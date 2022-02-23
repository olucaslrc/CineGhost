using System.ComponentModel.DataAnnotations.Schema;
using CineGhost.Domain.Base;

namespace CineGhost.Domain.Entities;

[Table("tickets")]
public partial class Ticket : BaseEntity
{
    [Column("id")]
    public long ID { get; private set; }

    [ForeignKey("user_id")]
    public long UserID { get; private set; }

    [Column("movie")]
    public string Movie { get; private set; }
    
}