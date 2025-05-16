using System.ComponentModel.DataAnnotations.Schema;

namespace finart_stock_web_api.Model
{
    public class User
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("role")]
        public string Role { get; set; }
        [Column("created_at")]
        public string CreatedAt { get; set; }
        [Column("update_at")]
        public string UpdatedAt { get; set; }
        public List<Comment> Comments { get; set; }
    }
}