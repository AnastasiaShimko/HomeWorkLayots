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
            var iphone = new Product
            {
                Name = "iPhone X",
                Company = "Apple",
                Price = 600
            };
            var huawei = new Product
            {
                Name = "Huawei P20 Lite",
                Company = "Huawei ltd.",
                Price = 200
            };
            var asus = new Product
            {
                Name = "Asus Zenbook",
                Company = "Asus",
                Price = 2600
            };
            var acer = new Product
            {
                Name = "Acer i7",
                Company = "Acer",
                Price = 1200
            };
            var nokia = new Product
            {
                Name = "Nokia Ftr",
                Company = "Nokia",
                Price = 5600
            };
            var sony = new Product
            {
                Name = "Sony Video",
                Company = "Sony",
                Price = 1200
            };
            context.Products.AddRange(iphone, huawei, acer, asus, nokia, sony);
            context.SaveChanges();

            var phonesCategory = new Category
            {
                ID = 1,
                Name = "Mobile Phones"
            };
            phonesCategory.Products.Add(iphone);
            phonesCategory.Products.Add(huawei);
            var notebookCategory = new Category
            {
                ID = 2,
                Name = "Notebook"
            };
            notebookCategory.Products.Add(asus);
            notebookCategory.Products.Add(acer);
            var cameraCategory = new Category
            {
                ID = 3,
                Name = "Camera"
            };
            cameraCategory.Products.Add(nokia);
            cameraCategory.Products.Add(sony);
            var headphonesCategory = new Category
            {
                ID = 4,
                Name = "Headphones"
            };
            context.Categories.AddRange( phonesCategory, notebookCategory, cameraCategory, headphonesCategory);
            headphonesCategory.Products.Add(nokia);
            headphonesCategory.Products.Add(huawei);

            context.SaveChanges();
        }
    }
}
