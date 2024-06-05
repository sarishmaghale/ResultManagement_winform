using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultManagement
{
    public class ResultModel
    {
        public int ResultId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> ClassId { get; set; }
        public Nullable<int> ExamTypeId { get; set; }
        public string Result { get; set; }

        public virtual tblClass tblClass { get; set; }
        public virtual tblExamType tblExamType { get; set; }
        public virtual tblResults tblResults1 { get; set; }
        public virtual tblResults tblResults2 { get; set; }
        public virtual tblStudents tblStudents { get; set; }

        public int SubjectId { get; set; }
        public string StudentRoll { get; set; }
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
        public int StudentCount { get; set; }
        public int Marks { get; set; }
        public List<ResultModel> ResultDetails { get; set; }
    }
}
