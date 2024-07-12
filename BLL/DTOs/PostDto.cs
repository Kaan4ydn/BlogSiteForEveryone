using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PostDto : BaseDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string? Photo { get; set; }
        public bool IsApproved { get; set; }
        public int Likes { get; set; }
        public int UserId { get; set; }
        public UserDto UserDto { get; set; }
        public List<ComplainDto> ComplainDtos { get; set; }
    }
}
