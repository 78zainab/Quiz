namespace BlazorAppNew.NewFolder
{
    public class Result
    {
        public List<UserSelections>? Selections { get; set; } // Stores the user selections
        public int TotalWeight { get; set; } // Overall total weight
        public Dictionary<string, int>? CategoryWeights { get; set; }
    }
}
