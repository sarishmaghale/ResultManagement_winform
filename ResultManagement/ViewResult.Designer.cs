namespace ResultManagement
{
    partial class ViewResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ViewResultGridView = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ExamTypeComboBox = new System.Windows.Forms.ComboBox();
            this.dgStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStudentRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgResultId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ViewResultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewResultGridView
            // 
            this.ViewResultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewResultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgStudentId,
            this.dgStudentRoll,
            this.dgStudentName,
            this.dgResultId});
            this.ViewResultGridView.Location = new System.Drawing.Point(23, 100);
            this.ViewResultGridView.Name = "ViewResultGridView";
            this.ViewResultGridView.Size = new System.Drawing.Size(740, 292);
            this.ViewResultGridView.TabIndex = 0;
            this.ViewResultGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewResultGridView_CellContentClick);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(31, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(95, 20);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Enter Class:";
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(143, 34);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(119, 26);
            this.txtClass.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(509, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 39);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ExamTypeComboBox
            // 
            this.ExamTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamTypeComboBox.FormattingEnabled = true;
            this.ExamTypeComboBox.Location = new System.Drawing.Point(291, 34);
            this.ExamTypeComboBox.Name = "ExamTypeComboBox";
            this.ExamTypeComboBox.Size = new System.Drawing.Size(193, 28);
            this.ExamTypeComboBox.TabIndex = 4;
            // 
            // dgStudentId
            // 
            this.dgStudentId.DataPropertyName = "StudentId";
            this.dgStudentId.HeaderText = "StudentId";
            this.dgStudentId.Name = "dgStudentId";
            this.dgStudentId.Visible = false;
            // 
            // dgStudentRoll
            // 
            this.dgStudentRoll.DataPropertyName = "StudentRoll";
            this.dgStudentRoll.HeaderText = "Roll Num";
            this.dgStudentRoll.Name = "dgStudentRoll";
            // 
            // dgStudentName
            // 
            this.dgStudentName.DataPropertyName = "StudentName";
            this.dgStudentName.HeaderText = "Name";
            this.dgStudentName.Name = "dgStudentName";
            // 
            // dgResultId
            // 
            this.dgResultId.DataPropertyName = "ResultId";
            this.dgResultId.HeaderText = "ResultId";
            this.dgResultId.Name = "dgResultId";
            this.dgResultId.Visible = false;
            // 
            // ViewResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExamTypeComboBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ViewResultGridView);
            this.Name = "ViewResult";
            this.Text = "ViewResult";
            this.Load += new System.EventHandler(this.ViewResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewResultGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewResultGridView;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox ExamTypeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStudentRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgResultId;
    }
}