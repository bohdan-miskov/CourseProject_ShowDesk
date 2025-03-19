using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;

namespace CourseProject_ShowDesk.Scripts.Utilities.Validators
{
    public class StageValidator
    {
        public bool Validate(Stage stage, out string errorMessage)
        {
            if (!ValidateStageName(stage.Name, out errorMessage))
                return false;

            return true;
        }
        private bool ValidateStageName(string name, out string errorMessage)
        {
            if (!ParametersValidator.NameValidator(name))
            {
                errorMessage = "There was an error in the name of the stage: the name must be more than two characters long.";
                return false;
            }

            errorMessage = null;
            return true;
        }
    }
}
