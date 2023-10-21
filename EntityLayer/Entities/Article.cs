using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EntityLayer.Entities
{
    public class Article : EntityBase
    {
        
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid ImageId { get; set; }
        public Image Image { get; set; }
        
    }
}
