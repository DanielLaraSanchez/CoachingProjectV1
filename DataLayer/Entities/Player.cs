using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities
{
    public  class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        [Required]
        public string EmailAddress { get; set; }
        [MaxLength(100)]
        [Required]
        public string Password { get; set; }
    }
}
