using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = new NorthWindDataContext();


            dataGridView1.DataSource = from o in db.Orders
                                       join od in db.Order_Details on o.OrderID equals od.OrderID
                                       join p in db.Products on od.ProductID equals p.ProductID
                                       select new { o.OrderDate, p.ProductName , od.Quantity, od.UnitPrice };
            //Procedure
            //dataGridView1.DataSource = db.CustOrdersDetail(10248);

        }
    }
}
