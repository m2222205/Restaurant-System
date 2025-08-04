using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Application.Interfaces
{
    public interface IDishRepo
    {
        Task<int> CreateDishAsync(Dish dish);
        Task UpdateDishRepo(Dish dish);
        Task DeleteDishRepo(int id);
        Task<List<Dish>> GetAllDishAsync();


    }
}
