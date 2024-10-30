class Book
{
    private int Id;
    public static int BookCount = 0;

    public Book(){
        Id = BookCount;
        BookCount++;
    }

    public int ID => Id;
}