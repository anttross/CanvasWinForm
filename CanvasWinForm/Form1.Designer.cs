namespace CanvasWinForm
{
    partial class Form1
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
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.txtDelivery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPOB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnCloseOrder = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ORD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORD_OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORD_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORD_Pattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pattern_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORD_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOrders
            // 
            this.gridOrders.AllowUserToAddRows = false;
            this.gridOrders.AllowUserToDeleteRows = false;
            this.gridOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORD_ID,
            this.ORD_OrderDate,
            this.ORD_Amount,
            this.ORD_Pattern,
            this.Pattern_desc,
            this.ORD_Status,
            this.Status_desc});
            this.gridOrders.Location = new System.Drawing.Point(12, 12);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridOrders.RowHeadersVisible = false;
            this.gridOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOrders.Size = new System.Drawing.Size(432, 150);
            this.gridOrders.TabIndex = 0;
            this.gridOrders.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridOrders_MouseClick);
            // 
            // txtDelivery
            // 
            this.txtDelivery.Location = new System.Drawing.Point(50, 337);
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDelivery.Size = new System.Drawing.Size(161, 20);
            this.txtDelivery.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 321);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "סוג משלוח";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 321);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ת.ד.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPOB
            // 
            this.txtPOB.Location = new System.Drawing.Point(236, 337);
            this.txtPOB.Name = "txtPOB";
            this.txtPOB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPOB.Size = new System.Drawing.Size(83, 20);
            this.txtPOB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 224);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "מייל";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(50, 240);
            this.txtMail.Name = "txtMail";
            this.txtMail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMail.Size = new System.Drawing.Size(161, 20);
            this.txtMail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 275);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "טלפון";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(50, 291);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone.Size = new System.Drawing.Size(161, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 321);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "מיקוד";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(325, 337);
            this.txtZip.Name = "txtZip";
            this.txtZip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtZip.Size = new System.Drawing.Size(72, 20);
            this.txtZip.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 275);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "עיר";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(236, 291);
            this.txtCity.Name = "txtCity";
            this.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCity.Size = new System.Drawing.Size(161, 20);
            this.txtCity.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 224);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "כתובת";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(236, 240);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(161, 20);
            this.txtAddress.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 175);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "שם מלא";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(236, 191);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFullName.Size = new System.Drawing.Size(161, 20);
            this.txtFullName.TabIndex = 9;
            // 
            // btnCloseOrder
            // 
            this.btnCloseOrder.Location = new System.Drawing.Point(50, 188);
            this.btnCloseOrder.Name = "btnCloseOrder";
            this.btnCloseOrder.Size = new System.Drawing.Size(101, 23);
            this.btnCloseOrder.TabIndex = 17;
            this.btnCloseOrder.Text = "סגירת הזמנה";
            this.btnCloseOrder.UseVisualStyleBackColor = true;
            this.btnCloseOrder.Click += new System.EventHandler(this.btnCloseOrder_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ORD_ID
            // 
            this.ORD_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ORD_ID.DataPropertyName = "ORD_ID";
            this.ORD_ID.HeaderText = "מס\' הזמנה";
            this.ORD_ID.Name = "ORD_ID";
            this.ORD_ID.ReadOnly = true;
            this.ORD_ID.Width = 82;
            // 
            // ORD_OrderDate
            // 
            this.ORD_OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ORD_OrderDate.DataPropertyName = "ORD_OrderDate";
            this.ORD_OrderDate.FillWeight = 120F;
            this.ORD_OrderDate.HeaderText = "תאריך הזמנה";
            this.ORD_OrderDate.Name = "ORD_OrderDate";
            this.ORD_OrderDate.ReadOnly = true;
            this.ORD_OrderDate.Width = 120;
            // 
            // ORD_Amount
            // 
            this.ORD_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ORD_Amount.DataPropertyName = "ORD_Amount";
            this.ORD_Amount.HeaderText = "כמות";
            this.ORD_Amount.Name = "ORD_Amount";
            this.ORD_Amount.ReadOnly = true;
            this.ORD_Amount.Width = 58;
            // 
            // ORD_Pattern
            // 
            this.ORD_Pattern.DataPropertyName = "ORD_Pattern";
            this.ORD_Pattern.HeaderText = "Column1";
            this.ORD_Pattern.Name = "ORD_Pattern";
            this.ORD_Pattern.Visible = false;
            this.ORD_Pattern.Width = 73;
            // 
            // Pattern_desc
            // 
            this.Pattern_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Pattern_desc.DataPropertyName = "Pattern_desc";
            this.Pattern_desc.HeaderText = "תבנית עיצוב";
            this.Pattern_desc.Name = "Pattern_desc";
            this.Pattern_desc.ReadOnly = true;
            this.Pattern_desc.Width = 97;
            // 
            // ORD_Status
            // 
            this.ORD_Status.DataPropertyName = "ORD_Status";
            this.ORD_Status.HeaderText = "Column1";
            this.ORD_Status.Name = "ORD_Status";
            this.ORD_Status.Visible = false;
            this.ORD_Status.Width = 73;
            // 
            // Status_desc
            // 
            this.Status_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status_desc.DataPropertyName = "Status_desc";
            this.Status_desc.HeaderText = "סטטוס";
            this.Status_desc.Name = "Status_desc";
            this.Status_desc.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 369);
            this.Controls.Add(this.btnCloseOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPOB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDelivery);
            this.Controls.Add(this.gridOrders);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridOrders;
        private System.Windows.Forms.TextBox txtDelivery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnCloseOrder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORD_OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORD_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORD_Pattern;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pattern_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORD_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_desc;
    }
}

