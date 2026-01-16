using System;
using System.Collections.Generic;
using LPU_Entity;
using LPU_Common;
using LPU_DAL;
using LPU_Exceptions;

namespace LPU_BL
{
    // This is not static because multiple instances are allowed unlike Netflix
    public class StudentBL : IStudentCRUD
    {
        StudentDAO sDAO = null;
        // this is object can be accessed by every member of the class
        // all methods in Student DAO are instances
        //  to invoke them object is required
        public StudentBL() 
        { 
            sDAO = new StudentDAO();
            // If I had init this object before the constructor, then it would have been in the memory
            // without even invoking the constructor
        }
        public bool DropStudentDetails(int id)
        {
            throw new NotImplementedException();
        }

        public bool EnrollStudent(Student sObj)
        {
            return sDAO.EnrollStudent(sObj); 
            // In memory collection
            // Will return true or false to the UI layer
            // This logic is in DAL layer
        }

        public Student SearchStudentByID(int rollNo)
        {
            Student s1 = null;
            try {
                s1 = sDAO.SearchStudentByID(rollNo);
                
            }catch(LPUException e)
            {
                throw e; // this is rethrow 
                //rethrown into UI
            }

            return s1;
            
        }

        public List<Student> SearchStudentByName(string name)
        {
            return sDAO.SearchStudentByName(name);
        }

        public bool UpdateStudentDetails(int id, Student newObj)
        {
            throw new NotImplementedException();
        }
    }
}
