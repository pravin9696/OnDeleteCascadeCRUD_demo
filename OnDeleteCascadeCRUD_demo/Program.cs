using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnDeleteCascadeCRUD_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentCRUD sobj=new StudentCRUD();
            // sobj.Delete_course();
            sobj.delete_course_by_cascading();
        }
    }
}
