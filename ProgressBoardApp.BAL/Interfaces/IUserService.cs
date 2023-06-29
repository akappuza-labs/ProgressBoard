using ProgressBoardApp.BAL.DTO;

namespace ProgressBoardApp.BAL.Interfaces
{
    public interface IUserService
    {
        void CreateUser(UserDTO userDto);
        IEnumerable<UserDTO> GetAllUsers();
        void Dispose();
    }
}
