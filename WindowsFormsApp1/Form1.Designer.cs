namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.Student = new System.Windows.Forms.Label();
            this.Book = new System.Windows.Forms.Label();
            this.listBoxBook = new System.Windows.Forms.ListBox();
            this.thuvienDataSet = new WindowsFormsApp1.ThuvienDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new WindowsFormsApp1.ThuvienDataSetTableAdapters.BookTableAdapter();
            this.thuvienDataSetStudentName = new WindowsFormsApp1.ThuvienDataSetStudentName();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new WindowsFormsApp1.ThuvienDataSetStudentNameTableAdapters.StudentTableAdapter();
            this.labelBorrow = new System.Windows.Forms.Label();
            this.dataGridViewBorrow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.thuvienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuvienDataSetStudentName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.DataSource = this.studentBindingSource;
            this.comboBoxStudent.DisplayMember = "Name";
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(124, 49);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(158, 21);
            this.comboBoxStudent.TabIndex = 1;
            this.comboBoxStudent.ValueMember = "Name";
            this.comboBoxStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent_SelectedIndexChanged);
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(71, 57);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(47, 13);
            this.Student.TabIndex = 2;
            this.Student.Text = "Student:";
            // 
            // Book
            // 
            this.Book.AutoSize = true;
            this.Book.Location = new System.Drawing.Point(725, 22);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(37, 13);
            this.Book.TabIndex = 3;
            this.Book.Text = "Books";
            // 
            // listBoxBook
            // 
            this.listBoxBook.DataSource = this.bookBindingSource;
            this.listBoxBook.DisplayMember = "Title";
            this.listBoxBook.FormattingEnabled = true;
            this.listBoxBook.Location = new System.Drawing.Point(678, 38);
            this.listBoxBook.Name = "listBoxBook";
            this.listBoxBook.Size = new System.Drawing.Size(84, 186);
            this.listBoxBook.TabIndex = 4;
            // 
            // thuvienDataSet
            // 
            this.thuvienDataSet.DataSetName = "ThuvienDataSet";
            this.thuvienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.thuvienDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // thuvienDataSetStudentName
            // 
            this.thuvienDataSetStudentName.DataSetName = "ThuvienDataSetStudentName";
            this.thuvienDataSetStudentName.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.thuvienDataSetStudentName;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // labelBorrow
            // 
            this.labelBorrow.AutoSize = true;
            this.labelBorrow.Location = new System.Drawing.Point(71, 90);
            this.labelBorrow.Name = "labelBorrow";
            this.labelBorrow.Size = new System.Drawing.Size(54, 13);
            this.labelBorrow.TabIndex = 6;
            this.labelBorrow.Text = "Borrowing";
            // 
            // dataGridViewBorrow
            // 
            this.dataGridViewBorrow.AllowUserToAddRows = false;
            this.dataGridViewBorrow.AllowUserToDeleteRows = false;
            this.dataGridViewBorrow.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrow.Location = new System.Drawing.Point(74, 115);
            this.dataGridViewBorrow.Name = "dataGridViewBorrow";
            this.dataGridViewBorrow.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBorrow.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBorrow.Size = new System.Drawing.Size(527, 233);
            this.dataGridViewBorrow.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewBorrow);
            this.Controls.Add(this.labelBorrow);
            this.Controls.Add(this.listBoxBook);
            this.Controls.Add(this.Book);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Thu Vien";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thuvienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuvienDataSetStudentName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.Label Student;
        private System.Windows.Forms.Label Book;
        private System.Windows.Forms.ListBox listBoxBook;
        private ThuvienDataSet thuvienDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private ThuvienDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private ThuvienDataSetStudentName thuvienDataSetStudentName;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ThuvienDataSetStudentNameTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Label labelBorrow;
        private System.Windows.Forms.DataGridView dataGridViewBorrow;
    }
}

