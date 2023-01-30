using System;
namespace PracticaCollectionView.Utilities.UserControls
{
    public class ProductDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var product = item as MVVM.Models.ProductModel;

            if (!product.HasOffer)
            {
                Application.Current.Resources.TryGetValue("ProductCollection", out var productStyle);
                return productStyle as DataTemplate;
            }
            else
            {
                Application.Current.Resources.TryGetValue("OfferStyle", out var offerStyle);
                return offerStyle as DataTemplate;
            }
        }
    }
}

