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
    public partial class SalesForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private MainForm linkToThePast;
        public SalesForm(MainForm link)
        {
            this.linkToThePast = link;
            InitializeComponent();
            UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            foreach (var sale in Databank.SalesTable.sales)
            {
                if (sale != null)
                {
                    if (sale.typeOfPayment)
                    {
                        dataGridView1.Rows.Add(sale.login, sale.address, sale.product, sale.price, "наличный");
                    }
                    else
                    {
                        dataGridView1.Rows.Add(sale.login, sale.address, sale.product, sale.price, "безналичный");
                    }
                }
            }
        }


        // Borderless Cons
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (!Databank.IsSaved)
            {
                var result = MessageBox.Show("Есть несохранённые измениня! Сохранить перед закрытием?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Databank.IsSaved = true;
                    Databank.HashTable.UpdateFile();
                    Databank.SalesTable.UpdateFile();
                    MessageBox.Show("Данные сохранены!", "Успех");
                }
            }
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

        
        // Clicks
        private void HomeButton_Click(object sender, EventArgs e)
        {
            linkToThePast.Show();
            this.Close();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.Rows[rowIndex].Cells[0].Value == null) return;
            string login = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            string address = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            string name = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            int price = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[3].Value.ToString());
            string methodStr = (dataGridView1.Rows[rowIndex].Cells[4].Value.ToString());
            bool method = (methodStr == "безналичный") ? false : true;
            dataGridView1.Rows.RemoveAt(rowIndex);

            SaleNode saleNode = new SaleNode(login, address, name, price, method);
            Databank.SalesTable.RemoveSale(saleNode); //
            UpdateTable();
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            using (SearchFormMainList form = new SearchFormMainList())
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    //MessageBox.Show("Опаньки!");
                }
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            using (AddFormMailList form = new AddFormMailList())
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    UpdateTable();
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Databank.IsSaved = true;
            Databank.HashTable.UpdateFile();
            Databank.SalesTable.UpdateFile();
            MessageBox.Show("Данные сохранены!", "Успех");
        }
    }
}
