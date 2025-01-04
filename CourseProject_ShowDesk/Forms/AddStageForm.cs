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

namespace CourseProject_ShowDesk
{
    public partial class AddStageForm : MetroFramework.Forms.MetroForm
    {
     

        private int index;

        private bool isValid;

        private Stage newStage;
        
        public AddStageForm(List<Stage> stages)
        {
            InitializeComponent();

            CreateIndex(stages);

            textBoxIndex.Text = Convert.ToString(index);

            isValid = false;
            newStage = new Stage();
        }

        private void CreateIndex(List<Stage> stages)
        {
            if (stages.Count == 0)
            {
                index = 1;
                return;
            }

            bool isRepeat;
            for (int i = 1; i < int.MaxValue; i++)
            {
                isRepeat = false;
                for (int j = 0; j < stages.Count; j++)
                {
                    if (i == stages[j].Index)
                    {
                        isRepeat = true;
                        break;
                    }
                }
                if (!isRepeat)
                {
                    index = i;
                    return;
                }
            }
        }

        private void textBoxIndex_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxStageName.Focus();
            }
        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd.Focus();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateOfStage())
            {
                isValid = true;

                AddStage();

                this.Close();
            }
        }

        private void AddStage()
        {
            string stageName = textBoxStageName.Text;

            newStage = new Stage(index, stageName);
        }

        private bool ValidateOfStage()
        {
            if (!ParametersValidator.NameValidator(textBoxStageName.Text))
            {
                MessageBox.Show(this,
                                "There was an error in the name of the stage: the name must be more than two characters long",
                                "Stage name error",
                                MessageBoxButtons.OK);
                textBoxStageName.Focus();
                return false;
            }
            return true;
        }

        public bool GetIsValid()
        {
            return isValid;
        }

        public Stage GetNewStage()
        {
            return newStage;
        }

    }
}
