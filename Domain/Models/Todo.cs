using Domain.Models.baseF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Todo : baseField
    {   
        public long ID { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateOnly date { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}
