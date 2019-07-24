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
        public long Player1Id { get; set; }
        [Required]
        public long Player2Id { get; set; }
        public long WinnerId { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime CreationTimeStamp { get; }
        public long CreatorId { get; set; }
    }
}
