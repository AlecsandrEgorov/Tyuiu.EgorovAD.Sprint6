using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using Tyuiu.EgorovAD.Sprint6.Task0.V19.Lib;
namespace Tyuiu.EgorovAD.Sprint6.Task0.V19;


public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void buttonis1_EAD_Click(object sender, EventArgs e)
    {
        DataService ds = new DataService();
        try
        {
            int inputValue = Convert.ToInt32(textBoxis2_EAD.Text);
            double result = ds.Calculate(inputValue);

            // Выводим результат
            textBoxis1_EAD.Text = result.ToString();
        }
        catch
        {
            MessageBox.Show("Введены неправильные данные", "Ошибка");
        }
    }

    private void textBoxis2_EAD_TextChanged(object sender, EventArgs e)
    {


    }

    private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
    {

    }

    private void X_KeyPress(object sender, KeyPressEventArgs e)
    {

    }

    private void textBoxis2_EAD_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) &&
                         e.KeyChar != (char)Keys.Back &&
                         e.KeyChar != (char)Keys.Delete)
        {
            e.Handled = true;
        }
    }
}


