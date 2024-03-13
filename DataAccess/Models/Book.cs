namespace DataAccess.Models;

public class Book
{
    public Guid Id { get; set; }
    public double Isbn { get; set; }
    public BookMetadata Metadata { get; set; }
    public string FilePath { get; set; }
}