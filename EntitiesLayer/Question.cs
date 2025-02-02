using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Question
    {
            public string? QuestionText { get; set; }
            public List<Options>? Options { get; set; }
    }
}
