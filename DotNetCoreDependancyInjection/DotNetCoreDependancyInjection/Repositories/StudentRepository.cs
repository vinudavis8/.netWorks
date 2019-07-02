using DotNetCoreDependancyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreDependancyInjection.Repositories
{
    public class StudentRepository:IStudent
    {
        private List<Mstudent> list;

        public StudentRepository()
        {
            list = new List<Mstudent>()
            {
               new Mstudent(){Name="Vinu",Age=27},
                new Mstudent(){Name="Siva",Age=28},
                 new Mstudent(){Name="John",Age=26},
                  new Mstudent(){Name="Nias",Age=25},
            };
        }

        public List<Mstudent>  GetStudentList()
        {
            return list;
        }

    }
}
