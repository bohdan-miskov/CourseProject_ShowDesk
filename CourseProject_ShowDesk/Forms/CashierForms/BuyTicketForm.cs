using CourseProject_ShowDesk.Scripts;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket.FactoryMethodTicket;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities;
using CourseProject_ShowDesk.Scripts.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.CashierForms
{
    public partial class BuyTicketForm : MetroFramework.Forms.MetroForm
    {
        private readonly Stage stage;

        private Performance performance;

        private int index;

        private bool isValid;

        //private StandardTicket ticket;
        //private StandardTicket newTicket;

        private int formHeight;

        private Control selectedControl;
        private List<Control> selectedControls;
        private readonly List<Seat> seatList;
        private List<StandardTicket> newTickets;
        private readonly PerformanceBaseService dataBase;

        private int currentPosition=-1;


        public BuyTicketForm(Stage stage, Performance performance)
        {
            InitializeComponent();

            this.stage = stage;
            this.performance = performance;
            this.selectedControls = new List<Control>();
            this.newTickets = new List<StandardTicket>();
            this.dataBase = new PerformanceBaseService();

            labelCurrency.Text = AppConstants.CurrencySymbol.ToString();

            CreateTicketIndex();

            textBoxIndex.Text = Convert.ToString(index);

            PopulateComboBoxTicketType();
            //PopulateComboBoxPositions();
            PopulateSeating();

            seatList = stage.SeatList;

            isValid = false;

            this.Height = 355;
            groupBoxTicket.Height = 288;
        }

        private void TextBoxIndex_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBoxTicketType.Focus();
            }
        }

        private void ComboBoxTicketType_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //comboBoxPositions.Focus();
                checkBoxReserved.Focus();
            }
        }

        //private void ComboBoxPositions_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        checkBoxReserved.Focus();
        //    }
        //}

        private void CheckBoxReserved_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPrice.Focus();
            }
        }

        private void TextBoxPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd.Focus();
            }
        }

        private void ComboBoxTicketType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTicketInfo();
            UpdateLastTicket();
            GetTicketPrice();
         }

        //private void ComboBoxPositions_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ticket = CreateTicket();
        //    GetTicketPrice();
        //}
        private void PanelSeating_MouseDown(object sender, MouseEventArgs e)
        {
            SeatingMouseDown(sender, e);
        }

        private void TimerScaleUp_Tick(object sender, EventArgs e)
        {
            SlowlyScaleUp();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            isValid = true;
            //newTicket = ticket;
            List<int> canceledPosition = CheckPositions();
            if (canceledPosition.Count != 0)
            {
                MessageBox.Show(
                     $"Sorry, follow positions sold: {string.Join(", ", canceledPosition)}",
                     "Not available",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                UpdateAllTicketsInformation();
            }
            else
            {

            CloseSoldPositions();

            this.Close();
            }
        }
        private void UpdateAllTicketsInformation()
        {
            Performance newPerformance = dataBase.GetUpdatedPerformance(performance);
            if (newPerformance != performance)
            {
                performance = newPerformance;
                //PopulateComboBoxPositions();
                PopulateSeating();
            }
        }
        private void UpdateLastTicket()
        {
            if (newTickets.Count > 0)
            {
                newTickets[newTickets.Count-1]=CreateTicket();
            }
        }
        private void CreateTicketIndex()
        {
            Random rnd = new Random();
            index = Convert.ToInt32(DateTime.Now.Second);
            index = Convert.ToInt32(index * rnd.Next(30, 100));
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
            }
            else
            {
                comboBoxTicketType.SelectedIndex = 0;
            }
        }

        //private void PopulateComboBoxPositions()
        //{
        //    comboBoxPositions.Items.Clear();

        //    List<int> positions = GetAllPositions();

        //    positions = ToFindFreePositions(positions);


        //    foreach (int position in positions)
        //    {
        //        comboBoxPositions.Items.Add(Convert.ToString(position));
        //    }

        //    if (positions.Count == 0)
        //    {
        //        comboBoxPositions.Enabled = false;
        //        buttonAdd.Enabled = false;
        //        MessageBox.Show(
        //            "All tickets are sold out",
        //            "Not available",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        comboBoxPositions.SelectedIndex = 0;
        //    }
        //}

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
            }
            else
            {
                comboBoxDrink.SelectedIndex = 0;
            }
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
            }
            else
            {
                comboBoxSouvenir.SelectedIndex = 0;
            }
        }

        private void PopulateSeating()
        {
            foreach (Seat seat in stage.SeatList)
            {
                if (!performance.AvailablePositions.Contains(seat.SeatNumber))
                {
                    seat.IsAvailable = false;
                }
                panelSeating.Controls.Add(seat.ToLabel());
            }
            foreach (DecorativeElement decor in stage.DecorList)
            {
                panelSeating.Controls.Add(decor.ToPanel());
            }
        }

        //private List<int> GetAllPositions()
        //{
        //    return performance.AvailablePositions;
        //}

        //private List<int> ToFindFreePositions(List<int> positions)
        //{
        //    for (int i = 0; i < positions.Count; i++)
        //    {
        //        foreach (StandardTicket ticket in performance.Tickets)
        //        {
        //            if (positions[i] == ticket.Position)
        //            {
        //                positions.RemoveAt(i);
        //                i--;
        //                break;
        //            }
        //        }
        //    }
        //    return positions;
        //}

        private StandardTicket CreateTicket()
        {
            if (currentPosition!=-1 && comboBoxTicketType.SelectedIndex != -1)
            {
                int position = currentPosition;
                bool reserved = checkBoxReserved.Checked; 

                double increase = GetIncrease(position);

                StandardTicket ticket = GetTicketType();

                ticket.Index = index;
                ticket.Position = position;
                ticket.Reserved = reserved;

                ticket.CalculatePrice(performance.Price, increase);

                return ticket;
            }
            return null;
        }

        private double GetIncrease(int position)
        {

            foreach (Zone zone in stage.Zones)
            {
                if ((zone.StartPosition <= position) && (zone.EndPosition >= position))
                {
                    return zone.Increase;
                }
            }


            return 0;
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
                labelInfo.Text = "Only position";
                formHeight = 355;
                timerScaleUp.Enabled = true;
            }
            else if (comboBoxTicketType.SelectedIndex == 1)
            {
                labelInfo.Text = "Standard + Separate entrance +" +
                    "Drink of choice";
                formHeight = 424;
                timerScaleUp.Enabled = true;
                PopulateComboBoxDrink();
            }
            else if (comboBoxTicketType.SelectedIndex == 2)
            {
                labelInfo.Text = "Standard Plus +" +
                    "A souvenir from the event +" +
                    "Backstage access";
                formHeight = 505;
                timerScaleUp.Enabled = true;
                PopulateComboBoxDrink();
                PopulateComboBoxSouvenir();
            }
        }

        private void SlowlyScaleUp()
        {
            if (this.Height < formHeight && Math.Abs(this.Height - formHeight) > 3)
            {
                this.Height += 3;
                groupBoxTicket.Height += 3;
            }
            else if (this.Height > formHeight && Math.Abs(this.Height - formHeight) > 3)
            {
                this.Height -= 3;
                groupBoxTicket.Height -= 3;
            }
            else
            {
                timerScaleUp.Enabled = false;
            }
        }

        private void GetTicketPrice()
        {
            //if (newTickets == null)
            //{
            //    textBoxPrice.Text = "Not all fields are populated";
            //    buttonAdd.Enabled = false;
            //}
            //else
            //{
            //    double totalPrice = 0;
            //    foreach (StandardTicket ticket in newTickets)
            //    {
            //        totalPrice+=ticket.CalculatedPrice;
            //    }
            //    textBoxPrice.Text = Convert.ToString(totalPrice);
            //    buttonAdd.Enabled = true;
            //}
            double totalPrice = 0;
            foreach (StandardTicket ticket in newTickets)
            {
                totalPrice += ticket.CalculatedPrice;
            }
            textBoxPrice.Text = Convert.ToString(totalPrice);
            buttonAdd.Enabled = true;
        }

        private void CloseSoldPositions()
        {
            foreach(StandardTicket ticket in newTickets)
            {
                stage.SeatList[ticket.Position - 1].IsAvailable = false;
            }

        }

        public bool GetIsValid()
        {
            return isValid;
        }

        public List<StandardTicket> GetNewTickets()
        {
            return newTickets;
        }
        private void SeatingMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selectedControl = null;

                foreach (Control control in panelSeating.Controls)
                {
                    if (control.Bounds.Contains(e.Location) && control is Label && IsAvailable(GetCurrentSeatIndex(control)))
                    {
                        selectedControl = control;
                        break;
                    }
                }

                if(selectedControls.Count==0)
                {
                    newTickets = new List<StandardTicket>();
                    if(selectedControl!=null )
                    {
                        for (int i = 0; i < performance.AvailablePositions.Count; i++)
                        {
                            if (performance.AvailablePositions[i].ToString() == selectedControl.Text)
                            {
                               currentPosition = performance.AvailablePositions[i];
                                break;
                            }
                        }
                        newTickets.Add(CreateTicket());
                        GetTicketPrice();
                    }
                }

                if (ModifierKeys == Keys.Control)
                {
                    if (selectedControl != null && !selectedControls.Contains(selectedControl))
                    {
                        selectedControls.Add(selectedControl);
                        selectedControl.BackColor = Color.Yellow;
                        for(int i=0; i<performance.AvailablePositions.Count; i++)
                        {
                            if (performance.AvailablePositions[i].ToString() == selectedControl.Text)
                            {
                                currentPosition = performance.AvailablePositions[i];
                                break;
                            }
                        }
                        int seatIndex = GetCurrentSeatIndex(selectedControl);
                        labelSeatInfo.Text = seatList[seatIndex].GetInfo();
                        newTickets.Add(CreateTicket());
                        GetTicketPrice();
                    }
                }
                else
                {

                    foreach (Control control in selectedControls.OfType<Label>().ToList())
                    {

                        int seatIndex = GetCurrentSeatIndex(control);

                        if (seatIndex != -1)
                        {
                            control.BackColor = seatList[seatIndex].CurrentZone.GetColor();
                            foreach(StandardTicket removeTicket in newTickets)
                            {
                                if (removeTicket.Position == seatIndex)
                                {
                                    newTickets.Remove(removeTicket);
                                    break;
                                }
                            }
                            
                            GetTicketPrice();
                        }
                        else
                        {
                            control.BackColor = Color.LightGray;
                        }
                    }
                }

                selectedControls.Clear();

                if (selectedControl != null && selectedControl is Label)
                {
                    selectedControls.Add(selectedControl);
                    selectedControl.BackColor = Color.Yellow;
                    currentPosition = Convert.ToInt32(selectedControl.Text);
                    int seatIndex = GetCurrentSeatIndex(selectedControl);
                    labelSeatInfo.Text = seatList[seatIndex].GetInfo();
                    //newTickets = new List<StandardTicket>();
                    //newTickets.Add(CreateTicket());
                    //GetTicketPrice();
                }
            }
        }
        private int GetCurrentSeatIndex(Control control)
        {

            
                bool isInteger = int.TryParse(control.Text, out int result);

                if (isInteger)
                {
                    return result;
                }
            

            return -1;

        }

        private bool IsAvailable(int position)
        {
            if (performance.AvailablePositions.Contains(position))
            {
                return true;
            }

            return false;
        }

        private List<int> CheckPositions()
        {
            List<int> canceledPositions = new List<int>();
            foreach(StandardTicket ticket in newTickets)
            {
                if(!dataBase.IsPositionAvailable(performance.Id, ticket.Position))
                {
                    canceledPositions.Add(ticket.Position);
                }
            }

            return canceledPositions;
        }
    }
    

}

