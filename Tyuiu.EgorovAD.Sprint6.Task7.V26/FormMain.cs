using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.EgorovAD.Sprint6.Task7.V26.Lib;
namespace Tyuiu.EgorovAD.Sprint6.Task7.V26
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            this.AutoScaleMode = AutoScaleMode.Font;

        }
        static string openFilePath;
        static int rows;
        static int col;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string path)
        {
            string filedata = File.ReadAllText(path);
            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            col = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, col];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < col; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn.ColumnCount = 50;
            dataGridViewOut.ColumnCount = 50;

            dataGridViewOut.RowCount = 50;
            dataGridViewIn.RowCount = 50;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] arrayValues = new int[rows, col];

            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewIn.ColumnCount = col;
            dataGridViewIn.RowCount = rows;
            dataGridViewOut.ColumnCount = col;
            dataGridViewOut.RowCount = rows;

            for (int i = 0; i < col; i++)
            {
                dataGridViewIn.Columns[i].Width = 25;
                dataGridViewOut.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    dataGridViewIn.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, col];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    dataGridViewOut.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7V26.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;
            FileInfo fi = new FileInfo(path);
            bool fileExists = fi.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut.RowCount;
            int col = dataGridViewOut.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j != col - 1)
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormName fa = new FormName();
            fa.ShowDialog();
        }

        private void dataGridViewIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void openFileDialogTask_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialogMatrix_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialogMatrix_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

