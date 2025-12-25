namespace Tyuiu.EgorovAD.Sprint6.Task7.V26
{
    partial class FormName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormName));
            labelinfo = new Label();
            buttonName = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelinfo
            // 
            labelinfo.AutoSize = true;
            labelinfo.Location = new Point(142, 19);
            labelinfo.Name = "labelinfo";
            labelinfo.Size = new Size(303, 120);
            labelinfo.TabIndex = 0;
            labelinfo.Text = resources.GetString("labelinfo.Text");
            // 
            // buttonName
            // 
            buttonName.Location = new Point(332, 142);
            buttonName.Name = "buttonName";
            buttonName.Size = new Size(68, 30);
            buttonName.TabIndex = 2;
            buttonName.Text = "OK";
            buttonName.UseVisualStyleBackColor = true;
            buttonName.Click += buttonName_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(3, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 165);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 177);
            Controls.Add(pictureBox1);
            Controls.Add(buttonName);
            Controls.Add(labelinfo);
            Name = "FormName";
            Text = "FormName";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelinfo;
        private Button buttonName;
        private PictureBox pictureBox1;
    }
}