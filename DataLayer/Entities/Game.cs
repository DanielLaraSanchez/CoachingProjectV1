using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities
{
   public class Game
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long GameId { get; set; }
        [Required]
        public virtual Player Player1 { get; set; }
        [Required]
        public virtual Player Player2 { get; set; }
        public virtual Player Winner { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime CreationTimeStamp { get; }
        public Player Creator { get; set; }
    }
}
