using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ComplainDto : BaseDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public UserDto UserDto { get; set; }
        public int PostId { get; set; }
        public PostDto PostDto { get; set; }
    }
}
