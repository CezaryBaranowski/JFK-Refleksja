namespace Refleksja
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Info = new System.Windows.Forms.RichTextBox();
            this.RUN = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.RichTextBox();
            this.argument = new System.Windows.Forms.TextBox();
            this.arg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 179);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(322, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 173);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(322, 215);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(272, 76);
            this.Info.TabIndex = 3;
            this.Info.Text = "";
            // 
            // RUN
            // 
            this.RUN.Enabled = false;
            this.RUN.Location = new System.Drawing.Point(485, 294);
            this.RUN.Name = "RUN";
            this.RUN.Size = new System.Drawing.Size(109, 41);
            this.RUN.TabIndex = 4;
            this.RUN.Text = "RUN";
            this.RUN.UseVisualStyleBackColor = true;
            this.RUN.Click += new System.EventHandler(this.RUN_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(322, 354);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(272, 81);
            this.Result.TabIndex = 5;
            this.Result.Text = "";
            // 
            // argument
            // 
            this.argument.Location = new System.Drawing.Point(345, 315);
            this.argument.Name = "argument";
            this.argument.Size = new System.Drawing.Size(100, 20);
            this.argument.TabIndex = 6;
            this.argument.TextChanged += new System.EventHandler(this.argument_TextChanged);
            // 
            // arg
            // 
            this.arg.AutoSize = true;
            this.arg.Location = new System.Drawing.Point(369, 294);
            this.arg.Name = "arg";
            this.arg.Size = new System.Drawing.Size(52, 13);
            this.arg.TabIndex = 7;
            this.arg.Text = "Argument";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(433, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "RESULT";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(354, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "DESCRIPTION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arg);
            this.Controls.Add(this.argument);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.RUN);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Refleksja";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox Info;
        private System.Windows.Forms.Button RUN;
        private System.Windows.Forms.RichTextBox Result;
        private System.Windows.Forms.TextBox argument;
        private System.Windows.Forms.Label arg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

