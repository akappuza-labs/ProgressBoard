using ProgressBoardApp.BAL.DTO;

namespace ProgressBoardApp.BAL.Interfaces
{
    public interface IUserService
    {
 
        void CreateUser(UserDto userDto);
        
        IEnumerable<UserDto> GetAllUsers();
        
    }
}
