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

        public void CreateUser(UserDto userDto)
        {
            // Validation
            if (userDto.Email.Length > 50 || userDto.Email.Length == 0)
            {
                throw new Infrastructure.ValidationException("Wrong length of Email", userDto.Email);
            }

            if (userDto.FirstName.Length > 50 || userDto.FirstName.Length == 0)
            {
                throw new Infrastructure.ValidationException("Wrong length of First name", userDto.FirstName);
            }

            if (userDto.LastName.Length > 50 || userDto.LastName.Length == 0)
            {
                throw new Infrastructure.ValidationException("Wrong length of Last name", userDto.LastName);;
            }

            if (userDto.Password.Length == 0)
            {
                throw new Infrastructure.ValidationException("Wrong length of Password", userDto.Password);
            }

            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(emailPattern);
            if (!regex.IsMatch(userDto.Email))
            {
                throw new Infrastructure.ValidationException("Wrong format of Email", userDto.Email);
            }
            
            if (!Database.Users.IsEmailUnique(userDto.Email))
            {
                throw new Infrastructure.ValidationException("Email is already taken", userDto.Email);
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

        public IEnumerable<UserDto> GetAllUsers()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDto>());
            var mapper = config.CreateMapper();
            var users = Database.Users.GetAll();
            var userDtos = mapper.Map<IEnumerable<User>, IEnumerable<UserDto>>(users);
            return userDtos;
        }

    }
}