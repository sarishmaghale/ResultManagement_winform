using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultManagement.Providers
{
   public class StudentProvider
    {
        ResultManagementDbEntities db = new ResultManagementDbEntities();
        public string AddStudents(tblStudents student)
        {
            
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                  
                    
                    bool checkData = CheckStudentExistInClass(student.StudentId,(int) student.ClassId, student.StudentRoll);
                    if (!checkData)
                    {
                        tblStudents std = new tblStudents()
                        {
                            StudentName = student.StudentName,
                            StudentRoll = student.StudentRoll,
                            ClassId = student.ClassId
                        };
                        db.tblStudents.Add(std);
                        db.SaveChanges();
                        var StudentCount = db.tblClass.Where(x => x.ClassId == student.ClassId).FirstOrDefault();
                        StudentCount.StudentCount++;
                        db.Entry(StudentCount).State = EntityState.Modified;
                        db.SaveChanges();
                        transaction.Commit();
                        return "Data Added";

                    }
                    else
                    {
                        transaction.Rollback();
                        return "Roll Number already exist ";


                    }
                   
                }
                catch (Exception ex)
                {
                    return "Failed to add ";
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public bool CheckStudentExistInClass(int StudentId,int ClassId,string RollNo)
        {
           var result= db.tblStudents.Where(x=>x.ClassId == ClassId && x.StudentRoll==RollNo).Count();

            bool res = (result>0) ? true : false;
            return res;
        }
      
    }
}
