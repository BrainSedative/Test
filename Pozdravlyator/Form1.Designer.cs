namespace Pozdra
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
            this.gridBirthdays = new System.Windows.Forms.DataGridView();
            this.bdayPeopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdayDatabaseDataSet = new Pozdra.BdayDatabaseDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bdayPeopleTableAdapter = new Pozdra.BdayDatabaseDataSetTableAdapters.BdayPeopleTableAdapter();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bdayDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdayDatabaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysUntilBirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridBirthdays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdayPeopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdayDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdayDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdayDatabaseDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBirthdays
            // 
            this.gridBirthdays.AllowUserToOrderColumns = true;
            this.gridBirthdays.AutoGenerateColumns = false;
            this.gridBirthdays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBirthdays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FullName,
            this.DateOfBirth,
            this.Position,
            this.daysUntilBirthdayDataGridViewTextBoxColumn});
            this.gridBirthdays.DataSource = this.bdayPeopleBindingSource;
            this.gridBirthdays.Location = new System.Drawing.Point(860, 46);
            this.gridBirthdays.Name = "gridBirthdays";
            this.gridBirthdays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridBirthdays.Size = new System.Drawing.Size(544, 423);
            this.gridBirthdays.TabIndex = 0;
            this.gridBirthdays.UseWaitCursor = true;
            this.gridBirthdays.Click += new System.EventHandler(this.gridBirthdays_Click);
            this.gridBirthdays.DoubleClick += new System.EventHandler(this.gridBirthdays_DoubleClick);
            // 
            // bdayPeopleBindingSource
            // 
            this.bdayPeopleBindingSource.DataMember = "BdayPeople";
            this.bdayPeopleBindingSource.DataSource = this.bdayDatabaseDataSet;
            // 
            // bdayDatabaseDataSet
            // 
            this.bdayDatabaseDataSet.DataSetName = "BdayDatabaseDataSet";
            this.bdayDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(474, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(588, 329);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 20);
            this.txtName.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(576, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bdayPeopleTableAdapter
            // 
            this.bdayPeopleTableAdapter.ClearBeforeFill = true;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(588, 370);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(210, 20);
            this.txtPosition.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(680, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(474, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Кем приходится";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(588, 283);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // bdayDatabaseDataSetBindingSource
            // 
            this.bdayDatabaseDataSetBindingSource.DataSource = this.bdayDatabaseDataSet;
            this.bdayDatabaseDataSetBindingSource.Position = 0;
            // 
            // bdayDatabaseDataSetBindingSource1
            // 
            this.bdayDatabaseDataSetBindingSource1.DataSource = this.bdayDatabaseDataSet;
            this.bdayDatabaseDataSetBindingSource1.Position = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(474, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Дата рождения";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Номер записи";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "ФИО";
            this.FullName.Name = "FullName";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Дата рождения";
            this.DateOfBirth.Name = "DateOfBirth";
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Кем приходится";
            this.Position.Name = "Position";
            // 
            // daysUntilBirthdayDataGridViewTextBoxColumn
            // 
            this.daysUntilBirthdayDataGridViewTextBoxColumn.DataPropertyName = "DaysUntilBirthday";
            this.daysUntilBirthdayDataGridViewTextBoxColumn.HeaderText = "Дней до дня рождения";
            this.daysUntilBirthdayDataGridViewTextBoxColumn.Name = "daysUntilBirthdayDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridBirthdays);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridBirthdays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdayPeopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdayDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdayDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdayDatabaseDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBirthdays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private BdayDatabaseDataSet bdayDatabaseDataSet;
        private System.Windows.Forms.BindingSource bdayPeopleBindingSource;
        private BdayDatabaseDataSetTableAdapters.BdayPeopleTableAdapter bdayPeopleTableAdapter;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button button2;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource bdayDatabaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource bdayDatabaseDataSetBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysUntilBirthdayDataGridViewTextBoxColumn;
    }
}

