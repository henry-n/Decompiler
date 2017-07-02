namespace decomp3
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
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.btnDiscoverTypeInformation = new System.Windows.Forms.Button();
            this.lstClass = new System.Windows.Forms.ListBox();
            this.lstFields = new System.Windows.Forms.ListBox();
            this.lstMethods = new System.Windows.Forms.ListBox();
            this.Files_In_Directory = new System.Windows.Forms.ListBox();
            this.DisplayFiles = new System.Windows.Forms.Button();
            this.lstArguments = new System.Windows.Forms.ListBox();
            this.lstMembers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(201, 15);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(560, 20);
            this.txtTypeName.TabIndex = 0;
            // 
            // btnDiscoverTypeInformation
            // 
            this.btnDiscoverTypeInformation.Location = new System.Drawing.Point(767, 13);
            this.btnDiscoverTypeInformation.Name = "btnDiscoverTypeInformation";
            this.btnDiscoverTypeInformation.Size = new System.Drawing.Size(75, 23);
            this.btnDiscoverTypeInformation.TabIndex = 1;
            this.btnDiscoverTypeInformation.Text = "Decomp File";
            this.btnDiscoverTypeInformation.UseVisualStyleBackColor = true;
            this.btnDiscoverTypeInformation.Click += new System.EventHandler(this.btnDiscoverTypeInformation_Click);
            // 
            // lstClass
            // 
            this.lstClass.FormattingEnabled = true;
            this.lstClass.Location = new System.Drawing.Point(201, 40);
            this.lstClass.Name = "lstClass";
            this.lstClass.Size = new System.Drawing.Size(177, 251);
            this.lstClass.TabIndex = 2;
            this.lstClass.SelectedIndexChanged += new System.EventHandler(this.lstMethods_SelectedIndexChanged);
            // 
            // lstFields
            // 
            this.lstFields.FormattingEnabled = true;
            this.lstFields.Location = new System.Drawing.Point(767, 40);
            this.lstFields.Name = "lstFields";
            this.lstFields.Size = new System.Drawing.Size(187, 251);
            this.lstFields.TabIndex = 3;
            this.lstFields.SelectedIndexChanged += new System.EventHandler(this.lstFields_SelectedIndexChanged);
            // 
            // lstMethods
            // 
            this.lstMethods.FormattingEnabled = true;
            this.lstMethods.Location = new System.Drawing.Point(384, 42);
            this.lstMethods.Name = "lstMethods";
            this.lstMethods.Size = new System.Drawing.Size(184, 251);
            this.lstMethods.TabIndex = 4;
            // 
            // Files_In_Directory
            // 
            this.Files_In_Directory.FormattingEnabled = true;
            this.Files_In_Directory.Location = new System.Drawing.Point(12, 42);
            this.Files_In_Directory.Name = "Files_In_Directory";
            this.Files_In_Directory.Size = new System.Drawing.Size(166, 251);
            this.Files_In_Directory.TabIndex = 5;
            this.Files_In_Directory.Click += new System.EventHandler(this.Files_In_Directory_Click);
            // 
            // DisplayFiles
            // 
            this.DisplayFiles.Location = new System.Drawing.Point(13, 13);
            this.DisplayFiles.Name = "DisplayFiles";
            this.DisplayFiles.Size = new System.Drawing.Size(165, 23);
            this.DisplayFiles.TabIndex = 6;
            this.DisplayFiles.Text = "Open Files";
            this.DisplayFiles.UseVisualStyleBackColor = true;
            this.DisplayFiles.Click += new System.EventHandler(this.DisplayFiles_Click);
            // 
            // lstArguments
            // 
            this.lstArguments.FormattingEnabled = true;
            this.lstArguments.Location = new System.Drawing.Point(574, 42);
            this.lstArguments.Name = "lstArguments";
            this.lstArguments.Size = new System.Drawing.Size(187, 251);
            this.lstArguments.TabIndex = 7;
            // 
            // lstMembers
            // 
            this.lstMembers.FormattingEnabled = true;
            this.lstMembers.Location = new System.Drawing.Point(960, 40);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.Size = new System.Drawing.Size(169, 251);
            this.lstMembers.TabIndex = 8;
            this.lstMembers.SelectedIndexChanged += new System.EventHandler(this.lstMembers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Methods";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Argument of Methods";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(832, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Global Fields";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1014, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Member Info";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(848, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save To Text File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMembers);
            this.Controls.Add(this.lstArguments);
            this.Controls.Add(this.DisplayFiles);
            this.Controls.Add(this.Files_In_Directory);
            this.Controls.Add(this.lstMethods);
            this.Controls.Add(this.lstFields);
            this.Controls.Add(this.lstClass);
            this.Controls.Add(this.btnDiscoverTypeInformation);
            this.Controls.Add(this.txtTypeName);
            this.Name = "Form1";
            this.Text = "Save To Text File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Button btnDiscoverTypeInformation;
        private System.Windows.Forms.ListBox lstClass;
        private System.Windows.Forms.ListBox lstFields;
        private System.Windows.Forms.ListBox lstMethods;
        private System.Windows.Forms.ListBox Files_In_Directory;
        private System.Windows.Forms.Button DisplayFiles;
        private System.Windows.Forms.ListBox lstArguments;
        private System.Windows.Forms.ListBox lstMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

