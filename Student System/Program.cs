using Student_System.Data;
using System;

namespace Student_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new StudentSystemContext();
            context.Database.EnsureCreated();
        }
    }
}
