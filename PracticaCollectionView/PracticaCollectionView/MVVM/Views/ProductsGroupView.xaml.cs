using System.Diagnostics;

namespace PracticaCollectionView.MVVM.Views;

public partial class ProductsGroupView : ContentPage
{
    public ProductsGroupView()
    {
        InitializeComponent();
        BindingContext = new MVVM.ViewModels.ProductsViewModels();
    }

    void CollectionView_Scrolled(System.Object sender, Microsoft.Maui.Controls.ItemsViewScrolledEventArgs e)
    {
        Debug.Write("-------------------------------------------------------------");
        Debug.WriteLine("VerticalOffset: " + e.VerticalOffset);
        Debug.WriteLine("CenterItemIndex: " + e.CenterItemIndex);
        Debug.WriteLine("Horizontal Delta: " + e.HorizontalDelta);
        Debug.WriteLine("HorizontalOffset: " + e.HorizontalOffset);
        Debug.WriteLine("VerticalDelta Delta: " + e.VerticalDelta);
        Debug.WriteLine("LastVisibleItemIndex: " + e.LastVisibleItemIndex);
        Debug.WriteLine("FirstVisibleItemIndex: " + e.FirstVisibleItemIndex);
        Debug.Write("-------------------------------------------------------------");
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        var vm =
        BindingContext as MVVM.ViewModels.ProductsViewModels;

        var product =
             vm.Products
             .SelectMany(p => p)
             .FirstOrDefault(x => x.Id == 100);

        CollectionView.ScrollTo(product, animate: true, position: ScrollToPosition.Center);
    }
}
