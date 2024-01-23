namespace DomainModel;

public class Course
{ 
    int id;
    int courseNumber;
    string courseName;

    List<Student> students;
    List<Assignment> assignments;

    Instructor instructor;
    
    public Course() 
    {
        this.students = new List<Student>();
        this.assignments = new List<Assignment>();
        this.instructor = new Instructor;
    }
    public List<Assignment> getAssignments()
    {
        return this.assignments;
    }

    public List<Student> getStudents() 
    {
        return this.students;
    }
    public int getId() 
    {
        return this.id;
    }
    public int getCourseNumber() 
    {
        return this.courseNumber;
    }
    public string getCourseName() 
    {
        return this.courseName;
    }

    public Instructor getInstructor()
    {
        return this.instructor;
    }
}
