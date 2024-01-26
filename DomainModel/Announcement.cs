namespace DomainModel;

public class Announcement
{ 
    private int id;

    private string title;
    private string announcement;
    private string date;

    private string author;

    public int getId()
    {
        return this.id;
    }
    public string getTitle()
    {
        return this.title;
    }
    public Announcement getAnnouncement()
    {
        return this.announcement;
    }

    public string getDate()
    {
        return this.date;
    } 
    
    public string getAuthor()
    {
        return this.author;
    }
}