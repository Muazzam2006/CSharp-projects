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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EggRadio = new System.Windows.Forms.RadioButton();
            this.ChickenRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Prepare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultListBox1 = new System.Windows.Forms.ListBox();
            this.QualityLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EggRadio);
            this.groupBox1.Controls.Add(this.ChickenRadio);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // EggRadio
            // 
            this.EggRadio.AutoSize = true;
            this.EggRadio.Location = new System.Drawing.Point(109, 44);
            this.EggRadio.Name = "EggRadio";
            this.EggRadio.Size = new System.Drawing.Size(44, 17);
            this.EggRadio.TabIndex = 1;
            this.EggRadio.TabStop = true;
            this.EggRadio.Text = "Egg";
            this.EggRadio.UseVisualStyleBackColor = true;
            this.EggRadio.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // ChickenRadio
            // 
            this.ChickenRadio.AutoSize = true;
            this.ChickenRadio.Location = new System.Drawing.Point(18, 44);
            this.ChickenRadio.Name = "ChickenRadio";
            this.ChickenRadio.Size = new System.Drawing.Size(64, 17);
            this.ChickenRadio.TabIndex = 0;
            this.ChickenRadio.TabStop = true;
            this.ChickenRadio.Text = "Chicken";
            this.ChickenRadio.UseVisualStyleBackColor = true;
            this.ChickenRadio.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quanity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(62, 140);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(36, 20);
            this.quantityTextBox.TabIndex = 2;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(122, 140);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(117, 23);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Submit new request";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(16, 182);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(223, 23);
            this.Copy.TabIndex = 4;
            this.Copy.Text = "Copy new request";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Egg Quality: ";
            // 
            // Prepare
            // 
            this.Prepare.Location = new System.Drawing.Point(16, 263);
            this.Prepare.Name = "Prepare";
            this.Prepare.Size = new System.Drawing.Size(223, 23);
            this.Prepare.TabIndex = 6;
            this.Prepare.Text = "Prepare Food";
            this.Prepare.UseVisualStyleBackColor = true;
            this.Prepare.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result";
            // 
            // ResultListBox1
            // 
            this.ResultListBox1.FormattingEnabled = true;
            this.ResultListBox1.Location = new System.Drawing.Point(19, 343);
            this.ResultListBox1.Name = "ResultListBox1";
            this.ResultListBox1.Size = new System.Drawing.Size(220, 95);
            this.ResultListBox1.TabIndex = 8;
            this.ResultListBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // QualityLabel
            // 
            this.QualityLabel.AutoSize = true;
            this.QualityLabel.Location = new System.Drawing.Point(90, 223);
            this.QualityLabel.Name = "QualityLabel";
            this.QualityLabel.Size = new System.Drawing.Size(13, 13);
            this.QualityLabel.TabIndex = 9;
            this.QualityLabel.Text = "0";
            this.QualityLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 450);
            this.Controls.Add(this.QualityLabel);
            this.Controls.Add(this.ResultListBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Prepare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton EggRadio;
        private System.Windows.Forms.RadioButton ChickenRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Prepare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ResultListBox1;
        private System.Windows.Forms.Label QualityLabel;
    }
}

