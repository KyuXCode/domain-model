namespace DomainModel;

public class Assignment
{
    int id;
    string description;
    int points;
    string dueDate;
    int score;

    bool isCompleted;

    public void grade(int grade)
    {
        this.score = grade;
    }
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
    public int getScore()
    {
        return this.score;
    }

    public bool getStatus()
    {
        return this.isCompleted;
    }

    public string remove()
    {
        return "remove";
    }

    public string update()
    {
        return "update";
    }
}