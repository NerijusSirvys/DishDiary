using DishDiary.Mobile.ViewModels;

namespace DishDiary.Mobile;

public partial class DishListPage : ContentPage
{
    public DishListPage(DishListViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }
}
