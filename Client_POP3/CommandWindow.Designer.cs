namespace Client_POP3
{
    partial class CommandWindow
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
            this.QUIT = new System.Windows.Forms.RadioButton();
            this.DELE = new System.Windows.Forms.RadioButton();
            this.RETR = new System.Windows.Forms.RadioButton();
            this.LIST = new System.Windows.Forms.RadioButton();
            this.STAT = new System.Windows.Forms.RadioButton();
            this.NOOP = new System.Windows.Forms.RadioButton();
            this.RSET = new System.Windows.Forms.RadioButton();
            this.UIDL = new System.Windows.Forms.RadioButton();
            this.TOP = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.nBox = new System.Windows.Forms.TextBox();
            this.ExcecuteButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // QUIT
            // 
            this.QUIT.AutoSize = true;
            this.QUIT.BackColor = System.Drawing.Color.White;
            this.QUIT.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.QUIT.ForeColor = System.Drawing.Color.Red;
            this.QUIT.Location = new System.Drawing.Point(11, 262);
            this.QUIT.Name = "QUIT";
            this.QUIT.Size = new System.Drawing.Size(56, 22);
            this.QUIT.TabIndex = 0;
            this.QUIT.TabStop = true;
            this.QUIT.Text = "QUIT";
            this.QUIT.UseVisualStyleBackColor = false;
            this.QUIT.CheckedChanged += new System.EventHandler(this.QUIT_CheckedChanged);
            // 
            // DELE
            // 
            this.DELE.AutoSize = true;
            this.DELE.BackColor = System.Drawing.Color.White;
            this.DELE.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.DELE.ForeColor = System.Drawing.Color.Green;
            this.DELE.Location = new System.Drawing.Point(380, 262);
            this.DELE.Name = "DELE";
            this.DELE.Size = new System.Drawing.Size(56, 22);
            this.DELE.TabIndex = 1;
            this.DELE.TabStop = true;
            this.DELE.Text = "DELE";
            this.DELE.UseVisualStyleBackColor = false;
            this.DELE.CheckedChanged += new System.EventHandler(this.DELE_CheckedChanged);
            // 
            // RETR
            // 
            this.RETR.AutoSize = true;
            this.RETR.BackColor = System.Drawing.Color.White;
            this.RETR.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RETR.ForeColor = System.Drawing.Color.Green;
            this.RETR.Location = new System.Drawing.Point(283, 262);
            this.RETR.Name = "RETR";
            this.RETR.Size = new System.Drawing.Size(56, 22);
            this.RETR.TabIndex = 2;
            this.RETR.TabStop = true;
            this.RETR.Text = "RETR";
            this.RETR.UseVisualStyleBackColor = false;
            this.RETR.CheckedChanged += new System.EventHandler(this.RETR_CheckedChanged);
            // 
            // LIST
            // 
            this.LIST.AutoSize = true;
            this.LIST.BackColor = System.Drawing.Color.White;
            this.LIST.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LIST.ForeColor = System.Drawing.Color.Green;
            this.LIST.Location = new System.Drawing.Point(187, 262);
            this.LIST.Name = "LIST";
            this.LIST.Size = new System.Drawing.Size(51, 22);
            this.LIST.TabIndex = 3;
            this.LIST.TabStop = true;
            this.LIST.Text = "LIST";
            this.LIST.UseVisualStyleBackColor = false;
            this.LIST.CheckedChanged += new System.EventHandler(this.LIST_CheckedChanged);
            // 
            // STAT
            // 
            this.STAT.AutoSize = true;
            this.STAT.BackColor = System.Drawing.Color.White;
            this.STAT.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.STAT.ForeColor = System.Drawing.Color.Green;
            this.STAT.Location = new System.Drawing.Point(95, 262);
            this.STAT.Name = "STAT";
            this.STAT.Size = new System.Drawing.Size(55, 22);
            this.STAT.TabIndex = 4;
            this.STAT.TabStop = true;
            this.STAT.Text = "STAT";
            this.STAT.UseVisualStyleBackColor = false;
            this.STAT.CheckedChanged += new System.EventHandler(this.STAT_CheckedChanged);
            // 
            // NOOP
            // 
            this.NOOP.AutoSize = true;
            this.NOOP.BackColor = System.Drawing.Color.White;
            this.NOOP.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.NOOP.ForeColor = System.Drawing.Color.Green;
            this.NOOP.Location = new System.Drawing.Point(476, 262);
            this.NOOP.Name = "NOOP";
            this.NOOP.Size = new System.Drawing.Size(64, 22);
            this.NOOP.TabIndex = 5;
            this.NOOP.TabStop = true;
            this.NOOP.Text = "NOOP";
            this.NOOP.UseVisualStyleBackColor = false;
            this.NOOP.CheckedChanged += new System.EventHandler(this.NOOP_CheckedChanged);
            // 
            // RSET
            // 
            this.RSET.AutoSize = true;
            this.RSET.BackColor = System.Drawing.Color.White;
            this.RSET.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RSET.ForeColor = System.Drawing.Color.Green;
            this.RSET.Location = new System.Drawing.Point(559, 262);
            this.RSET.Name = "RSET";
            this.RSET.Size = new System.Drawing.Size(55, 22);
            this.RSET.TabIndex = 8;
            this.RSET.TabStop = true;
            this.RSET.Text = "RSET";
            this.RSET.UseVisualStyleBackColor = false;
            this.RSET.CheckedChanged += new System.EventHandler(this.RSET_CheckedChanged);
            // 
            // UIDL
            // 
            this.UIDL.AutoSize = true;
            this.UIDL.BackColor = System.Drawing.Color.White;
            this.UIDL.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.UIDL.ForeColor = System.Drawing.Color.Green;
            this.UIDL.Location = new System.Drawing.Point(336, 285);
            this.UIDL.Name = "UIDL";
            this.UIDL.Size = new System.Drawing.Size(55, 22);
            this.UIDL.TabIndex = 10;
            this.UIDL.TabStop = true;
            this.UIDL.Text = "UIDL";
            this.UIDL.UseVisualStyleBackColor = false;
            this.UIDL.CheckedChanged += new System.EventHandler(this.UIDL_CheckedChanged);
            // 
            // TOP
            // 
            this.TOP.AutoSize = true;
            this.TOP.BackColor = System.Drawing.Color.White;
            this.TOP.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TOP.ForeColor = System.Drawing.Color.Green;
            this.TOP.Location = new System.Drawing.Point(233, 285);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(51, 22);
            this.TOP.TabIndex = 11;
            this.TOP.TabStop = true;
            this.TOP.Text = "TOP";
            this.TOP.UseVisualStyleBackColor = false;
            this.TOP.CheckedChanged += new System.EventHandler(this.TOP_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(157, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "msg (number)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(157, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "n (number)";
            // 
            // msgBox
            // 
            this.msgBox.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.msgBox.Location = new System.Drawing.Point(283, 123);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(196, 28);
            this.msgBox.TabIndex = 14;
            // 
            // nBox
            // 
            this.nBox.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.nBox.Location = new System.Drawing.Point(283, 169);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(196, 28);
            this.nBox.TabIndex = 15;
            // 
            // ExcecuteButton
            // 
            this.ExcecuteButton.BackColor = System.Drawing.Color.Lime;
            this.ExcecuteButton.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ExcecuteButton.ForeColor = System.Drawing.Color.Navy;
            this.ExcecuteButton.Location = new System.Drawing.Point(233, 212);
            this.ExcecuteButton.Name = "ExcecuteButton";
            this.ExcecuteButton.Size = new System.Drawing.Size(153, 44);
            this.ExcecuteButton.TabIndex = 16;
            this.ExcecuteButton.Text = "Execute";
            this.ExcecuteButton.UseVisualStyleBackColor = false;
            this.ExcecuteButton.Click += new System.EventHandler(this.ExcecuteButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ExcecuteButton);
            this.panel1.Controls.Add(this.nBox);
            this.panel1.Controls.Add(this.QUIT);
            this.panel1.Controls.Add(this.msgBox);
            this.panel1.Controls.Add(this.DELE);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.RETR);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LIST);
            this.panel1.Controls.Add(this.TOP);
            this.panel1.Controls.Add(this.STAT);
            this.panel1.Controls.Add(this.UIDL);
            this.panel1.Controls.Add(this.NOOP);
            this.panel1.Controls.Add(this.RSET);
            this.panel1.Location = new System.Drawing.Point(69, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 355);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client_POP3.Properties.Resources.POPr;
            this.pictureBox1.Location = new System.Drawing.Point(246, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // CommandWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "CommandWindow";
            this.Text = "CommandWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton QUIT;
        private System.Windows.Forms.RadioButton DELE;
        private System.Windows.Forms.RadioButton RETR;
        private System.Windows.Forms.RadioButton LIST;
        private System.Windows.Forms.RadioButton STAT;
        private System.Windows.Forms.RadioButton NOOP;
        private System.Windows.Forms.RadioButton RSET;
        private System.Windows.Forms.RadioButton UIDL;
        private System.Windows.Forms.RadioButton TOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.Button ExcecuteButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}