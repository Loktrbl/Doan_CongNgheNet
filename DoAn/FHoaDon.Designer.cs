
namespace DoAn
{
    partial class FHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHoaDon));
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.lvHoadon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox14.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox14.Controls.Add(this.lvHoadon);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox14.Location = new System.Drawing.Point(0, 0);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox14.Size = new System.Drawing.Size(1256, 546);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Danh sách hóa đơn";
            // 
            // lvHoadon
            // 
            this.lvHoadon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvHoadon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvHoadon.BackgroundImage")));
            this.lvHoadon.BackgroundImageTiled = true;
            this.lvHoadon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvHoadon.HideSelection = false;
            this.lvHoadon.Location = new System.Drawing.Point(26, 26);
            this.lvHoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvHoadon.Name = "lvHoadon";
            this.lvHoadon.Size = new System.Drawing.Size(1170, 455);
            this.lvHoadon.TabIndex = 0;
            this.lvHoadon.UseCompatibleStateImageBehavior = false;
            this.lvHoadon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã đặt phòng";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã trả phòng";
            this.columnHeader2.Width = 116;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã khách hàng";
            this.columnHeader3.Width = 121;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "tên khách hàng";
            this.columnHeader4.Width = 114;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên phòng";
            this.columnHeader5.Width = 99;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày đặt";
            this.columnHeader6.Width = 108;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ngày trả";
            this.columnHeader7.Width = 102;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Thành tiền";
            this.columnHeader8.Width = 94;
            // 
            // FHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 546);
            this.Controls.Add(this.groupBox14);
            this.Name = "FHoaDon";
            this.Text = "FHoaDon";
            this.groupBox14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.ListView lvHoadon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}