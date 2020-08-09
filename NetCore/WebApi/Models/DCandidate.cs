using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class DCandidate
    {
        [Key]
        public int id { get; set; }

        [Column("fullName", TypeName = "nvarchar(100)")]
        public string fullName{ get; set; }
        
        [Column("mobile", TypeName = "nvarchar(100)")]
        public string mobile { get; set; }
        
        [Column("email", TypeName = "nvarchar(100)")]
        public string email { get; set; }
        
        public int age{ get; set; }
        
        [Column("bloodGroup", TypeName = "nvarchar(100)")]
        public string bloodGroup { get; set; }
        
        [Column("address", TypeName = "nvarchar(100)")]
        public string address { get; set; }

    }
}
