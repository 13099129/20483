using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Student
    {
        public Int32 StudentId { get; set; } = 0;
        public string Name { get; set; } = "";


        public bool Save()
        {
            string sql = $"INSERT INTO STUDENT(id,name) values('{this.StudentId}','{this.Name}')";
            return true;
        }
    }
}
