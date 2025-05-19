using System.ComponentModel.DataAnnotations.Schema;

namespace finart_stock_web_api.Model;
[Table("user_settings")]
public class UserSettings
{
    [Column("id")]
    public int Id { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("theme")]
    public string Theme { get; set; }

    [Column("language")]
    public string Language { get; set; }

    [Column("notification_enabled")]
    public bool NotificationEnabled { get; set; }

    [Column("email_notification_enabled")]
    public bool EmailNotificationEnabled { get; set; }

    [Column("two_factor_enabled")]
    public bool TwoFactorEnabled { get; set; }

    [Column("created_at")]
    public DateTime  CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime  UpdatedAt { get; set; }

    // Navigation property
    public User User { get; set; }
} 