using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProgressBoardApp.BAL.DTO;
using ProgressBoardApp.BAL.Interfaces;
using ProgressBoardApp.WEB.Models;

namespace ProgressBoardApp.WEB.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet(Name = "GetUsers")]
        public IEnumerable<UserViewModel> Get()
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<UserDto, UserViewModel>());
            var mapper = new Mapper(mapperConfig);
            var userDTOs = _userService.GetAllUsers();
            var userViewModels = mapper.Map<IEnumerable<UserViewModel>>(userDTOs);
            return userViewModels;
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<UserViewModel, UserDto>());
                var mapper = new Mapper(mapperConfig);
                var userDto = mapper.Map<UserDto>(userViewModel);

                _userService.CreateUser(userDto);

                return CreatedAtRoute("GetUsers", null);
            }

            return BadRequest();
        }
    }
}