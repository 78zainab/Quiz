namespace BlazorAppQuiz.newdata
{
    public class UserSelections
    {
        //public string? question { get; set; }
        //public string? selectedoption { get; set; }
        //public int weight { get; set; }
        public string? CategoryName { get; set; } // Track the category the question belongs to
        public string? Question { get; set; }
        public string? SelectedOption { get; set; }
        public int Weight { get; set; }
    }
}
