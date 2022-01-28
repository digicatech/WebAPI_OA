using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WabAPI_Domain.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
