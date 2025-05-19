using System.ComponentModel.DataAnnotations.Schema;

namespace finart_stock_web_api.Model
{
    
    [Table("users")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("username")]
        public string Username { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("password_hash")]
        public string PasswordHash { get; set; }

        [Column("password_salt")]
        public string PasswordSalt { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public string UpdatedAt { get; set; }

        public UserProfile Profile { get; set; }
        public UserSettings Settings { get; set; }
        public ICollection<UserRole> Roles { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}