namespace DomainModel;

public class Announcement
{ 
    int id;

    string title;
    string announcement;

    string author;

    public void getId()
    {
        return this.id;
    }
    public void getTitle()
    {
        return this.title;
    }
    public void getAnnouncement()
    {
        return this.announcement;
    }
}