using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultManagement
{
     public class CommonUtility
    {
       private  ResultManagementDbEntities db= new ResultManagementDbEntities();     

     
        public List <tblStudents> GetStudents(int classId)
        {
            return db.tblStudents.Where(x => x.ClassId == classId).ToList();
        }

        public List<tblExamType> GetExamTypes()
        {
            return db.tblExamType.ToList();
        }
        public List<tblClassSubject> GetSubjects(int classId)
        {
            return db.tblClassSubject.Where(x => x.ClassId == classId).ToList();
        }

        public int CountSubject(int classId)
        {
           return db.tblClassSubject.Where(x => x.ClassId == classId).Count();
        }
      
        public int GetSubjectId(string subjectName)
        {
           return db.tblSubjects.Where(x => x.SubjectName == subjectName).Select(x => x.SubjectId).FirstOrDefault();
        }
     

        public string GetSubjectName(int subjectId)
        {
            return db.tblSubjects.Where(x => x.SubjectId == subjectId).Select(x => x.SubjectName).FirstOrDefault();
        }


        public List<ResultModel> GetSubjectsByClass(int classId)
        {

            var model = (from context in db.tblClassSubject
                        join data in db.tblSubjects on context.SubjectId equals data.SubjectId
                        where context.ClassId == classId
                        select new ResultModel()
                        {
                            SubjectId = (int)context.SubjectId,
                            SubjectName = data.SubjectName,
                        }).ToList();
            return model;


            
        }


        public List<tblClass> GetClasses()
        {
            var data = db.tblClass.ToList();
            return data;
        }
       
     
        public string GetStudentName(int studentId)
        {
            return db.tblStudents.Where(x => x.StudentId == studentId).Select(x => x.StudentName).FirstOrDefault();
        }

        public List<tblSubjects> GetTotalSubjects()
        {
            return db.tblSubjects.ToList();
        }

        
    }



}
