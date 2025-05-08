using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using System.Collections.Generic;

namespace CourseProject_ShowDesk.Scripts.Utilities.Validators
{
    public class StageValidator
    {
        private readonly List<Stage> stages;
        private readonly List<Performance> performances;

        public StageValidator(List<Stage> stages, List<Performance> performances=null)
        {
            this.stages = stages;
            this.performances = performances;
        }

        public bool Validate(Stage stage, out string errorMessage)
        {
            if (!ValidateStageName(stage.Name, out errorMessage))
                return false;
            if(IsNameRepeat(stage,out errorMessage))
                return false;
            if (isStageActive(stage, out errorMessage))
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
        private bool IsNameRepeat(Stage newStage, out string errorMessage)
        {
            foreach (Stage stage in stages)
            {
                if (stage.Name == newStage.Name && stage.Id!=newStage.Id)
                {
                    errorMessage = "There was an error in the name of the stage: the name cannot repeat";
                    return true;
                }
            }
            errorMessage = null;
            return false;
        }
        private bool isStageActive(Stage newStage, out string errorMessage)
        {
            errorMessage = null;
            if (performances == null) return false;

            foreach (Performance performance in performances)
            {
                if (performance.StageId == newStage.Id)
                {
                    errorMessage = "There was an error in the stage: If an upcoming performance is using this stage, its parameters cannot be changed.";
                    return true;
                }
            }

            return false;
        }
    }
}
