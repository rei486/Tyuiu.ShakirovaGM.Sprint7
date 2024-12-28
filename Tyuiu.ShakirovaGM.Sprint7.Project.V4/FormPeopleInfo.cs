﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShakirovaGM.Sprint7.Project.V4.Lib;

namespace Tyuiu.ShakirovaGM.Sprint7.Project.V4
{
    public partial class FormPeopleInfo : Form
    {
        public FormPeopleInfo()
        {
            InitializeComponent();
        }

        private void FormPeopleInfo_Load(object sender, EventArgs e)
        {
            buttonImportFile_SGM_Click(sender, e);
        }

        DataService ds = new DataService();
        string filePath = @"C:\Users\Пользователь\source\repos\Tyuiu.ShakirovaGM.Sprint7\images\SavedPeople.csv"; //путь для импорта/экспорта
        private void ImportCsvToDataGridView(string filePath)
        {
            DataTable dataTable = new DataTable();
            using (StreamReader sr = new StreamReader(filePath))
            {
                // Read the header line
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                // Read the data lines
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    dataTable.Rows.Add(values);
                }
            }
            // Bind the DataTable to the DataGridView
            dataGridViewPeople_SGM.DataSource = dataTable;
        }

        public void DeleteNullCells()
        {
            for (int i = 0; i < dataGridViewPeople_SGM.RowCount - 1; i++)
            {
                if (dataGridViewPeople_SGM.Rows[i].Cells[3].Value.ToString() == "") //удаление пустых строк
                {
                    dataGridViewPeople_SGM.Rows.RemoveAt(i);
                    i--;
                }
            }
        }
        private void buttonImportFile_SGM_Click(object sender, EventArgs e)
        {
            // Open a file dialog to select the CSV file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            ImportCsvToDataGridView(filePath);
            DeleteNullCells();
        }



        private void buttonExportFile_SGM_Click(object sender, EventArgs e)
        {
            // Create the CSV file
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Write the header row
                for (int i = 0; i < dataGridViewPeople_SGM.ColumnCount; i++)
                {
                    sw.Write(dataGridViewPeople_SGM.Columns[i].HeaderText);
                    if (i < dataGridViewPeople_SGM.ColumnCount - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.WriteLine();

                // Write the data rows
                foreach (DataGridViewRow row in dataGridViewPeople_SGM.Rows)
                {
                    for (int i = 0; i < dataGridViewPeople_SGM.ColumnCount; i++)
                    {
                        if (row.Cells[i].Value != null)
                        {
                            sw.Write(row.Cells[i].Value.ToString());
                        }
                        if (i < dataGridViewPeople_SGM.ColumnCount - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.WriteLine();
                }
            }
        }
        public double[] GetArrayRow(int row) //Универсальный метод получения столбца массива
        {
            double[] array = new double[dataGridViewPeople_SGM.Rows.Count];
            for (int i = 0; i < dataGridViewPeople_SGM.Rows.Count; i++)
            {
                array[i] = dataGridViewPeople_SGM.Rows[i].Cells[0].Value == null ? array[i - 1] : Convert.ToInt32(dataGridViewPeople_SGM.Rows[i].Cells[row].Value);
                //второй, в конце Cells[1] - номер столбца
            }
            return array;
        }
        private void buttonFindValue_SGM_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridViewPeople_SGM.RowCount; i++)
            {
                dataGridViewPeople_SGM.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewPeople_SGM.ColumnCount; j++)
                    if (dataGridViewPeople_SGM.Rows[i].Cells[j].Value != null)
                        if (dataGridViewPeople_SGM.Rows[i].Cells[j].Value.ToString().Contains(textBoxFindValue_SGM.Text))
                        {
                            dataGridViewPeople_SGM.Rows[i].Selected = true;
                            break;
                        }
            }
        }
        private void buttonGoBack_SGM_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
        }

        private void buttonDelete_SGM_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewPeople_SGM.SelectedRows)
            {
                dataGridViewPeople_SGM.Rows.RemoveAt(row.Index);
            }
        }

        private void buttonAdd_SGM_Click(object sender, EventArgs e)
        {
            double[] array = { };
            if (array != null)
            {
                array = GetArrayRow(0);
                /*(dataGridViewBooks_SGM.DataSource as DataTable).Rows.Add();*/
                dataGridViewPeople_SGM.CurrentCell = dataGridViewPeople_SGM[0, dataGridViewPeople_SGM.Rows.Count - 1];
                dataGridViewPeople_SGM.CurrentCell.Value = array.Length;
                dataGridViewPeople_SGM.CurrentCell = dataGridViewPeople_SGM[1, dataGridViewPeople_SGM.Rows.Count - 1];
            }
        }

        private void buttonSearchMiddlePrice_SGM_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(0);
            textBoxResultCalculation_SGM.Text = ds.FindMiddleValue(array).ToString();
        }

        private void buttonSearchTotalPrice_SGM_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(0);
            textBoxResultCalculation_SGM.Text = ds.FindTotalValue(array).ToString();
        }

        private void buttonSearchMinPrice_SGM_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(0);
            textBoxResultCalculation_SGM.Text = ds.FindMinValue(array).ToString();
        }

        private void buttonSearchMaxNumber_SGM_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(0);
            textBoxResultCalculation_SGM.Text = ds.FindMaxValue(array).ToString();
        }
    }
}
