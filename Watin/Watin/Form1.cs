using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WatiN.Core;

namespace Watin
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                IE ie = new IE();

                ie.GoTo("www.terra.com.br");

                ie.WaitForComplete();

                

                ie.TextField("autocomplete").Value = "esporte";
                ie.TextField("autocomplete").Focus();

                SendKeys.SendWait("{ENTER}");
                //ie.TextField("autocomplete").KeyPress((char)Keys.Enter);

                



            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }

        }
    }
}
