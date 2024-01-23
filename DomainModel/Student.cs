namespace DomainModel;

public class Student
{
    int id;
    string firstName;
    string lastName;
    string email;

    List<Course> classes;   
    
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