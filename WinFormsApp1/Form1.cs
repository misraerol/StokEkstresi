using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Office.Interop.Excel;
using System;
using System.Windows.Forms;

using excel = Microsoft.Office.Interop.Excel;
using Range = Microsoft.Office.Interop.Excel.Range;
using System.Drawing;
using System.Drawing.Printing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        StkManager stiManager = new StkManager(new EfStkDal());
        public Form1()
        {
            InitializeComponent(); 
         

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dgwList.DataSource = stiManager.GetForms();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MalKodu.Text != null && MalKodu.Text !="")
            {
                dgwList.DataSource = stiManager.GetBytext(MalKodu.Text);
                ClearAll(this);
            }
            else if(MalAdi.Text != null && MalAdi.Text != "")
            {
                dgwList.DataSource = stiManager.GetBytext(MalAdi.Text);
                ClearAll(this);
            }
            
        }
        private void ClearAll(Control ctl)
        {
            foreach (Control c in ctl.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)c).Clear();
                }
                if (c.Controls.Count > 0)
                {
                    ClearAll(c);
                }
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            excel.Application app = new excel.Application();
            app.Visible = true;
            Workbook workbook = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sayfa = (Worksheet)workbook.Sheets[1];
            for (int i = 0; i < dgwList.Columns.Count; i++)
            {//Başlık için
                Range alan = (Range)sayfa.Cells[1, 1];
                alan.Cells[1, i + 1] = dgwList.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgwList.Columns.Count; i++)
            {
                for (int j = 0; j < dgwList.Rows.Count; j++)
                {
                    Range alan2 = (Range)sayfa.Cells[j+1,i+1];
                    //verilerin yerini ayarladım
                    alan2.Cells[2,1] = dgwList[i, j].Value;

                }
            }
        }
        Bitmap bmp;
        private void print_Click(object sender, EventArgs e)
        {
            int height = dgwList.Height;
            dgwList.Height = dgwList.RowCount * dgwList.RowTemplate.Height * 2;
             bmp= new Bitmap(dgwList.Width, dgwList.Height);
            dgwList.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, dgwList.Width, dgwList.Height));
            dgwList.Height = height;
            pdDialog.ShowDialog();
        }

       
        private void pdPrint_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
               
        }
    }
}
