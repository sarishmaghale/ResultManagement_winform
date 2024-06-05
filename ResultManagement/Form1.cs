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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
       

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateResult gr = new GenerateResult();
            gr.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Classes classform = new Classes();
            classform.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student studentform = new Student();
            studentform.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewResult resultView = new ViewResult();
            resultView.Show();
        }

        private void addSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectToClass newForm = new SubjectToClass();
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }
    }
}
