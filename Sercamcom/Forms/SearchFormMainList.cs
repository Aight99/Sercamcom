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
    public partial class SearchFormMainList : Form
    {
        public SearchFormMainList()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string product = productBox.Text;

            var result = Databank.SalesTable.rbTree.FindSaleWithCount(login, product);
            dataGridView1.Rows.Clear();

            if (result != null)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i].typeOfPayment)
                    {
                        dataGridView1.Rows.Add(result[i].login, result[i].address, result[i].product, result[i].price, "наличный");
                    }
                    else
                    {
                        dataGridView1.Rows.Add(result[i].login, result[i].address, result[i].product, result[i].price, "безналичный");
                    }
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

        private void loginBox_TextChanged(object sender, EventArgs e)
        {
            if (loginBox.Text == "")
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void productBox_TextChanged(object sender, EventArgs e)
        {
            if (productBox.Text == "")
            {
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
            }
        }
    }
}
