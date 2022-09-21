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
            //try
            //{
            //    #region Admin kullanıcıları ekliyoruz.

            //    context.Users.AddOrUpdate(x => x.ID,
            //        new User
            //        {
            //            FirstName = "Yüksel",
            //            LastName = "Güzel",
            //            Email = "yuksel.guzel@bilgeadamboost.com",
            //            Password = Helper.GeneratePasswordHash("123456"),
            //            BirthDate = DateTime.Now.AddYears(-19),
            //            Weight = 45,
            //            Height = 160,
            //            PhoneNumber = "51111111111",
            //            UserType = UserTypeEnum.Admin
            //        },
            //        new User
            //        {
            //            FirstName = "Fatma",
            //            LastName = "Çiftçi",
            //            Email = "fatma.ciftci@bilgeadamboost.com",
            //            Password = Helper.GeneratePasswordHash("123456"),
            //            BirthDate = DateTime.Now.AddYears(-19),
            //            Weight = 45,
            //            Height = 160,
            //            PhoneNumber = "52222222222",
            //            UserType = UserTypeEnum.Admin
            //        },
            //        new User
            //        {
            //            FirstName = "Çağatay",
            //            LastName = "Korkut",
            //            Email = "cagatay.korkut@bilgeadamboost.com",
            //            Password = Helper.GeneratePasswordHash("123456"),
            //            BirthDate = DateTime.Now.AddYears(-19),
            //            Weight = 45,
            //            Height = 160,
            //            PhoneNumber = "53333333333",
            //            UserType = UserTypeEnum.Admin
            //        });

            //    #endregion Admin kullanıcıları ekliyoruz.

            //    #region Diyetisyen kullanıcıları ekliyoruz.

            //    context.Users.AddOrUpdate(x => x.ID,
            //        new User
            //        {
            //            FirstName = "Diyetisyen",
            //            LastName = "Deneme",
            //            Email = "deneme@bilgeadamboost.com",
            //            Password = Helper.GeneratePasswordHash("123456"),
            //            BirthDate = DateTime.Now.AddYears(-19),
            //            Weight = 45,
            //            Height = 160,
            //            UserType = UserTypeEnum.Dietitian
            //        });

            //    #endregion Diyetisyen kullanıcıları ekliyoruz.

            //    #region Normal kullanıcıları ekliyoruz.

            //    context.Users.AddOrUpdate(x => x.ID,
            //        new User
            //        {
            //            FirstName = "Kullanıcı Adı",
            //            LastName = "Kullanıcı Soyadı",
            //            Email = "ilkkullanici@bilgeadamboost.com",
            //            Password = Helper.GeneratePasswordHash("123456"),
            //            BirthDate = DateTime.Now.AddYears(-19),
            //            Weight = 45,
            //            Height = 160,
            //            PhoneNumber = "11111111111",
            //            UserType = UserTypeEnum.User
            //        },
            //        new User
            //        {
            //            FirstName = "Kullanıcı Adı 2",
            //            LastName = "Kullanıcı Soyadı 2",
            //            Email = "ikincikullanici@bilgeadamboost.com",
            //            Password = Helper.GeneratePasswordHash("123456"),
            //            BirthDate = DateTime.Now.AddYears(-21),
            //            Weight = 55,
            //            Height = 180,
            //            PhoneNumber = "22222222222",
            //            UserType = UserTypeEnum.User
            //        }
            //    );

            //    #endregion Normal kullanıcıları ekliyoruz.

            //    #region Kategorileri Ekliyoruz

            //    context.Categories.AddOrUpdate(x => x.CategoryID,
            //        new Category
            //        {
            //            Name = "AV HAYVANLARI",
            //            Description = "",
            //            // // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "BALIKLAR",
            //            Description = "",
            //            // // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "BİTKİSEL YAĞLAR",
            //            Description = "",
            //            // // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "ÇEŞNİLER",
            //            Description = "",
            //            // // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "ÇORBALAR",
            //            Description = "",
            //            // // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "DENİZ ÜRÜNLERİ",
            //            Description = "",
            //            // // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "DİĞER BESİNLER",
            //            Description = "",
            //            // // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "EKMEK VB. ÜRÜNLER",
            //            Description = "",
            //            // // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "ET ÜRÜNLERİ",
            //            Description = "",
            //            // // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "HAYVANSAL YAĞLAR",
            //            Description = "",
            //            // // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "İÇECEKLER",
            //            Description = "",
            //            // // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "KIRMIZI ETLER",
            //            Description = "",
            //            // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "KURUBAKLAGİLLER",
            //            Description = "",
            //            // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "KÜMES HAYVANLARI",
            //            Description = "",
            //            // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "MEYVELER",
            //            Description = "",
            //            // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "PEYNİRLER",
            //            Description = "",
            //            // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "SAKATATLAR",
            //            Description = "",
            //            // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "SEBZELER",
            //            Description = "",
            //            // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "SOSLAR",
            //            Description = "",
            //            // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "SÜT VE ÜRÜNLERİ",
            //            Description = "",
            //            // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "ŞEKER ve ŞEKER ÜRÜNLERİ",
            //            Description = "",
            //            // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "TAHIL ÜRÜNLERİ",
            //            Description = "",
            //            // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "TATLILAR",
            //            Description = "",
            //            // Picture = new byte[] { }
            //        },
            //        new Category
            //        {
            //            Name = "YUMURTALAR",
            //            Description = "",
            //            // Picture = new byte[] { }
            //        }
            //    );
            //    context.SaveChanges();
            //    #endregion Kategorileri Ekliyoruz

            //    #region Ürünleri Ekliyoruz

            //    context.Products.AddOrUpdate(x => x.ProductID,
            //        new Product
            //        {
            //            ProductName = "Bıldırcın",
            //            Scale = "porsiyon",
            //            Calory = 192,
            //            CategoryID = 1,
            //            Category = context.Categories.Find(1)
            //        },
            //        new Product
            //        {
            //            ProductName = "Güvercin",
            //            Scale = "porsiyon",
            //            Calory = 294,
            //            CategoryID = 1,
            //            Category = context.Categories.Find(1)
            //        },
            //        new Product
            //        {
            //            ProductName = "Sülün",
            //            Scale = "porsiyon",
            //            Calory = 181,
            //            CategoryID = 1,
            //            Category = context.Categories.Find(1)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tavşan",
            //            Scale = "porsiyon",
            //            Calory = 162,
            //            CategoryID = 1,
            //            Category = context.Categories.Find(1)
            //        },
            //        new Product
            //        {
            //            ProductName = "Alabalık",
            //            Scale = "porsiyon",
            //            Calory = 175,
            //            CategoryID = 2,
            //            Category = context.Categories.Find(2)
            //        },
            //        new Product
            //        {
            //            ProductName = "Balık Unu",
            //            Scale = "porsiyon",
            //            Calory = 336,
            //            CategoryID = 2,
            //            Category = context.Categories.Find(2)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kalkan",
            //            Scale = "porsiyon",
            //            Calory = 193,
            //            CategoryID = 2,
            //            Category = context.Categories.Find(2)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kılıç",
            //            Scale = "porsiyon",
            //            Calory = 164,
            //            CategoryID = 2,
            //            Category = context.Categories.Find(2)
            //        },
            //        new Product
            //        {
            //            ProductName = "Levrek",
            //            Scale = "porsiyon",
            //            Calory = 93,
            //            CategoryID = 2,
            //            Category = context.Categories.Find(2)
            //        },
            //        new Product
            //        {
            //            ProductName = "Mersin",
            //            Scale = "porsiyon",
            //            Calory = 96,
            //            CategoryID = 2,
            //            Category = context.Categories.Find(2)
            //        },
            //        new Product
            //        {
            //            ProductName = "Palamut",
            //            Scale = "porsiyon",
            //            Calory = 168,
            //            CategoryID = 2,
            //            Category = context.Categories.Find(2)
            //        },
            //        new Product
            //        {
            //            ProductName = "Sardalya",
            //            Scale = "porsiyon",
            //            Calory = 160,
            //            CategoryID = 2,
            //            Category = context.Categories.Find(2)
            //        },
            //        new Product
            //        {
            //            ProductName = "Sardalya (konserve)",
            //            Scale = "porsiyon",
            //            Calory = 205,
            //            CategoryID = 2,
            //            Category = context.Categories.Find(2)
            //        },
            //        new Product
            //        {
            //            ProductName = "Somon",
            //            Scale = "porsiyon",
            //            Calory = 155,
            //            CategoryID = 2,
            //            Category = context.Categories.Find(2)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ton",
            //            Scale = "porsiyon",
            //            Calory = 289,
            //            CategoryID = 2,
            //            Category = context.Categories.Find(2)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tuzlu Balık",
            //            Scale = "porsiyon",
            //            Calory = 305,
            //            CategoryID = 2,
            //            Category = context.Categories.Find(2)
            //        },
            //        new Product
            //        {
            //            ProductName = "Uskumru",
            //            Scale = "porsiyon",
            //            Calory = 159,
            //            CategoryID = 2,
            //            Category = context.Categories.Find(2)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ayçiçeği Yağı",
            //            Scale = "porsiyon",
            //            Calory = 884,
            //            CategoryID = 3,
            //            Category = context.Categories.Find(3)
            //        },
            //        new Product
            //        {
            //            ProductName = "Fındık Yağı",
            //            Scale = "porsiyon",
            //            Calory = 884,
            //            CategoryID = 3,
            //            Category = context.Categories.Find(3)
            //        },
            //        new Product
            //        {
            //            ProductName = "Haşhaş Yağı",
            //            Scale = "porsiyon",
            //            Calory = 884,
            //            CategoryID = 3,
            //            Category = context.Categories.Find(3)
            //        },
            //        new Product
            //        {
            //            ProductName = "Keten tohumu yağı",
            //            Scale = "porsiyon",
            //            Calory = 884,
            //            CategoryID = 3,
            //            Category = context.Categories.Find(3)
            //        },
            //        new Product
            //        {
            //            ProductName = "Margarin (kahvaltılık)",
            //            Scale = "porsiyon",
            //            Calory = 719,
            //            CategoryID = 3,
            //            Category = context.Categories.Find(3)
            //        },
            //        new Product
            //        {
            //            ProductName = "Margarin (kahvaltılık)",
            //            Scale = "porsiyon",
            //            Calory = 720,
            //            CategoryID = 3,
            //            Category = context.Categories.Find(3)
            //        },
            //        new Product
            //        {
            //            ProductName = "Mısırözü Yağı",
            //            Scale = "porsiyon",
            //            Calory = 884,
            //            CategoryID = 3,
            //            Category = context.Categories.Find(3)
            //        },
            //        new Product
            //        {
            //            ProductName = "Nebati Yağ",
            //            Scale = "porsiyon",
            //            Calory = 900,
            //            CategoryID = 3,
            //            Category = context.Categories.Find(3)
            //        },
            //        new Product
            //        {
            //            ProductName = "Palmiye Yağı",
            //            Scale = "porsiyon",
            //            Calory = 884,
            //            CategoryID = 3,
            //            Category = context.Categories.Find(3)
            //        },
            //        new Product
            //        {
            //            ProductName = "Pamuk Yağı",
            //            Scale = "porsiyon",
            //            Calory = 884,
            //            CategoryID = 3,
            //            Category = context.Categories.Find(3)
            //        },
            //        new Product
            //        {
            //            ProductName = "Soya Yağı",
            //            Scale = "porsiyon",
            //            Calory = 884,
            //            CategoryID = 3,
            //            Category = context.Categories.Find(3)
            //        },
            //        new Product
            //        {
            //            ProductName = "Susam Yağı",
            //            Scale = "porsiyon",
            //            Calory = 884,
            //            CategoryID = 3,
            //            Category = context.Categories.Find(3)
            //        },
            //        new Product
            //        {
            //            ProductName = "Yerfıstığı Yağı",
            //            Scale = "porsiyon",
            //            Calory = 884,
            //            CategoryID = 3,
            //            Category = context.Categories.Find(3)
            //        },
            //        new Product
            //        {
            //            ProductName = "Zeytin Yağı",
            //            Scale = "porsiyon",
            //            Calory = 884,
            //            CategoryID = 3,
            //            Category = context.Categories.Find(3)
            //        },
            //        new Product
            //        {
            //            ProductName = "Defne Yaprağı",
            //            Scale = "porsiyon",
            //            Calory = 313,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Dere Otu (Kuru)",
            //            Scale = "porsiyon",
            //            Calory = 253,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Hardal (Toz)",
            //            Scale = "porsiyon",
            //            Calory = 469,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Haşhaş Tohumu",
            //            Scale = "porsiyon",
            //            Calory = 533,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Hindistan cevizi (Toz)",
            //            Scale = "porsiyon",
            //            Calory = 525,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kabartma tozu",
            //            Scale = "tatlı kaşığı",
            //            Calory = 5,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Karabiber",
            //            Scale = "porsiyon",
            //            Calory = 255,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Karanfil",
            //            Scale = "porsiyon",
            //            Calory = 323,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kekik",
            //            Scale = "porsiyon",
            //            Calory = 276,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kırmızıbiber (toz)",
            //            Scale = "porsiyon",
            //            Calory = 318,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kimyon (Toz)",
            //            Scale = "porsiyon",
            //            Calory = 375,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kuş üzümü",
            //            Scale = "porsiyon",
            //            Calory = 54,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Maydonoz (kuru)",
            //            Scale = "porsiyon",
            //            Calory = 276,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Nane (Kuru)",
            //            Scale = "porsiyon",
            //            Calory = 245,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Safran",
            //            Scale = "porsiyon",
            //            Calory = 310,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Sofra Tuzu",
            //            Scale = "porsiyon",
            //            Calory = 0,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tarçın (Toz)",
            //            Scale = "porsiyon",
            //            Calory = 261,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Zencefil",
            //            Scale = "porsiyon",
            //            Calory = 347,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Zerdecal",
            //            Scale = "porsiyon",
            //            Calory = 354,
            //            CategoryID = 4,
            //            Category = context.Categories.Find(4)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bezelye",
            //            Scale = "porsiyon",
            //            Calory = 295,
            //            CategoryID = 5,
            //            Category = context.Categories.Find(5)
            //        },
            //        new Product
            //        {
            //            ProductName = "Domates",
            //            Scale = "porsiyon",
            //            Calory = 219,
            //            CategoryID = 5,
            //            Category = context.Categories.Find(5)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ezogelin",
            //            Scale = "porsiyon",
            //            Calory = 274,
            //            CategoryID = 5,
            //            Category = context.Categories.Find(5)
            //        },
            //        new Product
            //        {
            //            ProductName = "İşkembe",
            //            Scale = "porsiyon",
            //            Calory = 342,
            //            CategoryID = 5,
            //            Category = context.Categories.Find(5)
            //        },
            //        new Product
            //        {
            //            ProductName = "Mercimek",
            //            Scale = "porsiyon",
            //            Calory = 235,
            //            CategoryID = 5,
            //            Category = context.Categories.Find(5)
            //        },
            //        new Product
            //        {
            //            ProductName = "Sebze",
            //            Scale = "porsiyon",
            //            Calory = 227,
            //            CategoryID = 5,
            //            Category = context.Categories.Find(5)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tarhana (Acı)",
            //            Scale = "porsiyon",
            //            Calory = 290,
            //            CategoryID = 5,
            //            Category = context.Categories.Find(5)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tarhana (tatlı)",
            //            Scale = "porsiyon",
            //            Calory = 280,
            //            CategoryID = 5,
            //            Category = context.Categories.Find(5)
            //        },
            //        new Product
            //        {
            //            ProductName = "Yayla",
            //            Scale = "porsiyon",
            //            Calory = 252,
            //            CategoryID = 5,
            //            Category = context.Categories.Find(5)
            //        },
            //        new Product
            //        {
            //            ProductName = "Yulaf çorbası",
            //            Scale = "porsiyon",
            //            Calory = 318,
            //            CategoryID = 5,
            //            Category = context.Categories.Find(5)
            //        },
            //        new Product
            //        {
            //            ProductName = "Havyar",
            //            Scale = "porsiyon",
            //            Calory = 262,
            //            CategoryID = 6,
            //            Category = context.Categories.Find(6)
            //        },
            //        new Product
            //        {
            //            ProductName = "İstakoz",
            //            Scale = "porsiyon",
            //            Calory = 91,
            //            CategoryID = 6,
            //            Category = context.Categories.Find(6)
            //        },
            //        new Product
            //        {
            //            ProductName = "İstiridye",
            //            Scale = "adet",
            //            Calory = 90,
            //            CategoryID = 6,
            //            Category = context.Categories.Find(6)
            //        },
            //        new Product
            //        {
            //            ProductName = "Karides",
            //            Scale = "porsiyon",
            //            Calory = 91,
            //            CategoryID = 6,
            //            Category = context.Categories.Find(6)
            //        },
            //        new Product
            //        {
            //            ProductName = "Midye",
            //            Scale = "porsiyon",
            //            Calory = 95,
            //            CategoryID = 6,
            //            Category = context.Categories.Find(6)
            //        },
            //        new Product
            //        {
            //            ProductName = "Yengeç (haşlanmış)",
            //            Scale = "porsiyon",
            //            Calory = 127,
            //            CategoryID = 6,
            //            Category = context.Categories.Find(6)
            //        },
            //        new Product
            //        {
            //            ProductName = "Jelatin",
            //            Scale = "porsiyon",
            //            Calory = 335,
            //            CategoryID = 7,
            //            Category = context.Categories.Find(7)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kakao",
            //            Scale = "porsiyon",
            //            Calory = 299,
            //            CategoryID = 7,
            //            Category = context.Categories.Find(7)
            //        },
            //        new Product
            //        {
            //            ProductName = "Maya (kuru)",
            //            Scale = "porsiyon",
            //            Calory = 282,
            //            CategoryID = 7,
            //            Category = context.Categories.Find(7)
            //        },
            //        new Product
            //        {
            //            ProductName = "Maya (Yaş)",
            //            Scale = "porsiyon",
            //            Calory = 86,
            //            CategoryID = 7,
            //            Category = context.Categories.Find(7)
            //        },
            //        new Product
            //        {
            //            ProductName = "Sirke",
            //            Scale = "porsiyon",
            //            Calory = 12,
            //            CategoryID = 7,
            //            Category = context.Categories.Find(7)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tahin",
            //            Scale = "porsiyon",
            //            Calory = 595,
            //            CategoryID = 7,
            //            Category = context.Categories.Find(7)
            //        },
            //        new Product
            //        {
            //            ProductName = "Turşu (Salatalık)",
            //            Scale = "porsiyon",
            //            Calory = 10,
            //            CategoryID = 7,
            //            Category = context.Categories.Find(7)
            //        },
            //        new Product
            //        {
            //            ProductName = "Zeytin (Siyah)",
            //            Scale = "porsiyon",
            //            Calory = 207,
            //            CategoryID = 7,
            //            Category = context.Categories.Find(7)
            //        },
            //        new Product
            //        {
            //            ProductName = "Zeytin (Yeşil)",
            //            Scale = "porsiyon",
            //            Calory = 144,
            //            CategoryID = 7,
            //            Category = context.Categories.Find(7)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ekmek (buğday)",
            //            Scale = "porsiyon",
            //            Calory = 276,
            //            CategoryID = 8,
            //            Category = context.Categories.Find(8)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ekmek (çavdar)",
            //            Scale = "porsiyon",
            //            Calory = 243,
            //            CategoryID = 8,
            //            Category = context.Categories.Find(8)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ekmek (kepek)",
            //            Scale = "Dilim",
            //            Calory = 60,
            //            CategoryID = 8,
            //            Category = context.Categories.Find(8)
            //        },
            //        new Product
            //        {
            //            ProductName = "Galeta Unu",
            //            Scale = "porsiyon",
            //            Calory = 392,
            //            CategoryID = 8,
            //            Category = context.Categories.Find(8)
            //        },
            //        new Product
            //        {
            //            ProductName = "Grissini",
            //            Scale = "porsiyon",
            //            Calory = 433,
            //            CategoryID = 8,
            //            Category = context.Categories.Find(8)
            //        },
            //        new Product
            //        {
            //            ProductName = "İrmik",
            //            Scale = "porsiyon",
            //            Calory = 371,
            //            CategoryID = 8,
            //            Category = context.Categories.Find(8)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kraker (Peynirli)",
            //            Scale = "porsiyon",
            //            Calory = 479,
            //            CategoryID = 8,
            //            Category = context.Categories.Find(8)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kraker (Sade)",
            //            Scale = "porsiyon",
            //            Calory = 384,
            //            CategoryID = 8,
            //            Category = context.Categories.Find(8)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kraker (tuzlu)",
            //            Scale = "porsiyon",
            //            Calory = 433,
            //            CategoryID = 8,
            //            Category = context.Categories.Find(8)
            //        },
            //        new Product
            //        {
            //            ProductName = "Makarna",
            //            Scale = "porsiyon",
            //            Calory = 369,
            //            CategoryID = 8,
            //            Category = context.Categories.Find(8)
            //        },
            //        new Product
            //        {
            //            ProductName = "Sandviç ekmeği",
            //            Scale = "porsiyon",
            //            Calory = 298,
            //            CategoryID = 8,
            //            Category = context.Categories.Find(8)
            //        },
            //        new Product
            //        {
            //            ProductName = "Yufka",
            //            Scale = "porsiyon",
            //            Calory = 271,
            //            CategoryID = 8,
            //            Category = context.Categories.Find(8)
            //        },
            //        new Product
            //        {
            //            ProductName = "Yufka (Böreklik)",
            //            Scale = "porsiyon",
            //            Calory = 152,
            //            CategoryID = 8,
            //            Category = context.Categories.Find(8)
            //        },
            //        new Product
            //        {
            //            ProductName = "Jambon",
            //            Scale = "porsiyon",
            //            Calory = 182,
            //            CategoryID = 9,
            //            Category = context.Categories.Find(9)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kavurma",
            //            Scale = "porsiyon",
            //            Calory = 670,
            //            CategoryID = 9,
            //            Category = context.Categories.Find(9)
            //        },
            //        new Product
            //        {
            //            ProductName = "Pastırma (çemenli)",
            //            Scale = "porsiyon",
            //            Calory = 250,
            //            CategoryID = 9,
            //            Category = context.Categories.Find(9)
            //        },
            //        new Product
            //        {
            //            ProductName = "Pastırma (çemensiz)",
            //            Scale = "porsiyon",
            //            Calory = 269,
            //            CategoryID = 9,
            //            Category = context.Categories.Find(9)
            //        },
            //        new Product
            //        {
            //            ProductName = "Salam",
            //            Scale = "porsiyon",
            //            Calory = 450,
            //            CategoryID = 9,
            //            Category = context.Categories.Find(9)
            //        },
            //        new Product
            //        {
            //            ProductName = "Sosis",
            //            Scale = "porsiyon",
            //            Calory = 322,
            //            CategoryID = 9,
            //            Category = context.Categories.Find(9)
            //        },
            //        new Product
            //        {
            //            ProductName = "Sucuk",
            //            Scale = "porsiyon",
            //            Calory = 452,
            //            CategoryID = 9,
            //            Category = context.Categories.Find(9)
            //        },
            //        new Product
            //        {
            //            ProductName = "Balık Yağı",
            //            Scale = "porsiyon",
            //            Calory = 900,
            //            CategoryID = 10,
            //            Category = context.Categories.Find(10)
            //        },
            //        new Product
            //        {
            //            ProductName = "İçyağı",
            //            Scale = "porsiyon",
            //            Calory = 758,
            //            CategoryID = 10,
            //            Category = context.Categories.Find(10)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kuyruk Yağı",
            //            Scale = "porsiyon",
            //            Calory = 902,
            //            CategoryID = 10,
            //            Category = context.Categories.Find(10)
            //        },
            //        new Product
            //        {
            //            ProductName = "Sade Yağ (erimiş)",
            //            Scale = "porsiyon",
            //            Calory = 890,
            //            CategoryID = 10,
            //            Category = context.Categories.Find(10)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tereyağı",
            //            Scale = "tatlı kaşığı",
            //            Calory = 100,
            //            CategoryID = 10,
            //            Category = context.Categories.Find(10)
            //        },
            //        new Product
            //        {
            //            ProductName = "Adaçayı",
            //            Scale = "porsiyon",
            //            Calory = 315,
            //            CategoryID = 11,
            //            Category = context.Categories.Find(11)
            //        },
            //        new Product
            //        {
            //            ProductName = "Beyaz şarap",
            //            Scale = "kadeh",
            //            Calory = 80,
            //            CategoryID = 11,
            //            Category = context.Categories.Find(11)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bira",
            //            Scale = "adet",
            //            Calory = 150,
            //            CategoryID = 11,
            //            Category = context.Categories.Find(11)
            //        },
            //        new Product
            //        {
            //            ProductName = "Cin",
            //            Scale = "porsiyon",
            //            Calory = 231,
            //            CategoryID = 11,
            //            Category = context.Categories.Find(11)
            //        },
            //        new Product
            //        {
            //            ProductName = "Cola (diyet)",
            //            Scale = "kutu",
            //            Calory = 0,
            //            CategoryID = 11,
            //            Category = context.Categories.Find(11)
            //        },
            //        new Product
            //        {
            //            ProductName = "Cola (normal)",
            //            Scale = "kutu",
            //            Calory = 160,
            //            CategoryID = 11,
            //            Category = context.Categories.Find(11)
            //        },
            //        new Product
            //        {
            //            ProductName = "Domates suyu",
            //            Scale = "porsiyon",
            //            Calory = 16,
            //            CategoryID = 11,
            //            Category = context.Categories.Find(11)
            //        },
            //        new Product
            //        {
            //            ProductName = "Gazoz",
            //            Scale = "porsiyon",
            //            Calory = 39,
            //            CategoryID = 11,
            //            Category = context.Categories.Find(11)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ihlamur",
            //            Scale = "porsiyon",
            //            Calory = 42,
            //            CategoryID = 11,
            //            Category = context.Categories.Find(11)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kahve (instant)",
            //            Scale = "fincan",
            //            Calory = 5,
            //            CategoryID = 11,
            //            Category = context.Categories.Find(11)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kırmızı şarap",
            //            Scale = "kadeh",
            //            Calory = 75,
            //            CategoryID = 11,
            //            Category = context.Categories.Find(11)
            //        },
            //        new Product
            //        {
            //            ProductName = "Limonata",
            //            Scale = "porsiyon",
            //            Calory = 21,
            //            CategoryID = 11,
            //            Category = context.Categories.Find(11)
            //        },
            //        new Product
            //        {
            //            ProductName = "Meyve suyu",
            //            Scale = "porsiyon",
            //            Calory = 31,
            //            CategoryID = 11,
            //            Category = context.Categories.Find(11)
            //        },
            //        new Product
            //        {
            //            ProductName = "Portakal Suyu",
            //            Scale = "porsiyon",
            //            Calory = 45,
            //            CategoryID = 11,
            //            Category = context.Categories.Find(11)
            //        },
            //        new Product
            //        {
            //            ProductName = "Rose (şarap)",
            //            Scale = "porsiyon",
            //            Calory = 71,
            //            CategoryID = 11,
            //            Category = context.Categories.Find(11)
            //        },
            //        new Product
            //        {
            //            ProductName = "Viski",
            //            Scale = "porsiyon",
            //            Calory = 263,
            //            CategoryID = 11,
            //            Category = context.Categories.Find(11)
            //        },
            //        new Product
            //        {
            //            ProductName = "Votka",
            //            Scale = "porsiyon",
            //            Calory = 275,
            //            CategoryID = 11,
            //            Category = context.Categories.Find(11)
            //        },
            //        new Product
            //        {
            //            ProductName = "Az yağlı dana eti",
            //            Scale = "porsiyon",
            //            Calory = 156,
            //            CategoryID = 12,
            //            Category = context.Categories.Find(12)
            //        },
            //        new Product
            //        {
            //            ProductName = "Az yağlı domuz eti",
            //            Scale = "porsiyon",
            //            Calory = 472,
            //            CategoryID = 12,
            //            Category = context.Categories.Find(12)
            //        },
            //        new Product
            //        {
            //            ProductName = "Az yağlı koyun eti",
            //            Scale = "porsiyon",
            //            Calory = 247,
            //            CategoryID = 12,
            //            Category = context.Categories.Find(12)
            //        },
            //        new Product
            //        {
            //            ProductName = "Az yağlı sığır eti",
            //            Scale = "porsiyon",
            //            Calory = 225,
            //            CategoryID = 12,
            //            Category = context.Categories.Find(12)
            //        },
            //        new Product
            //        {
            //            ProductName = "Keçi eti",
            //            Scale = "porsiyon",
            //            Calory = 145,
            //            CategoryID = 12,
            //            Category = context.Categories.Find(12)
            //        },
            //        new Product
            //        {
            //            ProductName = "Orta yağlı dana eti",
            //            Scale = "porsiyon",
            //            Calory = 190,
            //            CategoryID = 12,
            //            Category = context.Categories.Find(12)
            //        },
            //        new Product
            //        {
            //            ProductName = "Orta yağlı domuz eti",
            //            Scale = "porsiyon",
            //            Calory = 513,
            //            CategoryID = 12,
            //            Category = context.Categories.Find(12)
            //        },
            //        new Product
            //        {
            //            ProductName = "Orta yağlı koyun eti",
            //            Scale = "porsiyon",
            //            Calory = 263,
            //            CategoryID = 12,
            //            Category = context.Categories.Find(12)
            //        },
            //        new Product
            //        {
            //            ProductName = "Orta yağlı sığır eti",
            //            Scale = "porsiyon",
            //            Calory = 263,
            //            CategoryID = 12,
            //            Category = context.Categories.Find(12)
            //        },
            //        new Product
            //        {
            //            ProductName = "Yağlı dana eti",
            //            Scale = "porsiyon",
            //            Calory = 223,
            //            CategoryID = 12,
            //            Category = context.Categories.Find(12)
            //        },
            //        new Product
            //        {
            //            ProductName = "Yağlı domuz eti",
            //            Scale = "porsiyon",
            //            Calory = 553,
            //            CategoryID = 12,
            //            Category = context.Categories.Find(12)
            //        },
            //        new Product
            //        {
            //            ProductName = "Yağlı koyun eti",
            //            Scale = "porsiyon",
            //            Calory = 310,
            //            CategoryID = 12,
            //            Category = context.Categories.Find(12)
            //        },
            //        new Product
            //        {
            //            ProductName = "Yağlı sığır eti",
            //            Scale = "porsiyon",
            //            Calory = 301,
            //            CategoryID = 12,
            //            Category = context.Categories.Find(12)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ay çekirdeği",
            //            Scale = "porsiyon",
            //            Calory = 560,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Badem",
            //            Scale = "porsiyon",
            //            Calory = 598,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bakla (İç)",
            //            Scale = "porsiyon",
            //            Calory = 338,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Barbunya",
            //            Scale = "porsiyon",
            //            Calory = 349,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bezelye",
            //            Scale = "porsiyon",
            //            Calory = 348,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Börülce",
            //            Scale = "porsiyon",
            //            Calory = 343,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ceviz",
            //            Scale = "porsiyon",
            //            Calory = 651,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Çam Fıstığı",
            //            Scale = "porsiyon",
            //            Calory = 635,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Fındık",
            //            Scale = "porsiyon",
            //            Calory = 634,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Fıstık",
            //            Scale = "porsiyon",
            //            Calory = 560,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kuru Fasulye (beyaz)",
            //            Scale = "porsiyon",
            //            Calory = 340,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kabak Çekirdeği",
            //            Scale = "porsiyon",
            //            Calory = 610,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kavun,Karpuz Çekirdeği",
            //            Scale = "porsiyon",
            //            Calory = 581,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kestane",
            //            Scale = "porsiyon",
            //            Calory = 194,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kestane Haşlanmış",
            //            Scale = "porsiyon",
            //            Calory = 131,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kestane Kavrulmuş",
            //            Scale = "porsiyon",
            //            Calory = 245,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Mercimek",
            //            Scale = "porsiyon",
            //            Calory = 340,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Nohut",
            //            Scale = "porsiyon",
            //            Calory = 360,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Palamut Çekirdeği",
            //            Scale = "porsiyon",
            //            Calory = 268,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Soya Fasulyesi",
            //            Scale = "porsiyon",
            //            Calory = 403,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Soya Unu (az yağlı)",
            //            Scale = "porsiyon",
            //            Calory = 356,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Soya Unu (yağsız)",
            //            Scale = "porsiyon",
            //            Calory = 326,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Susam",
            //            Scale = "porsiyon",
            //            Calory = 582,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Şam Fıstığı",
            //            Scale = "porsiyon",
            //            Calory = 594,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Yer Fıstığı",
            //            Scale = "porsiyon",
            //            Calory = 582,
            //            CategoryID = 13,
            //            Category = context.Categories.Find(13)
            //        },
            //        new Product
            //        {
            //            ProductName = "Hindi, et ve deri",
            //            Scale = "porsiyon",
            //            Calory = 160,
            //            CategoryID = 14,
            //            Category = context.Categories.Find(14)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kaz",
            //            Scale = "porsiyon",
            //            Calory = 371,
            //            CategoryID = 14,
            //            Category = context.Categories.Find(14)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ördek",
            //            Scale = "porsiyon",
            //            Calory = 404,
            //            CategoryID = 14,
            //            Category = context.Categories.Find(14)
            //        },
            //        new Product
            //        {
            //            ProductName = "Şehr. tavuk çorbası",
            //            Scale = "pors.",
            //            Calory = 75,
            //            CategoryID = 14,
            //            Category = context.Categories.Find(14)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tavuk bütün",
            //            Scale = "porsiyon",
            //            Calory = 215,
            //            CategoryID = 14,
            //            Category = context.Categories.Find(14)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tavuk beyaz et (derili)",
            //            Scale = "porsiyon",
            //            Calory = 186,
            //            CategoryID = 14,
            //            Category = context.Categories.Find(14)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tavuk beyaz et (derisiz)",
            //            Scale = "porsiyon",
            //            Calory = 114,
            //            CategoryID = 14,
            //            Category = context.Categories.Find(14)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tavuk göğüs kızarmış",
            //            Scale = "porsiyon",
            //            Calory = 365,
            //            CategoryID = 14,
            //            Category = context.Categories.Find(14)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tavuk siyah et derisiz",
            //            Scale = "porsiyon",
            //            Calory = 125,
            //            CategoryID = 14,
            //            Category = context.Categories.Find(14)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tavuk, deri",
            //            Scale = "porsiyon",
            //            Calory = 349,
            //            CategoryID = 14,
            //            Category = context.Categories.Find(14)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tavuk, siyah et (derili)",
            //            Scale = "porsiyon",
            //            Calory = 237,
            //            CategoryID = 14,
            //            Category = context.Categories.Find(14)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ahududu (Kırmızı)",
            //            Scale = "porsiyon",
            //            Calory = 57,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ahududu (Siyah)",
            //            Scale = "porsiyon",
            //            Calory = 73,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ananas",
            //            Scale = "porsiyon",
            //            Calory = 52,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Armut",
            //            Scale = "porsiyon",
            //            Calory = 61,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Avokado",
            //            Scale = "porsiyon",
            //            Calory = 167,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ayva",
            //            Scale = "porsiyon",
            //            Calory = 57,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Böğürtlen",
            //            Scale = "porsiyon",
            //            Calory = 58,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Çilek",
            //            Scale = "porsiyon",
            //            Calory = 37,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Dut",
            //            Scale = "porsiyon",
            //            Calory = 93,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Elma",
            //            Scale = "porsiyon",
            //            Calory = 58,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Elma Suyu",
            //            Scale = "porsiyon",
            //            Calory = 47,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Erik (Kırmızı)",
            //            Scale = "porsiyon",
            //            Calory = 66,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Erik (Mürdüm)",
            //            Scale = "porsiyon",
            //            Calory = 79,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Erik Mürdüm (Kuru)",
            //            Scale = "porsiyon",
            //            Calory = 255,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Erik Pestil",
            //            Scale = "porsiyon",
            //            Calory = 344,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Greyfurt",
            //            Scale = "porsiyon",
            //            Calory = 41,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Greyfurt Suyu",
            //            Scale = "porsiyon",
            //            Calory = 39,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Hurma",
            //            Scale = "porsiyon",
            //            Calory = 274,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Hurma",
            //            Scale = "adet",
            //            Calory = 15,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "İncir (Kuru)",
            //            Scale = "porsiyon",
            //            Calory = 274,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "İncir (Taze)",
            //            Scale = "porsiyon",
            //            Calory = 80,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Karpuz",
            //            Scale = "porsiyon",
            //            Calory = 26,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kavun",
            //            Scale = "porsiyon",
            //            Calory = 33,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kayısı (Kuru)",
            //            Scale = "porsiyon",
            //            Calory = 260,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kayısı (Taze)",
            //            Scale = "adet",
            //            Calory = 17,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kayısı Pestil",
            //            Scale = "porsiyon",
            //            Calory = 332,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kiraz",
            //            Scale = "adet",
            //            Calory = 5,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kivi",
            //            Scale = "porsiyon",
            //            Calory = 30,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Limon",
            //            Scale = "porsiyon",
            //            Calory = 27,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Limon Suyu",
            //            Scale = "porsiyon",
            //            Calory = 25,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Mandalina",
            //            Scale = "porsiyon",
            //            Calory = 46,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Mandalina Suyu",
            //            Scale = "porsiyon",
            //            Calory = 43,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Muz",
            //            Scale = "porsiyon",
            //            Calory = 105,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Nar",
            //            Scale = "porsiyon",
            //            Calory = 63,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Portakal",
            //            Scale = "porsiyon",
            //            Calory = 49,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Şeftali",
            //            Scale = "porsiyon",
            //            Calory = 38,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Üzüm (Kuru)",
            //            Scale = "porsiyon",
            //            Calory = 289,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Üzüm (Taze)",
            //            Scale = "porsiyon",
            //            Calory = 67,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Üzüm Suyu",
            //            Scale = "porsiyon",
            //            Calory = 66,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Vişne",
            //            Scale = "porsiyon",
            //            Calory = 58,
            //            CategoryID = 15,
            //            Category = context.Categories.Find(15)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bey. peynir (Edirne)",
            //            Scale = "porsiyon",
            //            Calory = 235,
            //            CategoryID = 16,
            //            Category = context.Categories.Find(16)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bey. peynir (Urfa)",
            //            Scale = "porsiyon",
            //            Calory = 312,
            //            CategoryID = 16,
            //            Category = context.Categories.Find(16)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bey. peynir (yağlı)",
            //            Scale = "porsiyon",
            //            Calory = 289,
            //            CategoryID = 16,
            //            Category = context.Categories.Find(16)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bey.peynir (yağsız)",
            //            Scale = "porsiyon",
            //            Calory = 99,
            //            CategoryID = 16,
            //            Category = context.Categories.Find(16)
            //        },
            //        new Product
            //        {
            //            ProductName = "Cheddar",
            //            Scale = "porsiyon",
            //            Calory = 403,
            //            CategoryID = 16,
            //            Category = context.Categories.Find(16)
            //        },
            //        new Product
            //        {
            //            ProductName = "Çökelek (Kuru)",
            //            Scale = "porsiyon",
            //            Calory = 379,
            //            CategoryID = 16,
            //            Category = context.Categories.Find(16)
            //        },
            //        new Product
            //        {
            //            ProductName = "Çökelek (Taze)",
            //            Scale = "porsiyon",
            //            Calory = 215,
            //            CategoryID = 16,
            //            Category = context.Categories.Find(16)
            //        },
            //        new Product
            //        {
            //            ProductName = "Gravyer (%8 Tuzlu)",
            //            Scale = "porsiyon",
            //            Calory = 413,
            //            CategoryID = 16,
            //            Category = context.Categories.Find(16)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kars Tipi",
            //            Scale = "porsiyon",
            //            Calory = 357,
            //            CategoryID = 16,
            //            Category = context.Categories.Find(16)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kaşar Peyniri",
            //            Scale = "porsiyon",
            //            Calory = 404,
            //            CategoryID = 16,
            //            Category = context.Categories.Find(16)
            //        },
            //        new Product
            //        {
            //            ProductName = "Krem Peynir (Sade)",
            //            Scale = "porsiyon",
            //            Calory = 349,
            //            CategoryID = 16,
            //            Category = context.Categories.Find(16)
            //        },
            //        new Product
            //        {
            //            ProductName = "Lor peyniri (%1 yağ)",
            //            Scale = "porsiyon",
            //            Calory = 72,
            //            CategoryID = 16,
            //            Category = context.Categories.Find(16)
            //        },
            //        new Product
            //        {
            //            ProductName = "Lor peyniri (%2 yağ)",
            //            Scale = "porsiyon",
            //            Calory = 90,
            //            CategoryID = 16,
            //            Category = context.Categories.Find(16)
            //        },
            //        new Product
            //        {
            //            ProductName = "Lor peyniri (yağsız)",
            //            Scale = "porsiyon",
            //            Calory = 85,
            //            CategoryID = 16,
            //            Category = context.Categories.Find(16)
            //        },
            //        new Product
            //        {
            //            ProductName = "Otlu Peynir",
            //            Scale = "porsiyon",
            //            Calory = 327,
            //            CategoryID = 16,
            //            Category = context.Categories.Find(16)
            //        },
            //        new Product
            //        {
            //            ProductName = "Rokfor",
            //            Scale = "porsiyon",
            //            Calory = 369,
            //            CategoryID = 16,
            //            Category = context.Categories.Find(16)
            //        },
            //        new Product
            //        {
            //            ProductName = "Akciğer (dana)",
            //            Scale = "porsiyon",
            //            Calory = 106,
            //            CategoryID = 17,
            //            Category = context.Categories.Find(17)
            //        },
            //        new Product
            //        {
            //            ProductName = "Beyin",
            //            Scale = "porsiyon",
            //            Calory = 125,
            //            CategoryID = 17,
            //            Category = context.Categories.Find(17)
            //        },
            //        new Product
            //        {
            //            ProductName = "Böbrek (kuzu)",
            //            Scale = "porsiyon",
            //            Calory = 105,
            //            CategoryID = 17,
            //            Category = context.Categories.Find(17)
            //        },
            //        new Product
            //        {
            //            ProductName = "Dalak (sığır, dana)",
            //            Scale = "porsiyon",
            //            Calory = 104,
            //            CategoryID = 17,
            //            Category = context.Categories.Find(17)
            //        },
            //        new Product
            //        {
            //            ProductName = "Dil (dana)",
            //            Scale = "porsiyon",
            //            Calory = 130,
            //            CategoryID = 17,
            //            Category = context.Categories.Find(17)
            //        },
            //        new Product
            //        {
            //            ProductName = "İşkembe (sığır)",
            //            Scale = "porsiyon",
            //            Calory = 100,
            //            CategoryID = 17,
            //            Category = context.Categories.Find(17)
            //        },
            //        new Product
            //        {
            //            ProductName = "Karaciğer (dana)",
            //            Scale = "porsiyon",
            //            Calory = 140,
            //            CategoryID = 17,
            //            Category = context.Categories.Find(17)
            //        },
            //        new Product
            //        {
            //            ProductName = "Karaciğer (tavuk)",
            //            Scale = "porsiyon",
            //            Calory = 129,
            //            CategoryID = 17,
            //            Category = context.Categories.Find(17)
            //        },
            //        new Product
            //        {
            //            ProductName = "Yürek (dana)",
            //            Scale = "porsiyon",
            //            Calory = 124,
            //            CategoryID = 17,
            //            Category = context.Categories.Find(17)
            //        },
            //        new Product
            //        {
            //            ProductName = "Asma Yaprağı",
            //            Scale = "porsiyon",
            //            Calory = 97,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bamya (Kurutulmuş)",
            //            Scale = "porsiyon",
            //            Calory = 266,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bamya (taze)",
            //            Scale = "porsiyon",
            //            Calory = 36,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bezelye (İç)",
            //            Scale = "porsiyon",
            //            Calory = 84,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bezelye (Konserve)",
            //            Scale = "porsiyon",
            //            Calory = 88,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Biber (Kurutulmuş)",
            //            Scale = "porsiyon",
            //            Calory = 293,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Biber (Taze)",
            //            Scale = "porsiyon",
            //            Calory = 22,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Börülce (Taze)",
            //            Scale = "porsiyon",
            //            Calory = 127,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Brokoli",
            //            Scale = "baş",
            //            Calory = 40,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Domates (Kırmızı)",
            //            Scale = "porsiyon",
            //            Calory = 25,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Domates (Yeşil)",
            //            Scale = "porsiyon",
            //            Calory = 24,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Domates suyu",
            //            Scale = "porsiyon",
            //            Calory = 19,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ebegümeci",
            //            Scale = "porsiyon",
            //            Calory = 47,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Enginar",
            //            Scale = "porsiyon",
            //            Calory = 53,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Fasulye (Kurutulmuş)",
            //            Scale = "porsiyon",
            //            Calory = 274,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Fasulye (Taze)",
            //            Scale = "porsiyon",
            //            Calory = 32,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Havuç",
            //            Scale = "porsiyon",
            //            Calory = 42,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Hıyar (Soyulmamış)",
            //            Scale = "porsiyon",
            //            Calory = 15,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Hıyar (soyulmuş)",
            //            Scale = "porsiyon",
            //            Calory = 14,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Hindibağ Otu",
            //            Scale = "porsiyon",
            //            Calory = 53,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ispanak",
            //            Scale = "porsiyon",
            //            Calory = 26,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kabak (Kış)",
            //            Scale = "porsiyon",
            //            Calory = 26,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kabak (Yaz)",
            //            Scale = "porsiyon",
            //            Calory = 19,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Karnıbahar",
            //            Scale = "porsiyon",
            //            Calory = 27,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kereviz",
            //            Scale = "porsiyon",
            //            Calory = 40,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kırmızı Biber (Taze)",
            //            Scale = "porsiyon",
            //            Calory = 93,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kıvırcık",
            //            Scale = "porsiyon",
            //            Calory = 20,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Konserve fasulye",
            //            Scale = "porsiyon",
            //            Calory = 24,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kuşkonmaz",
            //            Scale = "porsiyon",
            //            Calory = 26,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Lahana (Beyaz)",
            //            Scale = "porsiyon",
            //            Calory = 24,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Lahana (Brüksel)",
            //            Scale = "porsiyon",
            //            Calory = 63,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Lahana (Kara)",
            //            Scale = "porsiyon",
            //            Calory = 45,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Lahana (Kırmızı)",
            //            Scale = "porsiyon",
            //            Calory = 31,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Madımak",
            //            Scale = "porsiyon",
            //            Calory = 22,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Mantar",
            //            Scale = "porsiyon",
            //            Calory = 28,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Marul",
            //            Scale = "porsiyon",
            //            Calory = 14,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Maydonoz",
            //            Scale = "porsiyon",
            //            Calory = 44,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Mısır (Taze)",
            //            Scale = "porsiyon",
            //            Calory = 96,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Nane (Taze)",
            //            Scale = "porsiyon",
            //            Calory = 65,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Pancar (Kırmızı)",
            //            Scale = "porsiyon",
            //            Calory = 43,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Pancar (Yaprak)",
            //            Scale = "porsiyon",
            //            Calory = 24,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Patates",
            //            Scale = "porsiyon",
            //            Calory = 76,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Patates unu",
            //            Scale = "porsiyon",
            //            Calory = 351,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Patlıcan (kurutul.)",
            //            Scale = "porsiyon",
            //            Calory = 286,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Patlıcan (Taze)",
            //            Scale = "porsiyon",
            //            Calory = 25,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Pazı",
            //            Scale = "porsiyon",
            //            Calory = 33,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Pırasa",
            //            Scale = "porsiyon",
            //            Calory = 52,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Roka",
            //            Scale = "porsiyon",
            //            Calory = 33,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Sarmısak (Baş)",
            //            Scale = "porsiyon",
            //            Calory = 137,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Sarmısak (Toz)",
            //            Scale = "porsiyon",
            //            Calory = 332,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Semiz Otu",
            //            Scale = "porsiyon",
            //            Calory = 32,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Soğan (Kuru)",
            //            Scale = "porsiyon",
            //            Calory = 38,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Soğan (Toz)",
            //            Scale = "porsiyon",
            //            Calory = 347,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Soğan (Yeşil)",
            //            Scale = "porsiyon",
            //            Calory = 36,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Şalgam",
            //            Scale = "porsiyon",
            //            Calory = 30,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Taze Bakla",
            //            Scale = "porsiyon",
            //            Calory = 72,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tere",
            //            Scale = "porsiyon",
            //            Calory = 33,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Turp (Kırmızı)",
            //            Scale = "porsiyon",
            //            Calory = 19,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Turp (Siyah)",
            //            Scale = "porsiyon",
            //            Calory = 30,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Yer Elması",
            //            Scale = "porsiyon",
            //            Calory = 75,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Yonca",
            //            Scale = "porsiyon",
            //            Calory = 49,
            //            CategoryID = 18,
            //            Category = context.Categories.Find(18)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bin Ada Yağı",
            //            Scale = "porsiyon",
            //            Calory = 377,
            //            CategoryID = 19,
            //            Category = context.Categories.Find(19)
            //        },
            //        new Product
            //        {
            //            ProductName = "Fransız salata sosu",
            //            Scale = "porsiyon",
            //            Calory = 430,
            //            CategoryID = 19,
            //            Category = context.Categories.Find(19)
            //        },
            //        new Product
            //        {
            //            ProductName = "İtalyan salata sosu",
            //            Scale = "porsiyon",
            //            Calory = 467,
            //            CategoryID = 19,
            //            Category = context.Categories.Find(19)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ketçap",
            //            Scale = "porsiyon",
            //            Calory = 106,
            //            CategoryID = 19,
            //            Category = context.Categories.Find(19)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kıymalı Chili",
            //            Scale = "bard.",
            //            Calory = 340,
            //            CategoryID = 19,
            //            Category = context.Categories.Find(19)
            //        },
            //        new Product
            //        {
            //            ProductName = "Krema (%50 yağ, süt)",
            //            Scale = "porsiyon",
            //            Calory = 134,
            //            CategoryID = 19,
            //            Category = context.Categories.Find(19)
            //        },
            //        new Product
            //        {
            //            ProductName = "Mayonez",
            //            Scale = "porsiyon",
            //            Calory = 390,
            //            CategoryID = 19,
            //            Category = context.Categories.Find(19)
            //        },
            //        new Product
            //        {
            //            ProductName = "Salata sosu (yağlı)",
            //            Scale = "porsiyon",
            //            Calory = 449,
            //            CategoryID = 19,
            //            Category = context.Categories.Find(19)
            //        },
            //        new Product
            //        {
            //            ProductName = "Salça",
            //            Scale = "porsiyon",
            //            Calory = 98,
            //            CategoryID = 19,
            //            Category = context.Categories.Find(19)
            //        },
            //        new Product
            //        {
            //            ProductName = "Soya Sosu",
            //            Scale = "porsiyon",
            //            Calory = 68,
            //            CategoryID = 19,
            //            Category = context.Categories.Find(19)
            //        },
            //        new Product
            //        {
            //            ProductName = "Anne sütü",
            //            Scale = "porsiyon",
            //            Calory = 70,
            //            CategoryID = 20,
            //            Category = context.Categories.Find(20)
            //        },
            //        new Product
            //        {
            //            ProductName = "İnek (1/2 yağlı)",
            //            Scale = "porsiyon",
            //            Calory = 50,
            //            CategoryID = 20,
            //            Category = context.Categories.Find(20)
            //        },
            //        new Product
            //        {
            //            ProductName = "İnek (Yağlı)",
            //            Scale = "porsiyon",
            //            Calory = 61,
            //            CategoryID = 20,
            //            Category = context.Categories.Find(20)
            //        },
            //        new Product
            //        {
            //            ProductName = "İnek (yağsız)",
            //            Scale = "porsiyon",
            //            Calory = 35,
            //            CategoryID = 20,
            //            Category = context.Categories.Find(20)
            //        },
            //        new Product
            //        {
            //            ProductName = "Keçi sütü",
            //            Scale = "porsiyon",
            //            Calory = 69,
            //            CategoryID = 20,
            //            Category = context.Categories.Find(20)
            //        },
            //        new Product
            //        {
            //            ProductName = "Koyun",
            //            Scale = "porsiyon",
            //            Calory = 108,
            //            CategoryID = 20,
            //            Category = context.Categories.Find(20)
            //        },
            //        new Product
            //        {
            //            ProductName = "Manda sütü",
            //            Scale = "porsiyon",
            //            Calory = 97,
            //            CategoryID = 20,
            //            Category = context.Categories.Find(20)
            //        },
            //        new Product
            //        {
            //            ProductName = "Soya",
            //            Scale = "porsiyon",
            //            Calory = 33,
            //            CategoryID = 20,
            //            Category = context.Categories.Find(20)
            //        },
            //        new Product
            //        {
            //            ProductName = "Süt Tozu (Yağlı)",
            //            Scale = "porsiyon",
            //            Calory = 496,
            //            CategoryID = 20,
            //            Category = context.Categories.Find(20)
            //        },
            //        new Product
            //        {
            //            ProductName = "Süt Tozu (Yağsız)",
            //            Scale = "porsiyon",
            //            Calory = 362,
            //            CategoryID = 20,
            //            Category = context.Categories.Find(20)
            //        },
            //        new Product
            //        {
            //            ProductName = "Yoğurt (1/2 yağlı)",
            //            Scale = "porsiyon",
            //            Calory = 50,
            //            CategoryID = 20,
            //            Category = context.Categories.Find(20)
            //        },
            //        new Product
            //        {
            //            ProductName = "Yoğurt (Yağlı)",
            //            Scale = "porsiyon",
            //            Calory = 62,
            //            CategoryID = 20,
            //            Category = context.Categories.Find(20)
            //        },
            //        new Product
            //        {
            //            ProductName = "Akide şekeri",
            //            Scale = "porsiyon",
            //            Calory = 330,
            //            CategoryID = 21,
            //            Category = context.Categories.Find(21)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bal",
            //            Scale = "porsiyon",
            //            Calory = 315,
            //            CategoryID = 21,
            //            Category = context.Categories.Find(21)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bisküvi",
            //            Scale = "porsiyon",
            //            Calory = 418,
            //            CategoryID = 21,
            //            Category = context.Categories.Find(21)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bisküvi (pasta)",
            //            Scale = "porsiyon",
            //            Calory = 462,
            //            CategoryID = 21,
            //            Category = context.Categories.Find(21)
            //        },
            //        new Product
            //        {
            //            ProductName = "Çikolata (Bademli)",
            //            Scale = "porsiyon",
            //            Calory = 532,
            //            CategoryID = 21,
            //            Category = context.Categories.Find(21)
            //        },
            //        new Product
            //        {
            //            ProductName = "Çikolata (Fıstıklı)",
            //            Scale = "porsiyon",
            //            Calory = 543,
            //            CategoryID = 21,
            //            Category = context.Categories.Find(21)
            //        },
            //        new Product
            //        {
            //            ProductName = "Çikolata (Şekerli)",
            //            Scale = "porsiyon",
            //            Calory = 528,
            //            CategoryID = 21,
            //            Category = context.Categories.Find(21)
            //        },
            //        new Product
            //        {
            //            ProductName = "Çikolata (Şekersiz)",
            //            Scale = "porsiyon",
            //            Calory = 477,
            //            CategoryID = 21,
            //            Category = context.Categories.Find(21)
            //        },
            //        new Product
            //        {
            //            ProductName = "Dondurma (Sütlü)",
            //            Scale = "porsiyon",
            //            Calory = 193,
            //            CategoryID = 21,
            //            Category = context.Categories.Find(21)
            //        },
            //        new Product
            //        {
            //            ProductName = "Karamela",
            //            Scale = "porsiyon",
            //            Calory = 399,
            //            CategoryID = 21,
            //            Category = context.Categories.Find(21)
            //        },
            //        new Product
            //        {
            //            ProductName = "Lokum",
            //            Scale = "porsiyon",
            //            Calory = 240,
            //            CategoryID = 21,
            //            Category = context.Categories.Find(21)
            //        },
            //        new Product
            //        {
            //            ProductName = "Marmelat",
            //            Scale = "porsiyon",
            //            Calory = 278,
            //            CategoryID = 21,
            //            Category = context.Categories.Find(21)
            //        },
            //        new Product
            //        {
            //            ProductName = "Meyva şekerleme",
            //            Scale = "porsiyon",
            //            Calory = 316,
            //            CategoryID = 21,
            //            Category = context.Categories.Find(21)
            //        },
            //        new Product
            //        {
            //            ProductName = "Pekmez (Üzüm)",
            //            Scale = "porsiyon",
            //            Calory = 293,
            //            CategoryID = 21,
            //            Category = context.Categories.Find(21)
            //        },
            //        new Product
            //        {
            //            ProductName = "Reçel",
            //            Scale = "porsiyon",
            //            Calory = 272,
            //            CategoryID = 21,
            //            Category = context.Categories.Find(21)
            //        },
            //        new Product
            //        {
            //            ProductName = "Şeker",
            //            Scale = "porsiyon",
            //            Calory = 385,
            //            CategoryID = 21,
            //            Category = context.Categories.Find(21)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tahin helvası",
            //            Scale = "porsiyon",
            //            Calory = 516,
            //            CategoryID = 21,
            //            Category = context.Categories.Find(21)
            //        },
            //        new Product
            //        {
            //            ProductName = "Arpa",
            //            Scale = "porsiyon",
            //            Calory = 349,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Buğday (aşurelik)",
            //            Scale = "porsiyon",
            //            Calory = 335,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Buğday (durum)",
            //            Scale = "porsiyon",
            //            Calory = 332,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bulgur",
            //            Scale = "porsiyon",
            //            Calory = 357,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Corn Flakes",
            //            Scale = "porsiyon",
            //            Calory = 386,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Çavdar Unu",
            //            Scale = "porsiyon",
            //            Calory = 350,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ekmek (beyaz)",
            //            Scale = "dilim",
            //            Calory = 90,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ekmeklik",
            //            Scale = "porsiyon",
            //            Calory = 365,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kepek",
            //            Scale = "porsiyon",
            //            Calory = 213,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Mısır (haşlan.)",
            //            Scale = "porsiyon",
            //            Calory = 91,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Mısır unu",
            //            Scale = "porsiyon",
            //            Calory = 368,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Mısır, tane",
            //            Scale = "porsiyon",
            //            Calory = 362,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Nişasta",
            //            Scale = "porsiyon",
            //            Calory = 362,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Patlamış mısır",
            //            Scale = "porsiyon",
            //            Calory = 456,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Pirinç",
            //            Scale = "porsiyon",
            //            Calory = 363,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Şehriye",
            //            Scale = "porsiyon",
            //            Calory = 388,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tarhana",
            //            Scale = "porsiyon",
            //            Calory = 316,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Yulaf Unu",
            //            Scale = "porsiyon",
            //            Calory = 388,
            //            CategoryID = 22,
            //            Category = context.Categories.Find(22)
            //        },
            //        new Product
            //        {
            //            ProductName = "Cheesecake",
            //            Scale = "dilim",
            //            Calory = 280,
            //            CategoryID = 23,
            //            Category = context.Categories.Find(23)
            //        },
            //        new Product
            //        {
            //            ProductName = "Cheesecake",
            //            Scale = "bütün",
            //            Calory = 3350,
            //            CategoryID = 23,
            //            Category = context.Categories.Find(23)
            //        },
            //        new Product
            //        {
            //            ProductName = "Çikolatalı kurabiye",
            //            Scale = "adet",
            //            Calory = 45,
            //            CategoryID = 23,
            //            Category = context.Categories.Find(23)
            //        },
            //        new Product
            //        {
            //            ProductName = "Elmalı turta",
            //            Scale = "dilim",
            //            Calory = 405,
            //            CategoryID = 23,
            //            Category = context.Categories.Find(23)
            //        },
            //        new Product
            //        {
            //            ProductName = "Elmalı turta",
            //            Scale = "bütün",
            //            Calory = 2420,
            //            CategoryID = 23,
            //            Category = context.Categories.Find(23)
            //        },
            //        new Product
            //        {
            //            ProductName = "Hanımgöbeği",
            //            Scale = "porsiyon",
            //            Calory = 211,
            //            CategoryID = 23,
            //            Category = context.Categories.Find(23)
            //        },
            //        new Product
            //        {
            //            ProductName = "Havuçlu kek",
            //            Scale = "bütün",
            //            Calory = 6175,
            //            CategoryID = 23,
            //            Category = context.Categories.Find(23)
            //        },
            //        new Product
            //        {
            //            ProductName = "Havuçlu kek",
            //            Scale = "dilim",
            //            Calory = 385,
            //            CategoryID = 23,
            //            Category = context.Categories.Find(23)
            //        },
            //        new Product
            //        {
            //            ProductName = "Hurma tatlısı",
            //            Scale = "porsiyon",
            //            Calory = 318,
            //            CategoryID = 23,
            //            Category = context.Categories.Find(23)
            //        },
            //        new Product
            //        {
            //            ProductName = "İrmik helvası",
            //            Scale = "porsiyon",
            //            Calory = 302,
            //            CategoryID = 23,
            //            Category = context.Categories.Find(23)
            //        },
            //        new Product
            //        {
            //            ProductName = "Jöle",
            //            Scale = "porsiyon",
            //            Calory = 259,
            //            CategoryID = 23,
            //            Category = context.Categories.Find(23)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kastırd",
            //            Scale = "porsiyon",
            //            Calory = 126,
            //            CategoryID = 23,
            //            Category = context.Categories.Find(23)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kek pasta",
            //            Scale = "porsiyon",
            //            Calory = 364,
            //            CategoryID = 23,
            //            Category = context.Categories.Find(23)
            //        },
            //        new Product
            //        {
            //            ProductName = "Muhallebi",
            //            Scale = "porsiyon",
            //            Calory = 173,
            //            CategoryID = 23,
            //            Category = context.Categories.Find(23)
            //        },
            //        new Product
            //        {
            //            ProductName = "Sütlaç",
            //            Scale = "porsiyon",
            //            Calory = 139,
            //            CategoryID = 23,
            //            Category = context.Categories.Find(23)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tel kadayıf (fıstıklı)",
            //            Scale = "porsiyon",
            //            Calory = 286,
            //            CategoryID = 23,
            //            Category = context.Categories.Find(23)
            //        },
            //        new Product
            //        {
            //            ProductName = "Wafers",
            //            Scale = "porsiyon",
            //            Calory = 535,
            //            CategoryID = 23,
            //            Category = context.Categories.Find(23)
            //        },
            //        new Product
            //        {
            //            ProductName = "Bıldırcın yumurta",
            //            Scale = "porsiyon",
            //            Calory = 158,
            //            CategoryID = 24,
            //            Category = context.Categories.Find(24)
            //        },
            //        new Product
            //        {
            //            ProductName = "Kaz yumurta",
            //            Scale = "porsiyon",
            //            Calory = 185,
            //            CategoryID = 24,
            //            Category = context.Categories.Find(24)
            //        },
            //        new Product
            //        {
            //            ProductName = "Ördek yumurta",
            //            Scale = "porsiyon",
            //            Calory = 185,
            //            CategoryID = 24,
            //            Category = context.Categories.Find(24)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tavuk yumurta (beyaz)",
            //            Scale = "porsiyon",
            //            Calory = 49,
            //            CategoryID = 24,
            //            Category = context.Categories.Find(24)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tavuk yumurta (sarı)",
            //            Scale = "porsiyon",
            //            Calory = 369,
            //            CategoryID = 24,
            //            Category = context.Categories.Find(24)
            //        },
            //        new Product
            //        {
            //            ProductName = "Tavuk yumurta (tam)",
            //            Scale = "porsiyon",
            //            Calory = 158,
            //            CategoryID = 24,
            //            Category = context.Categories.Find(24)
            //        }

            //    );

            //    #endregion Ürünleri Ekliyoruz
            //}
            //catch (DbEntityValidationException e)
            //{
            //    foreach (var eve in e.EntityValidationErrors)
            //    {
            //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
            //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
            //                ve.PropertyName, ve.ErrorMessage);
            //        }
            //    }
            //    throw;
            //}
            #endregion
        }
    }
}