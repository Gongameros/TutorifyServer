using Microsoft.EntityFrameworkCore;
using TutorifyServer.Models.Person;

namespace TutorifyServer.Data
{
    public class TutorRepository : IPersonRepository<Tutor>
    {
        private readonly TutorifyContext _context;
        public TutorRepository(TutorifyContext context)
        {
            _context = context;
        }

        public Tutor Create(Tutor tutor)
        {
            _context.Tutors.Add(tutor);
            tutor.Id = _context.SaveChanges();

            return tutor;
        }

        public Tutor GetByEmail(string email)
        {
            return _context.Tutors.FirstOrDefault(t => t.Email == email);
        }

        public Tutor GetById(int id)
        {
            return _context.Tutors.FirstOrDefault(t => t.Id == id);
        }
    }
}
