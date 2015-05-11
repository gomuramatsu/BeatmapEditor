namespace BeatmapEditor
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
            this.metadata = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.versionInput = new System.Windows.Forms.TextBox();
            this.hpInput = new System.Windows.Forms.TextBox();
            this.arInput = new System.Windows.Forms.TextBox();
            this.odInput = new System.Windows.Forms.TextBox();
            this.csInput = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mapList = new System.Windows.Forms.ListBox();
            this.filePath = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.metadata.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metadata
            // 
            this.metadata.Controls.Add(this.label5);
            this.metadata.Controls.Add(this.label4);
            this.metadata.Controls.Add(this.label3);
            this.metadata.Controls.Add(this.label2);
            this.metadata.Controls.Add(this.label1);
            this.metadata.Controls.Add(this.versionInput);
            this.metadata.Controls.Add(this.hpInput);
            this.metadata.Controls.Add(this.arInput);
            this.metadata.Controls.Add(this.odInput);
            this.metadata.Controls.Add(this.csInput);
            this.metadata.Location = new System.Drawing.Point(23, 212);
            this.metadata.Name = "metadata";
            this.metadata.Size = new System.Drawing.Size(312, 135);
            this.metadata.TabIndex = 0;
            this.metadata.TabStop = false;
            this.metadata.Text = "Metadata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "HP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "OD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "AR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Version Name";
            // 
            // versionInput
            // 
            this.versionInput.Location = new System.Drawing.Point(37, 46);
            this.versionInput.Name = "versionInput";
            this.versionInput.Size = new System.Drawing.Size(238, 20);
            this.versionInput.TabIndex = 2;
            this.versionInput.TextChanged += new System.EventHandler(this.versionInput_TextChanged);
            // 
            // hpInput
            // 
            this.hpInput.Location = new System.Drawing.Point(220, 99);
            this.hpInput.Name = "hpInput";
            this.hpInput.Size = new System.Drawing.Size(55, 20);
            this.hpInput.TabIndex = 4;
            this.hpInput.TextChanged += new System.EventHandler(this.hpInput_TextChanged);
            // 
            // arInput
            // 
            this.arInput.Location = new System.Drawing.Point(98, 99);
            this.arInput.Name = "arInput";
            this.arInput.Size = new System.Drawing.Size(55, 20);
            this.arInput.TabIndex = 3;
            this.arInput.TextChanged += new System.EventHandler(this.arInput_TextChanged);
            // 
            // odInput
            // 
            this.odInput.Location = new System.Drawing.Point(159, 99);
            this.odInput.Name = "odInput";
            this.odInput.Size = new System.Drawing.Size(55, 20);
            this.odInput.TabIndex = 2;
            this.odInput.TextChanged += new System.EventHandler(this.odInput_TextChanged);
            // 
            // csInput
            // 
            this.csInput.Location = new System.Drawing.Point(37, 99);
            this.csInput.Name = "csInput";
            this.csInput.Size = new System.Drawing.Size(55, 20);
            this.csInput.TabIndex = 1;
            this.csInput.TextChanged += new System.EventHandler(this.csInput_TextChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(121, 353);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(116, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Create Beatmap";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mapList);
            this.groupBox1.Controls.Add(this.filePath);
            this.groupBox1.Controls.Add(this.browse);
            this.groupBox1.Location = new System.Drawing.Point(23, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beatmaps";
            // 
            // mapList
            // 
            this.mapList.FormattingEnabled = true;
            this.mapList.Location = new System.Drawing.Point(37, 57);
            this.mapList.Name = "mapList";
            this.mapList.Size = new System.Drawing.Size(238, 108);
            this.mapList.TabIndex = 2;
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.Location = new System.Drawing.Point(37, 29);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(0, 13);
            this.filePath.TabIndex = 1;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(98, 16);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(116, 26);
            this.browse.TabIndex = 0;
            this.browse.Text = "Select Beatmaps";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 407);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metadata);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Beatmap Editor";
            this.metadata.ResumeLayout(false);
            this.metadata.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox metadata;
        private System.Windows.Forms.TextBox versionInput;
        private System.Windows.Forms.TextBox hpInput;
        private System.Windows.Forms.TextBox arInput;
        private System.Windows.Forms.TextBox odInput;
        private System.Windows.Forms.TextBox csInput;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.ListBox mapList;
    }
}

