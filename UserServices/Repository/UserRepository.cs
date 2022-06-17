using System.Linq;
using UserServices.POCO.Data;
using UserServices.POCO.Models;

namespace UserServices.Repository
{
    public class UserRepository : IRepository<User>
    {
        private readonly SystemGeneratedDbContext _context;

        public UserRepository(SystemGeneratedDbContext context)
        {
            _context = context;
        }

        public void Add(User item)
        {
            _context.User.Add(item);
            _context.SaveChanges();
        }

        public User Find(int key)
        {
            return _context.User.FirstOrDefault(x => x.UserId == key);
        }

        public IQueryable<User> GetAll()
        {
            return _context.User;
        }

        public void Remove(int key)
        {
            var user = Find(key);
            _context.User.Remove(user);
            _context.SaveChanges();
        }
    }
}
