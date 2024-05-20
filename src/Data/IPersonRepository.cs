using TutorifyServer.Models.Person;

namespace TutorifyServer.Data
{
    public interface IPersonRepository <T> where T : Person
    {
        T Create(T user);
        T GetByEmail(string email);
        T GetById(int id);
    }
}
