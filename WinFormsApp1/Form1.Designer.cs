
namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BaslangicTarihi = new System.Windows.Forms.TextBox();
            this.BitisTarihi = new System.Windows.Forms.TextBox();
            this.MalKodu = new System.Windows.Forms.TextBox();
            this.MalAdi = new System.Windows.Forms.TextBox();
            this.dgwList = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.export = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.pdDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pdPrint = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).BeginInit();
            this.SuspendLayout();
            // 
            // BaslangicTarihi
            // 
            this.BaslangicTarihi.Location = new System.Drawing.Point(12, 406);
            this.BaslangicTarihi.Name = "BaslangicTarihi";
            this.BaslangicTarihi.Size = new System.Drawing.Size(100, 23);
            this.BaslangicTarihi.TabIndex = 0;
            // 
            // BitisTarihi
            // 
            this.BitisTarihi.Location = new System.Drawing.Point(144, 404);
            this.BitisTarihi.Name = "BitisTarihi";
            this.BitisTarihi.Size = new System.Drawing.Size(100, 23);
            this.BitisTarihi.TabIndex = 1;
            this.BitisTarihi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MalKodu
            // 
            this.MalKodu.Location = new System.Drawing.Point(12, 39);
            this.MalKodu.Name = "MalKodu";
            this.MalKodu.Size = new System.Drawing.Size(99, 23);
            this.MalKodu.TabIndex = 2;
            this.MalKodu.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // MalAdi
            // 
            this.MalAdi.Location = new System.Drawing.Point(144, 39);
            this.MalAdi.Name = "MalAdi";
            this.MalAdi.Size = new System.Drawing.Size(100, 23);
            this.MalAdi.TabIndex = 3;
            // 
            // dgwList
            // 
            this.dgwList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwList.Location = new System.Drawing.Point(13, 74);
            this.dgwList.Name = "dgwList";
            this.dgwList.RowTemplate.Height = 25;
            this.dgwList.Size = new System.Drawing.Size(615, 293);
            this.dgwList.TabIndex = 4;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(281, 29);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(99, 33);
            this.Search.TabIndex = 5;
            this.Search.Text = "Ara";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mal Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mal Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Başlangıç Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bitiş Tarihi";
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(376, 402);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(116, 24);
            this.export.TabIndex = 10;
            this.export.Text = "Excel oluştur";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(511, 402);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(116, 23);
            this.print.TabIndex = 11;
            this.print.Text = "Yazdır";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // pdDialog
            // 
            this.pdDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pdDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pdDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.pdDialog.Document = this.pdPrint;
            this.pdDialog.Enabled = true;
            this.pdDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("pdDialog.Icon")));
            this.pdDialog.Name = "printPreviewDialog1";
            this.pdDialog.Visible = false;
            // 
            // pdPrint
            // 
            this.pdPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdPrint_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 458);
            this.Controls.Add(this.print);
            this.Controls.Add(this.export);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dgwList);
            this.Controls.Add(this.MalAdi);
            this.Controls.Add(this.MalKodu);
            this.Controls.Add(this.BitisTarihi);
            this.Controls.Add(this.BaslangicTarihi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BaslangicTarihi;
        private System.Windows.Forms.TextBox BitisTarihi;
        private System.Windows.Forms.TextBox MalKodu;
        private System.Windows.Forms.TextBox MalAdi;
        private System.Windows.Forms.DataGridView dgwList;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.PrintPreviewDialog pdDialog;
        private System.Drawing.Printing.PrintDocument pdPrint;
    }
}

