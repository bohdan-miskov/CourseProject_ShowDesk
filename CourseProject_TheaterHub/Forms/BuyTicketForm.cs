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
                buttonGetPrice.Enabled = false;
                buttonAdd.Enabled = false;
            }
            else
            {
                comboBoxPositions.SelectedIndex = 0;
            }
        }

        private bool PriceValidator(string increase)
        {
            double currentPrice;

            if (increase.Length == 0)
            {
                return false;
            }

            try
            {
                currentPrice = Convert.ToDouble(increase);
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }

            if (currentPrice < 0)
            {
                return false;
            }

            return true;
        }

        private Ticket RecalculatePrice()
        {
            double increase = 0;

            foreach (Stage stage in stages)
            {
                if (stage.Index == performance.StageIndex)
                {
                    int position = Convert.ToInt32(comboBoxPositions.SelectedItem.ToString());
                    foreach (Zone zone in stage.Zones)
                    {
                        if ((zone.StartPosition <= position) && (zone.EndPosition >= position))
                        {
                            increase = zone.Increase;
                        }
                    }
                }
            }

            if (comboBoxTicketType.SelectedIndex == 0)
            {

                Ticket ticket = new Ticket(index,
                    Convert.ToInt32(comboBoxPositions.SelectedItem.ToString()),
                    0,
                    checkBoxReserved.Checked);
                ticket.CalculatePrice(performance.Price, increase);
                return ticket;
            }
            return null;
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
            Ticket ticket = RecalculatePrice();
            if (ticket == null)
            {
                textBoxPrice.Text = "Not all fields are populated";
            }
            else
            {
                textBoxPrice.Text = Convert.ToString(ticket.CalculatedPrice);
            }

            isValid = true;
            newTicket = ticket;

            this.Close();
        }

        private void buttonGetPrice_Click(object sender, EventArgs e)
        {
            Ticket ticket = RecalculatePrice();
            if (ticket == null)
            {
                textBoxPrice.Text = "Not all fields are populated";
            }
            else
            {
                textBoxPrice.Text = Convert.ToString(ticket.CalculatedPrice);
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

    }
}
