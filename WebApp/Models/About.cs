using System.Security.Principal;
using Microsoft.CodeAnalysis.Operations;

namespace CleanBlog.Models;

public class About
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string SubTitle { get; set; }
    public string  Description  { get; set; }
    public string PhotoUrl { get; set; }
}