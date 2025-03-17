namespace partial_view_task.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Email { get; set; }

        public string UniversityName { get; set; }   

        public string? Address { get; set; }

        public string? Phone { get; set; }

        public int level { get; set; }

        public int TotalGPA { get; set; }

        public int? DepartmentId { get; set; }

        public Department? Department { get; set; }
    }
}
