using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DishDiary.Mobile.Services.Dish;
using DishDiary.Mobile.Services.Dish.Data;

namespace DishDiary.Mobile.ViewModels;

public partial class DishListViewModel : ObservableObject
{
    private readonly DishService _dishService;

    public ObservableCollection<Dish> Dishes { get; }

    public DishListViewModel(DishService dishService)
    {
        _dishService = dishService;
     
        var dishes = _dishService.GetDishes();
        Dishes = dishes.ToObservableCollection();
    }

    [RelayCommand]
    public void OnCardClick(string id)
    {
        Debug.WriteLine($"Short Pressed: {id}");
    }
}
