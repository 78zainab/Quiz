using BlazorAppQuiz.newdata;
using System.Collections.Generic;
using System.Linq;

namespace BlazorAppQuiz.newdata
{
    public class ManipulateJson
    {
        // Method to calculate the total weight for a specific category
        public int CalculateTotalWeightForCategory(List<UserSelections> selections, string categoryName)
        {
            return selections
                .Where(selection => selection.CategoryName == categoryName)
                .Sum(selection => selection.Weight);
        }

        // Method to process and return the result for each category separately
        public Dictionary<string, Result> ProcessSelectionsByCategory(List<UserSelections> selections)
        {
            // Group selections by category name
            var groupedByCategory = selections
                .GroupBy(selection => selection.CategoryName)
                .ToDictionary(
                    group => group.Key ?? "Unknown Category", // Handle null category names
                    group => new Result
                    {
                        Selections = group.ToList(),
                        TotalWeight = CalculateTotalWeightForCategory(selections, group.Key ?? "Unknown Category")
                    });

            return groupedByCategory; // Return results by category
        }
    }
}
