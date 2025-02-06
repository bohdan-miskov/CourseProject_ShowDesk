using CourseProject_ShowDesk.FactoryMethod;
using CourseProject_ShowDesk.Scripts;
using CourseProject_ShowDesk.Scripts.Enities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject_ShowDesk
{
    public partial class BuyTicketForm : MetroFramework.Forms.MetroForm
    {
        private Stage stage;

        private Performance performance;

        private int index;

        private bool isValid;

        private StandardTicket ticket;
        private StandardTicket newTicket;

        private int formHeight;

        private Control selectedControl;
        private List<Control> selectedControls = new List<Control>();
        private List<Seat> seatList = new List<Seat>();
        private List<StandardTicket> newTickets = new List<StandardTicket>();


        public BuyTicketForm(Stage stage, Performance performance)
        {
            InitializeComponent();

            this.stage = stage;
            this.performance = performance;

            labelCurrency.Text = AppConstants.CurrencySymbol.ToString();

            CreateTicketIndex();

            textBoxIndex.Text = Convert.ToString(index);

            PopulateComboBoxTicketType();
            PopulateComboBoxPositions();
            PopulateSeating();

            seatList = stage.SeatList;

            isValid = false;

            this.Height = 355;
            groupBoxTicket.Height = 288;
        }

        private void textBoxIndex_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBoxTicketType.Focus();
            }
        }

        private void comboBoxTicketType_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBoxPositions.Focus();
            }
        }

        private void comboBoxPositions_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkBoxReserved.Focus();
            }
        }

        private void checkBoxReserved_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPrice.Focus();
            }
        }

        private void textBoxPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd.Focus();
            }
        }

        private void comboBoxTicketType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTicketInfo();
            ticket = CreateTicket();
            GetTicketPrice();
        }

        private void comboBoxPositions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ticket = CreateTicket();
            GetTicketPrice();
        }

        private void timerScaleUp_Tick(object sender, EventArgs e)
        {
            SlowlyScaleUp();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            isValid = true;
            newTicket = ticket;

            CloseSoldPositions();

            this.Close();
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

        private void PopulateComboBoxPositions()
        {
            comboBoxPositions.Items.Clear();

            List<int> positions = GetAllPositions();

            positions = ToFindFreePositions(positions);


            foreach (int position in positions)
            {
                comboBoxPositions.Items.Add(Convert.ToString(position));
            }

            if (positions.Count == 0)
            {
                comboBoxPositions.Enabled = false;
                buttonAdd.Enabled = false;
                MessageBox.Show(
                    "All tickets are sold out",
                    "Not available",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                comboBoxPositions.SelectedIndex = 0;
            }
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
                panelSeating.Controls.Add(seat.ToLabel());
            }
            foreach (DecorativeElement decor in stage.DecorList)
            {
                panelSeating.Controls.Add(decor.ToPanel());
            }
        }

        private List<int> GetAllPositions()
        {
            List<int> positions = stage.GetPositions();

            return positions;
        }

        private List<int> ToFindFreePositions(List<int> positions)
        {
            for (int i = 0; i < positions.Count; i++)
            {
                foreach (StandardTicket ticket in performance.Tickets)
                {
                    if (positions[i] == ticket.Position)
                    {
                        positions.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }
            return positions;
        }

        private StandardTicket CreateTicket()
        {
            if (comboBoxPositions.SelectedIndex != -1 && comboBoxTicketType.SelectedIndex != -1)
            {
                int position = Convert.ToInt32(comboBoxPositions.SelectedItem.ToString());
                bool reserved = checkBoxReserved.Checked; ;

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
                return ticket = new CreateStandardTicket().CreateTicket();
            }
            else if (comboBoxTicketType.SelectedIndex == 1)
            {
                string drink = comboBoxDrink.SelectedItem.ToString();
                return ticket = new CreateStandardPlusTicket(drink).CreateTicket();
            }
            else
            {
                string drink = comboBoxDrink.SelectedItem.ToString();
                string souvenir = comboBoxSouvenir.SelectedItem.ToString();
                return ticket = new CreatePremiumTicket(drink, souvenir).CreateTicket();
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

        private void panelSeating_MouseDown(object sender, MouseEventArgs e)
        {
            SeatingMouseDown(sender, e);
        }

        private void SeatingMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selectedControl = null;

                foreach (Control control in panelSeating.Controls)
                {
                    if (control.Bounds.Contains(e.Location) && control is Label && isAvailable(GetCurrentSeatIndex(control)))
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
                        comboBoxPositions.SelectedItem = selectedControl.Text;
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
                            control.BackColor = seatList[seatIndex].CurrentZone.Color;
                            newTickets.Remove(CreateTicket());
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
                    comboBoxPositions.SelectedItem = selectedControl.Text;
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

            if (control is Label label)
            {
                bool isInteger = int.TryParse(control.Text, out int result);

                if (isInteger)
                {
                    return result - 1;
                }
            }

            return -1;

        }

        private bool isAvailable(int index)
        {
            if (seatList[index].IsAvailable)
            {
                return true;
            }

            return false;
        }

    }
    

}

