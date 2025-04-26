using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using System;
using System.Collections.Generic;

namespace CourseProject_ShowDesk.Scripts.Utilities.Validators
{
    public class PerformanceValidator
    {
        private readonly List<Performance> performances;
        public PerformanceValidator(List<Performance> performances)
        {
            this.performances = performances;
        }
        public bool Validate(Performance performance, out string errorMessage)
        {
            if (!ValidateName(performance.Name, out errorMessage))
                return false;

            if (!ValidatePrice(performance.Price, out errorMessage))
                return false;

            if (!ValidateDate(performance.LocalPerformanceDateTime, out errorMessage))
                return false;

            if (!ValidatePerformanceIntersection(performance, out errorMessage))
                return false;

            errorMessage = null;
            return true;
        }

        private bool ValidateName(string name, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 3)
            {
                errorMessage = "Name must be at least 3 characters long.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        private bool ValidatePrice(double price, out string errorMessage)
        {
            if (price <= 0 || double.IsNaN(price))
            {
                errorMessage = "Base price must be positive.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        private bool ValidateDate(DateTime dateTime, out string errorMessage)
        {
            if (dateTime < DateTime.Now)
            {
                errorMessage = "Performance date can't be in the past.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        private bool ValidatePerformanceIntersection(Performance perf, out string errorMessage)
        {
            string intersectsPerformanceName = FindIntersectionPerformance(perf);
            if (intersectsPerformanceName != null)
            {
                errorMessage = $"The screening of the current performance is interspersed with the screening of the {intersectsPerformanceName} performance.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        private string FindIntersectionPerformance(Performance newPerformance)
        {
            foreach (var performance in performances)
            {
                if (performance.StageId == newPerformance.StageId)
                {
                    if ((newPerformance.LocalPerformanceDateTime - performance.LocalPerformanceDateTime).Days < 1 && performance.Id != newPerformance.Id)
                    {
                        if (IsIntersectionOfPerformances(newPerformance, performance))
                        {
                            return performance.Name;
                        }
                    }
                }
            }
            return null;
        }

        private bool IsIntersectionOfPerformances(Performance newPerformance, Performance performance)
        {
            double currentTimeDifference;
            double minTimeDifference;

            if (newPerformance.LocalPerformanceDateTime > performance.LocalPerformanceDateTime)
            {
                currentTimeDifference = (newPerformance.LocalPerformanceDateTime - performance.LocalPerformanceDateTime).TotalMinutes;
                minTimeDifference = performance.Duration.TotalMinutes + AppConstants.MinBreakBetweenPerformance.TotalMinutes;
            }
            else
            {
                currentTimeDifference = (performance.LocalPerformanceDateTime - newPerformance.LocalPerformanceDateTime).TotalMinutes;
                minTimeDifference = newPerformance.Duration.TotalMinutes + AppConstants.MinBreakBetweenPerformance.TotalMinutes;
            }

            return currentTimeDifference < minTimeDifference;
        }
    }

}
