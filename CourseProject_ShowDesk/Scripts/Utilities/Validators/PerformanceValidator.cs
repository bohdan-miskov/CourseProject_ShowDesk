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

            // Перевірка дати
            if (!ValidateDate(performance.PerformanceDateTime, out errorMessage))
                return false;

            // Перевірка на перетини
            if (!ValidatePerformanceIntersection(performance, out errorMessage))
                return false;

            errorMessage = null;
            return true;
        }

        // Перевірка імені
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

        // Перевірка ціни
        private bool ValidatePrice(double price, out string errorMessage)
        {
            if (price <= 0)
            {
                errorMessage = "Base price must be positive.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        // Перевірка дати
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

        // Перевірка перетину сеансів
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

        // Метод для пошуку перетину сеансів
        private string FindIntersectionPerformance(Performance newPerformance)
        {
            // Логіка для перевірки перетину сеансів, яка раніше була в методі
            // Примерний код для перевірки перетину, можливо, потрібно буде адаптувати під вашу ситуацію
            foreach (var performance in performances)
            {
                if (performance.StageId == newPerformance.StageId)
                {
                    if ((newPerformance.PerformanceDateTime - performance.PerformanceDateTime).Days < 1 && performance.Id != newPerformance.Id)
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

        // Метод для перевірки перетину між двома сеансами
        private bool IsIntersectionOfPerformances(Performance newPerformance, Performance performance)
        {
            double currentTimeDifference;
            double minTimeDifference;

            if (newPerformance.PerformanceDateTime > performance.PerformanceDateTime)
            {
                currentTimeDifference = (newPerformance.PerformanceDateTime - performance.PerformanceDateTime).TotalMinutes;
                minTimeDifference = performance.Duration.TotalMinutes + AppConstants.MinBreakBetweenPerformance.TotalMinutes;
            }
            else
            {
                currentTimeDifference = (performance.PerformanceDateTime - newPerformance.PerformanceDateTime).TotalMinutes;
                minTimeDifference = newPerformance.Duration.TotalMinutes + AppConstants.MinBreakBetweenPerformance.TotalMinutes;
            }

            return currentTimeDifference < minTimeDifference;
        }
    }

}
