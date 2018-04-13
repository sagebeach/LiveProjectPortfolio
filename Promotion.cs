using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueRibbonsReview.Models
{
    public class Promotion
    {
        public int PromotionId { get; set; }
        public int ItemCount { get; set; }
        public string UserId { get; set; }
        public int CampaignID { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Campaign Campaign { get; set; }
    }
}