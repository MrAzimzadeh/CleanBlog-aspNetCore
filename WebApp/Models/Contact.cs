using System.ComponentModel.DataAnnotations;

namespace CleanBlog.Models;


public class Contact
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Phone]
    public string PhoneNumber { get; set; }
    [Required]
    public string Message { get; set; }
}