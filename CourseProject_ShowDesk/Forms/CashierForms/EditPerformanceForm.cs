//using CourseProject_ShowDesk.Scripts;
//using CourseProject_ShowDesk.Scripts.Enities;
//using CourseProject_ShowDesk.Scripts.Enities.StageManager;
//using System;
//using System.Collections.Generic;
//using System.Windows.Forms;

//namespace CourseProject_ShowDesk
//{
//    public partial class EditPerformanceForm : MetroFramework.Forms.MetroForm
//    {

//        private StageManager stageManager;

//        private bool isValid;

//        private int currentIndex;

//        private Performance performance;
//        private PerformanceManager performanceManager;

//        public EditPerformanceForm(StageManager stageManager, PerformanceManager performanceManager, int currentIndex)
//        {
//            InitializeComponent();
//            this.stageManager = stageManager;
//            this.performance = performances[currentIndex];
//            this.performanceManager= performanceManager;
//            this.currentIndex = currentIndex;

//            dateTimePickerPerfomanceDate.MinDate = DateTime.Now.Date;

//            labelCurrency.Text = AppConstants.CurrencySymbol.ToString();

//            PopulateFields();

//            isValid = false;
//        }
//        private void dateTimePickerPerfomanceDate_KeyUp(object sender, KeyEventArgs e)
//        {
//            if (e.KeyCode == Keys.Enter)
//            {
//                textBoxPerformanceName.Focus();
//            }
//        }
//        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
//        {
//            if (e.KeyCode == Keys.Enter)
//            {
//                textBoxBaseTicketPrice.Focus();
//            }
//        }
//        private void textBoxBaseTicketPrice_KeyUp(object sender, KeyEventArgs e)
//        {
//            if (e.KeyCode == Keys.Enter)
//            {
//                comboBoxStage.Focus();
//            }
//        }
//        private void comboBoxStage_KeyUp(object sender, KeyEventArgs e)
//        {
//            if (e.KeyCode == Keys.Enter)
//            {
//                buttonSave.Focus();
//            }
//        }
//        private void textBoxBaseTicketPrice_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            ParametersValidator.ValidatorDoubleDigit(sender, e);
//        }

//        private void buttonSave_Click(object sender, EventArgs e)
//        {
//            if (ValidateOfPerformance())
//            {
//                isValid = true;

//                SavePerformance();

//                this.Close();
//            }
//        }
       

//        //private void SetAvailable(int seatIndex)
//        //{
//        //    int stageIndex = comboBoxStage.SelectedIndex;
//        //    stages[stageIndex].SeatList[seatIndex].IsAvailable = true;
//        //}

       


//        private void SavePerformance()
//        {
//            performance.PerformanceDateTime = dateTimePickerPerfomanceDate.Value;
//            performance.Name = textBoxPerformanceName.Text;
//            performance.Price = Convert.ToDouble(textBoxBaseTicketPrice.Text);
//            performance.Duration = new TimeSpan(dateTimePickerDuration.Value.Hour, dateTimePickerDuration.Value.Minute, 0);

//            if (stages[comboBoxStage.SelectedIndex].Index != performance.StageIndex)
//            {
//                performance.StageIndex = stages[comboBoxStage.SelectedIndex].Index;
//                performance.RemoveAllTickets();
//            }
//        }

//        private bool ValidateOfPerformance()
//        {
//            if (!ValidateOfPerformanceName()) return false;
//            if (!ValidateOfPerformancePrice()) return false;
//            if (!ValidateOfPerformanceDate()) return false;
//            if (!ValidateOfPerformancesIntersects()) return false;
//            if (!ValidateOfStageEdit()) return false;

//            return true;
//        }

//        private bool ValidateOfPerformanceName()
//        {
//            if (!ParametersValidator.NameValidator(textBoxPerformanceName.Text))
//            {
//                MessageBox.Show(
//                                "There was an error in the name of the performance: the name should be more than two characters long",
//                                "Performance name error",
//                                MessageBoxButtons.OK,
//                                MessageBoxIcon.Error);
//                textBoxPerformanceName.Focus();
//                return false;
//            }

//            return true;
//        }

//        private bool ValidateOfPerformancePrice()
//        {
//            if (!ParametersValidator.DoubleValidator(textBoxBaseTicketPrice.Text))
//            {
//                MessageBox.Show(
//                                "The base price of the ticket must be entered in the format 0.000, cannot be negative or empty",
//                                "StandardTicket price error",
//                                MessageBoxButtons.OK,
//                                MessageBoxIcon.Error);
//                textBoxBaseTicketPrice.Focus();
//                return false;
//            }

//            return true;
//        }

//        private bool ValidateOfPerformanceDate()
//        {
//            if (dateTimePickerPerfomanceDate.Value < DateTime.Now)
//            {
//                MessageBox.Show(
//                                "Performance date and time cannot be in the past.",
//                                "Performance date error",
//                                MessageBoxButtons.OK,
//                                MessageBoxIcon.Error);
//                dateTimePickerPerfomanceDate.Focus();
//                return false;
//            }

//            return true;
//        }

//        private bool ValidateOfPerformancesIntersects()
//        {
//            string intersectsPerformanceName = performanceManager.FindIntersectionPerformance();
//            if (intersectsPerformanceName != null)
//            {
//                MessageBox.Show(
//                               $"The screening of the current performance is interspersed with the screening of the {intersectsPerformanceName} performance in {stages[comboBoxStage.SelectedIndex].Name}",
//                               "Performance error",
//                               MessageBoxButtons.OK,
//                               MessageBoxIcon.Error);
//                dateTimePickerPerfomanceDate.Focus();
//                return false;
//            }

//            return true;
//        }

//        private bool ValidateOfStageEdit()
//        {
//            if (stages[comboBoxStage.SelectedIndex].Index != performance.StageIndex)
//            {
//                DialogResult result =
//                    MessageBox.Show(
//                                "If you change the stage, all tickets will be cancelled.\n" +
//                                "Are you sure you want to do this?",
//                                "Stage warning!",
//                                MessageBoxButtons.YesNo,
//                                MessageBoxIcon.Warning);
//                if (result == DialogResult.No)
//                {
//                    comboBoxStage.SelectedIndex = FindInitialStageIndex();

//                    return false;
//                }
//            }

//            return true;
//        }
//        private int FindInitialStageIndex()
//        {
//            for (int i = 0; i < stages.Count; i++)
//            {
//                if (stages[i].Index == performance.StageIndex)
//                {
//                    return i;
//                }
//            }

//            return -1;
//        }
//        public bool GetIsValid()
//        {
//            return isValid;
//        }

//        public Performance GetPerformance()
//        {
//            return performance;
//        }
//    }
//}
