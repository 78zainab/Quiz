namespace BlazorAppQuiz.newdata
{
    public class Result
    {
        public List<CategoriesRoot>? CategoryName {  get; set; } 
        public List<UserSelections>? Selections { get; set; } 
        public int TotalWeight { get; set; } 
        public Dictionary<string, int>? CategoryWeights { get; set; }
        public int GrandTotalWeight { get; set; }

    }
}
