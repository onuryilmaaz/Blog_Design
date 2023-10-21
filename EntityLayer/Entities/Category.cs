using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Category : EntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
