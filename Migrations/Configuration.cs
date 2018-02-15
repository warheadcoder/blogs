namespace LoadMoreMVCSample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LoadMoreMVCSample.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LoadMoreMVCSample.Models.ApplicationDbContext context)
        {
            context.Products.AddOrUpdate(
            new Models.Product
            {
                ProductDate = DateTime.Now,
                ProductDescription = "Super extra so very nice bike!",
                ProductName = "Bike",
                ProductPicture = "/Content/SampleImage.jpg",
                ProductPrice = 106
            },
            new Models.Product
            {
                ProductDate = DateTime.Now,
                ProductDescription = "A purse for use in amazon jungles.",
                ProductName = "Purse",
                ProductPicture = "/Content/SampleImage.jpg",
                ProductPrice = 26
            },
            new Models.Product
            {
                ProductDate = DateTime.Now,
                ProductDescription = "Make a homeless person happy.",
                ProductName = "Sleeping Bag",
                ProductPicture = "/Content/SampleImage.jpg",
                ProductPrice = 80
            },
            new Models.Product
            {
                ProductDate = DateTime.Now,
                ProductDescription = "You can't know what something is until you buy it, try it, trust me!",
                ProductName = "Something",
                ProductPicture = "/Content/SampleImage.jpg",
                ProductPrice = 800
            },
            new Models.Product
            {
                ProductDate = DateTime.Now,
                ProductDescription = "Vintage alcohol form 1912.",
                ProductName = "Alcohol",
                ProductPicture = "/Content/SampleImage.jpg",
                ProductPrice = 100005
            },
            new Models.Product
            {
                ProductDate = DateTime.Now,
                ProductDescription = "It come with cheap useless wig.",
                ProductName = "HairPin",
                ProductPicture = "/Content/SampleImage.jpg",
                ProductPrice = 1055
            },
            new Models.Product
            {
                ProductDate = DateTime.Now,
                ProductDescription = "ran out of wisecrack, sample description.",
                ProductName = "Lg Phone",
                ProductPicture = "/Content/SampleImage.jpg",
                ProductPrice = 45
            },
            new Models.Product
            {
                ProductDate = DateTime.Now,
                ProductDescription = "ran out of wisecrack, sample description.",
                ProductName = "Samsung Phone",
                ProductPicture = "/Content/SampleImage.jpg",
                ProductPrice = 44
            },
            new Models.Product
            {
                ProductDate = DateTime.Now,
                ProductDescription = "ran out of wisecrack, sample description.",
                ProductName = "Used car",
                ProductPicture = "/Content/SampleImage.jpg",
                ProductPrice = 4
            },
            new Models.Product
            {
                ProductDate = DateTime.Now,
                ProductDescription = "ran out of wisecrack, sample description.",
                ProductName = "Water Bottle",
                ProductPicture = "/Content/SampleImage.jpg",
                ProductPrice = 857
            },
            new Models.Product
            {
                ProductDate = DateTime.Now,
                ProductDescription = "ran out of wisecrack, sample description.",
                ProductName = "Green  band",
                ProductPicture = "/Content/SampleImage.jpg",
                ProductPrice = 145
            },
            new Models.Product
            {
                ProductDate = DateTime.Now,
                ProductDescription = "ran out of wisecrack, sample description.",
                ProductName = "Mirror",
                ProductPicture = "/Content/SampleImage.jpg",
                ProductPrice = 2457
            },
            new Models.Product
            {
                ProductDate = DateTime.Now,
                ProductDescription = "ran out of wisecrack, sample description.",
                ProductName = "Socks",
                ProductPicture = "/Content/SampleImage.jpg",
                ProductPrice = 214
            }
            );

        }
    }
}
