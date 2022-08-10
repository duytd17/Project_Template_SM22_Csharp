namespace Project_Template_SM22_Csharp.Views
{
    partial class FrmSach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_Loc = new System.Windows.Forms.ComboBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.cmb_SoTrang = new System.Windows.Forms.ComboBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgrid_Show = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_Loc);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.cmb_SoTrang);
            this.panel1.Controls.Add(this.txt_Ten);
            this.panel1.Controls.Add(this.txt_Ma);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 273);
            this.panel1.TabIndex = 0;
            // 
            // cmb_Loc
            // 
            this.cmb_Loc.FormattingEnabled = true;
            this.cmb_Loc.Location = new System.Drawing.Point(528, 182);
            this.cmb_Loc.Name = "cmb_Loc";
            this.cmb_Loc.Size = new System.Drawing.Size(118, 28);
            this.cmb_Loc.TabIndex = 9;
            this.cmb_Loc.Text = "Lọc số trang";
            this.cmb_Loc.SelectedIndexChanged += new System.EventHandler(this.cmb_Loc_SelectedIndexChanged);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(528, 132);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 29);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(528, 70);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 29);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cmb_SoTrang
            // 
            this.cmb_SoTrang.FormattingEnabled = true;
            this.cmb_SoTrang.Location = new System.Drawing.Point(179, 185);
            this.cmb_SoTrang.Name = "cmb_SoTrang";
            this.cmb_SoTrang.Size = new System.Drawing.Size(233, 28);
            this.cmb_SoTrang.TabIndex = 6;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(179, 122);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(207, 27);
            this.txt_Ten.TabIndex = 5;
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(179, 59);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(207, 27);
            this.txt_Ma.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số trang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sách";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgrid_Show);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 171);
            this.panel2.TabIndex = 1;
            // 
            // dgrid_Show
            // 
            this.dgrid_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Show.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_Show.Location = new System.Drawing.Point(0, 0);
            this.dgrid_Show.Name = "dgrid_Show";
            this.dgrid_Show.RowHeadersWidth = 51;
            this.dgrid_Show.RowTemplate.Height = 29;
            this.dgrid_Show.Size = new System.Drawing.Size(800, 171);
            this.dgrid_Show.TabIndex = 0;
            this.dgrid_Show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_Show_CellContentClick);
            // 
            // FrmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSach";
            this.Text = "FrmSach";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgrid_Show;
        private System.Windows.Forms.ComboBox cmb_SoTrang;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.ComboBox cmb_Loc;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
    }
}