using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    class Management
    {
        public readonly DataTable dataTable = new DataTable();

        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              orderby productReviews.Rating descending
                              select productReviews).Take(3);
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating
                    + " Review : " + list.Review + " isLike : " + list.isLike);
            }
        }
        public void SelectedRecord(List<ProductReview> listProductReview)
        {
            var recordData = from ProductReview in listProductReview
                             where (ProductReview.ProductID == 1 || ProductReview.ProductID == 4 || ProductReview.ProductID == 9) && ProductReview.Rating > 3
                             select ProductReview;
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating
                    + " Review : " + list.Review + " isLike : " + list.isLike);
            }
        }
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordCount = listProductReview.GroupBy(x => x.ProductID)
                .Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var list in recordCount)
            {
                Console.WriteLine("Product id : " + list.ProductID + " Count " + list.Count);
            }
        }
        public void RetrieveProductIdAndReview(List<ProductReview> listProductReview)
        {
            var recordPidReview = from product in listProductReview select (product.ProductID, product.Review);
            foreach (var list in recordPidReview)
            {
                Console.WriteLine("Product id : " + list.ProductID + " Review : " + list.Review);
            }
        }
        public void SkipFiveRecord(List<ProductReview> listProductReview)
        {
            var records = (from product in listProductReview select product).Skip(5);
            foreach (var list in records)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating
                    + " Review : " + list.Review + " isLike : " + list.isLike);
            }
        }
    }
}
