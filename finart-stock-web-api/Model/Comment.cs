using System.ComponentModel.DataAnnotations.Schema;

namespace finart_stock_web_api.Model;

public class Comment
{

    [Column("id")]
    public int Id { get; set; }
    [Column("content")]
    public string Content { get; set; }
    [Column("user_id")]
    public int UserId { get; set; }
    public User User { get; set; }
}
