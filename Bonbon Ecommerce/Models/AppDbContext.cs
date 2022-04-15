using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bonbon_Ecommerce.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Candy> Candies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Chocolate Candy"});
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Fruit Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Gummy Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Halloween Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Hard Candy" });

            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 1,
                Name = "Assorted Chocolate Candy",
                Price = 4.95M,
                Description = "GOURMET TRUFFLES: Bag containing Lindt LINDOR Milk Chocolate Truffles, 650g " +
                "\nINDULGENT FLAVOUR: Creamy milk chocolate truffles have smooth melting chocolate centres" +
                "\nBEAN TO BAR: Lindt controls every step in its chocolate - making process, from superior cacao beans to superb chocolates" +
                "\nGREAT FOR GIFTING: This bag of Swiss chocolate is perfect for sharing, gifting, or entertaining" +
                "\nCRAFTED BY EXPERTS: Created with experience and passion by Lindt Maître Chocolatiers since 1845",
                CategoryId = 1,
                ImageUrl = "\\Images\\chocolateCandy.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy-small.jpg",
                IsInStock = true,
                IsOnSale = false,
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 2,
                Name = "Another Assorted Chocolate Candy",
                Price = 3.95M,
                Description = "SHIPS IN COOL PACKAGING: This candy item is heat sensitive and will ship with cool pack packaging as needed." +
                "\nDELICIOUS HERSHEY KISSES, Individually Wrapped for any Celebration. " +
                "\nPARTY GUESTS WILL THANK YOU: Add your personal touch to your girl baby shower, birthday party, bridal shower, wedding reception, and more with these themed color candy favors for gift bags, candy buffets, and treats.",
                CategoryId = 1,
                ImageUrl = "\\Images\\chocolateCandy2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 3,
                Name = "Another Chocolate Candy",
                Price = 5.75M,
                Description = "Made with real milk chocolate and surrounded by a colorful candy shell" +
                "\nFrom cookies to brownies, M & M's chocolate candies are a colorful way to enhance your favorite desserts" +
                "\nAdd delicious fun and color to your day with M & M's milk chocolate candies",
                CategoryId = 1,
                ImageUrl = "\\Images\\chocolateCandy3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 4,
                Name = "Assorted Fruit Candy",
                Price = 3.95M,
                Description = "Craze started and famous from Tiktok Hit or Miss Challenge! Fruity's Snack TikTok Hit or Miss Challenge" +
                "\nDO YOU HAVE THE FANGS TO POP THAT THANG ? -Take a bite, We dare you! No matter what you will have a blast, and did we mention these are DELICIOUS TOO!",
                CategoryId = 2,
                ImageUrl = "\\Images\\fruitCandy.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 5,
                Name = "Fruit Candy",
                Price = 7.00M,
                Description = "EVEN BETTER THAN IT WAS BEFORE: New delicious recipe - we out candied candy!\nKICK SUGAR: Feel good about candy with SmartSweets Just 3g of sugar and 130 calories for the whole bag - that’s 91 % less sugar than the other sours! Smartly sweetened with high - quality, naturally sweet plant - based fibers and a touch of stevia",
                CategoryId = 2,
                ImageUrl = "\\Images\\fruitCandy2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 6,
                Name = "Another Assorted Fruit Candy",
                Price = 11.25M,
                Description = "KEEP CANDY: Mouthwatering sour gummy candy that is a radically better choice, free from sugar alcohols, added sugar; and artificial sweeteners, flavors and colors Every ingredient is gluten free, non-GMO, always real, and never artificial" +
                "\nPLANT - BASED: Packed with 17 grams of soluble prebiotic fiber A mix of 5 delicious flavors per bag: berry, blue raspberry, lime, lemon and orange(plus, they are certified vegan)!",
                CategoryId = 2,
                ImageUrl = "\\Images\\fruitCandy3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 7,
                Name = "Assorted Gummy Candy",
                Price = 3.95M,
                Description = "Product taste: comprehensive taste\nSpecification: 200g\nHow to eat: Open the package and eat immediately\nStorage conditions: Store in a cool and dry place,\navoid direct sunlight",
                CategoryId = 3,
                ImageUrl = "\\Images\\gummyCandy.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 8,
                Name = "Another Assorted Gummy Candy",
                Price = 1.95M,
                Description = "Each bag contains the following sweet and sour flavor combinations: cherry and orange, apple and lemon, and blueberry and blackcurrant\nShare with your friends and family",
                CategoryId = 3,
                ImageUrl = "\\Images\\gummyCandy2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 9,
                Name = "Gummy Candy",
                Price = 13.95M,
                Description = "Naturally flavored with balanced sweetness\nMouth watering candy and are fat - free\nFlavors are pineapple(white), strawberry(green), lemon(yellow), orange(orange) and raspberry(red)",
                CategoryId = 3,
                ImageUrl = "\\Images\\gummyCandy3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 10,
                Name = "Halloween Candy",
                Price = 1.95M,
                Description = "Halloween sweet boxes are designed with 4 different Halloween elements, including cat, spider, ghost, pumpkin. Adorable and unique design can meet kids’ preferences.",
                CategoryId = 4,
                ImageUrl = "\\Images\\halloweenCandy.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\halloweenCandy-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 11,
                Name = "Assorted Halloween Candy",
                Price = 12.95M,
                Description = "HALLOWEEN PARTY GAMES - Funny halloween craft for kids to decorate their own stickers, creative games for halloween party time, There are 6 styles in one set, each styles has 7 sheets. Each design is unique, children can paste different decorations for halloween face stickers to their own preferences.",
                CategoryId = 4,
                ImageUrl = "\\Images\\halloweenCandy2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\halloweenCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 12,
                Name = "Another Halloween Candy",
                Price = 21.95M,
                Description = "Value - packed candy assortment\nPerfect for parties, pantries and any candy - giveaway occasion",
                CategoryId = 4,
                ImageUrl = "\\Images\\halloweenCandy3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\halloweenCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 13,
                Name = "Hard Candy",
                Price = 6.95M,
                Description = "Block-shaped hard candy\nFruity flavors\nSodium-free \nLow-calorie \nIdeal for snacking, gifting, holidays, parties, baby showers, Halloween, stocking stuffers, etc.",
                CategoryId = 5,
                ImageUrl = "\\Images\\hardCandy.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\hardCandy-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 14,
                Name = "Another Hard Candy",
                Price = 2.95M,
                Description = "Store in a cool and dry place \nIndividually wrapped",
                CategoryId = 5,
                ImageUrl = "\\Images\\hardCandy2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\hardCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 15,
                Name = "Best Hard Candy",
                Price = 16.95M,
                Description = "Greek Classic Ouzo Flavour \nIndividually Wrapped \nBulk Bag",
                CategoryId = 5,
                ImageUrl = "\\Images\\hardCandy3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\hardCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
        }
    }
}
