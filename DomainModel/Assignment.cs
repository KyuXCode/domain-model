namespace DomainModel;

public class Assignment
{
    private int id;
    private string description;
    private int points;
    private string dueDate;
    private float score;

    bool isCompleted;
    
    public int getId()
    {
        return this.id;
    }

    public string getDescription()
    {
        return this.description;
    }
    public int getPoints()
    {
        return this.points;
    }
    public string getDueDate()
    {
        return this.dueDate;
    }
    public float getScore()
    {
        return this.score;
    }

    public bool getStatus()
    {
        return this.isCompleted;
    }
}