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
    public partial class Classes : Form
    {
        public CommonUtility utils = new CommonUtility();
        ClassProvider clHelper = new ClassProvider();
        public Classes()
        {
            InitializeComponent();
        }

        private void ClassesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void PageLoad()
        {
            ClassesGridView.AutoGenerateColumns = false;
            ClassesGridView.DataSource = utils.GetClasses();
            
        }
        private void Classes_Load(object sender, EventArgs e)
        {
            PageLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ResultModel model = new ResultModel();
            model.ClassId =Int32.Parse( txtClass.Text);
            model.StudentCount = 0;
            bool result = clHelper.AddClass(model);
            if (!result)
            {
                MessageBox.Show("Failed to add","",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            MessageBox.Show("Successfully inserted");
            PageLoad();
            
        }
    }
}
