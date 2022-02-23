using System.ComponentModel.DataAnnotations.Schema;
using CineGhost.Domain.Base;

namespace CineGhost.Domain.Entities;

[Table("users")]
public partial class User : BaseEntity
{
    public User(string userName, string firstName, string lastName, string address,
        DateTime birthDate, string email)
    {
        this.UserName   = userName;
        this.FirstName  = firstName;
        this.LastName   = lastName;
        this.Address    = address;
        this.BirthDate  = birthDate;
        this.Email      = email;
    }

    [Column("id")]
    public long ID { get; private set; }

    [Column("user_name")]
    public string UserName { get; private set; }

    [Column("first_name")]
    public string FirstName { get; private set; }

    [Column("last_name")]
    public string LastName { get; private set; }

    [Column("address")]
    public string Address { get; private set; }

    [Column("birthdate")]
    public DateTime? BirthDate { get; private set; }

    [Column("email")]
    public string Email { get; private set; }
    public IList<Ticket> Tickets { get; private set; }
}