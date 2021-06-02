using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class PostListItem
    {
        public int PostId { get; set; }
        public string Title { get; set; }

        public DateTimeOffset Created { get; set; }
    }
}
