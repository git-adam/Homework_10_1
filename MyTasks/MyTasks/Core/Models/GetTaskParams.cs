using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTasks.Core.Models
{
    public class GetTaskParams
    {
        public string UserId { get; set; }
        public bool IsExecuted { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
    }
}
