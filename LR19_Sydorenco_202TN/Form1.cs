using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR19_Sydorenco_202TN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vidrad.Text = "";
            fofOK.Text = "OK";
        }

        private void fofOK_Click(object sender, EventArgs e)
        {           
            string rem = "";            
            rem = string.Join(" ", radok.Text.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries));
            // За допомогою методу Split ділемо рядок, що знаходиться в radok.Text на масив підрядків і розділяємо їх
            // розділовим знаком " "
            // Потім за допомогою методу Join щеплюємо масив підрядків розділовим знаком " "            
            vidrad.Text = rem;
        }
        
    }
}
