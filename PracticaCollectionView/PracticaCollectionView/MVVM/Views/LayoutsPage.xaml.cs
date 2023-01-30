namespace PracticaCollectionView.MVVM.Views;

public partial class LayoutsPage : ContentPage
{
    public LayoutsPage()
    {
        InitializeComponent();
        BindingContext = new MVVM.ViewModels.DataViewModels();
    }
}
