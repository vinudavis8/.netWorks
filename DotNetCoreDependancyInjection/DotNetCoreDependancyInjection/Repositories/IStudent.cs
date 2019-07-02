using DotNetCoreDependancyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreDependancyInjection.Repositories
{
   public interface IStudent
    {
         List<Mstudent> GetStudentList();
    }
}
