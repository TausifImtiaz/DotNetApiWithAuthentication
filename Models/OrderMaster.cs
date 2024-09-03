using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DotNetApiWithAuthentication.Models
{
    public class OrderMaster
    {
        [Key]
        public int OrderId { get; set; }
        public string CustomerName { get; set; }    
        public string ImagePath { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }

        public virtual List<OrderDetail> OrderDetail { get; set; } = new List<OrderDetail>();
    }
}