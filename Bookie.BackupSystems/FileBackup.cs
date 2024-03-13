using DataAccess.Models;

namespace Bookie.BackupSystems;

public class FileBackup
{
    private const string BackupDirectory = @"C:\Users\JannikJost\Documents\BookieFileTests\bu";


    public void BackupBook(Book book)
    {
        if (string.IsNullOrEmpty(book.FilePath))
        {
            throw new Exception();
        }

        if (File.Exists(book.FilePath))
        {
            return;
        }

        var filePathForBackup = GetFileName(book);

        MoveFile(book.FilePath, filePathForBackup);
    }

    private string GetFileName(Book book)
    {
        var extension = Path.GetExtension(book.FilePath);
        return BackupDirectory + "\\" + book.Metadata.Title + extension;
    }

    private static void MoveFile(string path, string destinationPath)
    {
        if (File.Exists(path) == false)
        {
            return;
        }

        File.Move(path, destinationPath);
    }
}