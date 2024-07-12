using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AbstractServices
{
    public interface IPostService
    {
        Task CreatePost(PostDto postDto);
        Task<List<PostDto>> GetAllPosts();
        Task ApprovePost(int postId);
        Task DeletePost(int postId);
        Task LikePost(int postId);
        Task<List<PostDto>> GetPostsByCategory(int categoryId);
        Task ReportPost(int postId, ComplainDto complainDto);
    }
}
