﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PostId { get; set; }

        [ForeignKey(nameof(PostId))]
        public virtual Post Post { get; set; }
        [Required]
        public string Text { get; set; }
        public virtual List<Reply> Replies { get; set; }

        [Required]
        public Guid AuthorId { get; set; }

        [Required]
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Modified { get; set; }
    }
}
