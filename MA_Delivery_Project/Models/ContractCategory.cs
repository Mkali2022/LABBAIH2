using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MA_Delivery_Project.Models
{
   
    public class ContractCategory
    {

        [Key]
        [Display(Name = "ID")]

        [Column(TypeName = "int")]
        public int ID { get; set; }
        [Display(Name = "Category")]

        [Column(TypeName = "nvarchar(max)")]
        public string ConractCategory { get; set; } = "";

    }
}
