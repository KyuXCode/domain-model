namespace DomainModel;

public class Instructor
{
    
        private int id;
        private string firstName;
        private string lastName;
        private string email;

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

    
}