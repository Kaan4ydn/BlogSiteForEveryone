namespace BlogSiteForEveryone.Models
{
    public class UserViewModel : BaseViewModel
    {
        public string? Photo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public List<PostViewModel> PostViewModels { get; set; }
        public List<ComplainViewModel> ComplainViewModels { get; set; }
    }
}
