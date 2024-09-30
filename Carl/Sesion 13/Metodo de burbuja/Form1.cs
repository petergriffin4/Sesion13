using Metodo_de_burbuja.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodo_de_burbuja
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number = int.Parse(tbNumber.Text);
            numbers[i++]=number;
        }
        public void ShowNubers()
        {
            if(lbNumbers.Items.Count > 0)
            {
                lbNumbers.Items.Clear();
            }
            foreach(int numbers in numbers)
            {
                lbNumbers.Items.Add(numbers);
            }
        }
        private void Clear()
        {
            tbNumber.Clear();
            tbNumber.Focus();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Burbuja burbuja = new Burbuja();
            burbuja.SortBubble(numbers);
            ShowNubers();
        }
    }
    

}
