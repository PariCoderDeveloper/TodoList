using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public record Todo
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
