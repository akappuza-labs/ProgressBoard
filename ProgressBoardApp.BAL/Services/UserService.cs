using AutoMapper;
using ProgressBoardApp.BAL.DTO;
using ProgressBoardApp.BAL.Interfaces;
using ProgressBoardApp.DAL.Interfaces;
using ProgressBoardApp.Domain.Entities;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace ProgressBoardApp.BAL.Services
{
    public class UserService : IUserService
    {
        IUnitOfWork Database { get; set; }

        public UserService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void CreateUser(UserDTO userDto)
        {
            // Validation
            if (userDto.Email.Length > 50 || userDto.Email.Length == 0)
            {
                throw new Infrastructure.ValidationException(userDto.Email, "Wrong length of Email");
            }

            if (userDto.FirstName.Length > 50 || userDto.FirstName.Length == 0)
            {
                throw new Infrastructure.ValidationException(userDto.FirstName, "Wrong length of First name");
            }

            if (userDto.LastName.Length > 50 || userDto.LastName.Length == 0)
            {
                throw new Infrastructure.ValidationException(userDto.LastName, "Wrong length of Last name");;
            }

            if (userDto.Password.Length == 0)
            {
                throw new Infrastructure.ValidationException(userDto.Password, "Wrong length of Password");
            }

            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(emailPattern);
            if (!regex.IsMatch(userDto.Email))
            {
                throw new Infrastructure.ValidationException(userDto.Email, "Wrong format of Email");
            }
            
            if (!Database.Users.IsEmailUnique(userDto.Email))
            {
                throw new Infrastructure.ValidationException(userDto.Email, "Email is already taken");
            }

            // Password hash
            byte[] inputBytes = Encoding.UTF8.GetBytes(userDto.Password);
            string hashString;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(inputBytes); 
                hashString = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
            }
            
            User user = new User
            {
                Email = userDto.Email,
                Password = hashString,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
            };
            Database.Users.Create(user);
            Database.Save();
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>()).CreateMapper();
            return (IEnumerable<UserDTO>)mapper.Map<IEnumerable<User>, List<User>>(Database.Users.GetAll());
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}