using System.Windows.Forms;
using System.Collections.Generic;

namespace DBGroupProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                List<string> list = new List<string>();

                list = DataAccess.GetTableName();

                if (list.Count > 0)
                {
                    foreach (var item in list)
                    {
                        rtb1.AppendText(item + "\n");
                    }
                }
            }
            catch (System.Exception ex)
            {
                rtb1.AppendText(ex.Message);
                rtb1.AppendText(ex.InnerException.ToString());
            }         
        }
    }
}
