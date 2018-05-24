using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuizConsole.Models
{
    public interface IQuestion
    {
        int Id { get; set; }
        string Description { get; set; }
        string[] Answer { get; set; }
    }
}
