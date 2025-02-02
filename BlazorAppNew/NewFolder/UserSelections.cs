namespace BlazorAppNew.NewFolder
{
    public class UserSelections
    {
        public string? CategoryName { get; set; } // Track the category the question belongs to
        public string? Question { get; set; }
        public string? SelectedOption { get; set; }
        public int Weight { get; set; }
    }
}
