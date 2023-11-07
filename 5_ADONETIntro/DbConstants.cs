using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_ADONETIntro
{
    public static class DbConstants
    {
        public static string spGetAllStudents = "usp_GetAllStudents";
        public static string spGetStudentDetailsByRollNumber = "usp_GetStudentDetailsByRollNumber";
        public static string spAllTrainers = "usp_AllTrainers";
        public static string spCreateStudent = "usp_CreateStudent";
        public static string spUpdateStudent = "usp_UpdateStudent";
        public static string spDeleteStudent = "usp_DeleteStudent";
    }
}