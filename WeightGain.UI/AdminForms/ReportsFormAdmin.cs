using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;

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

            var a = _portionRepository.GetAll().GroupBy(x => x.MealTime.MealTimeType, x => x.Product).Select(x => new
            {
                MealTimeType = x.Key,
                Products = x.GroupBy(y => y.ProductId),
            }).ToList();
            //foreach (var b in a)
            //{
            //    ListViewGroup categoryGroup;
            //    if (lwProducts.Groups.Cast<ListViewGroup>().Any(x => x.Header == b.MealTimeType.ToString()))
            //    {
            //        categoryGroup = lwProducts.Groups.Cast<ListViewGroup>()
            //            .Single(x => x.Header == b.MealTimeType.ToString());
            //    }
            //    else
            //    {
            //        categoryGroup = new ListViewGroup(b.MealTimeType.ToString());
            //        lwProducts.Groups.Add(categoryGroup);
            //    }
            //    var item = new ListViewItem(new[]
            //    {
            //        b.Products.,
            //        b.Count.ToString()
            //    })
            //    {
            //        Tag = b.Products.ProductId,
            //        Group = categoryGroup
            //    };
            //    lwProducts.Items.Add(item);
            //}

            //var productGroups = _portionRepository.GetAll().GroupBy(x => x.Product).Select(x => new
            //{
            //    Product = x.Key,
            //    Count = x.Count()
            //}).OrderByDescending(x => x.Count);

            //foreach (var b in productGroups)
            //{
            //    ListViewGroup categoryGroup;
            //    if (lwProducts.Groups.Cast<ListViewGroup>().Any(x => x.Header == b.Product.Category.Name))
            //    {
            //        categoryGroup = lwProducts.Groups.Cast<ListViewGroup>()
            //            .Single(x => x.Header == b.Product.Category.Name);
            //    }
            //    else
            //    {
            //        categoryGroup = new ListViewGroup(b.Product.Category.Name);
            //        lwProducts.Groups.Add(categoryGroup);
            //    }
            //    var item = new ListViewItem(new[]
            //    {
            //        b.Product.ProductName,
            //        b.Count.ToString()
            //    })
            //    {
            //        Tag = b.Product.ProductId,
            //        Group = categoryGroup
            //    };
            //    lwProducts.Items.Add(item);
            //}
        }
    }
}
