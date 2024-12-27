using Session_08.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace Session_08.BUS
{
    public class ClassService
    {
        private readonly StudentManagementDBContext _context;

        public ClassService(StudentManagementDBContext context)
        {
            _context = context;
        }

        public List<Class> GetAllClasses()
        {
            return _context.Classes.ToList();
        }
    }
}
