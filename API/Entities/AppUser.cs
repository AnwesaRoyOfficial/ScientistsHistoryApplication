<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> fb7632f2213c77f519721db927098cea7144822b
using Microsoft.AspNetCore.Identity;

namespace API.Entities;

public class AppUser
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string DisplayName { get; set; } 

    public string Email { get; set; } 

<<<<<<< HEAD
    public string? ImageUrl {get; set;}

    public required byte[] PasswordHash {get; set;}

    public required byte[] PasswordSalt {get; set;}    

    public Member Member { get; set; } = null!;
=======
    public required byte[] PasswordHash {get; set;}

    public required byte[] PasswordSalt {get; set;}
>>>>>>> fb7632f2213c77f519721db927098cea7144822b
}
