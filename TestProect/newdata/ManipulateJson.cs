namespace TestProect.newdata
{
    public class ManipulateJson
    {
        // Method to calculate the total weight
        public int CalculateTotalWeight(List<UserSelections> selections)
        {
            return selections.Sum(selection => selection.weight);
        }

        // Method to process and return the result
        public Result ProcessSelections(List<UserSelections> selections)
        {
            var result = new Result
            {
                Selections = selections,
                TotalWeight = CalculateTotalWeight(selections)
            };

            return result;
        }
    }
}
