namespace DomainModel;

public class Course
{ 
    private int id;
    private int courseNumber;
    private string courseName;

    private List<Student> students;
    private List<Assignment> assignments;
    private List<Announcement> announcements;

    private Instructor instructor;
    
    
    public int getId() 
    {
        return this.id;
    }
    
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
    
    public List<Announcement> getAnnouncements() 
    {
        return this.announcement;
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
