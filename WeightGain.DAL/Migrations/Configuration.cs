using System;
using System.Data.Entity.Migrations;
using WeightGain.DATA;
using WeightGain.DATA.Helpers;

namespace WeightGain.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Context.WeightGainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.WeightGainContext context)
        {

            #region İlk kurulumda eklenecek veriler

            #region Admin kullanıcıları ekliyoruz.

            context.Users.AddOrUpdate(x => x.Id,
                new User
                {
                    FirstName = "Yüksel",
                    LastName = "Güzel",
                    Email = "yuksel.guzel@bilgeadamboost.com",
                    Password = Helper.GeneratePasswordHash("123456"),
                    BirthDate = DateTime.Now.AddYears(-19),
                    Weight = 45,
                    Height = 160,
                    PhoneNumber = "51111111111",
                    UserType = UserTypeEnum.Admin
                },
                new User
                {
                    FirstName = "Fatma",
                    LastName = "Çiftçi",
                    Email = "fatma.ciftci@bilgeadamboost.com",
                    Password = Helper.GeneratePasswordHash("123456"),
                    BirthDate = DateTime.Now.AddYears(-19),
                    Weight = 45,
                    Height = 160,
                    PhoneNumber = "52222222222",
                    UserType = UserTypeEnum.Admin
                },
                new User
                {
                    FirstName = "Çağatay",
                    LastName = "Korkut",
                    Email = "cagatay.korkut@bilgeadamboost.com",
                    Password = Helper.GeneratePasswordHash("123456"),
                    BirthDate = DateTime.Now.AddYears(-19),
                    Weight = 45,
                    Height = 160,
                    PhoneNumber = "53333333333",
                    UserType = UserTypeEnum.Admin
                });

            #endregion Admin kullanıcıları ekliyoruz.

            #region Diyetisyen kullanıcıları ekliyoruz.

            context.Users.AddOrUpdate(x => x.Id,
                new User
                {
                    FirstName = "Diyetisyen",
                    LastName = "Deneme",
                    Email = "deneme@bilgeadamboost.com",
                    Password = Helper.GeneratePasswordHash("123456"),
                    BirthDate = DateTime.Now.AddYears(-19),
                    Weight = 45,
                    Height = 160,
                    UserType = UserTypeEnum.Dietitian
                });

            #endregion Diyetisyen kullanıcıları ekliyoruz.

            #region Normal kullanıcıları ekliyoruz.

            context.Users.AddOrUpdate(x => x.Id,
                new User
                {
                    FirstName = "Kullanıcı Adı",
                    LastName = "Kullanıcı Soyadı",
                    Email = "ilkkullanici@bilgeadamboost.com",
                    Password = Helper.GeneratePasswordHash("123456"),
                    BirthDate = DateTime.Now.AddYears(-19),
                    Weight = 45,
                    Height = 160,
                    PhoneNumber = "11111111111",
                    UserType = UserTypeEnum.User
                },
                new User
                {
                    FirstName = "Kullanıcı Adı 2",
                    LastName = "Kullanıcı Soyadı 2",
                    Email = "ikincikullanici@bilgeadamboost.com",
                    Password = Helper.GeneratePasswordHash("123456"),
                    BirthDate = DateTime.Now.AddYears(-21),
                    Weight = 55,
                    Height = 180,
                    PhoneNumber = "22222222222",
                    UserType = UserTypeEnum.User
                }
            );

            #endregion Normal kullanıcıları ekliyoruz.

            #region Kategorileri Ekliyoruz

            context.Categories.AddOrUpdate(x => x.CategoryId,
                new Category
                {
                    Name = "BALIKLAR",
                    Description = "",
                },
                new Category
                {
                    Name = "ÇORBALAR",
                    Description = "",
                },
                new Category
                {
                    Name = "EKMEK VB. ÜRÜNLER",
                    Description = "",
                },
                new Category
                {
                    Name = "İÇECEKLER",
                    Description = "",
                },
                new Category
                {
                    Name = "ANA YEMEKLER",
                    Description = "",
                },
                new Category
                {
                    Name = "ZEYTİNYAĞLI & SALATALAR",
                    Description = "",
                },
                new Category
                {
                    Name = "KURUBAKLAGİLLER",
                    Description = "",
                },
                new Category
                {
                    Name = "MEYVELER",
                    Description = "",
                },
                new Category
                {
                    Name = "KAHVALTILIKLAR",
                    Description = "",
                },
                new Category
                {
                    Name = "TATLILAR",
                    Description = "",
                }
            );
            context.SaveChanges();
            #endregion Kategorileri Ekliyoruz

            #region Ürünleri Ekliyoruz

            context.Products.AddOrUpdate(x => x.ProductId,
            new Product
            {
                ProductName = "Alabalık",
                Scale = "gr",
                Calory = 175,
                CategoryId = 1,
                Category = context.Categories.Find(1),
                Picture = Helper.GetImageBytes("1")
            },
            new Product
            {
                ProductName = "Kalkan",
                Scale = "gr",
                Calory = 193,
                CategoryId = 1,
                Category = context.Categories.Find(1),
                Picture = Helper.GetImageBytes("2")
            },
            new Product
            {
                ProductName = "Kılıç",
                Scale = "gr",
                Calory = 164,
                CategoryId = 1,
                Category = context.Categories.Find(1),
                Picture = Helper.GetImageBytes("3")
            },
            new Product
            {
                ProductName = "Levrek",
                Scale = "gr",
                Calory = 93,
                CategoryId = 1,
                Category = context.Categories.Find(1),
                Picture = Helper.GetImageBytes("4")
            },
            new Product
            {
                ProductName = "Ton",
                Scale = "gr",
                Calory = 289,
                CategoryId = 1,
                Category = context.Categories.Find(1),
                Picture = Helper.GetImageBytes("5")
            },
            new Product
            {
                ProductName = "Domates",
                Scale = "gr",
                Calory = 219,
                CategoryId = 2,
                Category = context.Categories.Find(2),
                Picture = Helper.GetImageBytes("6")
            },
            new Product
            {
                ProductName = "Ezogelin",
                Scale = "gr",
                Calory = 274,
                CategoryId = 2,
                Category = context.Categories.Find(2),
                Picture = Helper.GetImageBytes("7")
            },
            new Product
            {
                ProductName = "İşkembe",
                Scale = "gr",
                Calory = 342,
                CategoryId = 2,
                Category = context.Categories.Find(2),
                Picture = Helper.GetImageBytes("8")
            },
            new Product
            {
                ProductName = "Mercimek",
                Scale = "gr",
                Calory = 235,
                CategoryId = 2,
                Category = context.Categories.Find(2),
                Picture = Helper.GetImageBytes("9")
            },
            new Product
            {
                ProductName = "Tarhana",
                Scale = "gr",
                Calory = 280,
                CategoryId = 2,
                Category = context.Categories.Find(2),
                Picture = Helper.GetImageBytes("10")
            },
            new Product
            {
                ProductName = "Yayla",
                Scale = "gr",
                Calory = 252,
                CategoryId = 2,
                Category = context.Categories.Find(2),
                Picture = Helper.GetImageBytes("11")
            },
            new Product
            {
                ProductName = "Ekmek (buğday)",
                Scale = "gr",
                Calory = 276,
                CategoryId = 3,
                Category = context.Categories.Find(3),
                Picture = Helper.GetImageBytes("12")
            },
            new Product
            {
                ProductName = "Ekmek (çavdar)",
                Scale = "gr",
                Calory = 243,
                CategoryId = 3,
                Category = context.Categories.Find(3),
                Picture = Helper.GetImageBytes("13")
            },
            new Product
            {
                ProductName = "Ekmek (kepek)",
                Scale = "Dilim",
                Calory = 60,
                CategoryId = 3,
                Category = context.Categories.Find(3),
                Picture = Helper.GetImageBytes("14")
            },
            new Product
            {
                ProductName = "Çay",
                Scale = "gr",
                Calory = 39,
                CategoryId = 4,
                Category = context.Categories.Find(4),
                Picture = Helper.GetImageBytes("15")
            },
            new Product
            {
                ProductName = "Süt",
                Scale = "gr",
                Calory = 70,
                CategoryId = 4,
                Category = context.Categories.Find(4),
                Picture = Helper.GetImageBytes("16")
            },
            new Product
            {
                ProductName = "Adaçayı",
                Scale = "gr",
                Calory = 315,
                CategoryId = 4,
                Category = context.Categories.Find(4),
                Picture = Helper.GetImageBytes("17")
            },
            new Product
            {
                ProductName = "Cola (diyet)",
                Scale = "kutu",
                Calory = 100,
                CategoryId = 4,
                Category = context.Categories.Find(4),
                Picture = Helper.GetImageBytes("18")
            },
            new Product
            {
                ProductName = "Cola (normal)",
                Scale = "kutu",
                Calory = 160,
                CategoryId = 4,
                Category = context.Categories.Find(4),
                Picture = Helper.GetImageBytes("19")
            },
            new Product
            {
                ProductName = "Domates suyu",
                Scale = "gr",
                Calory = 16,
                CategoryId = 4,
                Category = context.Categories.Find(4),
                Picture = Helper.GetImageBytes("20")
            },
            new Product
            {
                ProductName = "Gazoz",
                Scale = "gr",
                Calory = 39,
                CategoryId = 4,
                Category = context.Categories.Find(4),
                Picture = Helper.GetImageBytes("21")
            },
            new Product
            {
                ProductName = "Kahve",
                Scale = "fincan",
                Calory = 5,
                CategoryId = 4,
                Category = context.Categories.Find(4),
                Picture = Helper.GetImageBytes("22")
            },
            new Product
            {
                ProductName = "Limonata",
                Scale = "gr",
                Calory = 21,
                CategoryId = 4,
                Category = context.Categories.Find(4),
                Picture = Helper.GetImageBytes("23")
            },
            new Product
            {
                ProductName = "Meyve suyu",
                Scale = "gr",
                Calory = 31,
                CategoryId = 4,
                Category = context.Categories.Find(4),
                Picture = Helper.GetImageBytes("24")
            },
            new Product
            {
                ProductName = "Portakal Suyu",
                Scale = "gr",
                Calory = 45,
                CategoryId = 4,
                Category = context.Categories.Find(4),
                Picture = Helper.GetImageBytes("25")
            },
            new Product
            {
                ProductName = "Sebzeli Güveç",
                Scale = "gr",
                Calory = 156,
                CategoryId = 5,
                Category = context.Categories.Find(5),
                Picture = Helper.GetImageBytes("26")
            },
            new Product
            {
                ProductName = "Pizza",
                Scale = "gr",
                Calory = 472,
                CategoryId = 5,
                Category = context.Categories.Find(5),
                Picture = Helper.GetImageBytes("27")
            },
            new Product
            {
                ProductName = "Makarna",
                Scale = "gr",
                Calory = 100,
                CategoryId = 5,
                Category = context.Categories.Find(5),
                Picture = Helper.GetImageBytes("28")
            },
            new Product
            {
                ProductName = "Köfte",
                Scale = "gr",
                Calory = 225,
                CategoryId = 5,
                Category = context.Categories.Find(5),
                Picture = Helper.GetImageBytes("29")
            },
            new Product
            {
                ProductName = "Adana",
                Scale = "gr",
                Calory = 190,
                CategoryId = 5,
                Category = context.Categories.Find(5),
                Picture = Helper.GetImageBytes("30")
            },
            new Product
            {
                ProductName = "Et Sote",
                Scale = "gr",
                Calory = 150,
                CategoryId = 5,
                Category = context.Categories.Find(5),
                Picture = Helper.GetImageBytes("31")
            },
            new Product
            {
                ProductName = "Tavuk Sote",
                Scale = "gr",
                Calory = 450,
                CategoryId = 5,
                Category = context.Categories.Find(5),
                Picture = Helper.GetImageBytes("32")
            },
            new Product
            {
                ProductName = "Lahmacun",
                Scale = "gr",
                Calory = 400,
                CategoryId = 5,
                Category = context.Categories.Find(5),
                Picture = Helper.GetImageBytes("33")
            },
            new Product
            {
                ProductName = "Pilav",
                Scale = "gr",
                Calory = 380,
                CategoryId = 5,
                Category = context.Categories.Find(5),
                Picture = Helper.GetImageBytes("34")
            },
            new Product
            {
                ProductName = "Su Böreği",
                Scale = "gr",
                Calory = 456,
                CategoryId = 5,
                Category = context.Categories.Find(5),
                Picture = Helper.GetImageBytes("35")
            },
            new Product
            {
                ProductName = "Kuru Fasulye",
                Scale = "gr",
                Calory = 310,
                CategoryId = 5,
                Category = context.Categories.Find(5),
                Picture = Helper.GetImageBytes("36")
            },
            new Product
            {
                ProductName = "Bonfile&Pirzola",
                Scale = "gr",
                Calory = 315,
                CategoryId = 5,
                Category = context.Categories.Find(5),
                Picture = Helper.GetImageBytes("37")
            },
            new Product
            {
                ProductName = "Etli Mercimek",
                Scale = "gr",
                Calory = 380,
                CategoryId = 5,
                Category = context.Categories.Find(5),
                Picture = Helper.GetImageBytes("38")
            },
            new Product
            {
                ProductName = "Karnıyarık",
                Scale = "gr",
                Calory = 347,
                CategoryId = 5,
                Category = context.Categories.Find(5),
                Picture = Helper.GetImageBytes("39")
            },
            new Product
            {
                ProductName = "Ali Nazik",
                Scale = "gr",
                Calory = 301,
                CategoryId = 5,
                Category = context.Categories.Find(5),
                Picture = Helper.GetImageBytes("40")
            },
            new Product
            {
                ProductName = "Zeytin Yağlı Sarma&Dolma",
                Scale = "gr",
                Calory = 210,
                CategoryId = 6,
                Category = context.Categories.Find(6),
                Picture = Helper.GetImageBytes("41")
            },
            new Product
            {
                ProductName = "Zeytinyağlı Fasulye",
                Scale = "gr",
                Calory = 230,
                CategoryId = 6,
                Category = context.Categories.Find(6),
                Picture = Helper.GetImageBytes("42")
            },
            new Product
            {
                ProductName = "Mevsim Salata",
                Scale = "gr",
                Calory = 220,
                CategoryId = 6,
                Category = context.Categories.Find(6),
                Picture = Helper.GetImageBytes("43")
            },
            new Product
            {
                ProductName = "Kereviz Yemeği",
                Scale = "gr",
                Calory = 215,
                CategoryId = 6,
                Category = context.Categories.Find(6),
                Picture = Helper.GetImageBytes("44")
            },
            new Product
            {
                ProductName = "Taze Bamya",
                Scale = "gr",
                Calory = 190,
                CategoryId = 6,
                Category = context.Categories.Find(6),
                Picture = Helper.GetImageBytes("45")
            },
            new Product
            {
                ProductName = "Ispanak",
                Scale = "gr",
                Calory = 200,
                CategoryId = 6,
                Category = context.Categories.Find(6),
                Picture = Helper.GetImageBytes("46")
            },
            new Product
            {
                ProductName = "Badem",
                Scale = "gr",
                Calory = 598,
                CategoryId = 7,
                Category = context.Categories.Find(7),
                Picture = Helper.GetImageBytes("47")
            },
            new Product
            {
                ProductName = "Ceviz",
                Scale = "gr",
                Calory = 651,
                CategoryId = 7,
                Category = context.Categories.Find(7),
                Picture = Helper.GetImageBytes("48")
            },
            new Product
            {
                ProductName = "Fındık",
                Scale = "gr",
                Calory = 634,
                CategoryId = 7,
                Category = context.Categories.Find(7),
                Picture = Helper.GetImageBytes("49")
            },
            new Product
            {
                ProductName = "Fıstık",
                Scale = "gr",
                Calory = 560,
                CategoryId = 7,
                Category = context.Categories.Find(7),
                Picture = Helper.GetImageBytes("50")
            },
            new Product
            {
                ProductName = "Ananas",
                Scale = "gr",
                Calory = 52,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("51")
            },
            new Product
            {
                ProductName = "Armut",
                Scale = "gr",
                Calory = 61,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("52")
            },
            new Product
            {
                ProductName = "Avokado",
                Scale = "gr",
                Calory = 167,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("53")
            },
            new Product
            {
                ProductName = "Çilek",
                Scale = "gr",
                Calory = 37,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("54")
            },
            new Product
            {
                ProductName = "Elma",
                Scale = "gr",
                Calory = 58,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("55")
            },
            new Product
            {
                ProductName = "Greyfurt",
                Scale = "gr",
                Calory = 41,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("56")
            },
            new Product
            {
                ProductName = "İncir",
                Scale = "gr",
                Calory = 80,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("57")
            },
            new Product
            {
                ProductName = "Karpuz",
                Scale = "gr",
                Calory = 26,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("58")
            },
            new Product
            {
                ProductName = "Kavun",
                Scale = "gr",
                Calory = 33,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("59")
            },
            new Product
            {
                ProductName = "Kayısı",
                Scale = "adet",
                Calory = 17,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("60")
            },
            new Product
            {
                ProductName = "Kiraz",
                Scale = "adet",
                Calory = 5,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("61")
            },
            new Product
            {
                ProductName = "Kivi",
                Scale = "gr",
                Calory = 30,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("62")
            },
            new Product
            {
                ProductName = "Limon",
                Scale = "gr",
                Calory = 27,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("63")
            },
            new Product
            {
                ProductName = "Mandalina",
                Scale = "gr",
                Calory = 46,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("64")
            },
            new Product
            {
                ProductName = "Muz",
                Scale = "gr",
                Calory = 105,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("65")
            },
            new Product
            {
                ProductName = "Portakal",
                Scale = "gr",
                Calory = 49,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("66")
            },
            new Product
            {
                ProductName = "Şeftali",
                Scale = "gr",
                Calory = 38,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("67")
            },
            new Product
            {
                ProductName = "Vişne",
                Scale = "gr",
                Calory = 58,
                CategoryId = 8,
                Category = context.Categories.Find(8),
                Picture = Helper.GetImageBytes("68")
            },
            new Product
            {
                ProductName = "Haşlanmış Yumurta",
                Scale = "gr",
                Calory = 158,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("69")
            },
            new Product
            {
                ProductName = "Omlet",
                Scale = "gr",
                Calory = 185,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("70")
            },
            new Product
            {
                ProductName = "Bal",
                Scale = "gr",
                Calory = 315,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("71")
            },
            new Product
            {
                ProductName = "Tereyağı",
                Scale = "gr",
                Calory = 310,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("72")
            },
            new Product
            {
                ProductName = "Domates",
                Scale = "gr",
                Calory = 27,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("73")
            },
            new Product
            {
                ProductName = "Salatalık",
                Scale = "gr",
                Calory = 27,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("74")
            },
            new Product
            {
                ProductName = "Zeytin",
                Scale = "gr",
                Calory = 289,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("75")
            },
            new Product
            {
                ProductName = "Kızartma",
                Scale = "gr",
                Calory = 450,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("76")
            },
            new Product
            {
                ProductName = "Yoğurt",
                Scale = "gr",
                Calory = 62,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("77")
            },
            new Product
            {
                ProductName = "Bey. peynir",
                Scale = "gr",
                Calory = 289,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("78")
            },
            new Product
            {
                ProductName = "Çökelek",
                Scale = "gr",
                Calory = 215,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("79")
            },
            new Product
            {
                ProductName = "Kaşar Peyniri",
                Scale = "gr",
                Calory = 404,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("80")
            },
            new Product
            {
                ProductName = "Krem Peynir (Sade)",
                Scale = "gr",
                Calory = 349,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("81")
            },
            new Product
            {
                ProductName = "Otlu Peynir",
                Scale = "gr",
                Calory = 327,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("82")
            },
            new Product
            {
                ProductName = "Çikolata (Bademli)",
                Scale = "gr",
                Calory = 532,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("83")
            },
            new Product
            {
                ProductName = "Çikolata (Fıstıklı)",
                Scale = "gr",
                Calory = 543,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("84")
            },
            new Product
            {
                ProductName = "Pekmez (Üzüm)",
                Scale = "gr",
                Calory = 293,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("85")
            },
            new Product
            {
                ProductName = "Reçel",
                Scale = "gr",
                Calory = 272,
                CategoryId = 9,
                Category = context.Categories.Find(9),
                Picture = Helper.GetImageBytes("86")
            },
            new Product
            {
                ProductName = "Cheesecake",
                Scale = "dilim",
                Calory = 280,
                CategoryId = 10,
                Category = context.Categories.Find(10),
                Picture = Helper.GetImageBytes("87")
            },
            new Product
            {
                ProductName = "Elmalı turta",
                Scale = "bütün",
                Calory = 2420,
                CategoryId = 10,
                Category = context.Categories.Find(10),
                Picture = Helper.GetImageBytes("88")
            },
            new Product
            {
                ProductName = "Hanımgöbeği",
                Scale = "gr",
                Calory = 211,
                CategoryId = 10,
                Category = context.Categories.Find(10),
                Picture = Helper.GetImageBytes("89")
            },
            new Product
            {
                ProductName = "Havuçlu kek",
                Scale = "dilim",
                Calory = 385,
                CategoryId = 10,
                Category = context.Categories.Find(10),
                Picture = Helper.GetImageBytes("90")
            },
            new Product
            {
                ProductName = "İrmik helvası",
                Scale = "gr",
                Calory = 302,
                CategoryId = 10,
                Category = context.Categories.Find(10),
                Picture = Helper.GetImageBytes("91")
            },
            new Product
            {
                ProductName = "Kek pasta",
                Scale = "gr",
                Calory = 364,
                CategoryId = 10,
                Category = context.Categories.Find(10),
                Picture = Helper.GetImageBytes("92")
            },
            new Product
            {
                ProductName = "Sütlaç",
                Scale = "gr",
                Calory = 139,
                CategoryId = 10,
                Category = context.Categories.Find(10),
                Picture = Helper.GetImageBytes("93")
            },
            new Product
            {
                ProductName = "Dondurma (Sütlü)",
                Scale = "gr",
                Calory = 193,
                CategoryId = 10,
                Category = context.Categories.Find(10),
                Picture = Helper.GetImageBytes("94")
            }
            );

            #endregion Ürünleri Ekliyoruz

            #endregion
        }
    }
}