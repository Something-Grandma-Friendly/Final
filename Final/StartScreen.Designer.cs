namespace Final
{
    partial class StartScreen
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
            this.btnWeak = new System.Windows.Forms.Button();
            this.btnRespectable = new System.Windows.Forms.Button();
            this.btnBeast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWeak
            // 
            this.btnWeak.BackColor = System.Drawing.Color.Chartreuse;
            this.btnWeak.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeak.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWeak.Location = new System.Drawing.Point(38, 41);
            this.btnWeak.Name = "btnWeak";
            this.btnWeak.Size = new System.Drawing.Size(133, 23);
            this.btnWeak.TabIndex = 0;
            this.btnWeak.Text = "Weak";
            this.btnWeak.UseVisualStyleBackColor = false;
            this.btnWeak.Click += new System.EventHandler(this.btnWeak_Click);
            // 
            // btnRespectable
            // 
            this.btnRespectable.BackColor = System.Drawing.Color.Gold;
            this.btnRespectable.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespectable.Location = new System.Drawing.Point(38, 84);
            this.btnRespectable.Name = "btnRespectable";
            this.btnRespectable.Size = new System.Drawing.Size(133, 23);
            this.btnRespectable.TabIndex = 1;
            this.btnRespectable.Text = "Respectable";
            this.btnRespectable.UseVisualStyleBackColor = false;
            this.btnRespectable.Click += new System.EventHandler(this.btnRespectable_Click);
            // 
            // btnBeast
            // 
            this.btnBeast.BackColor = System.Drawing.Color.DarkRed;
            this.btnBeast.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnBeast.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeast.ForeColor = System.Drawing.Color.Snow;
            this.btnBeast.Location = new System.Drawing.Point(38, 128);
            this.btnBeast.Name = "btnBeast";
            this.btnBeast.Size = new System.Drawing.Size(133, 23);
            this.btnBeast.TabIndex = 2;
            this.btnBeast.Text = "Ludicrous Speed";
            this.btnBeast.UseVisualStyleBackColor = false;
            this.btnBeast.Click += new System.EventHandler(this.btnBeast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose your difficulty";
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final.Properties.Resources.StartScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBeast);
            this.Controls.Add(this.btnRespectable);
            this.Controls.Add(this.btnWeak);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWeak;
        private System.Windows.Forms.Button btnRespectable;
        private System.Windows.Forms.Button btnBeast;
        private System.Windows.Forms.Label label1;
    }
}