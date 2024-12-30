namespace SocialMedia.Core.Entities
{
    public class User
    {
        public int UserId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public DateOnly BirthDate { get; set; }

        public string? Phone { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Comment> Coments { get; set; } = new List<Comment>();

        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
    }

}

