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
    public partial class SubjectToClass : Form
    {
        CommonUtility utils = new CommonUtility();
        ClassProvider clHelper = new ClassProvider();

        public SubjectToClass()
        {
            InitializeComponent();
        }

        private void txtClassId_TextChanged(object sender, EventArgs e)
        {
        }

        private void SubjectToClass_Load(object sender, EventArgs e)
        {

            SubjectComboBox.DataSource = utils.GetTotalSubjects();
            SubjectComboBox.DisplayMember = "SubjectName";
            SubjectComboBox.ValueMember = "SubjectId";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SubjectDataGridView.AutoGenerateColumns = false;

            SubjectDataGridView.DataSource = utils.GetSubjectsByClass(Int32.Parse(txtShowClass.Text));
            txtClassId.Text = txtShowClass.Text;
        }
        public void PageReload()
        {
            SubjectDataGridView.DataSource = utils.GetSubjectsByClass(Int32.Parse(txtShowClass.Text));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ResultModel model = new ResultModel();
            var selectedSubject = (dynamic)SubjectComboBox.SelectedItem;
            model.SubjectId = selectedSubject.SubjectId;
            model.ClassId = Int32.Parse(txtClassId.Text);
            bool result = clHelper.AddSubjectsToClass(model);
            if (result)
            {
                MessageBox.Show("Inserted Successfully");
                PageReload();
            }
            else
            {
                MessageBox.Show("Failed to add", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
