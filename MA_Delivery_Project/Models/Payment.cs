using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MA_Delivery_Project.Models
{
    public class Payment
    {

        [Key]
        [Display(Name = "ID")]

        [Column(TypeName = "int")]
        public int ID { get; set; }
        [Display(Name = "Code")]

        [Column(TypeName = "int")]
        public int Code { get; set; }
        [Display(Name = "Payment Way")]

        [Column(TypeName = "nvarchar(MAX)")]
        public string? PaymentWay { get; set; }



    }
}
