namespace ClassroomProject
{
    public class Student
    {
        private string _firstName;
        private string _lastName;
        private string _subject;

        public Student(string firstName, string lastName, string subject)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._subject = subject;
        }

        public string FirstName
        {
            get => this._firstName;
            set => this._firstName = value;
        }
        public string LastName {
            get => this._lastName;
            set => this._lastName = value;
        }
        public string Subject {
            get => this._subject;
            set => this._subject = value;
        }
        
        public override string ToString()
        {
            return $"Student: First Name = {_firstName}, Last Name = {_lastName}, Subject = {_subject}";
        }
    }
}
