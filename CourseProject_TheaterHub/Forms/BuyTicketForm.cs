using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace CourseProject_TheaterHub
{
    public partial class BuyTicketForm : MetroFramework.Forms.MetroForm
    {

        private List<Stage> stages;

        private Performance performance;

        private int index;

        private bool isValid;

        private Ticket ticket;
        private Ticket newTicket;

       

        public BuyTicketForm(List<Stage> stages, Performance performance)
        {
            InitializeComponent();

            this.stages = stages;
            this.performance = performance;

            CreateTicketIndex();

            textBoxIndex.Text = Convert.ToString(index);

            PopulateComboBox();

            isValid = false;

        }

        private void CreateTicketIndex()
        {
            Random rnd = new Random();
            index = Convert.ToInt32(DateTime.Now.DayOfYear);
            index =  Convert.ToInt32( index * rnd.Next(30,100));
        }

        private void PopulateComboBox()
        {
            comboBoxTicketType.SelectedIndex = 0;

            List<int> positions = new List<int>();
            foreach (Stage stage in stages)
            {
                if (stage.Index == performance.StageIndex)
                {
                    positions = stage.GetPositions();
                    break;
                }
            }

            for (int i = 0; i < positions.Count; i++)
            {
                foreach (Ticket ticket in performance.Tickets)
                {
                    if (positions[i] == ticket.Position)
                    {
                        positions.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }

            foreach (int position in positions)
            {
                comboBoxPositions.Items.Add(Convert.ToString(position));
            }

            if (positions.Count == 0)
            {
                comboBoxPositions.Enabled = false;
                buttonAdd.Enabled = false;
            }
            else
            {
                comboBoxPositions.SelectedIndex = 0;
            }
        }

        private Ticket RecalculatePrice()
        {
            if (comboBoxPositions.SelectedIndex != -1 && comboBoxTicketType.SelectedIndex != -1)
            {
                double increase = 0;
                int position = Convert.ToInt32(comboBoxPositions.SelectedItem.ToString());
                bool reserved = checkBoxReserved.Checked; ;
                string type = comboBoxTicketType.SelectedItem.ToString();

                foreach (Stage stage in stages)
                {
                    if (stage.Index == performance.StageIndex)
                    {
                        foreach (Zone zone in stage.Zones)
                        {
                            if ((zone.StartPosition <= position) && (zone.EndPosition >= position))
                            {
                                increase = zone.Increase;
                            }
                        }
                    }
                }

                Ticket ticket = new Ticket(index, position, reserved, type);
                ticket.CalculatePrice(performance.Price, increase);

                return ticket;
            }
            return null;
        }

        private void ChangeTicketInfo()
        {
            if(comboBoxTicketType.SelectedIndex == 0)
            {
                labelInfo.Text = "Only position";
            }
            else if (comboBoxTicketType.SelectedIndex == 1)
            {
                labelInfo.Text = "Standard + Separate entrance +" +
                    "Drink of choice (Coffee or tea or juice)";
            }
            else if (comboBoxTicketType.SelectedIndex == 2)
            {
                labelInfo.Text = "Standard Plus +" +
                    "A souvenir from the theater +" +
                    "Backstage access";
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
            ticket = RecalculatePrice();
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

        public Ticket GetNewTicket()
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
    }
}
