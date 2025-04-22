using Microsoft.AspNetCore.Identity;

namespace SampleApp.Models;

public class ApplicationUser : IdentityUser
{
    // Podstawowe pola
    public string FirstName { get; set; }
    
    // Relacje
    public virtual ICollection<UserOrder> Orders { get; set; }
}

public class UserOrder
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    
    public string UserId { get; set; }
    public virtual ApplicationUser User { get; set; }
}