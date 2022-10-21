using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MA_Delivery_Project.Models
{
   
    //public class OfferItem
    //{
    //    public int ID { get; set; }
    //    public int ItemIDRef { get; set; }
    //    public int OfferIDRef { get; set; }
    //}
    public class OfferrItems
    {
        [Key]
        [Display(Name = "ID")]

        [Column(TypeName = "int")]
        public int ID { set; get; }

        public int ItemIDef { set; get; }
        [ForeignKey("ItemIDef")]
        public Items? Items { get; set; }
        public int OfferIDRef { get; set; }
        [ForeignKey("OfferIDRef")]
        public Offers? Offers { get; set; }


    }

}
