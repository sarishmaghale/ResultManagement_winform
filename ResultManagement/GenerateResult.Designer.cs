namespace ResultManagement
{
    partial class GenerateResult
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
            this.lblClass = new System.Windows.Forms.Label();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.btnClassSearch = new System.Windows.Forms.Button();
            this.StudentGridView = new System.Windows.Forms.DataGridView();
            this.dgStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStudentRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblExamType = new System.Windows.Forms.Label();
            this.ExamTypeCombo = new System.Windows.Forms.ComboBox();
            this.lblRollNum = new System.Windows.Forms.Label();
            this.txtRollNum = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.SubjectGridView = new System.Windows.Forms.DataGridView();
            this.dgSubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(12, 21);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(91, 20);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Enter Class";
            // 
            // txtClassId
            // 
            this.txtClassId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassId.Location = new System.Drawing.Point(121, 21);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(449, 26);
            this.txtClassId.TabIndex = 1;
            // 
            // btnClassSearch
            // 
            this.btnClassSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassSearch.Location = new System.Drawing.Point(588, 21);
            this.btnClassSearch.Name = "btnClassSearch";
            this.btnClassSearch.Size = new System.Drawing.Size(86, 33);
            this.btnClassSearch.TabIndex = 2;
            this.btnClassSearch.Text = "Search";
            this.btnClassSearch.UseVisualStyleBackColor = true;
            this.btnClassSearch.Click += new System.EventHandler(this.btnClassSearch_Click);
            // 
            // StudentGridView
            // 
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgStudentId,
            this.dgStudentRoll,
            this.dgStudentName});
            this.StudentGridView.Location = new System.Drawing.Point(25, 120);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.Size = new System.Drawing.Size(318, 171);
            this.StudentGridView.TabIndex = 3;
            this.StudentGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView_CellClick);
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
            this.dgStudentRoll.HeaderText = "Roll No:";
            this.dgStudentRoll.MaxInputLength = 22767;
            this.dgStudentRoll.MinimumWidth = 3;
            this.dgStudentRoll.Name = "dgStudentRoll";
            // 
            // dgStudentName
            // 
            this.dgStudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgStudentName.DataPropertyName = "StudentName";
            this.dgStudentName.HeaderText = "Name";
            this.dgStudentName.Name = "dgStudentName";
            // 
            // lblExamType
            // 
            this.lblExamType.AutoSize = true;
            this.lblExamType.Location = new System.Drawing.Point(444, 106);
            this.lblExamType.Name = "lblExamType";
            this.lblExamType.Size = new System.Drawing.Size(57, 13);
            this.lblExamType.TabIndex = 4;
            this.lblExamType.Text = "ExamType";
            // 
            // ExamTypeCombo
            // 
            this.ExamTypeCombo.FormattingEnabled = true;
            this.ExamTypeCombo.Location = new System.Drawing.Point(534, 106);
            this.ExamTypeCombo.Name = "ExamTypeCombo";
            this.ExamTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.ExamTypeCombo.TabIndex = 5;
            // 
            // lblRollNum
            // 
            this.lblRollNum.AutoSize = true;
            this.lblRollNum.Location = new System.Drawing.Point(444, 155);
            this.lblRollNum.Name = "lblRollNum";
            this.lblRollNum.Size = new System.Drawing.Size(68, 13);
            this.lblRollNum.TabIndex = 6;
            this.lblRollNum.Text = "Roll Number:";
            // 
            // txtRollNum
            // 
            this.txtRollNum.Location = new System.Drawing.Point(534, 152);
            this.txtRollNum.Name = "txtRollNum";
            this.txtRollNum.ReadOnly = true;
            this.txtRollNum.Size = new System.Drawing.Size(53, 20);
            this.txtRollNum.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(501, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 33);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(602, 152);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Size = new System.Drawing.Size(53, 20);
            this.txtStudentId.TabIndex = 9;
            this.txtStudentId.Visible = false;
            // 
            // SubjectGridView
            // 
            this.SubjectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSubjectId,
            this.dgSubjectName,
            this.dgMarks});
            this.SubjectGridView.Location = new System.Drawing.Point(405, 211);
            this.SubjectGridView.Name = "SubjectGridView";
            this.SubjectGridView.Size = new System.Drawing.Size(240, 150);
            this.SubjectGridView.TabIndex = 20;
            // 
            // dgSubjectId
            // 
            this.dgSubjectId.DataPropertyName = "SubjectId";
            this.dgSubjectId.HeaderText = "SubjectId";
            this.dgSubjectId.Name = "dgSubjectId";
            this.dgSubjectId.Visible = false;
            // 
            // dgSubjectName
            // 
            this.dgSubjectName.DataPropertyName = "SubjectName";
            this.dgSubjectName.HeaderText = "SubjectName";
            this.dgSubjectName.Name = "dgSubjectName";
            // 
            // dgMarks
            // 
            this.dgMarks.HeaderText = "Marks";
            this.dgMarks.Name = "dgMarks";
            // 
            // GenerateResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubjectGridView);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRollNum);
            this.Controls.Add(this.lblRollNum);
            this.Controls.Add(this.ExamTypeCombo);
            this.Controls.Add(this.lblExamType);
            this.Controls.Add(this.StudentGridView);
            this.Controls.Add(this.btnClassSearch);
            this.Controls.Add(this.txtClassId);
            this.Controls.Add(this.lblClass);
            this.Name = "GenerateResult";
            this.Text = "GenerateResult";
            this.Load += new System.EventHandler(this.GenerateResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.Button btnClassSearch;
        private System.Windows.Forms.DataGridView StudentGridView;
        private System.Windows.Forms.Label lblExamType;
        private System.Windows.Forms.ComboBox ExamTypeCombo;
        private System.Windows.Forms.Label lblRollNum;
        private System.Windows.Forms.TextBox txtRollNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStudentRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStudentName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.DataGridView SubjectGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMarks;
    }
}