using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuizConsole.Models
{
    class SingleChoiceQuestion : IQuestion
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string[] Answer { get; set; }
    }
}
