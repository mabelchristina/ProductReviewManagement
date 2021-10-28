using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReviewManagement
{
    class ProductReview
    {
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }

        public string toString()
        {
            return $"ProductID: - {ProductID}  UserID: - { UserID} Rating:- {Rating} Review:- { Review}  isLike:- { isLike}";
        }
    }
}
