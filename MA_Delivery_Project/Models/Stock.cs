using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MA_Delivery_Project.Models
{
   
        public class Stock //sub
        {
            [Key]
            [Display(Name = "ID")]

            [Column(TypeName = "int")]
            public int ID { get; set; }
        [Display(Name = "Code")]

        [Column(TypeName = "int")]
        public int StockCode { get; set; }
            [Display(Name = "Details")]

            [Column(TypeName = "nvarchar(MAX)")]
            public string? StockDetails { get; set; }


         public int IDRef { get; set; }
        [ForeignKey("IDRef")]
        public Items? Items { get; set; }

        [Display(Name = "Flag")]

        [Column(TypeName = "int")]
        public int? FlagVal { get; set; }

        
    }
}
