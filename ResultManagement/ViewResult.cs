using ResultManagement.DataSets;
using ResultManagement.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ResultManagement
{
    public partial class ViewResult : Form
    {
        CommonUtility utils = new CommonUtility();
        ResultProvider resultHelper = new ResultProvider();
        public ViewResult()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ViewResultGridView.Rows.Clear();
            int ClassId = Int32.Parse(txtClass.Text);
            var data = utils.GetSubjects(ClassId);
            int SubjectCount = utils.CountSubject(ClassId);

            var allSubjects = utils.GetSubjectsByClass(ClassId);
            // Add dynamic columns for subjects
            foreach(var sub in allSubjects)
            {
                ViewResultGridView.Columns.Add(sub.SubjectName, sub.SubjectName);
            }
            //fill the column name for each subject according to class
            int i = 4;
            for (int j = 1; j <= SubjectCount; j++)
            {

                foreach (var subject in data)
                {
                    string name = utils.GetSubjectName((int)subject.SubjectId);
                    ViewResultGridView.Columns[i].HeaderText = name;
                    i++;
                    j++;
                }

            }
            int ExamTypeId = (int)ExamTypeComboBox.SelectedValue;

            //get results for each student
            var resultData = resultHelper.GetResults(ClassId,ExamTypeId);

            foreach (var item in resultData)
            {
                DataGridViewRow existingRow = null;

                // Check if the row for the current student already exists
                foreach (DataGridViewRow row in ViewResultGridView.Rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == item.StudentRoll.ToString())
                    {
                        existingRow = row;
                        break;
                    }
                }

                // Get the details for the current result
                int ResultId = item.ResultId;
                var subjects = resultHelper.GetResultDetails(ResultId);

                if (existingRow != null)
                {
                    // Update the existing row
                    int x = 4;
                    foreach (var subject in subjects)
                    {
                        existingRow.Cells[x].Value = subject.Marks;
                        x++;
                    }
                }
                else
                {
                    // Create a new row for the new student
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(ViewResultGridView);
                    newRow.Cells[1].Value = item.StudentId;
                    newRow.Cells[2].Value = item.StudentName;
                    newRow.Cells[3].Value = item.ResultId;

                    int x = 4;
                    foreach (var subject in subjects)
                    {
                        newRow.Cells[x].Value = subject.Marks;
                        x++;
                    }

                    ViewResultGridView.Rows.Add(newRow);
                }
            
        }
        }

        private void ViewResult_Load(object sender, EventArgs e)
        {
            ExamTypeComboBox.DataSource = utils.GetExamTypes();
            ExamTypeComboBox.ValueMember = "ExamTypeId";
            ExamTypeComboBox.DisplayMember = "ExamTypeName";
        }

        private void ViewResultGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = ViewResultGridView.Rows[indexRow];
           
            int ResultId = (int)row.Cells[3].Value;
         
            PrintResult prpt = new PrintResult(ResultId);
            prpt.Show();
        }
    }
}
