using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product Review Management");
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=2,Review="Good",isLike=false},
                new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=3,UserID=2,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=2,Rating=6,Review="Good",isLike=false},
                new ProductReview(){ProductID=5,UserID=3,Rating=2,Review="nice",isLike=true},
                new ProductReview(){ProductID=6,UserID=3,Rating=1,Review="bad",isLike=true},
                new ProductReview(){ProductID=7,UserID=5,Rating=1,Review="Good",isLike=false},
                new ProductReview(){ProductID=8,UserID=5,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=9,UserID=8,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=10,UserID=8,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=11,UserID=10,Rating=5,Review="nice",isLike=true},
                new ProductReview(){ProductID=12,UserID=12,Rating=6,Review="nice",isLike=true},
                new ProductReview(){ProductID=13,UserID=12,Rating=7,Review="nice",isLike=true},
                new ProductReview(){ProductID=14,UserID=14,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=15,UserID=14,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=16,UserID=18,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=17,UserID=18,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=18,UserID=19,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=18,UserID=20,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=20,UserID=25,Rating=7,Review="nice",isLike=true},
                new ProductReview(){ProductID=21,UserID=20,Rating=7,Review="nice",isLike=true},
                new ProductReview(){ProductID=22,UserID=25,Rating=10,Review="nice",isLike=true},
                new ProductReview(){ProductID=23,UserID=20,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=25,UserID=25,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=25,UserID=20,Rating=6,Review="nice",isLike=true},
                new ProductReview(){ProductID=17,UserID=18,Rating=11,Review="nice",isLike=true},
            };
            //UC1
            //foreach (var list in productReviewList)
            //{
            //    Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating
            //        + " Review : " + list.Review + " isLike : " + list.isLike);
            //}
            //Console.ReadKey();
            
            Management management = new Management();
            //UC2
            //management.TopRecords(productReviewList);
            //UC3
            //management.SelectedRecord(productReviewList);
            //UC4
            //management.RetrieveCountOfRecords(productReviewList);
            //UC5
            //management.RetrieveProductIdAndReview(productReviewList);
            //UC 6
            //management.SkipFiveRecord(productReviewList);
            //UC 9
            ProductReviewDataTable productReviewDataTable = new ProductReviewDataTable();
            DataTable table = productReviewDataTable.AddToDatatable();
            //pdt.DisplayProductReview(table);
            //UC10
            //productReviewDataTable.AverageOfProductRatings();
            //UC11
            //productReviewDataTable.FetchNiceWord(table);
            //UC12
            productReviewDataTable.FetchUserTen(table);

        }
    }
}
