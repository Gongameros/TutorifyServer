using TutorifyServer.Models.Person;

namespace TutorifyServer.Data
{
    public class StudentRepository : IPersonRepository<Student>
    {
        private readonly TutorifyContext _context;

        public StudentRepository(TutorifyContext context)
        {
            _context = context;
        }

        public Student Create(Student student)
        {
            _context.Students.Add(student);
            student.Id = _context.SaveChanges();

            return student;
        }

        public Student GetByEmail(string email)
        {
            return _context.Students.FirstOrDefault(s => s.Email == email);
        }

        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
        }
    }
}
