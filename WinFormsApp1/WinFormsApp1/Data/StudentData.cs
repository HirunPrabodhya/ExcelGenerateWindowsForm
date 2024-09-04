using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.models;

namespace WinFormsApp1.Data
{
     class StudentData
    {
        internal static List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student> {
                                    new Student
                                    {
                                        Id = 1,
                                        FirstName = "Hirun",
                                        LastName  = "Prabodhya",
                                        Address = "549/2/A,'Lahiru',Mihindumawatha,Malwaththa,Nittambuwa"
                                    },
                                    new Student
                                    {
                                        Id = 2,
                                        FirstName = "Dineth",
                                        LastName = "Lahiru",
                                        Address = "549/2/B/,Mihindumawatha,Malwaththa,Nittambuwa"
                                    }

            };
            return students;

        }
    }
}
