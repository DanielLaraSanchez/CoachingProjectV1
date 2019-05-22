using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    class Score
    { 
    
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Player { get; set; }
        public int Points { get; set; }
    }
}
