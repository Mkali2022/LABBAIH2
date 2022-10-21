using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MA_Delivery_Project.Models
{

    public class SubCategory
    {
        [Key]
        [Display(Name = "ID")]

        [Column(TypeName = "int")]
        public int ID { set; get; }
        [Display(Name = "Code")]

        [Column(TypeName = "int")]

        public int? Code { set; get; }
        [Display(Name = "Name")]

        [Column(TypeName = "nvarchar(MAX)")]
        public string? SubCatName { set; get; }
        public int OrganizationRef { set; get; }
        [ForeignKey("OrganizationRef")]
        public Organizations? Organizations { get; set; }



    }
}
