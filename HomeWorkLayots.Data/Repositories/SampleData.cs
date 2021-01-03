using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HomeWorkLayots.Data.Model;

namespace HomeWorkLayots.Data.Repositories
{ public static class SampleData
    {
        /// <param name="context"></param>
        public static void Initialize(StoreContext context)
        {
            if (!context.Products.Any())
            {
                var iphone = new Product
                {
                    ID = 1,
                    Name = "iPhone X",
                    Company = "Apple",
                    Price = 600
                };
                var huawei = new Product
                {
                    ID = 2,
                    Name = "Huawei P20 Lite",
                    Company = "Huawei ltd.",
                    Price = 200
                };
                context.Products.AddRange(
                    iphone,
                    huawei
                );
                context.SaveChanges();
            }

            if (!context.Categories.Any())
            {
                var phonesCategory = new Category
                {
                    ID = 1,
                    Name = "Mobile Phones"
                };
                var notebookCategory = new Category
                {
                    ID = 2,
                    Name = "Notebook"
                };
                var cameraCategory = new Category
                {
                    ID = 3,
                    Name = "Camera"
                };
                var headphonesCategory = new Category
                {
                    ID = 4,
                    Name = "Headphones"
                };
                context.Categories.AddRange(
                    phonesCategory,
                    notebookCategory, cameraCategory, headphonesCategory
                );
                context.SaveChanges();
            }

            if (!context.ProductsCategories.Any())
            {
                var iphoneSheaf = new CategoryProduct
                {
                    CategoryID = 1,
                    ProductID = 1
                };
                var huaweiSheaf = new CategoryProduct
                {
                    CategoryID = 1,
                    ProductID = 2
                };
                var iphoneNotebookSheaf = new CategoryProduct
                {
                    CategoryID = 2,
                    ProductID = 1
                };
                var huaweiNotebookSheaf = new CategoryProduct
                {
                    CategoryID = 2,
                    ProductID = 2
                };
                var iphoneCameraSheaf = new CategoryProduct
                {
                    CategoryID = 3,
                    ProductID = 1
                };
                var huaweiCameraSheaf = new CategoryProduct
                {
                    CategoryID = 3,
                    ProductID = 2
                };
                var iphoneHeadphoneSheaf = new CategoryProduct
                {
                    CategoryID = 4,
                    ProductID = 1
                };
                var huaweiHeadphoneSheaf = new CategoryProduct
                {
                    CategoryID = 4,
                    ProductID = 2
                };
                context.ProductsCategories.AddRange(
                    iphoneSheaf, huaweiSheaf, iphoneNotebookSheaf, huaweiNotebookSheaf, iphoneCameraSheaf, huaweiCameraSheaf, iphoneHeadphoneSheaf,huaweiHeadphoneSheaf
                );
                context.SaveChanges();
            }
        }
    }
}
