namespace DomainModel;

public class Assignment
{
    int id;
    string description;
    
    // Actual points for the assignment 
    int points;
    string dueDate;
    
    int grade;

    bool isComplete;

    public void getGrade() 
    {
        return this.grade;
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
        return this.isComplete;
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