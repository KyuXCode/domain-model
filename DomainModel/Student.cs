namespace DomainModel;

public class Student
{
    private int id;
    private string firstName;
    private string lastName;
    private string email;

    public List<Course> classes;   
    
    public int getId()
    {
        return this.id;
    }
    public string getFirstName()
    {
        return this.firstName;
    }
    public string getLastName()
    {
        return this.lastName;
    }
    public string getEmail()
    {
        return this.email;
    }
    
    public List<int> checkGrades(Course selectedCourse) 
    {
        List<Assignment> assignments = selectedCourse.getAssignments();
        List<int> scores = assignments.getScore;
        return scores;
    }

}