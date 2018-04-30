namespace ChatBox
{
    partial class ChatBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatBoxForm));
            this.FirsttextBox1 = new System.Windows.Forms.TextBox();
            this.SecondtextBox2 = new System.Windows.Forms.TextBox();
            this.SnametextBox3 = new System.Windows.Forms.TextBox();
            this.FnametextBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fnamelabel3 = new System.Windows.Forms.Label();
            this.Snamelabel3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FirsttextBox1
            // 
            this.FirsttextBox1.Enabled = false;
            this.FirsttextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirsttextBox1.Location = new System.Drawing.Point(13, 349);
            this.FirsttextBox1.Multiline = true;
            this.FirsttextBox1.Name = "FirsttextBox1";
            this.FirsttextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FirsttextBox1.Size = new System.Drawing.Size(174, 36);
            this.FirsttextBox1.TabIndex = 3;
            this.FirsttextBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.FirsttextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // SecondtextBox2
            // 
            this.SecondtextBox2.Enabled = false;
            this.SecondtextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondtextBox2.Location = new System.Drawing.Point(210, 349);
            this.SecondtextBox2.Multiline = true;
            this.SecondtextBox2.Name = "SecondtextBox2";
            this.SecondtextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SecondtextBox2.Size = new System.Drawing.Size(184, 36);
            this.SecondtextBox2.TabIndex = 4;
            this.SecondtextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // SnametextBox3
            // 
            this.SnametextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnametextBox3.Location = new System.Drawing.Point(193, 53);
            this.SnametextBox3.Name = "SnametextBox3";
            this.SnametextBox3.Size = new System.Drawing.Size(144, 26);
            this.SnametextBox3.TabIndex = 1;
            // 
            // FnametextBox4
            // 
            this.FnametextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnametextBox4.Location = new System.Drawing.Point(13, 53);
            this.FnametextBox4.Name = "FnametextBox4";
            this.FnametextBox4.Size = new System.Drawing.Size(144, 26);
            this.FnametextBox4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(191, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Second Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(343, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fnamelabel3
            // 
            this.fnamelabel3.AutoSize = true;
            this.fnamelabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnamelabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fnamelabel3.Location = new System.Drawing.Point(15, 329);
            this.fnamelabel3.Name = "fnamelabel3";
            this.fnamelabel3.Size = new System.Drawing.Size(0, 17);
            this.fnamelabel3.TabIndex = 4;
            // 
            // Snamelabel3
            // 
            this.Snamelabel3.AutoSize = true;
            this.Snamelabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snamelabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Snamelabel3.Location = new System.Drawing.Point(207, 329);
            this.Snamelabel3.Name = "Snamelabel3";
            this.Snamelabel3.Size = new System.Drawing.Size(0, 17);
            this.Snamelabel3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(343, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(127, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chat Box";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(13, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(381, 238);
            this.listBox1.TabIndex = 101;
            // 
            // ChatBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(405, 412);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Snamelabel3);
            this.Controls.Add(this.fnamelabel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SnametextBox3);
            this.Controls.Add(this.FnametextBox4);
            this.Controls.Add(this.SecondtextBox2);
            this.Controls.Add(this.FirsttextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChatBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat-Box";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirsttextBox1;
        private System.Windows.Forms.TextBox SecondtextBox2;
        private System.Windows.Forms.TextBox SnametextBox3;
        private System.Windows.Forms.TextBox FnametextBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label fnamelabel3;
        private System.Windows.Forms.Label Snamelabel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

