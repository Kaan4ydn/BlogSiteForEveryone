using DAL.Entities;

namespace BlogSiteForEveryone.Models
{
    public class PostViewModel : BaseViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string? Photo { get; set; }
        public bool IsApproved { get; set; }
        public int Likes { get; set; }
        public int UserId { get; set; }
        public UserViewModel UserViewModel { get; set; }
        public List<ComplainViewModel> ComplainViewModels { get; set; }
    }
}
