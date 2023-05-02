namespace Vulkel
{
    partial class Vulkel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vulkel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.execute = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.inject = new System.Windows.Forms.Button();
            this.scripthub = new System.Windows.Forms.Button();
            this.executeFile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(21)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.close_button);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 23);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // close_button
            // 
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close_button.Location = new System.Drawing.Point(647, 4);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(22, 20);
            this.close_button.TabIndex = 0;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(625, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(4, 23);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(546, 274);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // execute
            // 
            this.execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(21)))));
            this.execute.Cursor = System.Windows.Forms.Cursors.Default;
            this.execute.FlatAppearance.BorderSize = 0;
            this.execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.execute.ForeColor = System.Drawing.Color.Snow;
            this.execute.Location = new System.Drawing.Point(12, 313);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(75, 24);
            this.execute.TabIndex = 2;
            this.execute.Text = "Execute";
            this.execute.UseVisualStyleBackColor = false;
            this.execute.Click += new System.EventHandler(this.button2_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(21)))));
            this.clear.Cursor = System.Windows.Forms.Cursors.Default;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.ForeColor = System.Drawing.Color.Snow;
            this.clear.Location = new System.Drawing.Point(93, 313);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 24);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFile
            // 
            this.openFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(21)))));
            this.openFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.openFile.FlatAppearance.BorderSize = 0;
            this.openFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFile.ForeColor = System.Drawing.Color.Snow;
            this.openFile.Location = new System.Drawing.Point(174, 313);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 24);
            this.openFile.TabIndex = 4;
            this.openFile.Text = "Open File";
            this.openFile.UseVisualStyleBackColor = false;
            this.openFile.Click += new System.EventHandler(this.button4_Click);
            // 
            // inject
            // 
            this.inject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(21)))));
            this.inject.Cursor = System.Windows.Forms.Cursors.Default;
            this.inject.FlatAppearance.BorderSize = 0;
            this.inject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inject.ForeColor = System.Drawing.Color.Snow;
            this.inject.Location = new System.Drawing.Point(336, 313);
            this.inject.Name = "inject";
            this.inject.Size = new System.Drawing.Size(75, 24);
            this.inject.TabIndex = 5;
            this.inject.Text = "Inject";
            this.inject.UseVisualStyleBackColor = false;
            this.inject.Click += new System.EventHandler(this.button5_Click);
            // 
            // scripthub
            // 
            this.scripthub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(21)))));
            this.scripthub.Cursor = System.Windows.Forms.Cursors.Default;
            this.scripthub.FlatAppearance.BorderSize = 0;
            this.scripthub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scripthub.ForeColor = System.Drawing.Color.Snow;
            this.scripthub.Location = new System.Drawing.Point(582, 313);
            this.scripthub.Name = "scripthub";
            this.scripthub.Size = new System.Drawing.Size(75, 24);
            this.scripthub.TabIndex = 6;
            this.scripthub.Text = "Script Hub";
            this.scripthub.UseVisualStyleBackColor = false;
            this.scripthub.Click += new System.EventHandler(this.button6_Click);
            // 
            // executeFile
            // 
            this.executeFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(21)))));
            this.executeFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.executeFile.FlatAppearance.BorderSize = 0;
            this.executeFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeFile.ForeColor = System.Drawing.Color.Snow;
            this.executeFile.Location = new System.Drawing.Point(255, 313);
            this.executeFile.Name = "executeFile";
            this.executeFile.Size = new System.Drawing.Size(75, 24);
            this.executeFile.TabIndex = 7;
            this.executeFile.Text = "Execute File";
            this.executeFile.UseVisualStyleBackColor = false;
            this.executeFile.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(21)))));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(556, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(101, 264);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Vulkel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(669, 349);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.executeFile);
            this.Controls.Add(this.scripthub);
            this.Controls.Add(this.inject);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vulkel";
            this.Text = "Vulkel";
            this.Load += new System.EventHandler(this.Vulkel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button inject;
        private System.Windows.Forms.Button scripthub;
        private System.Windows.Forms.Button executeFile;
        private System.Windows.Forms.ListBox listBox1;
    }
}

