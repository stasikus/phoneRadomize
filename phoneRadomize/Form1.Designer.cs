namespace phoneRadomize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.load_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loadFromFile_lbl = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.randomize_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.randomize_btn);
            this.panel1.Controls.Add(this.loadFromFile_lbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.load_btn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 99);
            this.panel1.TabIndex = 0;
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(3, 3);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(174, 23);
            this.load_btn.TabIndex = 0;
            this.load_btn.Text = "Загрузить";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Загружено с файла:";
            // 
            // loadFromFile_lbl
            // 
            this.loadFromFile_lbl.AutoSize = true;
            this.loadFromFile_lbl.Location = new System.Drawing.Point(138, 41);
            this.loadFromFile_lbl.Name = "loadFromFile_lbl";
            this.loadFromFile_lbl.Size = new System.Drawing.Size(13, 13);
            this.loadFromFile_lbl.TabIndex = 2;
            this.loadFromFile_lbl.Text = "0";
            // 
            // randomize_btn
            // 
            this.randomize_btn.Location = new System.Drawing.Point(3, 69);
            this.randomize_btn.Name = "randomize_btn";
            this.randomize_btn.Size = new System.Drawing.Size(174, 23);
            this.randomize_btn.TabIndex = 3;
            this.randomize_btn.Text = "Сохранить";
            this.randomize_btn.UseVisualStyleBackColor = true;
            this.randomize_btn.Click += new System.EventHandler(this.randomize_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 122);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(220, 160);
            this.MinimumSize = new System.Drawing.Size(220, 160);
            this.Name = "Form1";
            this.Text = "Randomize";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loadFromFile_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button randomize_btn;
    }
}

