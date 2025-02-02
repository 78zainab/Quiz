using BlazorAppQuiz.newdata;

namespace BlazorAppQuiz.newdata
{
    public class Category
    {
        public string? CategoryName { get; set; }  
        public int ? CategoryId { get; set; }
        public List<Questions>? Questions { get; set; }
    }
}
