using System;

using System.Windows.Media;
using TextileStore2.Models.Entities;

namespace TextileStore2.Models
{
    public class ProductModel
    {
        private static Color _color = new Color();

        public string ImagePath { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductManufacturer { get; set; }
        public  string Img { get; set; }
        public string ProductCost { get; set; }
        public string ProductStatus { get; set; }
        public string BackGround { get; set; }
        public string ProductArticul { get; set; }
        public string ProductUnit { get; set; }
        public string ProductCategory { get; set; }
        public string ProductProvider { get; set; }
        public byte? ProductDiscount { get; set; }
        public int? ProductMaxDiscount { get; set; }
        public int ProductQuantityInStock { get; set; }
        public static ProductModel ProductFromDB(ProductListForManagerAndClient context)
        {
            if (context.StatusValue.ToString() == "нет в наличии")
            {
                _color = Colors.LightGray;
            }
            else _color = Colors.White;

            return new ProductModel()
            {
                Img = string.IsNullOrWhiteSpace(context.ProductPhoto)
                ? "/bin/Debug/Images/picture.png" :
                "/bin/Debug/Images/" + context.ProductPhoto,
                ProductName = context.ProductName,
                ProductDescription = context.ProductDescription,
                ProductManufacturer = context.ManufacterValue,
                ProductCost = context.ProductCost.ToString(),
                ProductStatus = context.StatusValue.ToString(),
                BackGround = _color.ToString(),
                ProductArticul = context.ProductArticleNumber,
                ProductCategory = context.CategoryValue,
                ProductProvider = context.ProviderValue,
                ProductUnit = context.UnitValue,
                ProductDiscount = context.ProductDiscountAmount,
                ProductMaxDiscount = context.ProductMaxDiscountAmount,
                ProductQuantityInStock = context.ProductQuantityInStock,
                ImagePath = context.ProductPhoto
            };
        }    
    }
}
