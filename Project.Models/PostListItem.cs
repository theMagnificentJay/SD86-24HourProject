using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class PostListItem
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        [Display(Name="Created")]
        public DateTimeOffset Created { get; set; }
    }
}
