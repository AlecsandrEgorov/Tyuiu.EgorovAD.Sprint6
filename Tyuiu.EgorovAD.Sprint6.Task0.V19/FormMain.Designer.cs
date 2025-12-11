namespace Tyuiu.EgorovAD.Sprint6.Task0.V19
{
    partial class FormMain
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxis1_EAD = new GroupBox();
            groupBoxis2_EAD = new GroupBox();
            pictureBoxis_EAD = new PictureBox();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            buttonis1_EAD = new Button();
            textBoxis1_EAD = new TextBox();
            textBoxis2_EAD = new TextBox();
            groupBoxis_EAD = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxis_EAD).BeginInit();
            SuspendLayout();
            // 
            // groupBoxis1_EAD
            // 
            groupBoxis1_EAD.Location = new Point(12, 12);
            groupBoxis1_EAD.Name = "groupBoxis1_EAD";
            groupBoxis1_EAD.Size = new Size(200, 19);
            groupBoxis1_EAD.TabIndex = 0;
            groupBoxis1_EAD.TabStop = false;
            groupBoxis1_EAD.Text = "Условие";
            groupBoxis1_EAD.Enter += groupBox1_Enter;
            // 
            // groupBoxis2_EAD
            // 
            groupBoxis2_EAD.Location = new Point(0, 37);
            groupBoxis2_EAD.Name = "groupBoxis2_EAD";
            groupBoxis2_EAD.Size = new Size(428, 217);
            groupBoxis2_EAD.TabIndex = 1;
            groupBoxis2_EAD.TabStop = false;
            groupBoxis2_EAD.Text = "Вычислить по формуле";
            // 
            // pictureBoxis_EAD
            // 
            pictureBoxis_EAD.Image = Properties.Resources.photo_5321122819850571525_m;
            pictureBoxis_EAD.Location = new Point(445, 37);
            pictureBoxis_EAD.Name = "pictureBoxis_EAD";
            pictureBoxis_EAD.Size = new Size(205, 63);
            pictureBoxis_EAD.TabIndex = 2;
            pictureBoxis_EAD.TabStop = false;
            // 
            // buttonis1_EAD
            // 
            buttonis1_EAD.Location = new Point(517, 330);
            buttonis1_EAD.Name = "buttonis1_EAD";
            buttonis1_EAD.Size = new Size(106, 38);
            buttonis1_EAD.TabIndex = 4;
            buttonis1_EAD.Text = "ответ";
            buttonis1_EAD.UseVisualStyleBackColor = true;
            buttonis1_EAD.Click += buttonis1_EAD_Click;
            // 
            // textBoxis1_EAD
            // 
            textBoxis1_EAD.Location = new Point(517, 301);
            textBoxis1_EAD.Name = "textBoxis1_EAD";
            textBoxis1_EAD.Size = new Size(106, 23);
            textBoxis1_EAD.TabIndex = 5;
            // 
            // textBoxis2_EAD
            // 
            textBoxis2_EAD.Location = new Point(225, 330);
            textBoxis2_EAD.Name = "textBoxis2_EAD";
            textBoxis2_EAD.Size = new Size(100, 23);
            textBoxis2_EAD.TabIndex = 6;
            textBoxis2_EAD.TextChanged += textBoxis2_EAD_TextChanged;
            textBoxis2_EAD.KeyPress += textBoxis2_EAD_KeyPress;
            // 
            // groupBoxis_EAD
            // 
            groupBoxis_EAD.Location = new Point(213, 313);
            groupBoxis_EAD.Name = "groupBoxis_EAD";
            groupBoxis_EAD.Size = new Size(122, 11);
            groupBoxis_EAD.TabIndex = 7;
            groupBoxis_EAD.TabStop = false;
            groupBoxis_EAD.Text = "                 X";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 380);
            Controls.Add(groupBoxis_EAD);
            Controls.Add(textBoxis2_EAD);
            Controls.Add(textBoxis1_EAD);
            Controls.Add(buttonis1_EAD);
            Controls.Add(pictureBoxis_EAD);
            Controls.Add(groupBoxis2_EAD);
            Controls.Add(groupBoxis1_EAD);
            Name = "FormMain";
            Text = "Form1";
            KeyPress += X_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBoxis_EAD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBoxis1_EAD;
        private GroupBox groupBoxis2_EAD;
        private PictureBox pictureBoxis_EAD;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button buttonis1_EAD;
        private TextBox textBoxis1_EAD;
        private TextBox textBoxis2_EAD;
        private GroupBox groupBoxis_EAD;
    }
}
