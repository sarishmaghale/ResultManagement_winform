using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Runtime.InteropServices.ComTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Reflection;
using System.Windows.Forms;

namespace ResultManagement.Providers
{
    public class ResultProvider
    {
        private ResultManagementDbEntities db = new ResultManagementDbEntities();
        public bool AddResult(ResultModel Results)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    string overallResult = "Pass";
                    foreach (var item in Results.ResultDetails)
                    {
                        if (item != null && item.Marks < 40)
                        {
                            overallResult = "Fail";
                            break;
                        }
                    }
                    tblResults data1 = new tblResults()
                    {
                        StudentId = Results.StudentId,
                        ClassId = Results.ClassId,
                        ExamTypeId = Results.ExamTypeId,
                        Result = overallResult,
                    };
                    db.tblResults.Add(data1);
                    db.SaveChanges();
                  
                    foreach (var item in Results.ResultDetails)
                    {
                        if (item != null)
                        {
                            tblResultDetails resultDetails = new tblResultDetails()
                            {
                                ResultId = data1.ResultId,
                                SubjectId = item.SubjectId,
                                Marks = item.Marks.ToString(),
                            };
                            db.tblResultDetails.Add(resultDetails);
                            db.SaveChanges();
                        }

                    }
                    transaction.Commit();
                    return true;
                }




                catch (Exception ex)
                {
                    transaction.Rollback();
                    return false;
                }

            }
        }

        public List<ResultModel> GetResults(int classId,int ExamTypeId)
        {
            var model = (from student in db.tblStudents
                        join results in db.tblResults on student.StudentId equals results.StudentId
                        where results.ClassId == classId && results.ExamTypeId==ExamTypeId
                        select new ResultModel()
                        {
                            StudentId = results.StudentId,
                            StudentRoll = student.StudentRoll,
                            StudentName = student.StudentName,
                            Result = results.Result,
                            ResultId = results.ResultId,

                        }).ToList();
            return model;

        }
        public List<tblResultDetails> GetResultDetails(int ResultId)
        {
            return db.tblResultDetails.Where(x => x.ResultId == ResultId).ToList();
        }

        public DataTable GetResultsByStudent(int id)
        {
            var dt = new DataTable();
            string constr = "Data Source=DESKTOP-772ROET; Initial Catalog= ResultManagementDb; Integrated Security= true";
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT *  FROM ViewResult Where ResultId=@resultId ", con);
                cmd.Parameters.AddWithValue("@resultId", id);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();

            }
            return dt;
        }

       

    }
}

