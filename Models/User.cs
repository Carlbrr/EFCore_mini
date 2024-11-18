namespace EFCoreProject_itm8prep.Models;

public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    //Usually the password should be hashed, but for simplicity we will store it as plain text, or even better; External Authentication
    public required string Password { get; set; }
    public required string Role { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    //public List<Post> Posts { get; set; }
    
    public User(string name, string email, string password, string role = "user")
    {
        Name = name;
        Email = email;
        Password = password;
        Role = role;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
    
    
}