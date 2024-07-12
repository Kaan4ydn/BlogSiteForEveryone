using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AbstractServices
{
    public interface IUserService
    {
        Task Register(UserDto userDto);
        Task<UserDto> Login(string username, string password);
        Task<List<UserDto>> GetAllUsers();
    }
}
