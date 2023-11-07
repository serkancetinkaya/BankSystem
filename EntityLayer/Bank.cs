using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer
{
    public class Bank
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int customerId { get; set; }
        [StringLength(50)]
        public string name { get; set; }
        [StringLength(11)]
        public string identityNumber { get; set; }
        [StringLength(10)]
        public string phoneNumber { get; set; }
    }
}