using OnDeleteCascadeCRUD_demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnDeleteCascadeCRUD_demo
{
    internal class StudentCRUD
    {
        public void Delete_course()
        {
            StudentMGTEntities dbo = new StudentMGTEntities();

            Console.WriteLine("enter course id to delete records");
            int cid = int.Parse(Console.ReadLine());
            var courseObj = dbo.Courses_temp.Find(cid);
            if (courseObj!=null)
            {
                var studs = dbo.Students.Where(x => x.courseID == cid).ToList();


               dbo.Courses_temp.Remove(courseObj); //remove (delete) course from courses table
                dbo.Students.RemoveRange(studs);
                int n=dbo.SaveChanges();
                if (n>0)
                {
                    Console.WriteLine("records deleted successfully..");
                }
               
            }
        }
        public void delete_course_by_cascading()
        {
            StudentMGTEntities dbo = new StudentMGTEntities();

            Console.WriteLine("enter course id to delete records from database");
            int cid=int.Parse(Console.ReadLine());
            var courseObj = dbo.Courses_temp.Find(cid);// find method 
            if (courseObj!=null)
            {
                dbo.Courses_temp.Remove(courseObj);
                int n = dbo.SaveChanges();
                if (n>0)
                {
                    Console.WriteLine("all records deleted from DB");
                }
                else
                {
                    Console.WriteLine("unable to delete course and other records!!!");
                }
            }
            else
            {
                Console.WriteLine("course not found!!!");
            }
        }
    }
}
