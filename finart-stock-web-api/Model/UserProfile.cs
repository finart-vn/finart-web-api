using System.ComponentModel.DataAnnotations.Schema;

namespace finart_stock_web_api.Model;
[Table("user_profiles")]
public class UserProfile
{
    [Column("id")]
    public int Id { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("first_name")]
    public string FirstName { get; set; }

    [Column("last_name")]
    public string LastName { get; set; }

    [Column("phone_number")]
    public string PhoneNumber { get; set; }

    [Column("address")]
    public string Address { get; set; }

    [Column("date_of_birth")]
    public DateTime  DateOfBirth { get; set; }

    [Column("profile_picture_url")]
    public string ProfilePictureUrl { get; set; }

    [Column("created_at")]
    public DateTime  CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime  UpdatedAt { get; set; }

    // Navigation property
    public User User { get; set; }
} 