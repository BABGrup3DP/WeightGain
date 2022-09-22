using System;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
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
            try
            {
                #region Admin kullanıcıları ekliyoruz.

                context.Users.AddOrUpdate(x => x.ID,
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

                context.Users.AddOrUpdate(x => x.ID,
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

                context.Users.AddOrUpdate(x => x.ID,
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

                context.Categories.AddOrUpdate(x => x.CategoryID,
                    new Category
                    {
                        Name = "BALIKLAR",
                        Description = "",
                        // // Picture = new byte[] { }
                    },
                    new Category
                    {
                        Name = "ÇORBALAR",
                        Description = "",
                        // // Picture = new byte[] { }
                    },
                    new Category
                    {
                        Name = "EKMEK VB. ÜRÜNLER",
                        Description = "",
                        // // Picture = new byte[] { }
                    },
                    new Category
                    {
                        Name = "İÇECEKLER",
                        Description = "",
                        // // Picture = new byte[] { }
                    },
                    new Category
                    {
                        Name = "ANA YEMEKLER",
                        Description = "",
                        // Picture = new byte[] { }
                    },
                    new Category
                    {
                        Name = "ZEYTİNYAĞLI & SALATALAR",
                        Description = "",
                        // Picture = new byte[] { }
                    },
                    new Category
                    {
                        Name = "KURUBAKLAGİLLER",
                        Description = "",
                        // Picture = new byte[] { }
                    },
                    new Category
                    {
                        Name = "MEYVELER",
                        Description = "",
                        // Picture = new byte[] { }
                    },
                    new Category
                    {
                        Name = "KAHVALTILIKLAR",
                        Description = "",
                        // Picture = new byte[] { }
                    },
                    new Category
                    {
                        Name = "TATLILAR",
                        Description = "",
                        // Picture = new byte[] { }
                    }
                );
                context.SaveChanges();
                #endregion Kategorileri Ekliyoruz

                #region Ürünleri Ekliyoruz

                context.Products.AddOrUpdate(x => x.ProductID,
                new Product
                {
                    ProductName = "Alabalık",
                    Scale = "gr",
                    Calory = 175,
                    CategoryID = 1,
                    Category = context.Categories.Find(1)
                },
                new Product
                {
                    ProductName = "Kalkan",
                    Scale = "gr",
                    Calory = 193,
                    CategoryID = 1,
                    Category = context.Categories.Find(1)
                },
                new Product
                {
                    ProductName = "Kılıç",
                    Scale = "gr",
                    Calory = 164,
                    CategoryID = 1,
                    Category = context.Categories.Find(1)
                },
                new Product
                {
                    ProductName = "Levrek",
                    Scale = "gr",
                    Calory = 93,
                    CategoryID = 1,
                    Category = context.Categories.Find(1)
                },
                new Product
                {
                    ProductName = "Ton",
                    Scale = "gr",
                    Calory = 289,
                    CategoryID = 1,
                    Category = context.Categories.Find(1)
                },
                new Product
                {
                    ProductName = "Domates",
                    Scale = "gr",
                    Calory = 219,
                    CategoryID = 2,
                    Category = context.Categories.Find(2)
                },
                new Product
                {
                    ProductName = "Ezogelin",
                    Scale = "gr",
                    Calory = 274,
                    CategoryID = 2,
                    Category = context.Categories.Find(2)
                },
                new Product
                {
                    ProductName = "İşkembe",
                    Scale = "gr",
                    Calory = 342,
                    CategoryID = 2,
                    Category = context.Categories.Find(2)
                },
                new Product
                {
                    ProductName = "Mercimek",
                    Scale = "gr",
                    Calory = 235,
                    CategoryID = 2,
                    Category = context.Categories.Find(2)
                },
                new Product
                {
                    ProductName = "Tarhana",
                    Scale = "gr",
                    Calory = 280,
                    CategoryID = 2,
                    Category = context.Categories.Find(2)
                },
                new Product
                {
                    ProductName = "Yayla",
                    Scale = "gr",
                    Calory = 252,
                    CategoryID = 2,
                    Category = context.Categories.Find(2)
                },
                new Product
                {
                    ProductName = "Ekmek (buğday)",
                    Scale = "gr",
                    Calory = 276,
                    CategoryID = 3,
                    Category = context.Categories.Find(3)
                },
                new Product
                {
                    ProductName = "Ekmek (çavdar)",
                    Scale = "gr",
                    Calory = 243,
                    CategoryID = 3,
                    Category = context.Categories.Find(3)
                },
                new Product
                {
                    ProductName = "Ekmek (kepek)",
                    Scale = "Dilim",
                    Calory = 60,
                    CategoryID = 3,
                    Category = context.Categories.Find(3)
                },
                new Product
                {
                    ProductName = "Çay",
                    Scale = "gr",
                    Calory = 39,
                    CategoryID = 4,
                    Category = context.Categories.Find(4)
                },
                new Product
                {
                    ProductName = "Süt",
                    Scale = "gr",
                    Calory = 70,
                    CategoryID = 4,
                    Category = context.Categories.Find(4)
                },
                new Product
                {
                    ProductName = "Adaçayı",
                    Scale = "gr",
                    Calory = 315,
                    CategoryID = 4,
                    Category = context.Categories.Find(4)
                },
                new Product
                {
                    ProductName = "Cola (diyet)",
                    Scale = "kutu",
                    Calory = 0,
                    CategoryID = 4,
                    Category = context.Categories.Find(4)
                },
                new Product
                {
                    ProductName = "Cola (normal)",
                    Scale = "kutu",
                    Calory = 160,
                    CategoryID = 4,
                    Category = context.Categories.Find(4)
                },
                new Product
                {
                    ProductName = "Domates suyu",
                    Scale = "gr",
                    Calory = 16,
                    CategoryID = 4,
                    Category = context.Categories.Find(4)
                },
                new Product
                {
                    ProductName = "Gazoz",
                    Scale = "gr",
                    Calory = 39,
                    CategoryID = 4,
                    Category = context.Categories.Find(4)
                },
                new Product
                {
                    ProductName = "Kahve",
                    Scale = "fincan",
                    Calory = 5,
                    CategoryID = 4,
                    Category = context.Categories.Find(4)
                },
                new Product
                {
                    ProductName = "Limonata",
                    Scale = "gr",
                    Calory = 21,
                    CategoryID = 4,
                    Category = context.Categories.Find(4)
                },
                new Product
                {
                    ProductName = "Meyve suyu",
                    Scale = "gr",
                    Calory = 31,
                    CategoryID = 4,
                    Category = context.Categories.Find(4)
                },
                new Product
                {
                    ProductName = "Portakal Suyu",
                    Scale = "gr",
                    Calory = 45,
                    CategoryID = 4,
                    Category = context.Categories.Find(4)
                },
                new Product
                {
                    ProductName = "Sebzeli Güveç",
                    Scale = "gr",
                    Calory = 156,
                    CategoryID = 5,
                    Category = context.Categories.Find(5)
                },
                new Product
                {
                    ProductName = "Pizza",
                    Scale = "gr",
                    Calory = 472,
                    CategoryID = 5,
                    Category = context.Categories.Find(5)
                },
                new Product
                {
                    ProductName = "Makarna",
                    Scale = "gr",
                    Calory = 369,
                    CategoryID = 5,
                    Category = context.Categories.Find(5)
                },
                new Product
                {
                    ProductName = "Köfte",
                    Scale = "gr",
                    Calory = 225,
                    CategoryID = 5,
                    Category = context.Categories.Find(5)
                },
                new Product
                {
                    ProductName = "Adana",
                    Scale = "gr",
                    Calory = 190,
                    CategoryID = 5,
                    Category = context.Categories.Find(5)
                },
                new Product
                {
                    ProductName = "Et Sote",
                    Scale = "gr",
                    Calory = 0,
                    CategoryID = 5,
                    Category = context.Categories.Find(5)
                },
                new Product
                {
                    ProductName = "Tavuk Sote",
                    Scale = "gr",
                    Calory = 450,
                    CategoryID = 5,
                    Category = context.Categories.Find(5)
                },
                new Product
                {
                    ProductName = "Lahmacun",
                    Scale = "gr",
                    Calory = 400,
                    CategoryID = 5,
                    Category = context.Categories.Find(5)
                },
                new Product
                {
                    ProductName = "Pilav",
                    Scale = "gr",
                    Calory = 380,
                    CategoryID = 5,
                    Category = context.Categories.Find(5)
                },
                new Product
                {
                    ProductName = "Su Böreği",
                    Scale = "gr",
                    Calory = 456,
                    CategoryID = 5,
                    Category = context.Categories.Find(5)
                },
                new Product
                {
                    ProductName = "Kuru Fasulye",
                    Scale = "gr",
                    Calory = 310,
                    CategoryID = 5,
                    Category = context.Categories.Find(5)
                },
                new Product
                {
                    ProductName = "Bonfile&Pirzola",
                    Scale = "gr",
                    Calory = 315,
                    CategoryID = 5,
                    Category = context.Categories.Find(5)
                },
                new Product
                {
                    ProductName = "Etli Mercimek",
                    Scale = "gr",
                    Calory = 380,
                    CategoryID = 5,
                    Category = context.Categories.Find(5)
                },
                new Product
                {
                    ProductName = "Karnıyarık",
                    Scale = "gr",
                    Calory = 347,
                    CategoryID = 5,
                    Category = context.Categories.Find(5)
                },
                new Product
                {
                    ProductName = "Ali Nazik",
                    Scale = "gr",
                    Calory = 301,
                    CategoryID = 5,
                    Category = context.Categories.Find(5)
                },
                new Product
                {
                    ProductName = "Zeytin Yağlı Sarma&Dolma",
                    Scale = "gr",
                    Calory = 210,
                    CategoryID = 6,
                    Category = context.Categories.Find(6)
                },
                new Product
                {
                    ProductName = "Zeytinyağlı Fasulye",
                    Scale = "gr",
                    Calory = 230,
                    CategoryID = 6,
                    Category = context.Categories.Find(6)
                },
                new Product
                {
                    ProductName = "Mevsim Salata",
                    Scale = "gr",
                    Calory = 220,
                    CategoryID = 6,
                    Category = context.Categories.Find(6)
                },
                new Product
                {
                    ProductName = "Kereviz Yemeği",
                    Scale = "gr",
                    Calory = 215,
                    CategoryID = 6,
                    Category = context.Categories.Find(6)
                },
                new Product
                {
                    ProductName = "Taze Bamya",
                    Scale = "gr",
                    Calory = 190,
                    CategoryID = 6,
                    Category = context.Categories.Find(6)
                },
                new Product
                {
                    ProductName = "Ispanak",
                    Scale = "gr",
                    Calory = 200,
                    CategoryID = 6,
                    Category = context.Categories.Find(6)
                },
                new Product
                {
                    ProductName = "Badem",
                    Scale = "gr",
                    Calory = 598,
                    CategoryID = 7,
                    Category = context.Categories.Find(7)
                },
                new Product
                {
                    ProductName = "Ceviz",
                    Scale = "gr",
                    Calory = 651,
                    CategoryID = 7,
                    Category = context.Categories.Find(7)
                },
                new Product
                {
                    ProductName = "Fındık",
                    Scale = "gr",
                    Calory = 634,
                    CategoryID = 7,
                    Category = context.Categories.Find(7)
                },
                new Product
                {
                    ProductName = "Fıstık",
                    Scale = "gr",
                    Calory = 560,
                    CategoryID = 7,
                    Category = context.Categories.Find(7)
                },
                new Product
                {
                    ProductName = "Ananas",
                    Scale = "gr",
                    Calory = 52,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "Armut",
                    Scale = "gr",
                    Calory = 61,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "Avokado",
                    Scale = "gr",
                    Calory = 167,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "Çilek",
                    Scale = "gr",
                    Calory = 37,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "Elma",
                    Scale = "gr",
                    Calory = 58,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "Greyfurt",
                    Scale = "gr",
                    Calory = 41,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "İncir",
                    Scale = "gr",
                    Calory = 80,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "Karpuz",
                    Scale = "gr",
                    Calory = 26,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "Kavun",
                    Scale = "gr",
                    Calory = 33,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "Kayısı",
                    Scale = "adet",
                    Calory = 17,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "Kiraz",
                    Scale = "adet",
                    Calory = 5,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "Kivi",
                    Scale = "gr",
                    Calory = 30,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "Limon",
                    Scale = "gr",
                    Calory = 27,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "Mandalina",
                    Scale = "gr",
                    Calory = 46,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "Muz",
                    Scale = "gr",
                    Calory = 105,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "Portakal",
                    Scale = "gr",
                    Calory = 49,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "Şeftali",
                    Scale = "gr",
                    Calory = 38,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "Vişne",
                    Scale = "gr",
                    Calory = 58,
                    CategoryID = 8,
                    Category = context.Categories.Find(8)
                },
                new Product
                {
                    ProductName = "Haşlanmış Yumurta",
                    Scale = "gr",
                    Calory = 158,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Omlet",
                    Scale = "gr",
                    Calory = 185,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Bal",
                    Scale = "gr",
                    Calory = 315,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Tereyağı",
                    Scale = "gr",
                    Calory = 310,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Domates",
                    Scale = "gr",
                    Calory = 27,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Salatalık",
                    Scale = "gr",
                    Calory = 27,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Zeytin",
                    Scale = "gr",
                    Calory = 289,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Kızartma",
                    Scale = "gr",
                    Calory = 450,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Yoğurt",
                    Scale = "gr",
                    Calory = 62,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Bey. peynir",
                    Scale = "gr",
                    Calory = 289,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Çökelek",
                    Scale = "gr",
                    Calory = 215,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Kaşar Peyniri",
                    Scale = "gr",
                    Calory = 404,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Krem Peynir (Sade)",
                    Scale = "gr",
                    Calory = 349,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Otlu Peynir",
                    Scale = "gr",
                    Calory = 327,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Çikolata (Bademli)",
                    Scale = "gr",
                    Calory = 532,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Çikolata (Fıstıklı)",
                    Scale = "gr",
                    Calory = 543,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Pekmez (Üzüm)",
                    Scale = "gr",
                    Calory = 293,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Reçel",
                    Scale = "gr",
                    Calory = 272,
                    CategoryID = 9,
                    Category = context.Categories.Find(9)
                },
                new Product
                {
                    ProductName = "Cheesecake",
                    Scale = "dilim",
                    Calory = 280,
                    CategoryID = 10,
                    Category = context.Categories.Find(10)
                },
                new Product
                {
                    ProductName = "Elmalı turta",
                    Scale = "bütün",
                    Calory = 2420,
                    CategoryID = 10,
                    Category = context.Categories.Find(10)
                },
                new Product
                {
                    ProductName = "Hanımgöbeği",
                    Scale = "gr",
                    Calory = 211,
                    CategoryID = 10,
                    Category = context.Categories.Find(10)
                },
                new Product
                {
                    ProductName = "Havuçlu kek",
                    Scale = "dilim",
                    Calory = 385,
                    CategoryID = 10,
                    Category = context.Categories.Find(10)
                },
                new Product
                {
                    ProductName = "İrmik helvası",
                    Scale = "gr",
                    Calory = 302,
                    CategoryID = 10,
                    Category = context.Categories.Find(10)
                },
                new Product
                {
                    ProductName = "Kek pasta",
                    Scale = "gr",
                    Calory = 364,
                    CategoryID = 10,
                    Category = context.Categories.Find(10)
                },
                new Product
                {
                    ProductName = "Sütlaç",
                    Scale = "gr",
                    Calory = 139,
                    CategoryID = 10,
                    Category = context.Categories.Find(10)
                },
                new Product
                {
                    ProductName = "Dondurma (Sütlü)",
                    Scale = "gr",
                    Calory = 193,
                    CategoryID = 10,
                    Category = context.Categories.Find(10)
                }

                );

                #endregion Ürünleri Ekliyoruz
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            #endregion
        }
    }
}