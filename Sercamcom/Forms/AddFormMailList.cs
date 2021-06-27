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
    public partial class AddFormMailList : Form
    {
        public AddFormMailList()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string product = productBox.Text;
            string price = priceBox.Text;
            string type = typeBox.Text;
            string addr = addrBox.Text;

            if (Databank.SalesTable.AddNewSale(Databank.HashTable, login, addr, product, Int32.Parse(price), type))
            {
                MessageBox.Show("Запись добавлена", "Успех");
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

        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            if (priceBox.Text == "")
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
        }
        private void typeBox_TextChanged(object sender, EventArgs e)
        {
            if (typeBox.Text == "")
            {
                
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }
        }

        private void addrBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
        }
        private void addrBox_TextChanged(object sender, EventArgs e)
        {
            if (addrBox.Text == "")
            {

                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
        }
    }
}
