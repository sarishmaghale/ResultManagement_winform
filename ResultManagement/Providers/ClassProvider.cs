using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultManagement.Providers
{
    class ClassProvider
    {
        private ResultManagementDbEntities db = new ResultManagementDbEntities();
        public bool AddSubjectsToClass(ResultModel model)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    tblClassSubject data = new tblClassSubject()
                    {
                        SubjectId = model.SubjectId,
                        ClassId = model.ClassId,
                    };
                    db.tblClassSubject.Add(data);
                    db.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.Write(ex.ToString());
                    return false;
                }
            }
               
        }

        public bool AddClass(ResultModel model)
        {
            tblClass data = new tblClass() { 
                ClassId=(int)model.ClassId,
                StudentCount=(int)model.StudentCount,

            };
            db.tblClass.Add(data);
            int x=db.SaveChanges();
            bool result=(x > 0) ? true : false;
            return result;

        }
    }
}
