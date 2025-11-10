namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSystemName = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            listBox6 = new ListBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            getSystemInfo = new Button();
            AddAsset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(247, 51);
            label1.TabIndex = 0;
            label1.Text = "ScottishGlen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 119);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "System Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 181);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 237);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Manufacturer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 302);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 4;
            label5.Text = "Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 370);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 5;
            label6.Text = "IP Address";
            // 
            // txtSystemName
            // 
            txtSystemName.FormattingEnabled = true;
            txtSystemName.ItemHeight = 15;
            txtSystemName.Location = new Point(117, 119);
            txtSystemName.Name = "txtSystemName";
            txtSystemName.Size = new Size(152, 34);
            txtSystemName.TabIndex = 6;
            txtSystemName.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(117, 181);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(152, 34);
            listBox2.TabIndex = 7;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(117, 237);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(152, 34);
            listBox3.TabIndex = 8;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(117, 302);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(152, 34);
            listBox4.TabIndex = 9;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Location = new Point(117, 370);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(152, 34);
            listBox5.TabIndex = 10;
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 15;
            listBox6.Location = new Point(117, 487);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(152, 34);
            listBox6.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 435);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 12;
            label7.Text = "Purchase Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(117, 435);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 487);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 14;
            label8.Text = "Notes";
            // 
            // getSystemInfo
            // 
            getSystemInfo.Location = new Point(69, 618);
            getSystemInfo.Name = "getSystemInfo";
            getSystemInfo.Size = new Size(137, 61);
            getSystemInfo.TabIndex = 15;
            getSystemInfo.Text = "Get System Info";
            getSystemInfo.UseVisualStyleBackColor = true;
            getSystemInfo.Click += getSystemInfo_Click;
            // 
            // AddAsset
            // 
            AddAsset.Location = new Point(421, 617);
            AddAsset.Name = "AddAsset";
            AddAsset.Size = new Size(137, 62);
            AddAsset.TabIndex = 16;
            AddAsset.Text = "Add Asset";
            AddAsset.UseVisualStyleBackColor = true;
            AddAsset.Click += AddAsset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 739);
            Controls.Add(AddAsset);
            Controls.Add(getSystemInfo);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(listBox6);
            Controls.Add(listBox5);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(txtSystemName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox txtSystemName;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
        private ListBox listBox6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Button getSystemInfo;
        private Button AddAsset;
    }
}
