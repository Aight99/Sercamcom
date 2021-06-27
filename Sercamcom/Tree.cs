using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sercamcom
{
    enum Colour // Перечислимый тип, отвечающий за цвет узла
    {
        Red, // Красный цвет
        Black // Чёрный цвет
    }
    public struct Data // Структурный тип ключа, состоящий из двух полей
    {
        public int productCode;
        public List<SaleNode> indexList;
    }
    class Tree
    {

        public class Node // Класс узла
        {
            public Colour color;    // Поле цвета
            public Node left;       // Поле-узел слева
            public Node right;      // Поле-узел справа
            public Node parent;     // Поле-узел, являющийся родителем
            public Data data;       // Поле данных

            public Node(int code, SaleNode indexInList)
            {
                this.data.indexList = new List<SaleNode> { };
                this.data.productCode = code;
                this.data.indexList.Add(indexInList);
            }
            public Node(int code)
            {
                this.data.indexList = new List<SaleNode> { };
                this.data.productCode = code;
            }
            public Node(Colour color)
            {
                this.data.indexList = new List<SaleNode> { };
                this.color = color;
            }
            public Node(int code, Colour color, SaleNode indexInList)
            {
                this.data.indexList = new List<SaleNode> { };
                this.data.productCode = code;
                this.data.indexList.Add(indexInList);
                this.color = color;
            }

            ///
            /// Перегрузки сравнений 
            /// 

            public bool IsLess(Node node2)
            {
                return (this.data.productCode < node2.data.productCode);
            }
            public bool IsMore(Node node2)
            {
                return (this.data.productCode > node2.data.productCode);
            }
            public bool IsEqual(Node node2)
            {
                return (this.data.productCode == node2.data.productCode);
            }

        }

        private Node root; // Узел-корень дерева
        private Node nil; // Пустой узел-лист дерева

        public Tree()
        {
            nil = new Node(Colour.Black);
            nil.parent = nil;
            nil.left = nil;
            nil.right = nil;
            nil.data.productCode = 0;
            nil.data.indexList = new List<SaleNode> { };
            root = nil;
        }

        public void Clear()
        {
            Console.WriteLine("Clearing the tree.");
            while (root != nil)
                Delete(root);
            DisplayTree();
        }

        ///
        /// Повороты
        /// 

        private void LeftRotate(Node X)
        {
            Node Y = X.right; // set Y
            X.right = Y.left; // turn Y's left subtree into X's right subtree

            if (Y.left != nil)
                Y.left.parent = X;

            if (Y != nil)
                Y.parent = X.parent; // link X's parent to Y

            if (X.parent == nil)
                root = Y;
            else if (X == X.parent.left)
                X.parent.left = Y;
            else
                X.parent.right = Y;

            Y.left = X; // put X on Y's left

            if (X != nil)
                X.parent = Y;
        }
        private void RightRotate(Node Y)
        {
            Node X = Y.left;
            Y.left = X.right;

            if (X.right != nil)
                X.right.parent = Y;

            if (X != nil)
                X.parent = Y.parent;

            if (Y.parent == nil)
                root = X;
            else if (Y == Y.parent.right)
                Y.parent.right = X;
            else
                Y.parent.left = X;

            X.right = Y; // put Y on X's right

            if (Y != nil)
                Y.parent = X;
        }

        /// 
        /// Поиски
        /// 

        public SaleNode FindSale(SaleNode index)
        {
            int code = index.GetProductCode();
            bool isFound = false;
            Node temp = root;
            Node node = new Node(code);

            while (!isFound)
            {
                if (temp == nil)
                    break;
                if (node.IsLess(temp))
                    temp = temp.left;
                else if (node.IsMore(temp))
                    temp = temp.right;
                else
                    isFound = true;
            }

            if (isFound)
            {
                foreach (var sale in temp.data.indexList)
                {
                    if (isEquals(sale, index))
                    {
                        Console.WriteLine($"Found! {sale.product} from {sale.login} : {sale.GetProductCode()}");
                        return sale;
                    }
                }
                return null;
            }
            else
                return null;
        }
        public SaleNode FindSale(string login, string product)
        {
            int code = 0;
            for (int i = 0; i < product.Length; i++)
            {
                code += (int)product[i];
            }
            bool isFound = false;
            Node temp = root;
            Node node = new Node(code);

            while (!isFound)
            {
                if (temp == nil)
                    break;
                if (node.IsLess(temp))
                    temp = temp.left;
                else if (node.IsMore(temp))
                    temp = temp.right;
                else
                    isFound = true;
            }
            if (isFound)
            {
                foreach (var sale in temp.data.indexList)
                {
                    if (sale.login == login)
                    {
                        return sale;
                    }
                }
            }
            return null;
        }

        //public SaleNode FindSaleWithCount(string login, string product)
        //{
        //    int compare = 0;
        //    int code = 0;
        //    for (int i = 0; i < product.Length; i++)
        //    {
        //        code += (int)product[i];
        //    }
        //    bool isFound = false;
        //    Node temp = root;
        //    Node node = new Node(code);

        //    while (!isFound)
        //    {
        //        compare++;
        //        if (temp == nil)
        //            break;
        //        if (node.IsLess(temp))
        //            temp = temp.left;
        //        else if (node.IsMore(temp))
        //            temp = temp.right;
        //        else
        //            isFound = true;
        //    }
        //    if (isFound)
        //    {
        //        foreach (var sale in temp.data.indexList)
        //        {
        //            compare++;
        //            if (sale.login == login)
        //            {
        //                MessageBox.Show($"Сравнений - {compare}", "Результаты поиска");
        //                return sale;
        //            }
        //        }
        //    }
        //    MessageBox.Show($"Сравнений - {compare}", "Результаты поиска");
        //    return null;
        //}
        public List<SaleNode> FindSaleWithCount(string login, string product)
        {
            List<SaleNode> result = new List<SaleNode>();
            int compare = 0;
            int code = 0;
            for (int i = 0; i < product.Length; i++)
            {
                code += (int)product[i];
            }
            bool isFound = false;
            Node temp = root;
            Node node = new Node(code);

            while (!isFound)
            {
                compare++;
                if (temp == nil)
                    break;
                if (node.IsLess(temp))
                    temp = temp.left;
                else if (node.IsMore(temp))
                    temp = temp.right;
                else
                    isFound = true;
            }
            if (isFound)
            {
                foreach (var sale in temp.data.indexList)
                {
                    compare++;
                    if (sale.login == login)
                    {
                        result.Add(sale);
                    }
                }
            }
            MessageBox.Show($"Сравнений - {compare}", "Результаты поиска");
            if (result.Count == 0)
            {
                return null;
            }
            else
            {
                return result;
            }
        }


        public Node FindNode(int code)
        {
            bool isFound = false;
            Node temp = root;
            Node node = new Node(code);

            while (!isFound)
            {
                if (temp == nil)
                    break;
                if (node.IsLess(temp))
                    temp = temp.left;
                else if (node.IsMore(temp))
                    temp = temp.right;
                else
                    isFound = true;
            }

            if (isFound)
                return temp;
            else
                return nil;
        }
        public Node FindNode(SaleNode index)
        {
            int code = index.GetProductCode();
            bool isFound = false;
            Node temp = root;
            Node node = new Node(code);

            while (!isFound)
            {
                if (temp == nil)
                    break;
                if (node.IsLess(temp))
                    temp = temp.left;
                else if (node.IsMore(temp))
                    temp = temp.right;
                else
                    isFound = true;
            }

            if (isFound)
            {
                foreach (var sale in temp.data.indexList)
                {
                    if (isEquals(sale, index))
                    {
                        Console.WriteLine($"Found! {sale.product} from {sale.login} : {sale.GetProductCode()}");
                        return temp;
                    }
                }
                return nil;
            }
            else
                return nil;
        }
        public Node FindMinimum()
        {
            Node node = FindMinimum(root);
            Console.WriteLine("Minimal node {0} in the tree was found.", node.data.productCode);
            return node;
        }
        public Node FindMinimum(Node node)
        {
            Node temp = node;

            if (temp == nil)
                return nil;

            while (temp.right != nil)
                temp = temp.right;

            return temp;
        }

        /// 
        /// Выводы и обходы
        /// 

        public void DisplayTree()
        {
            if (root == nil)
            {
                Console.WriteLine("The tree is empty.");
                return;
            }
            if (root != nil)
            {
                TraversalNLR();
                Console.WriteLine("____________________________________");
            }
        }
        private void Display(Node current, int n)
        {
            if (current != nil)
            {
                Display(current.right, n + 1);
                Console.Write("  ");
                Console.Write("{0}", current.data.productCode);
                if (current.color == Colour.Black)
                    Console.WriteLine(" (B)");
                else
                    Console.WriteLine(" (R)");

                Display(current.left, n + 1);
            }
        }
        public void TraversalNLR()
        {
            Console.WriteLine("Pre-order NLR");
            TraversalNLR(root);
            if (root == nil)
                Console.WriteLine("Empty tree.");
            Console.WriteLine();
        }
        private void TraversalNLR(Node current)
        {
            if (current != nil)
            {
                Console.Write("{0} : {1} [{2}] ", current.data.indexList[0].product, current.data.productCode, current.color);
                TraversalNLR(current.left);
                TraversalNLR(current.right);
            }
        }
        public void TraversalLNR()
        {
            Console.WriteLine("In-order LNR");
            TraversalLNR(root);
            if (root == nil)
                Console.WriteLine("Empty tree.");
            Console.WriteLine();
        }
        private void TraversalLNR(Node current)
        {
            if (current != nil)
            {
                TraversalLNR(current.left);
                Console.Write("{0} ", current.data.productCode);
                TraversalLNR(current.right);
            }
        }
        public void TraversalRNL()
        {
            Console.WriteLine("Reverse in-order RNL");
            TraversalRNL(root);
            if (root == nil)
                Console.WriteLine("Empty tree.");
            Console.WriteLine();
        }
        private void TraversalRNL(Node current)
        {
            if (current != nil)
            {
                TraversalRNL(current.right);
                Console.Write("{0} ", current.data.productCode);
                TraversalRNL(current.left);
            }
        }
        public void TraversalLRN()
        {
            Console.WriteLine("Post-order LRN");
            TraversalLRN(root);
            if (root == nil)
                Console.WriteLine("Empty tree.");
            Console.WriteLine();
        }
        private void TraversalLRN(Node current)
        {
            if (current != nil)
            {
                TraversalLRN(current.left);
                TraversalLRN(current.right);
                Console.Write("{0} ", current.data.productCode);
            }
        }


        // Добавляет новый узел в дерево по правилу вставки в бинарное дерево
        // Формальные параметры: поля структуры ключа day и month
        // Входные данные: дерево
        // Выходные данные: дерево с новым узлом, удовлетворяющее свойствам КЧ дерева
        public void Insert(int code, SaleNode index)
        {
            Node Z = new Node(code, index);
            Node Y = nil;
            Node X = root;

            while (X != nil)
            {
                Y = X;
                if (Z.IsEqual(X))
                {
                    this.FindNode(code).data.indexList.Add(index);
                    return;
                }
                else if (Z.IsLess(X))
                    X = X.left;
                else
                    X = X.right;
            }
            Z.parent = Y;

            if (Y == nil)
                root = Z;
            else if (Z.IsLess(Y))
                Y.left = Z;
            else
                Y.right = Z;

            Z.left = nil;
            Z.right = nil;
            Z.color = Colour.Red; // colour the new node red

            InsertFixUp(Z); // call method to check for violations and fix
        }
        public void Insert(SaleNode index)
        {
            int code = index.GetProductCode();
            Node Z = new Node(code, index);
            Node Y = nil;
            Node X = root;

            while (X != nil)
            {
                Y = X;
                if (Z.IsEqual(X))
                {
                    this.FindNode(code).data.indexList.Add(index);
                    return;
                }
                else if (Z.IsLess(X))
                    X = X.left;
                else
                    X = X.right;
            }
            Z.parent = Y;

            if (Y == nil)
                root = Z;
            else if (Z.IsLess(Y))
                Y.left = Z;
            else
                Y.right = Z;

            Z.left = nil;
            Z.right = nil;
            Z.color = Colour.Red; // colour the new node red

            InsertFixUp(Z); // call method to check for violations and fix
        }
        public void InsertAndDisplay(int code, SaleNode index)
        {
            Console.WriteLine("Inserting {0} ", code);
            this.Insert(code, index);
            this.DisplayTree();
        }

        // Проверяет, нарушены ли свойства КЧ дерева после вставки узла, и исправляет нарушения
        private void InsertFixUp(Node Z)
        {
            while (Z != root && Z.parent.color == Colour.Red)
            {
                if (Z.parent == Z.parent.parent.left)
                {
                    Node Y = Z.parent.parent.right;

                    if (Y.color == Colour.Red) // Case 1: uncle is red
                    {
                        Z.parent.color = Colour.Black;
                        Y.color = Colour.Black;
                        Z.parent.parent.color = Colour.Red;
                        Z = Z.parent.parent;
                    }

                    else // Case 2: uncle is black
                    {
                        if (Z == Z.parent.right)
                        {
                            Z = Z.parent;
                            LeftRotate(Z);
                        }
                        // Case 3: recolour & rotate
                        Z.parent.color = Colour.Black;
                        Z.parent.parent.color = Colour.Red;
                        RightRotate(Z.parent.parent);
                    }
                }
                else
                {
                    Node X = Z.parent.parent.left;

                    if (X.color == Colour.Red) // Case 1
                    {
                        Z.parent.color = Colour.Black;
                        X.color = Colour.Black;
                        Z.parent.parent.color = Colour.Red;
                        Z = Z.parent.parent;
                    }

                    else // Case 2
                    {
                        if (Z == Z.parent.left)
                        {
                            Z = Z.parent;
                            RightRotate(Z);
                        }
                        // Case 3 
                        Z.parent.color = Colour.Black;
                        Z.parent.parent.color = Colour.Red;
                        LeftRotate(Z.parent.parent);
                    }
                }
            }

            root.color = Colour.Black; // re-colour the root black as necessary
        }
        private void Transplant(Node X, Node Y)
        {
            if (X.parent == nil)
                root = Y;
            else if (X == X.parent.left)
                X.parent.left = Y;
            else
                X.parent.right = Y;

            Y.parent = X.parent;
        }
        public SaleNode Delete(SaleNode sale)
        {
            Node node = FindNode(sale.GetProductCode());
            if (node.data.indexList.Count > 1)
            {
                node.data.indexList.Remove(sale); // Надо, чтобы оно вернуло значение того нода, что удалило
                return sale;
            }
            Delete(node);
            return node.data.indexList.Find(x => isEquals(x, sale));
        }
        public bool isEquals(SaleNode salesNode, SaleNode node)
        {
            return (salesNode.login == node.login &&
                    salesNode.address == node.address &&
                    salesNode.product == node.product &&
                    salesNode.price == node.price &&
                    salesNode.typeOfPayment == node.typeOfPayment);
        }
        public void Delete(Node Z)
        {
            Node Y = Z;
            Node X = nil;
            Colour SavedColor = Y.color;

            if (Z == nil)
            {
                Console.WriteLine("Nothing to delete!");
                return;
            }
            if (Z.left == nil)
            {
                X = Z.right;
                Transplant(Z, Z.right);
            }
            else if (Z.right == nil)
            {
                X = Z.left;
                Transplant(Z, Z.left);
            }
            else
            {
                Y = FindMinimum(Z.left);
                Console.WriteLine("Minimum: {0} ", Y.data.productCode);
                if (Y == nil)
                {
                    Console.WriteLine("Node does not have minimum.");
                    return;
                }
                SavedColor = Y.color;
                X = Y.left;
                if (Y.parent == Z)
                    X.parent = Y;
                else
                {
                    Transplant(Y, Y.left);
                    Y.left = Z.left;
                    Y.left.parent = Y;
                }
                Transplant(Z, Y);

                Y.right = Z.right;
                Y.right.parent = Y;
                Y.color = Z.color;
            }

            if (SavedColor == Colour.Black)
                DeleteFixUp(X);
        }
        private void DeleteFixUp(Node X)
        {

            while (X != root && X.color == Colour.Black)
            {
                Node Y = X.parent;
                if (X == Y.right)
                {
                    Node W = Y.left;

                    if (W.color == Colour.Red)
                    {
                        W.color = Colour.Black; //case 1
                        Y.color = Colour.Red;
                        //LeftRotate(Y);
                        RightRotate(Y);
                        W = Y.left;
                    }

                    if (W.right.color == Colour.Black && W.left.color == Colour.Black)
                    {
                        W.color = Colour.Red; //case 2
                        X = Y;
                    }
                    else
                    {
                        if (W.left.color == Colour.Black)
                        {
                            W.right.color = Colour.Black; //case 3
                            W.color = Colour.Red;
                            //RightRotate(W);
                            LeftRotate(W);
                            W = Y.left;
                        }

                        W.color = Y.color; //case 4
                        Y.color = Colour.Black;
                        W.left.color = Colour.Black;
                        //LeftRotate(Y);
                        RightRotate(Y);
                        X = root;
                    }
                }
                else //mirror code from above with "left" & "right" exchanged
                {
                    Node W = Y.right;

                    if (W.color == Colour.Red)
                    {
                        W.color = Colour.Black;
                        Y.color = Colour.Red;
                        //RightRotate(Y);
                        LeftRotate(Y);
                        W = Y.right;
                    }

                    if (W.left.color == Colour.Black && W.right.color == Colour.Black)
                    {
                        W.color = Colour.Red;
                        X = Y;
                    }
                    else
                    {
                        if (W.right.color == Colour.Black)
                        {
                            W.left.color = Colour.Black;
                            W.color = Colour.Red;
                            //LeftRotate(W);
                            RightRotate(W);
                            W = Y.right;
                        }

                        W.color = Y.color;
                        Y.color = Colour.Black;
                        W.right.color = Colour.Black;
                        //RightRotate(Y);
                        LeftRotate(Y);
                        X = root;
                    }
                }
            }

            X.color = Colour.Black;
        }
    }
}
