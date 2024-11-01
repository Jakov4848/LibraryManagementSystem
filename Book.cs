class Book
{
    //  atributes
    public static int bookCount = 0;
    private int id;
    private string title;
    private string author;
    private string publicationYear;
    private int numOfPages;
    private string language;
    
    
    //  constructors
    //  default
    public Book(){
        id = bookCount;
        bookCount++;
    }

    //  parametric    
    public Book(string title, string author, string publicationYear, int numOfPages, string language){
        this.title = title;
        this.author = author;
        this.publicationYear = publicationYear;
        this.numOfPages = numOfPages;
        this.language = language;
        id = bookCount;
        bookCount++;
    }


    //  getter methods
    public int ID => id;
    public string Title => title;
    public string Author => author;
    public string PublicationYear => publicationYear;
    public int NumOfPages => numOfPages;
    public string Language => language;

}