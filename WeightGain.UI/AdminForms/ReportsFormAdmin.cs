using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA.Helpers;

namespace WeightGain.UI.AdminForms
{
    public partial class ReportsFormAdmin : Form
    {
        private readonly MealTimeRepository _mealTimeRepository;
        private readonly PortionRepository _portionRepository;

        public ReportsFormAdmin(List<BaseRepository> baseRepositories)
        {
            _mealTimeRepository = (MealTimeRepository)baseRepositories.Single(x => x.GetType() == typeof(MealTimeRepository));
            _portionRepository = (PortionRepository)baseRepositories.Single(x => x.GetType() == typeof(PortionRepository));
            InitializeComponent();
        }

        private void ReportsFormAdmin_Load(object sender, EventArgs e)
        {
            var productGroups = _portionRepository.GetAll()
                .GroupBy(x => new
                {
                    x.MealTime.MealTimeType,
                    x.Product
                }).Select(x => new
                {
                    x.Key.MealTimeType,
                    x.Key.Product,
                    Count = x.Count()
                })
                .OrderByDescending(x => x.Count);

            foreach (var product in productGroups)
            {
                string mealTimeType = Helper.GetTurkishMealTime(product.MealTimeType);
                ListViewGroup categoryGroup;
                if (lwProducts.Groups.Cast<ListViewGroup>().Any(x => x.Header == mealTimeType))
                {
                    categoryGroup = lwProducts.Groups.Cast<ListViewGroup>()
                        .Single(x => x.Header == mealTimeType);
                }
                else
                {
                    categoryGroup = new ListViewGroup(mealTimeType);
                    lwProducts.Groups.Add(categoryGroup);
                }
                var memStream = new MemoryStream(product.Product.Picture);
                ilProducts.Images.Add(Image.FromStream(memStream));
                var lastId = ilProducts.Images.Count - 1;
                var item = new ListViewItem(new[]
                {
                    product.Product.ProductName,
                    product.Count.ToString(),
                    product.Product.Category.Name
                }, lastId)
                {
                    Tag = product.Product.ProductId,
                    Group = categoryGroup
                };
                lwProducts.Items.Add(item);
            }
            lwProducts.SmallImageList = ilProducts;
            lwProducts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lwProducts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
