namespace Tyuiu.ShakirovaGM.Sprint7.Project.V4
{
    partial class FormBooksInfo
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
            dataGridViewBooks_SGM = new DataGridView();
            buttonImportFile_SGM = new Button();
            buttonExportFile_SGM = new Button();
            buttonAdd_SGM = new Button();
            textBoxFindValue_SGM = new TextBox();
            buttonFindValue_SGM = new Button();
            groupBoxSortMethods_SGM = new GroupBox();
            buttonSearchMaxNumber_SGM = new Button();
            buttonSearchMinPrice_SGM = new Button();
            buttonSearchTotalPrice_SGM = new Button();
            textBoxResultCalculation_SGM = new TextBox();
            buttonSearchMiddlePrice_SGM = new Button();
            buttonDelete_SGM = new Button();
            buttonGoBack_SGM = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks_SGM).BeginInit();
            groupBoxSortMethods_SGM.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewBooks_SGM
            // 
            dataGridViewBooks_SGM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks_SGM.Location = new Point(0, 0);
            dataGridViewBooks_SGM.Name = "dataGridViewBooks_SGM";
            dataGridViewBooks_SGM.Size = new Size(709, 150);
            dataGridViewBooks_SGM.TabIndex = 0;
            // 
            // buttonImportFile_SGM
            // 
            buttonImportFile_SGM.Location = new Point(634, 415);
            buttonImportFile_SGM.Name = "buttonImportFile_SGM";
            buttonImportFile_SGM.RightToLeft = RightToLeft.No;
            buttonImportFile_SGM.Size = new Size(75, 23);
            buttonImportFile_SGM.TabIndex = 1;
            buttonImportFile_SGM.Text = "Импорт";
            buttonImportFile_SGM.UseVisualStyleBackColor = true;
            buttonImportFile_SGM.Visible = false;
            buttonImportFile_SGM.Click += buttonImportFile_SGM_Click;
            // 
            // buttonExportFile_SGM
            // 
            buttonExportFile_SGM.BackColor = Color.ForestGreen;
            buttonExportFile_SGM.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonExportFile_SGM.Location = new Point(12, 156);
            buttonExportFile_SGM.Name = "buttonExportFile_SGM";
            buttonExportFile_SGM.Size = new Size(169, 62);
            buttonExportFile_SGM.TabIndex = 2;
            buttonExportFile_SGM.Text = "Сохранить изменения";
            buttonExportFile_SGM.UseVisualStyleBackColor = false;
            buttonExportFile_SGM.Click += buttonExportFile_SGM_Click;
            // 
            // buttonAdd_SGM
            // 
            buttonAdd_SGM.BackColor = Color.ForestGreen;
            buttonAdd_SGM.Location = new Point(187, 156);
            buttonAdd_SGM.Name = "buttonAdd_SGM";
            buttonAdd_SGM.Size = new Size(92, 62);
            buttonAdd_SGM.TabIndex = 3;
            buttonAdd_SGM.Text = "Добавить строку";
            buttonAdd_SGM.UseVisualStyleBackColor = false;
            buttonAdd_SGM.Click += buttonAdd_SGM_Click;
            // 
            // textBoxFindValue_SGM
            // 
            textBoxFindValue_SGM.Location = new Point(12, 229);
            textBoxFindValue_SGM.Name = "textBoxFindValue_SGM";
            textBoxFindValue_SGM.Size = new Size(361, 23);
            textBoxFindValue_SGM.TabIndex = 4;
            // 
            // buttonFindValue_SGM
            // 
            buttonFindValue_SGM.Location = new Point(12, 258);
            buttonFindValue_SGM.Name = "buttonFindValue_SGM";
            buttonFindValue_SGM.Size = new Size(102, 29);
            buttonFindValue_SGM.TabIndex = 5;
            buttonFindValue_SGM.Text = "Найти";
            buttonFindValue_SGM.UseVisualStyleBackColor = true;
            buttonFindValue_SGM.Click += buttonFindValue_SGM_Click;
            // 
            // groupBoxSortMethods_SGM
            // 
            groupBoxSortMethods_SGM.BackColor = Color.DarkSeaGreen;
            groupBoxSortMethods_SGM.Controls.Add(buttonSearchMaxNumber_SGM);
            groupBoxSortMethods_SGM.Controls.Add(buttonSearchMinPrice_SGM);
            groupBoxSortMethods_SGM.Controls.Add(buttonSearchTotalPrice_SGM);
            groupBoxSortMethods_SGM.Controls.Add(textBoxResultCalculation_SGM);
            groupBoxSortMethods_SGM.Controls.Add(buttonSearchMiddlePrice_SGM);
            groupBoxSortMethods_SGM.Location = new Point(379, 156);
            groupBoxSortMethods_SGM.Name = "groupBoxSortMethods_SGM";
            groupBoxSortMethods_SGM.Size = new Size(330, 253);
            groupBoxSortMethods_SGM.TabIndex = 6;
            groupBoxSortMethods_SGM.TabStop = false;
            groupBoxSortMethods_SGM.Text = "Коробочка вычислений";
            // 
            // buttonSearchMaxNumber_SGM
            // 
            buttonSearchMaxNumber_SGM.BackColor = Color.Sienna;
            buttonSearchMaxNumber_SGM.FlatStyle = FlatStyle.Flat;
            buttonSearchMaxNumber_SGM.Location = new Point(179, 102);
            buttonSearchMaxNumber_SGM.Name = "buttonSearchMaxNumber_SGM";
            buttonSearchMaxNumber_SGM.Size = new Size(143, 56);
            buttonSearchMaxNumber_SGM.TabIndex = 16;
            buttonSearchMaxNumber_SGM.Text = "Максимальная цена";
            buttonSearchMaxNumber_SGM.UseVisualStyleBackColor = false;
            buttonSearchMaxNumber_SGM.Click += buttonSearchMaxNumber_SGM_Click;
            // 
            // buttonSearchMinPrice_SGM
            // 
            buttonSearchMinPrice_SGM.BackColor = Color.Sienna;
            buttonSearchMinPrice_SGM.FlatStyle = FlatStyle.Flat;
            buttonSearchMinPrice_SGM.Location = new Point(6, 102);
            buttonSearchMinPrice_SGM.Name = "buttonSearchMinPrice_SGM";
            buttonSearchMinPrice_SGM.Size = new Size(151, 56);
            buttonSearchMinPrice_SGM.TabIndex = 15;
            buttonSearchMinPrice_SGM.Text = "Минимальная цена";
            buttonSearchMinPrice_SGM.UseVisualStyleBackColor = false;
            buttonSearchMinPrice_SGM.Click += buttonSearchMinPrice_SGM_Click;
            // 
            // buttonSearchTotalPrice_SGM
            // 
            buttonSearchTotalPrice_SGM.BackColor = Color.Sienna;
            buttonSearchTotalPrice_SGM.BackgroundImageLayout = ImageLayout.None;
            buttonSearchTotalPrice_SGM.FlatStyle = FlatStyle.Flat;
            buttonSearchTotalPrice_SGM.Location = new Point(179, 22);
            buttonSearchTotalPrice_SGM.Name = "buttonSearchTotalPrice_SGM";
            buttonSearchTotalPrice_SGM.Size = new Size(143, 62);
            buttonSearchTotalPrice_SGM.TabIndex = 14;
            buttonSearchTotalPrice_SGM.Text = "Общая стоимость";
            buttonSearchTotalPrice_SGM.UseVisualStyleBackColor = false;
            buttonSearchTotalPrice_SGM.Click += buttonSearchTotalPrice_SGM_Click;
            // 
            // textBoxResultCalculation_SGM
            // 
            textBoxResultCalculation_SGM.Location = new Point(22, 179);
            textBoxResultCalculation_SGM.Name = "textBoxResultCalculation_SGM";
            textBoxResultCalculation_SGM.ReadOnly = true;
            textBoxResultCalculation_SGM.Size = new Size(268, 23);
            textBoxResultCalculation_SGM.TabIndex = 13;
            // 
            // buttonSearchMiddlePrice_SGM
            // 
            buttonSearchMiddlePrice_SGM.BackColor = Color.Sienna;
            buttonSearchMiddlePrice_SGM.BackgroundImageLayout = ImageLayout.None;
            buttonSearchMiddlePrice_SGM.FlatStyle = FlatStyle.Flat;
            buttonSearchMiddlePrice_SGM.Location = new Point(6, 22);
            buttonSearchMiddlePrice_SGM.Name = "buttonSearchMiddlePrice_SGM";
            buttonSearchMiddlePrice_SGM.Size = new Size(151, 62);
            buttonSearchMiddlePrice_SGM.TabIndex = 12;
            buttonSearchMiddlePrice_SGM.Text = "Средняя цена";
            buttonSearchMiddlePrice_SGM.UseVisualStyleBackColor = false;
            buttonSearchMiddlePrice_SGM.Click += buttonSearchMiddlePrice_SGM_Click;
            // 
            // buttonDelete_SGM
            // 
            buttonDelete_SGM.BackColor = Color.ForestGreen;
            buttonDelete_SGM.Location = new Point(281, 156);
            buttonDelete_SGM.Name = "buttonDelete_SGM";
            buttonDelete_SGM.Size = new Size(92, 62);
            buttonDelete_SGM.TabIndex = 7;
            buttonDelete_SGM.Text = "Удалить строку";
            buttonDelete_SGM.UseVisualStyleBackColor = false;
            buttonDelete_SGM.Click += buttonDelete_SGM_Click;
            // 
            // buttonGoBack_SGM
            // 
            buttonGoBack_SGM.Location = new Point(12, 401);
            buttonGoBack_SGM.Name = "buttonGoBack_SGM";
            buttonGoBack_SGM.Size = new Size(118, 37);
            buttonGoBack_SGM.TabIndex = 8;
            buttonGoBack_SGM.Text = "Назад";
            buttonGoBack_SGM.UseVisualStyleBackColor = true;
            buttonGoBack_SGM.Click += buttonGoBack_SGM_Click;
            // 
            // FormBooksInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fonknigi;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(717, 450);
            Controls.Add(buttonGoBack_SGM);
            Controls.Add(buttonDelete_SGM);
            Controls.Add(groupBoxSortMethods_SGM);
            Controls.Add(buttonFindValue_SGM);
            Controls.Add(textBoxFindValue_SGM);
            Controls.Add(buttonAdd_SGM);
            Controls.Add(buttonExportFile_SGM);
            Controls.Add(buttonImportFile_SGM);
            Controls.Add(dataGridViewBooks_SGM);
            Name = "FormBooksInfo";
            Text = "FormBooksInfo";
            Load += FormBooksInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks_SGM).EndInit();
            groupBoxSortMethods_SGM.ResumeLayout(false);
            groupBoxSortMethods_SGM.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBooks_SGM;
        private Button buttonImportFile_SGM;
        private Button buttonExportFile_SGM;
        private Button buttonAdd_SGM;
        private TextBox textBoxFindValue_SGM;
        private Button buttonFindValue_SGM;
        private GroupBox groupBoxSortMethods_SGM;
        private Button buttonSearchMaxNumber_SGM;
        private Button buttonSearchMinPrice_SGM;
        private Button buttonSearchTotalPrice_SGM;
        private TextBox textBoxResultCalculation_SGM;
        private Button buttonSearchMiddlePrice_SGM;
        private Button buttonDelete_SGM;
        private Button buttonGoBack_SGM;
    }
}