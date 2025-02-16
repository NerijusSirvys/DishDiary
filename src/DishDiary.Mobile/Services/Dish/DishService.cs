namespace DishDiary.Mobile.Services.Dish;

using Dish = Data.Dish;

public class DishService
{

    private readonly List<Dish> _dishList = [
        new Dish("d1", "Dish One", "Dish One Description"),
        new Dish("d2", "Dish Two", "Dish Two Description"),
        new Dish("d3", "Dish Three", "Dish Three Description"),
        new Dish("d4", "Dish Four", "Dish Four Description"),
        new Dish("d5", "Dish Five", "Dish Five Description")
        ];

    public IEnumerable<Dish> GetDishes()
    {
        return _dishList;
    }
}
