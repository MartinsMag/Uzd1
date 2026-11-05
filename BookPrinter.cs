// Paskaidrojums: Book un BookPrinter ir atsevišķas klases, jo Book atbild tikai par grāmatas datiem
// un stāvokli, bet BookPrinter tikai par izvadi. Tā katrai klasei ir tikai viens iemesls mainīties
// – tas ir Single Responsibility princips (S).
public class BookPrinter
{
    public void Print(Book book)
    {
        string state = book.IsBorrowed ? "izsniegta" : "brīva";
        Console.WriteLine($"{book.Title} ({book.Author}) - {state}");
    }
}
