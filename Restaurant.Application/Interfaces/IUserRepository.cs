using Restaurant.Domain.Entities;

namespace Restaurant.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<int> CreateUserAsync(User user);
        Task UpdateUserAsyn(User user);
        Task DeleteUserAsync(int userId);
        Task<List<User>> GetAllUsersAsync();
    }
}
