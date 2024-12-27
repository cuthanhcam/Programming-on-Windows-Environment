using Session_08.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_08.BUS
{
    public class StudentService
    {
        private readonly StudentManagementDBContext _context;

        public StudentService(StudentManagementDBContext context)
        {
            _context = context;
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.Include("Class").ToList();
        }

        public void AddStudent(Student student)
        {
            if (_context.Students.Any(s => s.StudentID == student.StudentID))
                throw new Exception("Mã sinh viên đã tồn tại!");

            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            var existingStudent = _context.Students.Find(student.StudentID);
            if (existingStudent == null)
                throw new Exception("Không tìm thấy sinh viên!");

            existingStudent.StudentName = student.StudentName;
            existingStudent.DateOfBirth = student.DateOfBirth;
            existingStudent.ClassID = student.ClassID;
            _context.SaveChanges();
        }

        public void DeleteStudent(string studentID)
        {
            var student = _context.Students.Find(studentID);
            if (student == null)
                throw new Exception("Không tìm thấy sinh viên!");

            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public List<Student> SearchStudents(string searchText)
        {
            return _context.Students
                .Include("Class")
                .Where(s => s.StudentName.ToLower().Contains(searchText.ToLower()))
                .ToList();
        }
    }
}
