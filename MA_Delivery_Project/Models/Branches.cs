using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MA_Delivery_Project.Models
{
    public class Branches
    {
        [Key]
        //[Key]
        [Display(Name = "ID")]
        //[Column (TypeName ="nvarchar(max)")]
        [Column(TypeName = "int")]
        public int ID { get; set; }
        [Display(Name = "Branch Code")]
        [Column(TypeName = "nvarchar(max)")]
        public string? BranchCode { get; set; } = "";
        [Display(Name = "Branch Name")]
        [Column(TypeName = "nvarchar(max)")]
        public string? BranchName { get; set; } = "";
        [Display(Name = "Branch Latittiude")]
        [Column(TypeName = "nvarrchar(max)")]
        public string? latitude { get; set; } = "";
        [Display(Name = "Branch LongTitude ")]
        [Column(TypeName = "nvarrchar(max)")]
        public string? longtitude { get; set; } = "";
        public int? OrgsSubID { get; set; }
        [ForeignKey("OrgsSubID")]
        public OrgsSub? orgsSub { get; set; }



    }
}
