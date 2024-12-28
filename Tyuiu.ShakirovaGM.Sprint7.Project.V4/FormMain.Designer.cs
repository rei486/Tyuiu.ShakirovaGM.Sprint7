namespace Tyuiu.ShakirovaGM.Sprint7.Project.V4
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
            buttonInfo_SGM = new Button();
            buttonGoFormBooks_SGM = new Button();
            buttonGoFormPeopleInfo_SGM = new Button();
            SuspendLayout();
            // 
            // buttonInfo_SGM
            // 
            buttonInfo_SGM.Location = new Point(392, 403);
            buttonInfo_SGM.Name = "buttonInfo_SGM";
            buttonInfo_SGM.Size = new Size(30, 26);
            buttonInfo_SGM.TabIndex = 0;
            buttonInfo_SGM.Text = "?";
            buttonInfo_SGM.UseVisualStyleBackColor = true;
            buttonInfo_SGM.Click += buttonInfo_SGM_Click;
            // 
            // buttonGoFormBooks_SGM
            // 
            buttonGoFormBooks_SGM.BackColor = Color.FromArgb(64, 0, 0);
            buttonGoFormBooks_SGM.ForeColor = Color.WhiteSmoke;
            buttonGoFormBooks_SGM.Location = new Point(21, 49);
            buttonGoFormBooks_SGM.Name = "buttonGoFormBooks_SGM";
            buttonGoFormBooks_SGM.Size = new Size(117, 64);
            buttonGoFormBooks_SGM.TabIndex = 1;
            buttonGoFormBooks_SGM.Text = "Книги";
            buttonGoFormBooks_SGM.UseVisualStyleBackColor = false;
            buttonGoFormBooks_SGM.Click += buttonGoFormBooks_SGM_Click;
            // 
            // buttonGoFormPeopleInfo_SGM
            // 
            buttonGoFormPeopleInfo_SGM.BackColor = Color.FromArgb(64, 0, 0);
            buttonGoFormPeopleInfo_SGM.ForeColor = Color.WhiteSmoke;
            buttonGoFormPeopleInfo_SGM.Location = new Point(21, 222);
            buttonGoFormPeopleInfo_SGM.Name = "buttonGoFormPeopleInfo_SGM";
            buttonGoFormPeopleInfo_SGM.Size = new Size(120, 63);
            buttonGoFormPeopleInfo_SGM.TabIndex = 2;
            buttonGoFormPeopleInfo_SGM.Text = "Картотека";
            buttonGoFormPeopleInfo_SGM.UseVisualStyleBackColor = false;
            buttonGoFormPeopleInfo_SGM.Click += buttonGoFormPeopleInfo_SGM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.fonmain;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(434, 450);
            Controls.Add(buttonGoFormPeopleInfo_SGM);
            Controls.Add(buttonGoFormBooks_SGM);
            Controls.Add(buttonInfo_SGM);
            Name = "FormMain";
            Text = "Библиотека";
            Load += FormMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonInfo_SGM;
        private Button buttonGoFormBooks_SGM;
        private Button buttonGoFormPeopleInfo_SGM;
    }
}
