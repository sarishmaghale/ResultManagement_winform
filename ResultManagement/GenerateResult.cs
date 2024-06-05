
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ResultManagement
{
    public partial class GenerateResult : Form
    {
        CommonUtility utils = new CommonUtility();
        ResultProvider resultHelper = new ResultProvider();
        public GenerateResult()
        {
            
            InitializeComponent();
        }

        private void GenerateResult_Load(object sender, EventArgs e)
        {
            ExamTypeCombo.DataSource = utils.GetExamTypes(); 
            ExamTypeCombo.ValueMember = "ExamTypeId";
            ExamTypeCombo.DisplayMember = "ExamTypeName";
          
        }
        private void PageRefresh()
        {
            txtRollNum.Clear();
            SubjectGridView.DataSource =utils.GetSubjectsByClass(Int32.Parse(txtClassId.Text));
        }

        private void btnClassSearch_Click(object sender, EventArgs e)
        {            
            StudentGridView.AutoGenerateColumns = false;
            int classId = Int32.Parse(txtClassId.Text);
            StudentGridView.DataSource = utils.GetStudents(classId);
            SubjectGridView.AutoGenerateColumns = false;
            SubjectGridView.DataSource = utils.GetSubjectsByClass(classId);


        }

        private void StudentGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = StudentGridView.Rows[indexRow];
            txtRollNum.Text = row.Cells[1].Value.ToString();
            txtStudentId.Text = row.Cells[0].Value.ToString();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ResultModel model = new ResultModel();
            model.StudentId = Int32.Parse(txtStudentId.Text);
            model.ClassId = Int32.Parse(txtClassId.Text);
            model.ExamTypeId = (int)ExamTypeCombo.SelectedValue;
            List<ResultModel> marks = new List<ResultModel>();
            foreach (DataGridViewRow row in SubjectGridView.Rows)
            {
                if (row.IsNewRow) continue;
                marks.Add(new ResultModel
                {
                    SubjectId = Convert.ToInt32(row.Cells[0].Value),
                    SubjectName = row.Cells[1].Value.ToString(),
                    Marks = Convert.ToInt32(row.Cells[2].Value),
                });
            }

            model.ResultDetails = marks;
           
            bool insert = resultHelper.AddResult(model);
            if (insert)
            {
                MessageBox.Show("Successfully inserted");
               
                PageRefresh();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
