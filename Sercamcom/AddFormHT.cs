using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sercamcom
{
    public partial class AddFormHT : Form
    {
        public AddFormHT()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string product = productBox.Text;

            var result = Databank.HashTable.SearchAllWithCount(login, product);
            dataGrid.Rows.Clear();

            if (result != null)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    dataGrid.Rows.Add(result[i].Key.login, result[i].Key.product, Databank.HashTable.GetHashCode(result[i].Key.login, result[i].Key.product), result[i].Value);
                }
            }
        }

        private void Search_MouseEnter(object sender, EventArgs e)
        {
            Search_Shadow.Visible = true;
        }
        private void Search_MouseLeave(object sender, EventArgs e)
        {
            Search_Shadow.Visible = false;
        }
        private void Cancel_MouseEnter(object sender, EventArgs e)
        {
            Cancel_Shadow.Visible = true;
        }
        private void Cancel_MouseLeave(object sender, EventArgs e)
        {
            Cancel_Shadow.Visible = false;
        }
        private void text1_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
        private void text1_MouseLeave(object sender, EventArgs e)
        {

        }
        private void text2_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
        private void text2_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
