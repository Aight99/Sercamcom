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
    public partial class ProductForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private MainForm linkToThePast;
        public ProductForm(MainForm link)
        {
            this.linkToThePast = link;
            InitializeComponent();
            UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Databank.HashTable.size_h; i++)
            {
                if (Databank.HashTable.h_table[i] != null)
                {
                    dataGridView1.Rows.Add(Databank.HashTable.h_table[i].login, Databank.HashTable.h_table[i].product, Databank.HashTable.GetHashCode(Databank.HashTable.h_table[i].login, Databank.HashTable.h_table[i].product), i);
                }
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ControlBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void ControlBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void ControlBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        // Selection Effect
        private void HomeButton_MouseEnter(object sender, EventArgs e)
        {
            HomeButton_Shadow.Visible = true;
        }
        private void HomeButton_MouseLeave(object sender, EventArgs e)
        {
            HomeButton_Shadow.Visible = false;
        }
        private void RefreshButton_MouseEnter(object sender, EventArgs e)
        {
            RefreshButton_Shadow.Visible = true;
        }
        private void RefreshButton_MouseLeave(object sender, EventArgs e)
        {
            RefreshButton_Shadow.Visible = false;
        }
        private void SearchButton_MouseEnter(object sender, EventArgs e)
        {
            SearchButton_Shadow.Visible = true;
        }
        private void SearchButton_MouseLeave(object sender, EventArgs e)
        {
            SearchButton_Shadow.Visible = false;
        }
        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton_Shadow.Visible = true;
        }
        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton_Shadow.Visible = false;
        }
        private void DeleteButton_MouseEnter(object sender, EventArgs e)
        {
            DeleteButton_Shadow.Visible = true;
        }
        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton_Shadow.Visible = false;
        }
        private void SaveButton_MouseEnter(object sender, EventArgs e)
        {
            SaveButton_Shadow.Visible = true;
        }
        private void SaveButton_MouseLeave(object sender, EventArgs e)
        {
            SaveButton_Shadow.Visible = false;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            linkToThePast.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Удалить эту запись из обоих справочников?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                //HashTableOA myTable = new HashTableOA();
                //ListOfSales salesTable = new ListOfSales(myTable);
                if (dataGridView1.Rows[rowIndex].Cells[0].Value == null) return;
                string num1 = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                string num2 = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                dataGridView1.Rows.RemoveAt(rowIndex);
                ProductNode nodeforMyList = new ProductNode(num1, num2);
                Databank.SalesTable.RemoveAllSalesWithName(nodeforMyList.login, nodeforMyList.product); //
                Databank.HashTable.Delete(nodeforMyList); //
                UpdateTable();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            using (SearchFormHT form = new SearchFormHT())
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    //MessageBox.Show("Опаньки!");
                }

            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }


}
