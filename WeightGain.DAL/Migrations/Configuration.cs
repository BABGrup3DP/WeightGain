using System;
using System.Data.Entity.Migrations;
using WeightGain.DATA;
using WeightGain.UI.Helpers;

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
            #region Admin kullanıcıları ekliyoruz.

            context.Admins.AddOrUpdate(x => x.ID,
                new Admin
                {
                    Email = "yuksel.guzel@bilgeadamboost.com",
                    Password = Helper.GenerateMd5("123456"),
                    PhoneNumber = "51111111111"
                },
                new Admin
                {
                    Email = "fatma.ciftci@bilgeadamboost.com",
                    Password = Helper.GenerateMd5("123456"),
                    PhoneNumber = "52222222222"
                },
                new Admin
                {
                    Email = "cagatay.korkut@bilgeadamboost.com",
                    Password = Helper.GenerateMd5("123456"),
                    PhoneNumber = "53333333333"
                });

            #endregion Admin kullanıcıları ekliyoruz.

            #region Diyetisyen kullanıcıları ekliyoruz.

            context.Dietitians.AddOrUpdate(x => x.ID,
                new Dietitian
                {
                    Email = "deneme@bilgeadamboost.com",
                    Password = Helper.GenerateMd5("123456"),
                });

            #endregion Diyetisyen kullanıcıları ekliyoruz.

            #region Normal kullanıcıları ekliyoruz.

            context.Users.AddOrUpdate(x => x.ID,
                new User
                {
                    FirstName = "Kullanıcı Adı",
                    LastName = "Kullanıcı Soyadı",
                    Email = "ilkkullanici@bilgeadamboost.com",
                    Password = Helper.GenerateMd5("123456"),
                    BirthDate = DateTime.Now.AddYears(-19),
                    Weight = 45,
                    Height = 160
                },
                new User
                {
                    FirstName = "Kullanıcı Adı 2",
                    LastName = "Kullanıcı Soyadı 2",
                    Email = "ikincikullanici@bilgeadamboost.com",
                    Password = Helper.GenerateMd5("123456"),
                    BirthDate = DateTime.Now.AddYears(-21),
                    Weight = 55,
                    Height = 180
                }
            );

            #endregion Normal kullanıcıları ekliyoruz.

            #region Kategorileri Ekliyoruz

            context.Categories.AddOrUpdate(x => x.CategoryID,
                new Category
                {
                    Name = "AV HAYVANLARI",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "BALIKLAR",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "BİTKİSEL YAĞLAR",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "ÇEŞNİLER",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "ÇORBALAR",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "DENİZ ÜRÜNLERİ",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "DİĞER BESİNLER",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "EKMEK VB. ÜRÜNLER",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "ET ÜRÜNLERİ",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "HAYVANSAL YAĞLAR",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "İÇECEKLER",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "KIRMIZI ETLER",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "KURUBAKLAGİLLER",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "KÜMES HAYVANLARI",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "MEYVELER",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "PEYNİRLER",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "SAKATATLAR",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "SEBZELER",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "SOSLAR",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "SÜT VE ÜRÜNLERİ",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "ŞEKER ve ŞEKER ÜRÜNLERİ",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "TAHIL ÜRÜNLERİ",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "TATLILAR",
                    Description = "",
                    Picture = new byte[] { }
                },
                new Category
                {
                    Name = "YUMURTALAR",
                    Description = "",
                    Picture = new byte[] { }
                }
            );

            #endregion Kategorileri Ekliyoruz

            #region Ürünleri Ekliyoruz

            context.Products.AddOrUpdate(x => x.ProductID,
               new Product
               {
                   ProductName = "Bıldırcın",
                   Scale = "gr",
                   Calory = 192,
                   CategoryID = 1,
                   Category = context.Categories.Find(1)
               },
               new Product
               {
                   ProductName = "Güvercin",
                   Scale = "gr",
                   Calory = 294,
                   CategoryID = 1,
                   Category = context.Categories.Find(1)
               },
               new Product
               {
                   ProductName = "Sülün",
                   Scale = "gr",
                   Calory = 181,
                   CategoryID = 1,
                   Category = context.Categories.Find(1)
               },
               new Product
               {
                   ProductName = "Tavşan",
                   Scale = "gr",
                   Calory = 162,
                   CategoryID = 1,
                   Category = context.Categories.Find(1)
               },
               new Product
               {
                   ProductName = "Alabalık",
                   Scale = "gr",
                   Calory = 175,
                   CategoryID = 2,
                   Category = context.Categories.Find(2)
               },
               new Product
               {
                   ProductName = "Balık Unu",
                   Scale = "gr",
                   Calory = 336,
                   CategoryID = 2,
                   Category = context.Categories.Find(2)
               },
               new Product
               {
                   ProductName = "Kalkan",
                   Scale = "gr",
                   Calory = 193,
                   CategoryID = 2,
                   Category = context.Categories.Find(2)
               },
               new Product
               {
                   ProductName = "Kılıç",
                   Scale = "gr",
                   Calory = 164,
                   CategoryID = 2,
                   Category = context.Categories.Find(2)
               },
               new Product
               {
                   ProductName = "Levrek",
                   Scale = "gr",
                   Calory = 93,
                   CategoryID = 2,
                   Category = context.Categories.Find(2)
               },
               new Product
               {
                   ProductName = "Mersin",
                   Scale = "gr",
                   Calory = 96,
                   CategoryID = 2,
                   Category = context.Categories.Find(2)
               },
               new Product
               {
                   ProductName = "Palamut",
                   Scale = "gr",
                   Calory = 168,
                   CategoryID = 2,
                   Category = context.Categories.Find(2)
               },
               new Product
               {
                   ProductName = "Sardalya",
                   Scale = "gr",
                   Calory = 160,
                   CategoryID = 2,
                   Category = context.Categories.Find(2)
               },
               new Product
               {
                   ProductName = "Sardalya (konserve)",
                   Scale = "gr",
                   Calory = 205,
                   CategoryID = 2,
                   Category = context.Categories.Find(2)
               },
               new Product
               {
                   ProductName = "Somon",
                   Scale = "gr",
                   Calory = 155,
                   CategoryID = 2,
                   Category = context.Categories.Find(2)
               },
               new Product
               {
                   ProductName = "Ton",
                   Scale = "gr",
                   Calory = 289,
                   CategoryID = 2,
                   Category = context.Categories.Find(2)
               },
               new Product
               {
                   ProductName = "Tuzlu Balık",
                   Scale = "gr",
                   Calory = 305,
                   CategoryID = 2,
                   Category = context.Categories.Find(2)
               },
               new Product
               {
                   ProductName = "Uskumru",
                   Scale = "gr",
                   Calory = 159,
                   CategoryID = 2,
                   Category = context.Categories.Find(2)
               },
               new Product
               {
                   ProductName = "Ayçiçeği Yağı",
                   Scale = "gr",
                   Calory = 884,
                   CategoryID = 3,
                   Category = context.Categories.Find(3)
               },
               new Product
               {
                   ProductName = "Fındık Yağı",
                   Scale = "gr",
                   Calory = 884,
                   CategoryID = 3,
                   Category = context.Categories.Find(3)
               },
               new Product
               {
                   ProductName = "Haşhaş Yağı",
                   Scale = "gr",
                   Calory = 884,
                   CategoryID = 3,
                   Category = context.Categories.Find(3)
               },
               new Product
               {
                   ProductName = "Keten tohumu yağı",
                   Scale = "gr",
                   Calory = 884,
                   CategoryID = 3,
                   Category = context.Categories.Find(3)
               },
               new Product
               {
                   ProductName = "Margarin (kahvaltılık)",
                   Scale = "gr",
                   Calory = 719,
                   CategoryID = 3,
                   Category = context.Categories.Find(3)
               },
               new Product
               {
                   ProductName = "Margarin (kahvaltılık)",
                   Scale = "gr",
                   Calory = 720,
                   CategoryID = 3,
                   Category = context.Categories.Find(3)
               },
               new Product
               {
                   ProductName = "Mısırözü Yağı",
                   Scale = "gr",
                   Calory = 884,
                   CategoryID = 3,
                   Category = context.Categories.Find(3)
               },
               new Product
               {
                   ProductName = "Nebati Yağ",
                   Scale = "gr",
                   Calory = 900,
                   CategoryID = 3,
                   Category = context.Categories.Find(3)
               },
               new Product
               {
                   ProductName = "Palmiye Yağı",
                   Scale = "gr",
                   Calory = 884,
                   CategoryID = 3,
                   Category = context.Categories.Find(3)
               },
               new Product
               {
                   ProductName = "Pamuk Yağı",
                   Scale = "gr",
                   Calory = 884,
                   CategoryID = 3,
                   Category = context.Categories.Find(3)
               },
               new Product
               {
                   ProductName = "Soya Yağı",
                   Scale = "gr",
                   Calory = 884,
                   CategoryID = 3,
                   Category = context.Categories.Find(3)
               },
               new Product
               {
                   ProductName = "Susam Yağı",
                   Scale = "gr",
                   Calory = 884,
                   CategoryID = 3,
                   Category = context.Categories.Find(3)
               },
               new Product
               {
                   ProductName = "Yerfıstığı Yağı",
                   Scale = "gr",
                   Calory = 884,
                   CategoryID = 3,
                   Category = context.Categories.Find(3)
               },
               new Product
               {
                   ProductName = "Zeytin Yağı",
                   Scale = "gr",
                   Calory = 884,
                   CategoryID = 3,
                   Category = context.Categories.Find(3)
               },
               new Product
               {
                   ProductName = "Defne Yaprağı",
                   Scale = "gr",
                   Calory = 313,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Dere Otu (Kuru)",
                   Scale = "gr",
                   Calory = 253,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Hardal (Toz)",
                   Scale = "gr",
                   Calory = 469,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Haşhaş Tohumu",
                   Scale = "gr",
                   Calory = 533,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Hindistan cevizi (Toz)",
                   Scale = "gr",
                   Calory = 525,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Kabartma tozu",
                   Scale = "tatlı kaşığı",
                   Calory = 5,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Karabiber",
                   Scale = "gr",
                   Calory = 255,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Karanfil",
                   Scale = "gr",
                   Calory = 323,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Kekik",
                   Scale = "gr",
                   Calory = 276,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Kırmızıbiber (toz)",
                   Scale = "gr",
                   Calory = 318,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Kimyon (Toz)",
                   Scale = "gr",
                   Calory = 375,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Kuş üzümü",
                   Scale = "gr",
                   Calory = 54,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Maydonoz (kuru)",
                   Scale = "gr",
                   Calory = 276,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Nane (Kuru)",
                   Scale = "gr",
                   Calory = 245,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Safran",
                   Scale = "gr",
                   Calory = 310,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Sofra Tuzu",
                   Scale = "gr",
                   Calory = 0,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Tarçın (Toz)",
                   Scale = "gr",
                   Calory = 261,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Zencefil",
                   Scale = "gr",
                   Calory = 347,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Zerdecal",
                   Scale = "gr",
                   Calory = 354,
                   CategoryID = 4,
                   Category = context.Categories.Find(4)
               },
               new Product
               {
                   ProductName = "Bezelye",
                   Scale = "gr",
                   Calory = 295,
                   CategoryID = 5,
                   Category = context.Categories.Find(5)
               },
               new Product
               {
                   ProductName = "Domates",
                   Scale = "gr",
                   Calory = 219,
                   CategoryID = 5,
                   Category = context.Categories.Find(5)
               },
               new Product
               {
                   ProductName = "Ezogelin",
                   Scale = "gr",
                   Calory = 274,
                   CategoryID = 5,
                   Category = context.Categories.Find(5)
               },
               new Product
               {
                   ProductName = "İşkembe",
                   Scale = "gr",
                   Calory = 342,
                   CategoryID = 5,
                   Category = context.Categories.Find(5)
               },
               new Product
               {
                   ProductName = "Mercimek",
                   Scale = "gr",
                   Calory = 235,
                   CategoryID = 5,
                   Category = context.Categories.Find(5)
               },
               new Product
               {
                   ProductName = "Sebze",
                   Scale = "gr",
                   Calory = 227,
                   CategoryID = 5,
                   Category = context.Categories.Find(5)
               },
               new Product
               {
                   ProductName = "Tarhana (Acı)",
                   Scale = "gr",
                   Calory = 290,
                   CategoryID = 5,
                   Category = context.Categories.Find(5)
               },
               new Product
               {
                   ProductName = "Tarhana (tatlı)",
                   Scale = "gr",
                   Calory = 280,
                   CategoryID = 5,
                   Category = context.Categories.Find(5)
               },
               new Product
               {
                   ProductName = "Yayla",
                   Scale = "gr",
                   Calory = 252,
                   CategoryID = 5,
                   Category = context.Categories.Find(5)
               },
               new Product
               {
                   ProductName = "Yulaf çorbası",
                   Scale = "gr",
                   Calory = 318,
                   CategoryID = 5,
                   Category = context.Categories.Find(5)
               },
               new Product
               {
                   ProductName = "Havyar",
                   Scale = "gr",
                   Calory = 262,
                   CategoryID = 6,
                   Category = context.Categories.Find(6)
               },
               new Product
               {
                   ProductName = "İstakoz",
                   Scale = "gr",
                   Calory = 91,
                   CategoryID = 6,
                   Category = context.Categories.Find(6)
               },
               new Product
               {
                   ProductName = "İstiridye",
                   Scale = "adet",
                   Calory = 90,
                   CategoryID = 6,
                   Category = context.Categories.Find(6)
               },
               new Product
               {
                   ProductName = "Karides",
                   Scale = "gr",
                   Calory = 91,
                   CategoryID = 6,
                   Category = context.Categories.Find(6)
               },
               new Product
               {
                   ProductName = "Midye",
                   Scale = "gr",
                   Calory = 95,
                   CategoryID = 6,
                   Category = context.Categories.Find(6)
               },
               new Product
               {
                   ProductName = "Yengeç (haşlanmış)",
                   Scale = "gr",
                   Calory = 127,
                   CategoryID = 6,
                   Category = context.Categories.Find(6)
               },
               new Product
               {
                   ProductName = "Jelatin",
                   Scale = "gr",
                   Calory = 335,
                   CategoryID = 7,
                   Category = context.Categories.Find(7)
               },
               new Product
               {
                   ProductName = "Kakao",
                   Scale = "gr",
                   Calory = 299,
                   CategoryID = 7,
                   Category = context.Categories.Find(7)
               },
               new Product
               {
                   ProductName = "Maya (kuru)",
                   Scale = "gr",
                   Calory = 282,
                   CategoryID = 7,
                   Category = context.Categories.Find(7)
               },
               new Product
               {
                   ProductName = "Maya (Yaş)",
                   Scale = "gr",
                   Calory = 86,
                   CategoryID = 7,
                   Category = context.Categories.Find(7)
               },
               new Product
               {
                   ProductName = "Sirke",
                   Scale = "gr",
                   Calory = 12,
                   CategoryID = 7,
                   Category = context.Categories.Find(7)
               },
               new Product
               {
                   ProductName = "Tahin",
                   Scale = "gr",
                   Calory = 595,
                   CategoryID = 7,
                   Category = context.Categories.Find(7)
               },
               new Product
               {
                   ProductName = "Turşu (Salatalık)",
                   Scale = "gr",
                   Calory = 10,
                   CategoryID = 7,
                   Category = context.Categories.Find(7)
               },
               new Product
               {
                   ProductName = "Zeytin (Siyah)",
                   Scale = "gr",
                   Calory = 207,
                   CategoryID = 7,
                   Category = context.Categories.Find(7)
               },
               new Product
               {
                   ProductName = "Zeytin (Yeşil)",
                   Scale = "gr",
                   Calory = 144,
                   CategoryID = 7,
                   Category = context.Categories.Find(7)
               },
               new Product
               {
                   ProductName = "Ekmek (buğday)",
                   Scale = "gr",
                   Calory = 276,
                   CategoryID = 8,
                   Category = context.Categories.Find(8)
               },
               new Product
               {
                   ProductName = "Ekmek (çavdar)",
                   Scale = "gr",
                   Calory = 243,
                   CategoryID = 8,
                   Category = context.Categories.Find(8)
               },
               new Product
               {
                   ProductName = "Ekmek (kepek)",
                   Scale = "Dilim",
                   Calory = 60,
                   CategoryID = 8,
                   Category = context.Categories.Find(8)
               },
               new Product
               {
                   ProductName = "Galeta Unu",
                   Scale = "gr",
                   Calory = 392,
                   CategoryID = 8,
                   Category = context.Categories.Find(8)
               },
               new Product
               {
                   ProductName = "Grissini",
                   Scale = "gr",
                   Calory = 433,
                   CategoryID = 8,
                   Category = context.Categories.Find(8)
               },
               new Product
               {
                   ProductName = "İrmik",
                   Scale = "gr",
                   Calory = 371,
                   CategoryID = 8,
                   Category = context.Categories.Find(8)
               },
               new Product
               {
                   ProductName = "Kraker (Peynirli)",
                   Scale = "gr",
                   Calory = 479,
                   CategoryID = 8,
                   Category = context.Categories.Find(8)
               },
               new Product
               {
                   ProductName = "Kraker (Sade)",
                   Scale = "gr",
                   Calory = 384,
                   CategoryID = 8,
                   Category = context.Categories.Find(8)
               },
               new Product
               {
                   ProductName = "Kraker (tuzlu)",
                   Scale = "gr",
                   Calory = 433,
                   CategoryID = 8,
                   Category = context.Categories.Find(8)
               },
               new Product
               {
                   ProductName = "Makarna",
                   Scale = "gr",
                   Calory = 369,
                   CategoryID = 8,
                   Category = context.Categories.Find(8)
               },
               new Product
               {
                   ProductName = "Sandviç ekmeği",
                   Scale = "gr",
                   Calory = 298,
                   CategoryID = 8,
                   Category = context.Categories.Find(8)
               },
               new Product
               {
                   ProductName = "Yufka",
                   Scale = "gr",
                   Calory = 271,
                   CategoryID = 8,
                   Category = context.Categories.Find(8)
               },
               new Product
               {
                   ProductName = "Yufka (Böreklik)",
                   Scale = "gr",
                   Calory = 152,
                   CategoryID = 8,
                   Category = context.Categories.Find(8)
               },
               new Product
               {
                   ProductName = "Jambon",
                   Scale = "gr",
                   Calory = 182,
                   CategoryID = 9,
                   Category = context.Categories.Find(9)
               },
               new Product
               {
                   ProductName = "Kavurma",
                   Scale = "gr",
                   Calory = 670,
                   CategoryID = 9,
                   Category = context.Categories.Find(9)
               },
               new Product
               {
                   ProductName = "Pastırma (çemenli)",
                   Scale = "gr",
                   Calory = 250,
                   CategoryID = 9,
                   Category = context.Categories.Find(9)
               },
               new Product
               {
                   ProductName = "Pastırma (çemensiz)",
                   Scale = "gr",
                   Calory = 269,
                   CategoryID = 9,
                   Category = context.Categories.Find(9)
               },
               new Product
               {
                   ProductName = "Salam",
                   Scale = "gr",
                   Calory = 450,
                   CategoryID = 9,
                   Category = context.Categories.Find(9)
               },
               new Product
               {
                   ProductName = "Sosis",
                   Scale = "gr",
                   Calory = 322,
                   CategoryID = 9,
                   Category = context.Categories.Find(9)
               },
               new Product
               {
                   ProductName = "Sucuk",
                   Scale = "gr",
                   Calory = 452,
                   CategoryID = 9,
                   Category = context.Categories.Find(9)
               },
               new Product
               {
                   ProductName = "Balık Yağı",
                   Scale = "gr",
                   Calory = 900,
                   CategoryID = 10,
                   Category = context.Categories.Find(10)
               },
               new Product
               {
                   ProductName = "İçyağı",
                   Scale = "gr",
                   Calory = 758,
                   CategoryID = 10,
                   Category = context.Categories.Find(10)
               },
               new Product
               {
                   ProductName = "Kuyruk Yağı",
                   Scale = "gr",
                   Calory = 902,
                   CategoryID = 10,
                   Category = context.Categories.Find(10)
               },
               new Product
               {
                   ProductName = "Sade Yağ (erimiş)",
                   Scale = "gr",
                   Calory = 890,
                   CategoryID = 10,
                   Category = context.Categories.Find(10)
               },
               new Product
               {
                   ProductName = "Tereyağı",
                   Scale = "tatlı kaşığı",
                   Calory = 100,
                   CategoryID = 10,
                   Category = context.Categories.Find(10)
               },
               new Product
               {
                   ProductName = "Adaçayı",
                   Scale = "gr",
                   Calory = 315,
                   CategoryID = 11,
                   Category = context.Categories.Find(11)
               },
               new Product
               {
                   ProductName = "Beyaz şarap",
                   Scale = "kadeh",
                   Calory = 80,
                   CategoryID = 11,
                   Category = context.Categories.Find(11)
               },
               new Product
               {
                   ProductName = "Bira",
                   Scale = "adet",
                   Calory = 150,
                   CategoryID = 11,
                   Category = context.Categories.Find(11)
               },
               new Product
               {
                   ProductName = "Cin",
                   Scale = "gr",
                   Calory = 231,
                   CategoryID = 11,
                   Category = context.Categories.Find(11)
               },
               new Product
               {
                   ProductName = "Cola (diyet)",
                   Scale = "kutu",
                   Calory = 0,
                   CategoryID = 11,
                   Category = context.Categories.Find(11)
               },
               new Product
               {
                   ProductName = "Cola (normal)",
                   Scale = "kutu",
                   Calory = 160,
                   CategoryID = 11,
                   Category = context.Categories.Find(11)
               },
               new Product
               {
                   ProductName = "Domates suyu",
                   Scale = "gr",
                   Calory = 16,
                   CategoryID = 11,
                   Category = context.Categories.Find(11)
               },
               new Product
               {
                   ProductName = "Gazoz",
                   Scale = "gr",
                   Calory = 39,
                   CategoryID = 11,
                   Category = context.Categories.Find(11)
               },
               new Product
               {
                   ProductName = "Ihlamur",
                   Scale = "gr",
                   Calory = 42,
                   CategoryID = 11,
                   Category = context.Categories.Find(11)
               },
               new Product
               {
                   ProductName = "Kahve (instant)",
                   Scale = "fincan",
                   Calory = 5,
                   CategoryID = 11,
                   Category = context.Categories.Find(11)
               },
               new Product
               {
                   ProductName = "Kırmızı şarap",
                   Scale = "kadeh",
                   Calory = 75,
                   CategoryID = 11,
                   Category = context.Categories.Find(11)
               },
               new Product
               {
                   ProductName = "Limonata",
                   Scale = "gr",
                   Calory = 21,
                   CategoryID = 11,
                   Category = context.Categories.Find(11)
               },
               new Product
               {
                   ProductName = "Meyve suyu",
                   Scale = "gr",
                   Calory = 31,
                   CategoryID = 11,
                   Category = context.Categories.Find(11)
               },
               new Product
               {
                   ProductName = "Portakal Suyu",
                   Scale = "gr",
                   Calory = 45,
                   CategoryID = 11,
                   Category = context.Categories.Find(11)
               },
               new Product
               {
                   ProductName = "Rose (şarap)",
                   Scale = "gr",
                   Calory = 71,
                   CategoryID = 11,
                   Category = context.Categories.Find(11)
               },
               new Product
               {
                   ProductName = "Viski",
                   Scale = "gr",
                   Calory = 263,
                   CategoryID = 11,
                   Category = context.Categories.Find(11)
               },
               new Product
               {
                   ProductName = "Votka",
                   Scale = "gr",
                   Calory = 275,
                   CategoryID = 11,
                   Category = context.Categories.Find(11)
               },
               new Product
               {
                   ProductName = "Az yağlı dana eti",
                   Scale = "gr",
                   Calory = 156,
                   CategoryID = 12,
                   Category = context.Categories.Find(12)
               },
               new Product
               {
                   ProductName = "Az yağlı domuz eti",
                   Scale = "gr",
                   Calory = 472,
                   CategoryID = 12,
                   Category = context.Categories.Find(12)
               },
               new Product
               {
                   ProductName = "Az yağlı koyun eti",
                   Scale = "gr",
                   Calory = 247,
                   CategoryID = 12,
                   Category = context.Categories.Find(12)
               },
               new Product
               {
                   ProductName = "Az yağlı sığır eti",
                   Scale = "gr",
                   Calory = 225,
                   CategoryID = 12,
                   Category = context.Categories.Find(12)
               },
               new Product
               {
                   ProductName = "Keçi eti",
                   Scale = "gr",
                   Calory = 145,
                   CategoryID = 12,
                   Category = context.Categories.Find(12)
               },
               new Product
               {
                   ProductName = "Orta yağlı dana eti",
                   Scale = "gr",
                   Calory = 190,
                   CategoryID = 12,
                   Category = context.Categories.Find(12)
               },
               new Product
               {
                   ProductName = "Orta yağlı domuz eti",
                   Scale = "gr",
                   Calory = 513,
                   CategoryID = 12,
                   Category = context.Categories.Find(12)
               },
               new Product
               {
                   ProductName = "Orta yağlı koyun eti",
                   Scale = "gr",
                   Calory = 263,
                   CategoryID = 12,
                   Category = context.Categories.Find(12)
               },
               new Product
               {
                   ProductName = "Orta yağlı sığır eti",
                   Scale = "gr",
                   Calory = 263,
                   CategoryID = 12,
                   Category = context.Categories.Find(12)
               },
               new Product
               {
                   ProductName = "Yağlı dana eti",
                   Scale = "gr",
                   Calory = 223,
                   CategoryID = 12,
                   Category = context.Categories.Find(12)
               },
               new Product
               {
                   ProductName = "Yağlı domuz eti",
                   Scale = "gr",
                   Calory = 553,
                   CategoryID = 12,
                   Category = context.Categories.Find(12)
               },
               new Product
               {
                   ProductName = "Yağlı koyun eti",
                   Scale = "gr",
                   Calory = 310,
                   CategoryID = 12,
                   Category = context.Categories.Find(12)
               },
               new Product
               {
                   ProductName = "Yağlı sığır eti",
                   Scale = "gr",
                   Calory = 301,
                   CategoryID = 12,
                   Category = context.Categories.Find(12)
               },
               new Product
               {
                   ProductName = "Ay çekirdeği",
                   Scale = "gr",
                   Calory = 560,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Badem",
                   Scale = "gr",
                   Calory = 598,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Bakla (İç)",
                   Scale = "gr",
                   Calory = 338,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Barbunya",
                   Scale = "gr",
                   Calory = 349,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Bezelye",
                   Scale = "gr",
                   Calory = 348,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Börülce",
                   Scale = "gr",
                   Calory = 343,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Ceviz",
                   Scale = "gr",
                   Calory = 651,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Çam Fıstığı",
                   Scale = "gr",
                   Calory = 635,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Fındık",
                   Scale = "gr",
                   Calory = 634,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Fıstık",
                   Scale = "gr",
                   Calory = 560,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Kuru Fasulye (beyaz)",
                   Scale = "gr",
                   Calory = 340,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Kabak Çekirdeği",
                   Scale = "gr",
                   Calory = 610,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Kavun,Karpuz Çekirdeği",
                   Scale = "gr",
                   Calory = 581,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Kestane",
                   Scale = "gr",
                   Calory = 194,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Kestane Haşlanmış",
                   Scale = "gr",
                   Calory = 131,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Kestane Kavrulmuş",
                   Scale = "gr",
                   Calory = 245,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Mercimek",
                   Scale = "gr",
                   Calory = 340,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Nohut",
                   Scale = "gr",
                   Calory = 360,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Palamut Çekirdeği",
                   Scale = "gr",
                   Calory = 268,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Soya Fasulyesi",
                   Scale = "gr",
                   Calory = 403,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Soya Unu (az yağlı)",
                   Scale = "gr",
                   Calory = 356,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Soya Unu (yağsız)",
                   Scale = "gr",
                   Calory = 326,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Susam",
                   Scale = "gr",
                   Calory = 582,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Şam Fıstığı",
                   Scale = "gr",
                   Calory = 594,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Yer Fıstığı",
                   Scale = "gr",
                   Calory = 582,
                   CategoryID = 13,
                   Category = context.Categories.Find(13)
               },
               new Product
               {
                   ProductName = "Hindi, et ve deri",
                   Scale = "gr",
                   Calory = 160,
                   CategoryID = 14,
                   Category = context.Categories.Find(14)
               },
               new Product
               {
                   ProductName = "Kaz",
                   Scale = "gr",
                   Calory = 371,
                   CategoryID = 14,
                   Category = context.Categories.Find(14)
               },
               new Product
               {
                   ProductName = "Ördek",
                   Scale = "gr",
                   Calory = 404,
                   CategoryID = 14,
                   Category = context.Categories.Find(14)
               },
               new Product
               {
                   ProductName = "Şehr. tavuk çorbası",
                   Scale = "pors.",
                   Calory = 75,
                   CategoryID = 14,
                   Category = context.Categories.Find(14)
               },
               new Product
               {
                   ProductName = "Tavuk bütün",
                   Scale = "gr",
                   Calory = 215,
                   CategoryID = 14,
                   Category = context.Categories.Find(14)
               },
               new Product
               {
                   ProductName = "Tavuk beyaz et (derili)",
                   Scale = "gr",
                   Calory = 186,
                   CategoryID = 14,
                   Category = context.Categories.Find(14)
               },
               new Product
               {
                   ProductName = "Tavuk beyaz et (derisiz)",
                   Scale = "gr",
                   Calory = 114,
                   CategoryID = 14,
                   Category = context.Categories.Find(14)
               },
               new Product
               {
                   ProductName = "Tavuk göğüs kızarmış",
                   Scale = "porsiyon",
                   Calory = 365,
                   CategoryID = 14,
                   Category = context.Categories.Find(14)
               },
               new Product
               {
                   ProductName = "Tavuk siyah et derisiz",
                   Scale = "gr",
                   Calory = 125,
                   CategoryID = 14,
                   Category = context.Categories.Find(14)
               },
               new Product
               {
                   ProductName = "Tavuk, deri",
                   Scale = "gr",
                   Calory = 349,
                   CategoryID = 14,
                   Category = context.Categories.Find(14)
               },
               new Product
               {
                   ProductName = "Tavuk, siyah et (derili)",
                   Scale = "gr",
                   Calory = 237,
                   CategoryID = 14,
                   Category = context.Categories.Find(14)
               },
               new Product
               {
                   ProductName = "Ahududu (Kırmızı)",
                   Scale = "gr",
                   Calory = 57,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Ahududu (Siyah)",
                   Scale = "gr",
                   Calory = 73,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Ananas",
                   Scale = "gr",
                   Calory = 52,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Armut",
                   Scale = "gr",
                   Calory = 61,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Avokado",
                   Scale = "gr",
                   Calory = 167,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Ayva",
                   Scale = "gr",
                   Calory = 57,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Böğürtlen",
                   Scale = "gr",
                   Calory = 58,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Çilek",
                   Scale = "gr",
                   Calory = 37,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Dut",
                   Scale = "gr",
                   Calory = 93,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Elma",
                   Scale = "gr",
                   Calory = 58,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Elma Suyu",
                   Scale = "gr",
                   Calory = 47,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Erik (Kırmızı)",
                   Scale = "gr",
                   Calory = 66,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Erik (Mürdüm)",
                   Scale = "gr",
                   Calory = 79,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Erik Mürdüm (Kuru)",
                   Scale = "gr",
                   Calory = 255,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Erik Pestil",
                   Scale = "gr",
                   Calory = 344,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Greyfurt",
                   Scale = "gr",
                   Calory = 41,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Greyfurt Suyu",
                   Scale = "gr",
                   Calory = 39,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Hurma",
                   Scale = "gr",
                   Calory = 274,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Hurma",
                   Scale = "adet",
                   Calory = 15,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "İncir (Kuru)",
                   Scale = "gr",
                   Calory = 274,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "İncir (Taze)",
                   Scale = "gr",
                   Calory = 80,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Karpuz",
                   Scale = "gr",
                   Calory = 26,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Kavun",
                   Scale = "gr",
                   Calory = 33,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Kayısı (Kuru)",
                   Scale = "gr",
                   Calory = 260,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Kayısı (Taze)",
                   Scale = "adet",
                   Calory = 17,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Kayısı Pestil",
                   Scale = "gr",
                   Calory = 332,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Kiraz",
                   Scale = "adet",
                   Calory = 5,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
               {
                   ProductName = "Kivi",
                   Scale = "gr",
                   Calory = 30,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
                {
                    ProductName = "Limon",
                    Scale = "gr",
                    Calory = 27,
                    CategoryID = 15,
                    Category = context.Categories.Find(15)
                },
               new Product
               {
                   ProductName = "Limon Suyu",
                   Scale = "gr",
                   Calory = 25,
                   CategoryID = 15,
                   Category = context.Categories.Find(15)
               },
               new Product
                {
                    ProductName = "Mandalina",
                    Scale = "gr",
                    Calory = 46,
                    CategoryID = 15,
                    Category = context.Categories.Find(15)
                },
               new Product
                {
                    ProductName = "Mandalina Suyu",
                    Scale = "gr",
                    Calory = 43,
                    CategoryID = 15,
                    Category = context.Categories.Find(15)
                },
               new Product
                {
                    ProductName = "Muz",
                    Scale = "gr",
                    Calory = 105,
                    CategoryID = 15,
                    Category = context.Categories.Find(15)
                },
               new Product
                {
                    ProductName = "Nar",
                    Scale = "gr",
                    Calory = 63,
                    CategoryID = 15,
                    Category = context.Categories.Find(15)
                },
               new Product
                {
                    ProductName = "Portakal",
                    Scale = "gr",
                    Calory = 49,
                    CategoryID = 15,
                    Category = context.Categories.Find(15)
                },
               new Product
                {
                    ProductName = "Şeftali",
                    Scale = "gr",
                    Calory = 38,
                    CategoryID = 15,
                    Category = context.Categories.Find(15)
                },
               new Product
                {
                    ProductName = "Üzüm (Kuru)",
                    Scale = "gr",
                    Calory = 289,
                    CategoryID = 15,
                    Category = context.Categories.Find(15)
                },
               new Product
                {
                    ProductName = "Üzüm (Taze)",
                    Scale = "gr",
                    Calory = 67,
                    CategoryID = 15,
                    Category = context.Categories.Find(15)
                },
               new Product
                {
                    ProductName = "Üzüm Suyu",
                    Scale = "gr",
                    Calory = 66,
                    CategoryID = 15,
                    Category = context.Categories.Find(15)
                },
               new Product
                {
                    ProductName = "Vişne",
                    Scale = "gr",
                    Calory = 58,
                    CategoryID = 15,
                    Category = context.Categories.Find(15)
                },
               new Product
                {
                    ProductName = "Bey. peynir (Edirne)",
                    Scale = "gr",
                    Calory = 235,
                    CategoryID = 16,
                    Category = context.Categories.Find(16)
                },
               new Product
                {
                    ProductName = "Bey. peynir (Urfa)",
                    Scale = "gr",
                    Calory = 312,
                    CategoryID = 16,
                    Category = context.Categories.Find(16)
                },
               new Product
                {
                    ProductName = "Bey. peynir (yağlı)",
                    Scale = "gr",
                    Calory = 289,
                    CategoryID = 16,
                    Category = context.Categories.Find(16)
                },
               new Product
                {
                    ProductName = "Bey.peynir (yağsız)",
                    Scale = "gr",
                    Calory = 99,
                    CategoryID = 16,
                    Category = context.Categories.Find(16)
                },
               new Product
                {
                    ProductName = "Cheddar",
                    Scale = "gr",
                    Calory = 403,
                    CategoryID = 16,
                    Category = context.Categories.Find(16)
                },
               new Product
                {
                    ProductName = "Çökelek (Kuru)",
                    Scale = "gr",
                    Calory = 379,
                    CategoryID = 16,
                    Category = context.Categories.Find(16)
                },
               new Product
                {
                    ProductName = "Çökelek (Taze)",
                    Scale = "gr",
                    Calory = 215,
                    CategoryID = 16,
                    Category = context.Categories.Find(16)
                },
               new Product
                {
                    ProductName = "Gravyer (%8 Tuzlu)",
                    Scale = "gr",
                    Calory = 413,
                    CategoryID = 16,
                    Category = context.Categories.Find(16)
                },
               new Product
               {
                   ProductName = "Kars Tipi",
                   Scale = "gr",
                   Calory = 357,
                   CategoryID = 16,
                   Category = context.Categories.Find(16)
               },
               new Product
               {
                   ProductName = "Kaşar Peyniri",
                   Scale = "gr",
                   Calory = 404,
                   CategoryID = 16,
                   Category = context.Categories.Find(16)
               },
               new Product
               {
                   ProductName = "Krem Peynir (Sade)",
                   Scale = "gr",
                   Calory = 349,
                   CategoryID = 16,
                   Category = context.Categories.Find(16)
               },
               new Product
               {
                   ProductName = "Lor peyniri (%1 yağ)",
                   Scale = "gr",
                   Calory = 72,
                   CategoryID = 16,
                   Category = context.Categories.Find(16)
               },
               new Product
               {
                   ProductName = "Lor peyniri (%2 yağ)",
                   Scale = "gr",
                   Calory = 90,
                   CategoryID = 16,
                   Category = context.Categories.Find(16)
               },
               new Product
               {
                   ProductName = "Lor peyniri (yağsız)",
                   Scale = "gr",
                   Calory = 85,
                   CategoryID = 16,
                   Category = context.Categories.Find(16)
               },
               new Product
               {
                   ProductName = "Otlu Peynir",
                   Scale = "gr",
                   Calory = 327,
                   CategoryID = 16,
                   Category = context.Categories.Find(16)
               },
               new Product
               {
                   ProductName = "Rokfor",
                   Scale = "gr",
                   Calory = 369,
                   CategoryID = 16,
                   Category = context.Categories.Find(16)
               },
               new Product
               {
                   ProductName = "Akciğer (dana)",
                   Scale = "gr",
                   Calory = 106,
                   CategoryID = 17,
                   Category = context.Categories.Find(17)
               },
               new Product
               {
                   ProductName = "Beyin",
                   Scale = "gr",
                   Calory = 125,
                   CategoryID = 17,
                   Category = context.Categories.Find(17)
               },
               new Product
               {
                   ProductName = "Böbrek (kuzu)",
                   Scale = "gr",
                   Calory = 105,
                   CategoryID = 17,
                   Category = context.Categories.Find(17)
               },
               new Product
               {
                   ProductName = "Dalak (sığır, dana)",
                   Scale = "gr",
                   Calory = 104,
                   CategoryID = 17,
                   Category = context.Categories.Find(17)
               },
               new Product
               {
                   ProductName = "Dil (dana)",
                   Scale = "gr",
                   Calory = 130,
                   CategoryID = 17,
                   Category = context.Categories.Find(17)
               },
               new Product
               {
                   ProductName = "İşkembe (sığır)",
                   Scale = "gr",
                   Calory = 100,
                   CategoryID = 17,
                   Category = context.Categories.Find(17)
               },
               new Product
               {
                   ProductName = "Karaciğer (dana)",
                   Scale = "gr",
                   Calory = 140,
                   CategoryID = 17,
                   Category = context.Categories.Find(17)
               },
               new Product
               {
                   ProductName = "Karaciğer (tavuk)",
                   Scale = "gr",
                   Calory = 129,
                   CategoryID = 17,
                   Category = context.Categories.Find(17)
               },
               new Product
               {
                   ProductName = "Yürek (dana)",
                   Scale = "gr",
                   Calory = 124,
                   CategoryID = 17,
                   Category = context.Categories.Find(17)
               },
               new Product
               {
                   ProductName = "Asma Yaprağı",
                   Scale = "gr",
                   Calory = 97,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Bamya (Kurutulmuş)",
                   Scale = "gr",
                   Calory = 266,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Bamya (taze)",
                   Scale = "gr",
                   Calory = 36,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Bezelye (İç)",
                   Scale = "gr",
                   Calory = 84,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Bezelye (Konserve)",
                   Scale = "gr",
                   Calory = 88,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Biber (Kurutulmuş)",
                   Scale = "gr",
                   Calory = 293,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Biber (Taze)",
                   Scale = "gr",
                   Calory = 22,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Börülce (Taze)",
                   Scale = "gr",
                   Calory = 127,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Brokoli",
                   Scale = "baş",
                   Calory = 40,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Domates (Kırmızı)",
                   Scale = "gr",
                   Calory = 25,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Domates (Yeşil)",
                   Scale = "gr",
                   Calory = 24,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Domates suyu",
                   Scale = "gr",
                   Calory = 19,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Ebegümeci",
                   Scale = "gr",
                   Calory = 47,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Enginar",
                   Scale = "gr",
                   Calory = 53,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Fasulye (Kurutulmuş)",
                   Scale = "gr",
                   Calory = 274,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Fasulye (Taze)",
                   Scale = "gr",
                   Calory = 32,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Havuç",
                   Scale = "gr",
                   Calory = 42,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Hıyar (Soyulmamış)",
                   Scale = "gr",
                   Calory = 15,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Hıyar (soyulmuş)",
                   Scale = "gr",
                   Calory = 14,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Hindibağ Otu",
                   Scale = "gr",
                   Calory = 53,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Ispanak",
                   Scale = "gr",
                   Calory = 26,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Kabak (Kış)",
                   Scale = "gr",
                   Calory = 26,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Kabak (Yaz)",
                   Scale = "gr",
                   Calory = 19,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Karnıbahar",
                   Scale = "gr",
                   Calory = 27,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Kereviz",
                   Scale = "gr",
                   Calory = 40,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Kırmızı Biber (Taze)",
                   Scale = "gr",
                   Calory = 93,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Kıvırcık",
                   Scale = "gr",
                   Calory = 20,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Konserve fasulye",
                   Scale = "gr",
                   Calory = 24,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Kuşkonmaz",
                   Scale = "gr",
                   Calory = 26,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Lahana (Beyaz)",
                   Scale = "gr",
                   Calory = 24,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Lahana (Brüksel)",
                   Scale = "gr",
                   Calory = 63,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Lahana (Kara)",
                   Scale = "gr",
                   Calory = 45,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Lahana (Kırmızı)",
                   Scale = "gr",
                   Calory = 31,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Madımak",
                   Scale = "gr",
                   Calory = 22,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Mantar",
                   Scale = "gr",
                   Calory = 28,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Marul",
                   Scale = "gr",
                   Calory = 14,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Maydonoz",
                   Scale = "gr",
                   Calory = 44,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Mısır (Taze)",
                   Scale = "gr",
                   Calory = 96,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Nane (Taze)",
                   Scale = "gr",
                   Calory = 65,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Pancar (Kırmızı)",
                   Scale = "gr",
                   Calory = 43,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Pancar (Yaprak)",
                   Scale = "gr",
                   Calory = 24,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Patates",
                   Scale = "gr",
                   Calory = 76,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Patates unu",
                   Scale = "gr",
                   Calory = 351,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Patlıcan (kurutul.)",
                   Scale = "gr",
                   Calory = 286,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Patlıcan (Taze)",
                   Scale = "gr",
                   Calory = 25,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Pazı",
                   Scale = "gr",
                   Calory = 33,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Pırasa",
                   Scale = "gr",
                   Calory = 52,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Roka",
                   Scale = "gr",
                   Calory = 33,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Sarmısak (Baş)",
                   Scale = "gr",
                   Calory = 137,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Sarmısak (Toz)",
                   Scale = "gr",
                   Calory = 332,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Semiz Otu",
                   Scale = "gr",
                   Calory = 32,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Soğan (Kuru)",
                   Scale = "gr",
                   Calory = 38,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Soğan (Toz)",
                   Scale = "gr",
                   Calory = 347,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Soğan (Yeşil)",
                   Scale = "gr",
                   Calory = 36,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Şalgam",
                   Scale = "gr",
                   Calory = 30,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Taze Bakla",
                   Scale = "gr",
                   Calory = 72,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Tere",
                   Scale = "gr",
                   Calory = 33,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Turp (Kırmızı)",
                   Scale = "gr",
                   Calory = 19,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Turp (Siyah)",
                   Scale = "gr",
                   Calory = 30,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Yer Elması",
                   Scale = "gr",
                   Calory = 75,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Yonca",
                   Scale = "gr",
                   Calory = 49,
                   CategoryID = 18,
                   Category = context.Categories.Find(18)
               },
               new Product
               {
                   ProductName = "Bin Ada Yağı",
                   Scale = "gr",
                   Calory = 377,
                   CategoryID = 19,
                   Category = context.Categories.Find(19)
               },
               new Product
               {
                   ProductName = "Fransız salata sosu",
                   Scale = "gr",
                   Calory = 430,
                   CategoryID = 19,
                   Category = context.Categories.Find(19)
               },
               new Product
               {
                   ProductName = "İtalyan salata sosu",
                   Scale = "gr",
                   Calory = 467,
                   CategoryID = 19,
                   Category = context.Categories.Find(19)
               },
               new Product
               {
                   ProductName = "Ketçap",
                   Scale = "gr",
                   Calory = 106,
                   CategoryID = 19,
                   Category = context.Categories.Find(19)
               },
               new Product
               {
                   ProductName = "Kıymalı Chili",
                   Scale = "bard.",
                   Calory = 340,
                   CategoryID = 19,
                   Category = context.Categories.Find(19)
               },
               new Product
               {
                   ProductName = "Krema (%50 yağ, süt)",
                   Scale = "gr",
                   Calory = 134,
                   CategoryID = 19,
                   Category = context.Categories.Find(19)
               },
               new Product
               {
                   ProductName = "Mayonez",
                   Scale = "gr",
                   Calory = 390,
                   CategoryID = 19,
                   Category = context.Categories.Find(19)
               },
               new Product
               {
                   ProductName = "Salata sosu (yağlı)",
                   Scale = "gr",
                   Calory = 449,
                   CategoryID = 19,
                   Category = context.Categories.Find(19)
               },
               new Product
               {
                   ProductName = "Salça",
                   Scale = "gr",
                   Calory = 98,
                   CategoryID = 19,
                   Category = context.Categories.Find(19)
               },
               new Product
               {
                   ProductName = "Soya Sosu",
                   Scale = "gr",
                   Calory = 68,
                   CategoryID = 19,
                   Category = context.Categories.Find(19)
               },
               new Product
               {
                   ProductName = "Anne sütü",
                   Scale = "gr",
                   Calory = 70,
                   CategoryID = 20,
                   Category = context.Categories.Find(20)
               },
               new Product
               {
                   ProductName = "İnek (1/2 yağlı)",
                   Scale = "gr",
                   Calory = 50,
                   CategoryID = 20,
                   Category = context.Categories.Find(20)
               },
               new Product
               {
                   ProductName = "İnek (Yağlı)",
                   Scale = "gr",
                   Calory = 61,
                   CategoryID = 20,
                   Category = context.Categories.Find(20)
               },
               new Product
               {
                   ProductName = "İnek (yağsız)",
                   Scale = "gr",
                   Calory = 35,
                   CategoryID = 20,
                   Category = context.Categories.Find(20)
               },
               new Product
               {
                   ProductName = "Keçi sütü",
                   Scale = "gr",
                   Calory = 69,
                   CategoryID = 20,
                   Category = context.Categories.Find(20)
               },
               new Product
               {
                   ProductName = "Koyun",
                   Scale = "gr",
                   Calory = 108,
                   CategoryID = 20,
                   Category = context.Categories.Find(20)
               },
               new Product
               {
                   ProductName = "Manda sütü",
                   Scale = "gr",
                   Calory = 97,
                   CategoryID = 20,
                   Category = context.Categories.Find(20)
               },
               new Product
               {
                   ProductName = "Soya",
                   Scale = "gr",
                   Calory = 33,
                   CategoryID = 20,
                   Category = context.Categories.Find(20)
               },
               new Product
               {
                   ProductName = "Süt Tozu (Yağlı)",
                   Scale = "gr",
                   Calory = 496,
                   CategoryID = 20,
                   Category = context.Categories.Find(20)
               },
               new Product
               {
                   ProductName = "Süt Tozu (Yağsız)",
                   Scale = "gr",
                   Calory = 362,
                   CategoryID = 20,
                   Category = context.Categories.Find(20)
               },
               new Product
               {
                   ProductName = "Yoğurt (1/2 yağlı)",
                   Scale = "gr",
                   Calory = 50,
                   CategoryID = 20,
                   Category = context.Categories.Find(20)
               },
               new Product
               {
                   ProductName = "Yoğurt (Yağlı)",
                   Scale = "gr",
                   Calory = 62,
                   CategoryID = 20,
                   Category = context.Categories.Find(20)
               },
               new Product
               {
                   ProductName = "Akide şekeri",
                   Scale = "gr",
                   Calory = 330,
                   CategoryID = 21,
                   Category = context.Categories.Find(21)
               },
               new Product
               {
                   ProductName = "Bal",
                   Scale = "gr",
                   Calory = 315,
                   CategoryID = 21,
                   Category = context.Categories.Find(21)
               },
               new Product
               {
                   ProductName = "Bisküvi",
                   Scale = "gr",
                   Calory = 418,
                   CategoryID = 21,
                   Category = context.Categories.Find(21)
               },
               new Product
               {
                   ProductName = "Bisküvi (pasta)",
                   Scale = "gr",
                   Calory = 462,
                   CategoryID = 21,
                   Category = context.Categories.Find(21)
               },
               new Product
               {
                   ProductName = "Çikolata (Bademli)",
                   Scale = "gr",
                   Calory = 532,
                   CategoryID = 21,
                   Category = context.Categories.Find(21)
               },
               new Product
               {
                   ProductName = "Çikolata (Fıstıklı)",
                   Scale = "gr",
                   Calory = 543,
                   CategoryID = 21,
                   Category = context.Categories.Find(21)
               },
               new Product
               {
                   ProductName = "Çikolata (Şekerli)",
                   Scale = "gr",
                   Calory = 528,
                   CategoryID = 21,
                   Category = context.Categories.Find(21)
               },
               new Product
               {
                   ProductName = "Çikolata (Şekersiz)",
                   Scale = "gr",
                   Calory = 477,
                   CategoryID = 21,
                   Category = context.Categories.Find(21)
               },
               new Product
               {
                   ProductName = "Dondurma (Sütlü)",
                   Scale = "gr",
                   Calory = 193,
                   CategoryID = 21,
                   Category = context.Categories.Find(21)
               },
               new Product
               {
                   ProductName = "Karamela",
                   Scale = "gr",
                   Calory = 399,
                   CategoryID = 21,
                   Category = context.Categories.Find(21)
               },
               new Product
               {
                   ProductName = "Lokum",
                   Scale = "gr",
                   Calory = 240,
                   CategoryID = 21,
                   Category = context.Categories.Find(21)
               },
               new Product
               {
                   ProductName = "Marmelat",
                   Scale = "gr",
                   Calory = 278,
                   CategoryID = 21,
                   Category = context.Categories.Find(21)
               },
               new Product
               {
                   ProductName = "Meyva şekerleme",
                   Scale = "gr",
                   Calory = 316,
                   CategoryID = 21,
                   Category = context.Categories.Find(21)
               },
               new Product
               {
                   ProductName = "Pekmez (Üzüm)",
                   Scale = "gr",
                   Calory = 293,
                   CategoryID = 21,
                   Category = context.Categories.Find(21)
               },
               new Product
               {
                   ProductName = "Reçel",
                   Scale = "gr",
                   Calory = 272,
                   CategoryID = 21,
                   Category = context.Categories.Find(21)
               },
               new Product
               {
                   ProductName = "Şeker",
                   Scale = "gr",
                   Calory = 385,
                   CategoryID = 21,
                   Category = context.Categories.Find(21)
               },
               new Product
               {
                   ProductName = "Tahin helvası",
                   Scale = "gr",
                   Calory = 516,
                   CategoryID = 21,
                   Category = context.Categories.Find(21)
               },
               new Product
               {
                   ProductName = "Arpa",
                   Scale = "gr",
                   Calory = 349,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Buğday (aşurelik)",
                   Scale = "gr",
                   Calory = 335,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Buğday (durum)",
                   Scale = "gr",
                   Calory = 332,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Bulgur",
                   Scale = "gr",
                   Calory = 357,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Corn Flakes",
                   Scale = "gr",
                   Calory = 386,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Çavdar Unu",
                   Scale = "gr",
                   Calory = 350,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Ekmek (beyaz)",
                   Scale = "dilim",
                   Calory = 90,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Ekmeklik",
                   Scale = "gr",
                   Calory = 365,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Kepek",
                   Scale = "gr",
                   Calory = 213,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Mısır (haşlan.)",
                   Scale = "gr",
                   Calory = 91,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Mısır unu",
                   Scale = "gr",
                   Calory = 368,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Mısır, tane",
                   Scale = "gr",
                   Calory = 362,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Nişasta",
                   Scale = "gr",
                   Calory = 362,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Patlamış mısır",
                   Scale = "gr",
                   Calory = 456,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Pirinç",
                   Scale = "gr",
                   Calory = 363,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Şehriye",
                   Scale = "gr",
                   Calory = 388,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Tarhana",
                   Scale = "gr",
                   Calory = 316,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Yulaf Unu",
                   Scale = "gr",
                   Calory = 388,
                   CategoryID = 22,
                   Category = context.Categories.Find(22)
               },
               new Product
               {
                   ProductName = "Cheesecake",
                   Scale = "dilim",
                   Calory = 280,
                   CategoryID = 23,
                   Category = context.Categories.Find(23)
               },
               new Product
               {
                   ProductName = "Cheesecake",
                   Scale = "bütün",
                   Calory = 3350,
                   CategoryID = 23,
                   Category = context.Categories.Find(23)
               },
               new Product
               {
                   ProductName = "Çikolatalı kurabiye",
                   Scale = "adet",
                   Calory = 45,
                   CategoryID = 23,
                   Category = context.Categories.Find(23)
               },
               new Product
               {
                   ProductName = "Elmalı turta",
                   Scale = "dilim",
                   Calory = 405,
                   CategoryID = 23,
                   Category = context.Categories.Find(23)
               },
               new Product
               {
                   ProductName = "Elmalı turta",
                   Scale = "bütün",
                   Calory = 2420,
                   CategoryID = 23,
                   Category = context.Categories.Find(23)
               },
               new Product
               {
                   ProductName = "Hanımgöbeği",
                   Scale = "gr",
                   Calory = 211,
                   CategoryID = 23,
                   Category = context.Categories.Find(23)
               },
               new Product
               {
                   ProductName = "Havuçlu kek",
                   Scale = "bütün",
                   Calory = 6175,
                   CategoryID = 23,
                   Category = context.Categories.Find(23)
               },
               new Product
               {
                   ProductName = "Havuçlu kek",
                   Scale = "dilim",
                   Calory = 385,
                   CategoryID = 23,
                   Category = context.Categories.Find(23)
               },
               new Product
               {
                   ProductName = "Hurma tatlısı",
                   Scale = "gr",
                   Calory = 318,
                   CategoryID = 23,
                   Category = context.Categories.Find(23)
               },
               new Product
               {
                   ProductName = "İrmik helvası",
                   Scale = "gr",
                   Calory = 302,
                   CategoryID = 23,
                   Category = context.Categories.Find(23)
               },
               new Product
               {
                   ProductName = "Jöle",
                   Scale = "gr",
                   Calory = 259,
                   CategoryID = 23,
                   Category = context.Categories.Find(23)
               },
               new Product
               {
                   ProductName = "Kastırd",
                   Scale = "gr",
                   Calory = 126,
                   CategoryID = 23,
                   Category = context.Categories.Find(23)
               },
               new Product
               {
                   ProductName = "Kek pasta",
                   Scale = "gr",
                   Calory = 364,
                   CategoryID = 23,
                   Category = context.Categories.Find(23)
               },
               new Product
               {
                   ProductName = "Muhallebi",
                   Scale = "gr",
                   Calory = 173,
                   CategoryID = 23,
                   Category = context.Categories.Find(23)
               },
               new Product
               {
                   ProductName = "Sütlaç",
                   Scale = "gr",
                   Calory = 139,
                   CategoryID = 23,
                   Category = context.Categories.Find(23)
               },
               new Product
               {
                   ProductName = "Tel kadayıf (fıstıklı)",
                   Scale = "gr",
                   Calory = 286,
                   CategoryID = 23,
                   Category = context.Categories.Find(23)
               },
               new Product
               {
                   ProductName = "Wafers",
                   Scale = "gr",
                   Calory = 535,
                   CategoryID = 23,
                   Category = context.Categories.Find(23)
               },
               new Product
               {
                   ProductName = "Bıldırcın yumurta",
                   Scale = "gr",
                   Calory = 158,
                   CategoryID = 24,
                   Category = context.Categories.Find(24)
               },
               new Product
               {
                   ProductName = "Kaz yumurta",
                   Scale = "gr",
                   Calory = 185,
                   CategoryID = 24,
                   Category = context.Categories.Find(24)
               },
               new Product
               {
                   ProductName = "Ördek yumurta",
                   Scale = "gr",
                   Calory = 185,
                   CategoryID = 24,
                   Category = context.Categories.Find(24)
               },
               new Product
               {
                   ProductName = "Tavuk yumurta (beyaz)",
                   Scale = "gr",
                   Calory = 49,
                   CategoryID = 24,
                   Category = context.Categories.Find(24)
               },
               new Product
               {
                   ProductName = "Tavuk yumurta (sarı)",
                   Scale = "gr",
                   Calory = 369,
                   CategoryID = 24,
                   Category = context.Categories.Find(24)
               },
               new Product
               {
                   ProductName = "Tavuk yumurta (tam)",
                   Scale = "gr",
                   Calory = 158,
                   CategoryID = 24,
                   Category = context.Categories.Find(24)
               }

            );

            #endregion Ürünleri Ekliyoruz
        }
    }
}