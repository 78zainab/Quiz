using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorApp1Web.data.ReadWrite
{
    public class ReadWrite
    {
        private readonly HttpClient _httpClient;
        private readonly string _questionsFilePath;

        public ReadWrite(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _questionsFilePath = "wwwroot/questions.json"; // Accessing via symlink
        }

        // Asynchronous method to load questions from questions.json
        public async Task<List<Question>> LoadQuestionsAsync()
        {
            var json = await _httpClient.GetStringAsync(_questionsFilePath);
            return JsonConvert.DeserializeObject<List<Question>>(json);
        }
    }
}
