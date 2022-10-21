﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MA_Delivery_Project.Models
{
     
    public class SubCategoryOrgsSub 
    {
        [Key]
        [Display(Name = "ID")]

        [Column(TypeName = "int")]
        public int ID { get; set; }


        public int OrgSubIDRef { get; set; }
        [ForeignKey("OrgSubIDRef")]
        public OrgsSub? OrgsSub { get; set; }

        public int SubCategoryID { get; set; }
        [ForeignKey("SubCategoryID")]
        public SubCategory? SubCategory { get; set; }

    }
}
