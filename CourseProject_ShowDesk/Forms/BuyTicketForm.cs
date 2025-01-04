using CourseProject_ShowDesk.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseProject_ShowDesk
{
    public partial class BuyTicketForm : MetroFramework.Forms.MetroForm
    {

        private List<Stage> stages;

        private Performance performance;

        private int index;

        private bool isValid;

        private StandardTicket ticket;
        private StandardTicket newTicket;

        private int formHeight;

        public BuyTicketForm(List<Stage> stages, Performance performance)
        {
            InitializeComponent();

            this.stages = stages;
            this.performance = performance;

            CreateTicketIndex();

            textBoxIndex.Text = Convert.ToString(index);

            PopulateComboBox();


            isValid = false;

            this.Height = 355;
            groupBoxTicket.Height = 288;
        }

        private void CreateTicketIndex()
        {
            Random rnd = new Random();
            index = Convert.ToInt32(DateTime.Now.Second);
            index = Convert.ToInt32(index * rnd.Next(30, 100));
        }

        private void PopulateComboBox()
        {
            comboBoxTicketType.SelectedIndex = 0;
            comboBoxDrink.SelectedIndex = 0;
            comboBoxSouvenir.SelectedIndex = 0;

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
                MessageBox.Show(this,
                    "All tickets are sold out",
                    "Not available",
                    MessageBoxButtons.OK);
            }
            else
            {
                comboBoxPositions.SelectedIndex = 0;
            }
        }

        private List<int> GetAllPositions()
        {
            List<int> positions = new List<int>();
            foreach (Stage stage in stages)
            {
                if (stage.Index == performance.StageIndex)
                {
                    positions = stage.GetPositions();
                    break;
                }
            }
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
            foreach (Stage stage in stages)
            {
                if (stage.Index == performance.StageIndex)
                {
                    foreach (Zone zone in stage.Zones)
                    {
                        if ((zone.StartPosition <= position) && (zone.EndPosition >= position))
                        {
                            return zone.Increase;
                        }
                    }
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
            }
            else if (comboBoxTicketType.SelectedIndex == 2)
            {
                labelInfo.Text = "Standard Plus +" +
                    "A souvenir from the theater +" +
                    "Backstage access";
                formHeight = 505;
                timerScaleUp.Enabled = true;
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            isValid = true;
            newTicket = ticket;

            this.Close();
        }

        private void GetTicketPrice()
        {
            ticket = CreateTicket();
            if (ticket == null)
            {
                textBoxPrice.Text = "Not all fields are populated";
                buttonAdd.Enabled = false;
            }
            else
            {
                textBoxPrice.Text = Convert.ToString(ticket.CalculatedPrice);
                buttonAdd.Enabled = true;
            }
        }

        public bool GetIsValid()
        {
            return isValid;
        }

        public StandardTicket GetNewTicket()
        {
            return newTicket;
        }

        private void comboBoxTicketType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTicketInfo();
            GetTicketPrice();
        }

        private void comboBoxPositions_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTicketPrice();
        }

        private void timerScaleUp_Tick(object sender, EventArgs e)
        {
            SlowlyScaleUp();
        }
    }
}
