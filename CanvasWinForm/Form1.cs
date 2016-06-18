using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace CanvasWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BuildGrid();
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Temp"))
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Temp");
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Temp\Orders"))
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Temp\Orders");
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"Temp");
            FileInfo[] fi = di.GetFiles();
            foreach (FileInfo f in fi)
                f.Delete();
            foreach (DataGridViewRow row in gridOrders.Rows)
            {
                ProccessNewOrder(Convert.ToInt32(row.Cells["ORD_ID"].Value));
                Canvas_DB.updateOrderStatus(Convert.ToInt32(row.Cells["ORD_ID"].Value), 2);
            }
            BuildGrid();
        }

        private void BuildGrid()
        {
            DataTable dtOrders = Canvas_DB.getNewOrders();
            gridOrders.DataSource = dtOrders.DefaultView;
        }

        private void ProccessNewOrder(int OrderID)
        {
            DataTable dtPictures = Canvas_DB.getPictures(OrderID);
            DataTable dtTexts = Canvas_DB.getTexts(OrderID);
            /* 
                byte[] ss = Encoding.Default.GetBytes(s);
                string sss = Encoding.UTF8.GetString(ss);
                int mod4 = s.Length % 4;
                if (mod4 > 0)
                {
                    s += new string('=', 4 - mod4);
                }
                byte[] result = Convert.FromBase64String(s);
             */
            for (int i = 0; i < dtPictures.Rows.Count; i++)
            {                
                byte[] result = (byte[])dtPictures.Rows[i]["PIC_FileBody"];
                MemoryStream ms = new MemoryStream(result, 0, result.Length);
                string fileName = AppDomain.CurrentDomain.BaseDirectory + @"Temp\" + dtPictures.Rows[i]["PIC_FileName"].ToString();
                FileStream fs = File.Create(fileName);
                ms.CopyTo(fs);
                ms.Close();
                fs.Close();
                /*-----------------------*/
                Bitmap b = new Bitmap(300, 300);
                Graphics g = Graphics.FromImage(b);
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, 300, 300));

                Bitmap img = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + @"Temp\" + dtPictures.Rows[i]["PIC_FileName"].ToString());

                g.DrawImage(img, (float.Parse(dtPictures.Rows[i]["PIC_Size"].ToString()) * Convert.ToInt32(dtPictures.Rows[i]["PIC_Left"])), (float.Parse(dtPictures.Rows[i]["PIC_Size"].ToString()) * Convert.ToInt32(dtPictures.Rows[i]["PIC_Top"])), (float.Parse(dtPictures.Rows[i]["PIC_Size"].ToString()) * img.Width), (float.Parse(dtPictures.Rows[i]["PIC_Size"].ToString()) * img.Height));
                ImageConverter converter = new ImageConverter();
                result = (byte[])converter.ConvertTo(b, typeof(byte[]));
                ms = new MemoryStream(result, 0, result.Length);
                fs = File.Create(AppDomain.CurrentDomain.BaseDirectory + @"Temp\tmp" + OrderID + ".jpg");
                ms.CopyTo(fs);
                ms.Close();
                fs.Close();

                img = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + @"Temp\tmp" + OrderID + ".jpg");
                b = new Bitmap(400, 400);
                g = Graphics.FromImage(b);
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, 400, 400));
                g.DrawImage(img, 50, 50, 300, 300);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                g.DrawString(OrderID.ToString(), new Font("Arial", 8), Brushes.Black, new Rectangle(0, 380, 400, 400), format);
                g.Flush();
                converter = new ImageConverter();
                result = (byte[])converter.ConvertTo(b, typeof(byte[]));
                ms = new MemoryStream(result, 0, result.Length);
                fs = File.Create(AppDomain.CurrentDomain.BaseDirectory + @"Temp\Orders\" + OrderID + ".jpg");
                ms.CopyTo(fs);
                ms.Close();
                fs.Close();
                g.Dispose();
                img.Dispose();
                b.Dispose();
                
                //System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + @"Temp\" + OrderID + ".jpg");
            }
        }

        private void Clear()
        {
            txtAddress.Text = "";
            txtCity.Text = "";
            txtDelivery.Text = "";
            txtFullName.Text = "";
            txtMail.Text = "";
            txtPhone.Text = "";
            txtPOB.Text = "";
            txtZip.Text = "";            
            gridOrders.ClearSelection();
        }

        private void gridOrders_MouseClick(object sender, MouseEventArgs e)
        {
            if (gridOrders.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataTable dtClient = Canvas_DB.getClient(Convert.ToInt32(gridOrders.SelectedRows[0].Cells["ORD_ID"].Value));
                txtFullName.Text = dtClient.Rows[0]["CLI_FullName"].ToString();
                txtAddress.Text = dtClient.Rows[0]["CLI_Address"].ToString();
                txtCity.Text = dtClient.Rows[0]["CLI_City"].ToString();
                txtDelivery.Text = dtClient.Rows[0]["DeliveryMethod"].ToString();
                txtMail.Text = dtClient.Rows[0]["CLI_EMail"].ToString();
                txtPhone.Text = dtClient.Rows[0]["CLI_Phone"].ToString();
                txtPOB.Text = dtClient.Rows[0]["CLI_POB"].ToString();
                txtZip.Text = dtClient.Rows[0]["CLI_Zip"].ToString();
            }
        }
        private void btnCloseOrder_Click(object sender, EventArgs e)
        {
            Canvas_DB.updateOrderStatus(Convert.ToInt32(gridOrders.SelectedRows[0].Cells["ORD_ID"].Value),3);
            BuildGrid();
            Clear();
        }

        //private void btnCloseOrder_Click(object sender, EventArgs e)
        //{
        //    chooseFile(out picture1);
        //    Canvas_DB.insertPicture(Convert.ToInt32(gridOrders.SelectedRows[0].Cells["ORD_ID"].Value) + 1, "IMG_20160120_011100.jpg", picture1,339909,0.5F,0,0,0.0F);
        //}

        //string fileName = "";
        //string fileSafeName = "";
        //byte[] picture1 = null;
        //string safeFileName = "";
        //string ext = "";
        //private void chooseFile(out byte[] picture)
        //{
        //    //Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
        //    openFileDialog1.ShowDialog();
        //    //openFileDialog1.Title = "בחירת קובץ מצורף למשימה";
        //    openFileDialog1.CheckFileExists = true;
        //    openFileDialog1.CheckPathExists = true;
        //    // Add a default extension if the user does not type one.
        //    openFileDialog1.AddExtension = true;
        //    openFileDialog1.Filter = "Office files Image files |(*.JPG;*.jpg;*.jpeg;*.bmp;*.png;*.tif;*.tiff;*.gif;*.pdf;)";
        //    if (openFileDialog1.FileName.Trim().Length > 0)
        //    {
        //        safeFileName = openFileDialog1.SafeFileName;
        //        ext = System.IO.Path.GetExtension(openFileDialog1.FileName).Replace(".", "").Trim();
        //        // ext = (safeFileName.Substring(safeFileName.LastIndexOf('.'), (safeFileName.Length) - safeFileName.LastIndexOf('.'))).Replace(".", "");
        //        string[] arr = safeFileName.Split('.');

        //        fileName = openFileDialog1.FileName;
        //        FileInfo fi = new FileInfo(openFileDialog1.FileName);
        //        fi.IsReadOnly = false;
        //        FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
        //        long temp = fi.Length;

        //        int lung = Convert.ToInt32(temp);
        //        picture = new byte[lung];
        //        fs.Read(picture, 0, lung);
        //        fs.Close();
        //        fileSafeName = openFileDialog1.SafeFileName;
        //    }
        //    else
        //    {
        //        picture = null;
        //    }
        //}
    }
}
