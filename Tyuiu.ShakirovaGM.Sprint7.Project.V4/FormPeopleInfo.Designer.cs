namespace Tyuiu.ShakirovaGM.Sprint7.Project.V4
{
    partial class FormPeopleInfo
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
            buttonGoBack_SGM = new Button();
            buttonDelete_SGM = new Button();
            groupBoxSortMethods_SGM = new GroupBox();
            buttonSearchMaxNumber_SGM = new Button();
            buttonSearchMinPrice_SGM = new Button();
            buttonSearchTotalPrice_SGM = new Button();
            textBoxResultCalculation_SGM = new TextBox();
            buttonSearchMiddlePrice_SGM = new Button();
            buttonFindValue_SGM = new Button();
            textBoxFindValue_SGM = new TextBox();
            buttonAdd_SGM = new Button();
            buttonExportFile_SGM = new Button();
            buttonImportFile_SGM = new Button();
            dataGridViewPeople_SGM = new DataGridView();
            groupBoxSortMethods_SGM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeople_SGM).BeginInit();
            SuspendLayout();
            // 
            // buttonGoBack_SGM
            // 
            buttonGoBack_SGM.Location = new Point(12, 401);
            buttonGoBack_SGM.Name = "buttonGoBack_SGM";
            buttonGoBack_SGM.Size = new Size(118, 37);
            buttonGoBack_SGM.TabIndex = 17;
            buttonGoBack_SGM.Text = "Назад";
            buttonGoBack_SGM.UseVisualStyleBackColor = true;
            buttonGoBack_SGM.Click += buttonGoBack_SGM_Click;
            // 
            // buttonDelete_SGM
            // 
            buttonDelete_SGM.Location = new Point(263, 162);
            buttonDelete_SGM.Name = "buttonDelete_SGM";
            buttonDelete_SGM.Size = new Size(104, 67);
            buttonDelete_SGM.TabIndex = 16;
            buttonDelete_SGM.Text = "Удалить";
            buttonDelete_SGM.UseVisualStyleBackColor = true;
            buttonDelete_SGM.Click += buttonDelete_SGM_Click;
            // 
            // groupBoxSortMethods_SGM
            // 
            groupBoxSortMethods_SGM.Controls.Add(buttonSearchMaxNumber_SGM);
            groupBoxSortMethods_SGM.Controls.Add(buttonSearchMinPrice_SGM);
            groupBoxSortMethods_SGM.Controls.Add(buttonSearchTotalPrice_SGM);
            groupBoxSortMethods_SGM.Controls.Add(textBoxResultCalculation_SGM);
            groupBoxSortMethods_SGM.Controls.Add(buttonSearchMiddlePrice_SGM);
            groupBoxSortMethods_SGM.Location = new Point(385, 162);
            groupBoxSortMethods_SGM.Name = "groupBoxSortMethods_SGM";
            groupBoxSortMethods_SGM.Size = new Size(370, 253);
            groupBoxSortMethods_SGM.TabIndex = 15;
            groupBoxSortMethods_SGM.TabStop = false;
            groupBoxSortMethods_SGM.Text = "Коробочка вычислений";
            // 
            // buttonSearchMaxNumber_SGM
            // 
            buttonSearchMaxNumber_SGM.BackColor = Color.FromArgb(255, 255, 192);
            buttonSearchMaxNumber_SGM.FlatStyle = FlatStyle.Flat;
            buttonSearchMaxNumber_SGM.Location = new Point(192, 102);
            buttonSearchMaxNumber_SGM.Name = "buttonSearchMaxNumber_SGM";
            buttonSearchMaxNumber_SGM.Size = new Size(164, 66);
            buttonSearchMaxNumber_SGM.TabIndex = 16;
            buttonSearchMaxNumber_SGM.Text = "Максимальное id";
            buttonSearchMaxNumber_SGM.UseVisualStyleBackColor = false;
            buttonSearchMaxNumber_SGM.Click += buttonSearchMaxNumber_SGM_Click;
            // 
            // buttonSearchMinPrice_SGM
            // 
            buttonSearchMinPrice_SGM.BackColor = Color.FromArgb(255, 255, 192);
            buttonSearchMinPrice_SGM.FlatStyle = FlatStyle.Flat;
            buttonSearchMinPrice_SGM.Location = new Point(22, 102);
            buttonSearchMinPrice_SGM.Name = "buttonSearchMinPrice_SGM";
            buttonSearchMinPrice_SGM.Size = new Size(164, 66);
            buttonSearchMinPrice_SGM.TabIndex = 15;
            buttonSearchMinPrice_SGM.Text = "Минимальное id";
            buttonSearchMinPrice_SGM.UseVisualStyleBackColor = false;
            buttonSearchMinPrice_SGM.Click += buttonSearchMinPrice_SGM_Click;
            // 
            // buttonSearchTotalPrice_SGM
            // 
            buttonSearchTotalPrice_SGM.BackColor = Color.FromArgb(255, 255, 192);
            buttonSearchTotalPrice_SGM.BackgroundImageLayout = ImageLayout.None;
            buttonSearchTotalPrice_SGM.FlatStyle = FlatStyle.Flat;
            buttonSearchTotalPrice_SGM.Location = new Point(192, 34);
            buttonSearchTotalPrice_SGM.Name = "buttonSearchTotalPrice_SGM";
            buttonSearchTotalPrice_SGM.Size = new Size(164, 62);
            buttonSearchTotalPrice_SGM.TabIndex = 14;
            buttonSearchTotalPrice_SGM.Text = "Общее id";
            buttonSearchTotalPrice_SGM.UseVisualStyleBackColor = false;
            buttonSearchTotalPrice_SGM.Click += buttonSearchTotalPrice_SGM_Click;
            // 
            // textBoxResultCalculation_SGM
            // 
            textBoxResultCalculation_SGM.Location = new Point(22, 174);
            textBoxResultCalculation_SGM.Name = "textBoxResultCalculation_SGM";
            textBoxResultCalculation_SGM.ReadOnly = true;
            textBoxResultCalculation_SGM.Size = new Size(334, 23);
            textBoxResultCalculation_SGM.TabIndex = 13;
            // 
            // buttonSearchMiddlePrice_SGM
            // 
            buttonSearchMiddlePrice_SGM.BackColor = Color.FromArgb(255, 255, 192);
            buttonSearchMiddlePrice_SGM.BackgroundImageLayout = ImageLayout.None;
            buttonSearchMiddlePrice_SGM.FlatStyle = FlatStyle.Flat;
            buttonSearchMiddlePrice_SGM.Location = new Point(22, 34);
            buttonSearchMiddlePrice_SGM.Name = "buttonSearchMiddlePrice_SGM";
            buttonSearchMiddlePrice_SGM.Size = new Size(164, 62);
            buttonSearchMiddlePrice_SGM.TabIndex = 12;
            buttonSearchMiddlePrice_SGM.Text = "Среднее id";
            buttonSearchMiddlePrice_SGM.UseVisualStyleBackColor = false;
            buttonSearchMiddlePrice_SGM.Click += buttonSearchMiddlePrice_SGM_Click;
            // 
            // buttonFindValue_SGM
            // 
            buttonFindValue_SGM.Location = new Point(6, 264);
            buttonFindValue_SGM.Name = "buttonFindValue_SGM";
            buttonFindValue_SGM.Size = new Size(75, 23);
            buttonFindValue_SGM.TabIndex = 14;
            buttonFindValue_SGM.Text = "Найти";
            buttonFindValue_SGM.UseVisualStyleBackColor = true;
            buttonFindValue_SGM.Click += buttonFindValue_SGM_Click;
            // 
            // textBoxFindValue_SGM
            // 
            textBoxFindValue_SGM.Location = new Point(6, 235);
            textBoxFindValue_SGM.Name = "textBoxFindValue_SGM";
            textBoxFindValue_SGM.Size = new Size(361, 23);
            textBoxFindValue_SGM.TabIndex = 13;
            // 
            // buttonAdd_SGM
            // 
            buttonAdd_SGM.Location = new Point(156, 162);
            buttonAdd_SGM.Name = "buttonAdd_SGM";
            buttonAdd_SGM.Size = new Size(101, 67);
            buttonAdd_SGM.TabIndex = 12;
            buttonAdd_SGM.Text = "Добавить";
            buttonAdd_SGM.UseVisualStyleBackColor = true;
            buttonAdd_SGM.Click += buttonAdd_SGM_Click;
            // 
            // buttonExportFile_SGM
            // 
            buttonExportFile_SGM.BackColor = Color.FromArgb(255, 192, 128);
            buttonExportFile_SGM.Location = new Point(6, 162);
            buttonExportFile_SGM.Name = "buttonExportFile_SGM";
            buttonExportFile_SGM.Size = new Size(144, 67);
            buttonExportFile_SGM.TabIndex = 11;
            buttonExportFile_SGM.Text = "Сохранить";
            buttonExportFile_SGM.UseVisualStyleBackColor = false;
            buttonExportFile_SGM.Click += buttonExportFile_SGM_Click;
            // 
            // buttonImportFile_SGM
            // 
            buttonImportFile_SGM.Location = new Point(666, 421);
            buttonImportFile_SGM.Name = "buttonImportFile_SGM";
            buttonImportFile_SGM.RightToLeft = RightToLeft.No;
            buttonImportFile_SGM.Size = new Size(75, 23);
            buttonImportFile_SGM.TabIndex = 10;
            buttonImportFile_SGM.Text = "Импорт";
            buttonImportFile_SGM.UseVisualStyleBackColor = true;
            buttonImportFile_SGM.Visible = false;
            buttonImportFile_SGM.Click += buttonImportFile_SGM_Click;
            // 
            // dataGridViewPeople_SGM
            // 
            dataGridViewPeople_SGM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPeople_SGM.Location = new Point(6, 6);
            dataGridViewPeople_SGM.Name = "dataGridViewPeople_SGM";
            dataGridViewPeople_SGM.Size = new Size(749, 150);
            dataGridViewPeople_SGM.TabIndex = 9;
            // 
            // FormPeopleInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fonpeople;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(762, 450);
            Controls.Add(buttonGoBack_SGM);
            Controls.Add(buttonDelete_SGM);
            Controls.Add(groupBoxSortMethods_SGM);
            Controls.Add(buttonFindValue_SGM);
            Controls.Add(textBoxFindValue_SGM);
            Controls.Add(buttonAdd_SGM);
            Controls.Add(buttonExportFile_SGM);
            Controls.Add(buttonImportFile_SGM);
            Controls.Add(dataGridViewPeople_SGM);
            Name = "FormPeopleInfo";
            Text = "FormPeopleInfo";
            Load += FormPeopleInfo_Load;
            groupBoxSortMethods_SGM.ResumeLayout(false);
            groupBoxSortMethods_SGM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeople_SGM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGoBack_SGM;
        private Button buttonDelete_SGM;
        private GroupBox groupBoxSortMethods_SGM;
        private Button buttonSearchMaxNumber_SGM;
        private Button buttonSearchMinPrice_SGM;
        private Button buttonSearchTotalPrice_SGM;
        private TextBox textBoxResultCalculation_SGM;
        private Button buttonSearchMiddlePrice_SGM;
        private Button buttonFindValue_SGM;
        private TextBox textBoxFindValue_SGM;
        private Button buttonAdd_SGM;
        private Button buttonExportFile_SGM;
        private Button buttonImportFile_SGM;
        private DataGridView dataGridViewPeople_SGM;
    }
}