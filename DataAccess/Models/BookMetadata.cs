using System.Reflection.Metadata.Ecma335;

namespace DataAccess.Models;

public class BookMetadata
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Authors { get; set; }
    public double NumberOfPages { get; set; }
}