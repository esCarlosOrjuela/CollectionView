namespace PracticaCollectionView.MVVM.Views;

public partial class DataView : ContentPage
{
    public DataView()
    {
        InitializeComponent();
        BindingContext = new MVVM.ViewModels.DataViewModels();
    }
}
