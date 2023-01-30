namespace PracticaCollectionView.MVVM.Views;

public partial class LayoutPage2 : ContentPage
{
    public LayoutPage2()
    {
        InitializeComponent();
        BindingContext = new MVVM.ViewModels.DataViewModels();
    }

    void Switch_Toggled(System.Object sender, Microsoft.Maui.Controls.ToggledEventArgs e)
    {
        var isToggled = e.Value;
        collectionProduct.EmptyView = isToggled ? Resources["NoResultsView"] : Resources["ConnectivityIssue"];
    }
}
