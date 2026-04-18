using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishedYear { get; set; }
    }
}
