using Microsoft.EntityFrameworkCore.Migrations;

namespace Bonbon_Ecommerce.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, null, "Chocolate Candy" },
                    { 2, null, "Fruit Candy" },
                    { 3, null, "Gummy Candy" },
                    { 4, null, "Halloween Candy" },
                    { 5, null, "Hard Candy" }
                });

            migrationBuilder.InsertData(
                table: "Candies",
                columns: new[] { "CandyId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, @"GOURMET TRUFFLES: Bag containing Lindt LINDOR Milk Chocolate Truffles, 650g 
                INDULGENT FLAVOUR: Creamy milk chocolate truffles have smooth melting chocolate centres
                BEAN TO BAR: Lindt controls every step in its chocolate - making process, from superior cacao beans to superb chocolates
                GREAT FOR GIFTING: This bag of Swiss chocolate is perfect for sharing, gifting, or entertaining
                CRAFTED BY EXPERTS: Created with experience and passion by Lindt Maître Chocolatiers since 1845", "~\\Images\\thumbnails\\chocolateCandy-small.jpg", "~\\Images\\chocolateCandy.jpg", true, false, "Assorted Chocolate Candy", 4.95m },
                    { 2, 1, @"SHIPS IN COOL PACKAGING: This candy item is heat sensitive and will ship with cool pack packaging as needed.
                DELICIOUS HERSHEY KISSES, Individually Wrapped for any Celebration. 
                PARTY GUESTS WILL THANK YOU: Add your personal touch to your girl baby shower, birthday party, bridal shower, wedding reception, and more with these themed color candy favors for gift bags, candy buffets, and treats.", "\\Images\\thumbnails\\chocolateCandy2-small.jpg", "\\Images\\chocolateCandy2.jpg", true, true, "Another Assorted Chocolate Candy", 3.95m },
                    { 3, 1, @"Made with real milk chocolate and surrounded by a colorful candy shell
                From cookies to brownies, M & M's chocolate candies are a colorful way to enhance your favorite desserts
                Add delicious fun and color to your day with M & M's milk chocolate candies", "\\Images\\thumbnails\\chocolateCandy3-small.jpg", "\\Images\\chocolateCandy3.jpg", true, false, "Another Chocolate Candy", 5.75m },
                    { 4, 2, @"Craze started and famous from Tiktok Hit or Miss Challenge! Fruity's Snack TikTok Hit or Miss Challenge
                DO YOU HAVE THE FANGS TO POP THAT THANG ? -Take a bite, We dare you! No matter what you will have a blast, and did we mention these are DELICIOUS TOO!", "\\Images\\thumbnails\\fruitCandy-small.jpg", "\\Images\\fruitCandy.jpg", true, false, "Assorted Fruit Candy", 3.95m },
                    { 5, 2, @"EVEN BETTER THAN IT WAS BEFORE: New delicious recipe - we out candied candy!
                KICK SUGAR: Feel good about candy with SmartSweets Just 3g of sugar and 130 calories for the whole bag - that’s 91 % less sugar than the other sours! Smartly sweetened with high - quality, naturally sweet plant - based fibers and a touch of stevia", "\\Images\\thumbnails\\fruitCandy2-small.jpg", "\\Images\\fruitCandy2.jpg", true, true, "Fruit Candy", 7.00m },
                    { 6, 2, @"KEEP CANDY: Mouthwatering sour gummy candy that is a radically better choice, free from sugar alcohols, added sugar; and artificial sweeteners, flavors and colors Every ingredient is gluten free, non-GMO, always real, and never artificial
                PLANT - BASED: Packed with 17 grams of soluble prebiotic fiber A mix of 5 delicious flavors per bag: berry, blue raspberry, lime, lemon and orange(plus, they are certified vegan)!", "\\Images\\thumbnails\\fruitCandy3-small.jpg", "\\Images\\fruitCandy3.jpg", true, true, "Another Assorted Fruit Candy", 11.25m },
                    { 7, 3, @"Product taste: comprehensive taste
                Specification: 200g
                How to eat: Open the package and eat immediately
                Storage conditions: Store in a cool and dry place,
                avoid direct sunlight", "\\Images\\thumbnails\\gummyCandy-small.jpg", "\\Images\\gummyCandy.jpg", true, true, "Assorted Gummy Candy", 3.95m },
                    { 8, 3, @"Each bag contains the following sweet and sour flavor combinations: cherry and orange, apple and lemon, and blueberry and blackcurrant
                Share with your friends and family", "\\Images\\thumbnails\\gummyCandy2-small.jpg", "\\Images\\gummyCandy2.jpg", true, false, "Another Assorted Gummy Candy", 1.95m },
                    { 9, 3, @"Naturally flavored with balanced sweetness
                Mouth watering candy and are fat - free
                Flavors are pineapple(white), strawberry(green), lemon(yellow), orange(orange) and raspberry(red)", "\\Images\\thumbnails\\gummyCandy3-small.jpg", "\\Images\\gummyCandy3.jpg", true, false, "Gummy Candy", 13.95m },
                    { 10, 4, "Halloween sweet boxes are designed with 4 different Halloween elements, including cat, spider, ghost, pumpkin. Adorable and unique design can meet kids’ preferences.", "\\Images\\thumbnails\\halloweenCandy-small.jpg", "\\Images\\halloweenCandy.jpg", true, true, "Halloween Candy", 1.95m },
                    { 11, 4, "HALLOWEEN PARTY GAMES - Funny halloween craft for kids to decorate their own stickers, creative games for halloween party time, There are 6 styles in one set, each styles has 7 sheets. Each design is unique, children can paste different decorations for halloween face stickers to their own preferences.", "\\Images\\thumbnails\\halloweenCandy2-small.jpg", "\\Images\\halloweenCandy2.jpg", true, true, "Assorted Halloween Candy", 12.95m },
                    { 12, 4, @"Value - packed candy assortment
                Perfect for parties, pantries and any candy - giveaway occasion", "\\Images\\thumbnails\\halloweenCandy3-small.jpg", "\\Images\\halloweenCandy3.jpg", true, true, "Another Halloween Candy", 21.95m },
                    { 13, 5, @"Block-shaped hard candy
                Fruity flavors
                Sodium-free 
                Low-calorie 
                Ideal for snacking, gifting, holidays, parties, baby showers, Halloween, stocking stuffers, etc.", "\\Images\\thumbnails\\hardCandy-small.jpg", "\\Images\\hardCandy.jpg", true, false, "Hard Candy", 6.95m },
                    { 14, 5, @"Store in a cool and dry place 
                Individually wrapped", "\\Images\\thumbnails\\hardCandy2-small.jpg", "\\Images\\hardCandy2.jpg", true, true, "Another Hard Candy", 2.95m },
                    { 15, 5, @"Greek Classic Ouzo Flavour 
                Individually Wrapped 
                Bulk Bag", "\\Images\\thumbnails\\hardCandy3-small.jpg", "\\Images\\hardCandy3.jpg", true, false, "Best Hard Candy", 16.95m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);
        }
    }
}
