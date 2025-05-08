using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket.FactoryMethodTicket;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.CashierForms
{
    public partial class BuyTicketForm : MetroFramework.Forms.MetroForm
    {
        private Performance performance;

        private List<StandardTicket> newTickets;
        private readonly PerformanceBaseService dataBase;
        private readonly SelectionManager selectionManager;
        private readonly SeatingManager seatingManager;
        private readonly CanvasController canvasController;

        private bool isValid;
        private bool logOut;

        public BuyTicketForm(Employee userAccount, Stage stage, Performance performance)
        {
            InitializeComponent();
            FormConfigurator.ConfigureForm(this);

            this.MouseWheel += PanelSeating_MouseWheel;

            this.performance = performance;
            this.newTickets = new List<StandardTicket>();
            this.dataBase = new PerformanceBaseService();

            this.selectionManager = new SelectionManager();
            this.seatingManager = new SeatingManager(panelSeating, stage?.SeatList, stage?.DecorList);
            canvasController = new CanvasController(panelSeating, panelViewport, stage.StageLocation, stage.StageSize);
            labelAccountName.Text = userAccount.FullName;

            PopulateComponents();

            isValid = false;
            logOut = false;
        }

        private void TextBoxIndex_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) comboBoxTicketType.Focus();
        }

        private void ComboBoxTicketType_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) checkBoxReserved.Focus();
        }

        private void CheckBoxReserved_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxPrice.Focus();
        }

        private void TextBoxPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonAdd.Focus();
        }

        private void ComboBoxTicketType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTicketInfo();
            UpdateLastTicket();
            GetTicketPrice();
        }
        private void PanelSeating_MouseUp(object sender, MouseEventArgs e)
        {
            canvasController.StopPanning();
        }
        private void PanelSeating_MouseDown(object sender, MouseEventArgs e)
        {
            bool useControl = ModifierKeys == Keys.Control;
            canvasController.StartPanning(e, useControl);
            SeatingMouseDown(e);
        }
        private void PanelSeating_MouseMove(object sender, MouseEventArgs e)
        {
            canvasController.CanvasMove(e.Location);
        }
        private void PanelSeating_MouseWheel(object sender, MouseEventArgs e)
        {
            bool useControl = ModifierKeys == Keys.Control;
            canvasController.StartScaleCanvas(e, useControl);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            SaveTickets();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void PopulateComponents()
        {
            labelCurrency.Text = AppConstants.CurrencySymbol.ToString();

            PopulateComboBoxTicketType();

            seatingManager.PopulateSeating();
            PopulateSeating();
        }

        private void PopulateComboBoxTicketType()
        {
            comboBoxTicketType.Items.Clear();

            foreach (string type in AppConstants.ListOfTicketTypes)
            {
                comboBoxTicketType.Items.Add(type);
            }

            if (AppConstants.ListOfTicketTypes.Count == 0)
            {
                comboBoxTicketType.Enabled = false;
                buttonAdd.Enabled = false;
                MessageBox.Show(
                    "Tickets is not available",
                    "Not available",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            comboBoxTicketType.SelectedIndex = 0;
        }

        private void PopulateComboBoxDrink()
        {
            comboBoxDrink.Items.Clear();

            foreach (string drink in AppConstants.ListOfDrinks)
            {
                comboBoxDrink.Items.Add(drink);
            }

            if (AppConstants.ListOfDrinks.Count == 0)
            {
                comboBoxDrink.Enabled = false;
                MessageBox.Show(
                    "Drinks is not available",
                    "Not available",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            comboBoxDrink.SelectedIndex = 0;
        }

        private void PopulateComboBoxSouvenir()
        {
            comboBoxSouvenir.Items.Clear();

            foreach (string souvenir in AppConstants.ListOfSouvenirs)
            {
                comboBoxSouvenir.Items.Add(souvenir);
            }

            if (AppConstants.ListOfSouvenirs.Count == 0)
            {
                comboBoxSouvenir.Enabled = false;
                MessageBox.Show(
                    "Souvenirs is not available",
                    "Not available",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            comboBoxSouvenir.SelectedIndex = 0;
        }

        private void PopulateSeating()
        {
            foreach (Seat seat in seatingManager.SeatList)
            {
                if (!performance.AvailablePositions.Contains(seat.SeatNumber))
                {
                    seat.IsAvailable = false;
                }
                panelSeating.Controls.Add(seat.ToLabel());
            }
            foreach (DecorativeElement decor in seatingManager.DecorList)
            {
                panelSeating.Controls.Add(decor.ToPanel());
            }
        }

        private void UpdateAllTicketsInformation()
        {
            Performance newPerformance = dataBase.GetUpdatedPerformance(performance);
            if (newPerformance != performance)
            {
                performance = newPerformance;
                PopulateSeating();
            }
        }

        private void UpdateLastTicket()
        {
            if (newTickets.Count > 0)
            {
                int currentPosition = newTickets[newTickets.Count - 1].Position;
                newTickets[newTickets.Count - 1] = CreateTicket(currentPosition);
            }
        }

        private StandardTicket CreateTicket(int position)
        {
            if (position == -1 && comboBoxTicketType.SelectedIndex == -1) return null;

            bool reserved = checkBoxReserved.Checked;
            double increase = seatingManager.SeatList[position - 1].CurrentZone.Increase;

            StandardTicket ticket = GetTicketType();

            ticket.Position = position;
            ticket.Reserved = reserved;
            ticket.CalculatePrice(performance.Price, increase);
            textBoxId.Text = Convert.ToString(ticket.Id);

            return ticket;
        }

        private StandardTicket GetTicketType()
        {
            if (comboBoxTicketType.SelectedIndex == 0)
            {
                var newTicket = new CreateStandardTicket().CreateTicket();
                return newTicket;
            }
            else if (comboBoxTicketType.SelectedIndex == 1)
            {
                string drink = comboBoxDrink.SelectedItem.ToString();
                var newTicket = new CreateStandardPlusTicket(drink).CreateTicket();
                return newTicket;
            }
            else
            {
                string drink = comboBoxDrink.SelectedItem.ToString();
                string souvenir = comboBoxSouvenir.SelectedItem.ToString();
                var newTicket = new CreatePremiumTicket(drink, souvenir).CreateTicket();
                return newTicket;
            }
        }

        private void ChangeTicketInfo()
        {
            if (comboBoxTicketType.SelectedIndex == 0)
            {
                groupBoxStandardPlus.Visible = false;
                groupBoxPremium.Visible = false;
            }
            else if (comboBoxTicketType.SelectedIndex == 1)
            {
                groupBoxStandardPlus.Visible = true;
                groupBoxPremium.Visible = false;
                PopulateComboBoxDrink();
            }
            else if (comboBoxTicketType.SelectedIndex == 2)
            {
                groupBoxStandardPlus.Visible = true;
                groupBoxPremium.Visible = true;
                PopulateComboBoxDrink();
                PopulateComboBoxSouvenir();
            }
        }

        private void GetTicketPrice()
        {
            double totalPrice = 0;
            foreach (StandardTicket ticket in newTickets)
            {
                totalPrice += ticket.CalculatedPrice;
            }
            textBoxPrice.Text = Convert.ToString(totalPrice);
            buttonAdd.Enabled = true;
        }

        private void SeatingMouseDown(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            bool useControl = ModifierKeys == Keys.Control;
            canvasController.StartPanning(e, useControl);
            HandleSelection(e, useControl);
        }
        public void HandleSelection(MouseEventArgs e, bool useControl)
        {
            if (e.Button != MouseButtons.Left) return;

            Control selectedControl = GetSelectedControl(e.Location);
            if (selectedControl == null) return;

            if (useControl) HandleMultiSelection(selectedControl);
            else
            {
                ResetSelection();
                HandleSingleSelection(selectedControl);
            }
        }
        private Control GetSelectedControl(Point location)
        {
            foreach (Control control in panelSeating.Controls)
            {
                if (control.Bounds.Contains(location) &&
                    control is Label &&
                    performance.IsAvailable(seatingManager.GetCurrentSeatPosition(control)))
                {
                    return control;
                }
            }
            return null;
        }

        private void HandleSingleSelection(Control selectedControl)
        {
            newTickets = new List<StandardTicket>();

            if (selectedControl != null)
            {
                selectionManager.AddToSelection(selectedControl);
                int currentSeatPosition = seatingManager.GetCurrentSeatPosition(selectedControl);
                int currentSeatIndex = seatingManager.GetCurrentSeatIndex(selectedControl);
                labelSeatInfo.Text = seatingManager.SeatList[currentSeatIndex].GetInfo();
                newTickets.Add(CreateTicket(currentSeatPosition));
                GetTicketPrice();
            }
        }

        private void HandleMultiSelection(Control selectedControl)
        {
            if (selectedControl == null || selectionManager.SelectedControls.Contains(selectedControl))
                return;

            selectionManager.AddToSelection(selectedControl);

            int seatIndex = seatingManager.GetCurrentSeatIndex(selectedControl);
            labelSeatInfo.Text = seatingManager.SeatList[seatIndex].GetInfo();
            int seatPosition = seatingManager.GetCurrentSeatPosition(selectedControl);

            newTickets.Add(CreateTicket(seatPosition));
            GetTicketPrice();
        }

        private void ResetSelection()
        {
            for (int i = selectionManager.SelectedControls.Count - 1; i >= 0; i--)
            {
                Control control = selectionManager.SelectedControls[i];
                Color initColor = seatingManager.GetSeatColorByControl(control);
                selectionManager.RemoveSelection(control, initColor);
                RemoveTicket(seatingManager.GetCurrentSeatPosition(control));
            }

            GetTicketPrice();
        }

        private void RemoveTicket(int seatPosition)
        {
            foreach (StandardTicket removeTicket in newTickets.ToList())
            {
                if (removeTicket.Position == seatPosition)
                {
                    newTickets.Remove(removeTicket);
                    break;
                }
            }
        }

        private void SaveTickets()
        {
            List<int> canceledPosition = CheckPositions();
            if (canceledPosition.Count != 0)
            {
                MessageBox.Show(
                     $"Sorry, follow positions sold: {string.Join(", ", canceledPosition)}",
                     "Not available",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                UpdateAllTicketsInformation();

                return;
            }

            isValid = true;

            this.Close();
        }

        private List<int> CheckPositions()
        {
            List<int> canceledPositions = new List<int>();
            foreach (StandardTicket ticket in newTickets)
            {
                if (!dataBase.IsPositionAvailable(performance.Id, ticket.Position))
                {
                    canceledPositions.Add(ticket.Position);
                }
            }
            return canceledPositions;
        }

        private void LogOut()
        {
            logOut = true;
            this.Close();
        }

        public bool GetLogOut()
        {
            return logOut;
        }

        public bool GetIsValid()
        {
            return isValid;
        }

        public List<StandardTicket> GetNewTickets()
        {
            return newTickets;
        }
    }
}

