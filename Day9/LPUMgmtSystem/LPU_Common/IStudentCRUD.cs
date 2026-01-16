using System;
using LPU_Entity;
using System.Collections.Generic;
namespace LPU_Common
{
    public interface IStudentCRUD
    {
        /// <summary>
        /// Interface is for service oriented applications
        /// Whenever this interface will be implemented, all the abstract methods will HAVE TO BE
        /// overriden. It is and enforcement
        /// </summary>
        Student SearchStudentByID(int ID);
        List<Student> SearchStudentByName(string name);
        bool EnrollStudent(Student sObj);
        bool UpdateStudentDetails(int id, Student newObj);
        bool DropStudentDetails(int id);
    }
}
