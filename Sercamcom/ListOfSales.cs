using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sercamcom
{
    class ListOfSales
    {

        public List<SaleNode> sales;

        public Tree rbTree;


        public ListOfSales(HashTableOA hashTable)
        {
            sales = new List<SaleNode>();
            rbTree = new Tree();
            InputFromFile(hashTable);

        }
        //public ListOfSales() // TO DELETE
        //{
        //    sales = new List<SaleNode> { };
        //    rbTree = new Tree();
        //    InputFromFile(hashTable);

        //}

        public void AddNewSale(HashTableOA hashTable, string login, string address, string product, int price, string type)
        {

            if (CheckingAdress(address) && CheckingLogin(login)
                && CheckingNameOfProduct(product) && CheckRangeOfPrice(price) && CheckTypeOfMethod(type))
            {

                SaleNode saleNode = new SaleNode();
                saleNode.login = login;
                saleNode.address = address;
                saleNode.product = product;
                saleNode.price = price;
                saleNode.typeOfPayment = ConvertTypeOfMethod(type);
                if (!sales.Contains(saleNode))
                {
                    ProductNode hashTableNode = new ProductNode(login, product);

                    if (!hashTable.Search(hashTableNode))
                    {
                        MessageBox.Show("Нет соответствующей записи в справочнике товаров", "Ошибка!");
                        Console.WriteLine("This sale isn't in product list");
                        return;
                    }

                    sales.Add(saleNode);
                    rbTree.Insert(saleNode.GetProductCode(), saleNode);

                    //UpdateFile();
                    MessageBox.Show("Данные были успешно добавлены", "Успех!");
                    Console.WriteLine("Data added successfully");
                }
                else
                {
                    MessageBox.Show($"{ saleNode.login} уже в справочнике", "Ошибка!");
                    Console.WriteLine($"{ saleNode.login} is already in table");
                }
            }
            else
            {
                MessageBox.Show("Неверные дванные", "Ошибка!");
                Console.WriteLine("Incorrect data");
            }

        }
        public void RemoveAllSalesWithName(string login, string product)
        {
            SaleNode saleNode = rbTree.FindSale(login, product);
            while (saleNode != null)
            {
                sales.Remove(rbTree.Delete(saleNode));
                saleNode = rbTree.FindSale(login, product);
            }
            //UpdateFile();

        }
        public void RemoveSale(SaleNode saleNode)
        {
            sales.Remove(rbTree.Delete(saleNode));
            //UpdateFile();
        }

        public void CreateRBTree() // Для ввода из файла
        {
            for (int i = 0; i < sales.Count; i++)
                rbTree.Insert(sales[i].GetProductCode(), sales[i]);
        }

        private void InputFromFile(HashTableOA myTable)
        {
            string path = @"InputSales.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line;
                    if ((line = reader.ReadLine()) == null)
                    {
                        Console.WriteLine("No data in file");
                        continue;
                    }
                    string[] fields = line.Split(new[] { '|' });
                    if (!CheckingLogin(fields[0]))
                    {
                        MessageBox.Show("Неверные дванные", "Ошибка!");
                        Console.WriteLine("Incorrect data");
                        continue;
                    }
                    string login = fields[0];
                    if (!CheckingAdress(fields[1]))
                    {
                        MessageBox.Show("Неверные дванные", "Ошибка!");
                        Console.WriteLine("Incorrect data");
                        continue;
                    }
                    string location = fields[1];
                    if (!CheckingNameOfProduct(fields[2]))
                    {
                        MessageBox.Show("Неверные дванные", "Ошибка!");
                        Console.WriteLine("Incorrect data");
                        continue;
                    }
                    string nameOfProduct = fields[2];
                    int price = Convert.ToInt32(fields[3]);
                    if (!CheckRangeOfPrice(price))
                    {
                        MessageBox.Show("Неверные дванные", "Ошибка!");
                        Console.WriteLine("Incorrect data");
                        continue;
                    }
                    if (!CheckTypeOfMethod(fields[4]))
                    {
                        MessageBox.Show("Неверные дванные", "Ошибка!");
                        Console.WriteLine("Incorrect data");
                        continue;
                    }
                    bool typeOfPayment = ConvertTypeOfMethod(fields[4]);
                    ProductNode nodeforMyList = new ProductNode(fields[0], fields[2]);
                    if (!myTable.Search(nodeforMyList))
                    {
                        MessageBox.Show($"Человек с логином { fields[0]} отсутствует в базе", "Ошибка!");
                        Console.WriteLine($"there is no { fields[0]} person in hash table");
                        continue;
                    };
                    SaleNode saleNode = new SaleNode();
                    saleNode.login = login;
                    saleNode.address = location;
                    saleNode.product = nameOfProduct;
                    saleNode.price = price;
                    saleNode.typeOfPayment = typeOfPayment;
                    sales.Add(saleNode);
                }
                CreateRBTree();
            }
        }

        public async void UpdateFile() // Нужен ли Async?
        {
            string path = @"InputSales.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var a in sales)
                {
                    string type = (a.typeOfPayment ? "безналичный" : "наличный");
                    string temp = "";
                    temp += a.login + "|" + a.address + "|" + a.product + "|" + a.price + "|" + type + "\r\n";
                    await writer.WriteAsync(temp);
                }
            }
        }
        static bool CheckingLogin(string s)
        {
            if (s.Length > 30) return false;
            if (s == "" || s == null) return false;
            if ((s[0] >= 'A' && s[0] <= 'Z') || (s[0] >= 'a' && s[0] <= 'z'))
            {
                for (int i = 1; i < s.Length; i++)
                {
                    if (!((s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= 'a' && s[0] <= 'z') || s[i] == '.' || s[i] == '_' || (s[i] >= '0' && s[i] <= '9')))
                    {
                        return false;
                    }
                }
                return true;
            }
            else return false;
        }
        static bool CheckingAdress(string s)
        {
            string[] dormitory = new string[18] { "город", "корпус 11", "корпус 10", "корпус 9", "корпус 8.1", "корпус 8.2", "корпус 7.1", "корпус 7.2", "корпус 6.1", "корпус 6.2", "корпус 1.10", "корпус 2.1", "корпус 2.2", "корпус 2.3", "корпус 2.4", "корпус 2.5", "корпус 2.6", "корпус 2.7" };
            int count = 0;
            foreach (string a in dormitory)
            {
                if (String.Compare(a, s) == 0) count++;
            }
            if (count == 1) return true;
            else return false;
        }
        static bool CheckingNameOfProduct(string s)
        {
            if (s.Length > 50) return false;
            if ((s[0] >= 'А' && s[0] <= 'Я') || (s[0] >= 'а' && s[0] <= 'я') || (s[0] >= 'a' && s[0] <= 'z') || (s[0] >= 'A' && s[0] <= 'Z')) // » «
            {
                for (int i = 1; i < s.Length; i++)
                {
                    if (!((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= 'А' && s[i] <= 'Я') || (s[i] >= 'а' && s[i] <= 'я') || s[i] == '.' || s[i] == ' ' || s[i] == '»' || s[i] == '«' || s[i] == '-' || (s[i] >= '0' && s[i] <= '9')))
                    {
                        return false;
                    }
                }
                return true;
            }
            else return false;
        }
        static bool CheckRangeOfPrice(int a)
        {
            return (a >= 0 && a <= 999999);
        }
        static bool CheckTypeOfMethod(string s)
        {
            return (s == "безналичный" || s == "наличный");

        }
        static bool ConvertTypeOfMethod(string a)
        {
            if (a == "наличный") return false;
            else return true;
        }
    }
}
