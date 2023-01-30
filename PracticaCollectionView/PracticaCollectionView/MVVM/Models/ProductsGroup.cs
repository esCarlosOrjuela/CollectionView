using System;
using System.Collections.ObjectModel;

namespace PracticaCollectionView.MVVM.Models
{
    public class ProductsGroup : List<ProductModel>
    {
        public string Name { get; set; }

        public ProductsGroup(string name, List<ProductModel> products) : base(products)
        {
            this.Name = name;
        }
    }
}

