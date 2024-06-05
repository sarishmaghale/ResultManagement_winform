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

namespace ResultManagement
{
    public partial class Student : Form
    {
        CommonUtility utils = new CommonUtility();
        StudentProvider stHelper = new StudentProvider();
        public Student()
        {
            InitializeComponent();
        }

        private void txtClass_TextChanged(object sender, EventArgs e)
        {
            if(txtClass.Text!= null)
            {
                int ClassId = Int32.Parse(txtClass.Text);
                StudentGridView.DataSource = utils.GetStudents(ClassId);
                StudentGridView.AutoGenerateColumns = false;
            }
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblStudents student = new tblStudents();
            student.ClassId = Int32.Parse(txtClass.Text);
            student.StudentName = txtStudent.Text;
            student.StudentRoll = txtStudentRoll.Text;
            string result= stHelper.AddStudents(student);
            MessageBox.Show(result);
            txtStudentRoll.Clear();
            StudentGridView.DataSource = utils.GetStudents(Int32.Parse(txtClass.Text));
        }

        private void Student_Load(object sender, EventArgs e)
        {
            LoadPage();
        }
        public void LoadPage()
        {
            StudentGridView.AutoGenerateColumns = false;
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            txtStudent.Text = utils.GetStudentName(Int32.Parse(txtStudentId.Text));
        }
    }
}
