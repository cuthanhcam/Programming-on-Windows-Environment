using Session_08.BUS;
using Session_08.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_08.GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi tạo DbContext
            var dbContext = new StudentManagementDBContext();

            // Khởi tạo các Service
            var studentService = new StudentService(dbContext);
            var classService = new ClassService(dbContext);
            Application.Run(new frmStudent(studentService, classService));
        }
    }
}
