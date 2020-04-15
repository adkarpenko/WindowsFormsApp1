namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonVisibleJSON = new System.Windows.Forms.Button();
            this.buttonAllJSON = new System.Windows.Forms.Button();
            this.buttonVisibleXml = new System.Windows.Forms.Button();
            this.buttonAllXml = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raisedAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Round = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(0, 0);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(40, 23);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(46, 0);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(50, 23);
            this.buttonDown.TabIndex = 1;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonVisibleJSON
            // 
            this.buttonVisibleJSON.Location = new System.Drawing.Point(102, 0);
            this.buttonVisibleJSON.Name = "buttonVisibleJSON";
            this.buttonVisibleJSON.Size = new System.Drawing.Size(190, 23);
            this.buttonVisibleJSON.TabIndex = 2;
            this.buttonVisibleJSON.Text = "Сериализовать видимые(JSON)";
            this.buttonVisibleJSON.UseVisualStyleBackColor = true;
            this.buttonVisibleJSON.Click += new System.EventHandler(this.buttonVisibleJSON_Click);
            // 
            // buttonAllJSON
            // 
            this.buttonAllJSON.Location = new System.Drawing.Point(298, 0);
            this.buttonAllJSON.Name = "buttonAllJSON";
            this.buttonAllJSON.Size = new System.Drawing.Size(163, 23);
            this.buttonAllJSON.TabIndex = 3;
            this.buttonAllJSON.Text = "Сериализовать все(JSON)";
            this.buttonAllJSON.UseVisualStyleBackColor = true;
            this.buttonAllJSON.Click += new System.EventHandler(this.buttonAllJSON_Click);
            // 
            // buttonVisibleXml
            // 
            this.buttonVisibleXml.Location = new System.Drawing.Point(471, 0);
            this.buttonVisibleXml.Name = "buttonVisibleXml";
            this.buttonVisibleXml.Size = new System.Drawing.Size(176, 23);
            this.buttonVisibleXml.TabIndex = 4;
            this.buttonVisibleXml.Text = "Сериализовать видимые(Xml)";
            this.buttonVisibleXml.UseVisualStyleBackColor = true;
            this.buttonVisibleXml.Click += new System.EventHandler(this.buttonVisibleXml_Click);
            // 
            // buttonAllXml
            // 
            this.buttonAllXml.Location = new System.Drawing.Point(653, 0);
            this.buttonAllXml.Name = "buttonAllXml";
            this.buttonAllXml.Size = new System.Drawing.Size(158, 23);
            this.buttonAllXml.TabIndex = 5;
            this.buttonAllXml.Text = "Сериализовать все(Xml)";
            this.buttonAllXml.UseVisualStyleBackColor = true;
            this.buttonAllXml.Click += new System.EventHandler(this.buttonAllXml_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.dateFound,
            this.City,
            this.date,
            this.raisedAmt,
            this.Round});
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 267);
            this.dataGridView1.TabIndex = 6;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // dateFound
            // 
            this.dateFound.HeaderText = "dateFound";
            this.dateFound.Name = "dateFound";
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.Name = "date";
            this.date.Width = 150;
            // 
            // raisedAmt
            // 
            this.raisedAmt.HeaderText = "raisedAmt";
            this.raisedAmt.Name = "raisedAmt";
            // 
            // Round
            // 
            this.Round.HeaderText = "Round";
            this.Round.Name = "Round";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 299);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAllXml);
            this.Controls.Add(this.buttonVisibleXml);
            this.Controls.Add(this.buttonAllJSON);
            this.Controls.Add(this.buttonVisibleJSON);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonVisibleJSON;
        private System.Windows.Forms.Button buttonAllJSON;
        private System.Windows.Forms.Button buttonVisibleXml;
        private System.Windows.Forms.Button buttonAllXml;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn raisedAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Round;
    }
}

