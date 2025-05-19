using System.ComponentModel.DataAnnotations.Schema;

namespace finart_stock_web_api.Model;

public enum Role
{
    Admin,
    User,
    Guest
}
[Table("user_roles")]
public class UserRole
{
    [Column("id")]
    public int Id { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("role_name")]
    public Role RoleName { get; set; }

    [Column("created_at")]
    public DateTime  CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime  UpdatedAt { get; set; }

    // Navigation property
    public User User { get; set; }
} 