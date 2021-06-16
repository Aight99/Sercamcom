using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sercamcom
{
    enum Colour // Перечислимый тип, отвечающий за цвет узла
    {
        Red, // Красный цвет
        Black // Чёрный цвет
    }
    public struct Data // Структурный тип ключа, состоящий из двух полей
    {
        public byte day; // Целочисленное поле дня
        public byte month; // Целочисленное поле месяца
    }
    class Tree
    {
        public class Node // Класс узла
        {
            public Colour color;      // Поле цвета
            public Node left;        // Поле-узел слева
            public Node right;        // Поле-узел справа
            public Node parent;        // Поле-узел, являющийся родителем
            public ushort count = 1;    // Счётчик вставок узла с данным ключом в дерево //TO DELETE
            public Data data = new Data();  // Поле данных


            // 

            public Node(byte day, byte month)
            {
                this.data.day = day;
                this.data.month = month;
                // Проверка ввода
                if (day == 0 || day > 31 || month == 0 || month > 13 || (day > 29 && month == 2))
                {
                    Console.WriteLine("Invalid data. Creating node 1.1");
                    this.data.day = 1;
                    this.data.month = 1;
                }
            }
            public Node(Colour color)
            {
                this.color = color;
            }

            public Node(byte day, byte month, Colour color) //TO DELETE
            {
                this.data.day = day;
                this.data.month = month;
                if (day == 0 || day > 31 || month == 0 || month > 13 || (day > 29 && month == 2))
                {
                    Console.WriteLine("Invalid data. Creating node 1.1");
                    this.data.day = 1;
                    this.data.month = 1;
                }
                this.color = color;
            }


            // Перегрузки сравнений 

            // Проверяет, меньше ли ключ первого узла, чем ключ второго узла
            // Выходные данные: True или False
            public bool IsLess(Node node2)
            {
                return (data.month < node2.data.month) || (data.month == node2.data.month && data.day < node2.data.day);
            }

            // Проверяет, больше ли ключ первого узла, чем ключ второго узла
            // Выходные данные: True или False
            public bool IsMore(Node node2)
            {
                return (data.month > node2.data.month) || (data.month == node2.data.month && data.day > node2.data.day);
            }

            // Проверяет, равны ли ключи первого и второго узлов
            // Выходные данные: True или False
            public bool IsEqual(Node node2)
            {
                return data.month == node2.data.month && data.day == node2.data.day;
            }

        }

        private Node root; // Узел-корень дерева
        private Node nil; // Пустой узел-лист дерева


        // Конструктор дерева
        // Формальные параметры: пусто
        // Входные данные: узлы root и nil
        // Выходные данные: инициализация чёрного узла nil, root = nil
        public Tree()
        {
            nil = new Node(Colour.Black);
            nil.parent = nil;
            nil.left = nil;
            nil.right = nil;
            nil.data.day = 0;
            nil.data.month = 0;
            root = nil;
        }

        // Удаляет все элементы дерева, освобождая память
        // Формальные параметры: пусто
        // Входные данные: дерево
        // Выходные данные: root = nil
        public void Clear()
        {
            Console.WriteLine("Clearing the tree.");
            while (root != nil)
                Delete(root);
            DisplayTree();
        }


        // Вращает дерево налево относительно узла
        // Формальные параметры: узел X
        // Входные данные: дерево
        // Выходные данные: дерево с изменёнными связями около X
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

        // Вращает дерево направо относительно узла
        // Формальные параметры: узел X
        // Входные данные: дерево
        // Выходные данные: дерево с изменёнными связями около X
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

        // Нахождение узла с заданным ключом в дереве
        // Формальные параметры: поля структуры ключа day и month
        // Входные данные: дерево
        // Выходные данные: узел с заданным ключом
        public Node Find(byte day, byte month)
        {
            bool isFound = false;
            Node temp = root;
            Node node = new Node(day, month);

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

        // Нахождение узла с минимальным ключом в дереве
        // Формальные параметры: пусто
        // Входные данные: дерево
        // Выходные данные: узел с минимальным ключом
        public Node FindMinimum()
        {
            Node node = FindMinimum(root);
            Console.WriteLine("Minimal node {0}.{1} in the tree was found.", node.data.day, node.data.month);
            return node;
        }

        // Нахождение узла с минимальным ключом в поддереве
        // Формальные параметры: узел-корень node поддерева
        // Входные данные: дерево
        // Выходные данные: узел с минимальным ключом в поддереве
        public Node FindMinimum(Node node)
        {
            Node temp = node;

            if (temp == nil)
                return nil;

            while (temp.right != nil)
                temp = temp.right;

            return temp;
        }

        // Выводит значения полей узлов дерева на экран с учётом связей
        // Формальные параметры: пусто
        // Входные данные: дерево
        // Выходные данные: значения узлов дерева по порядку
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
                //Display(root, 0);
                Console.WriteLine("____________________________________");
            }
        }

        // Выводит значения полей узлов поддерева на экран с учётом связей
        // Формальные параметры: узел-корень поддерева, число пробелов n
        // Входные данные: дерево
        // Выходные данные: значения узлов поддерева по порядку
        private void Display(Node current, int n)
        {
            if (current != nil)
            {
                Display(current.right, n + 1);
                Console.Write("  ");
                Console.Write("{0}.{1}", current.data.day, current.data.month);
                if (current.color == Colour.Black)
                    Console.WriteLine(" (B, {0})", current.count);
                else
                    Console.WriteLine(" (R, {0})", current.count);

                Display(current.left, n + 1);
            }
        }

        // Выводит ключи узлов согласно прямому обходу дерева
        // Формальные параметры: пусто
        // Входные данные: дерево
        // Выходные данные: значения узлов дерева в порядке КЛП
        public void TraversalNLR()
        {
            Console.WriteLine("Pre-order NLR");
            TraversalNLR(root);
            if (root == nil)
                Console.WriteLine("Empty tree.");
            Console.WriteLine();
        }

        // Выводит ключи узлов согласно прямому обходу поддерева
        // Формальные параметры: узел-корень current поддерева
        // Входные данные: дерево
        // Выходные данные: значения узлов поддерева в порядке КЛП
        private void TraversalNLR(Node current)
        {
            if (current != nil)
            {
                Console.Write("{0}.{1} [{2}] ", current.data.day, current.data.month, current.color);
                TraversalNLR(current.left);
                TraversalNLR(current.right);
            }
        }

        // Выводит ключи узлов согласно симметричному обходу дерева
        // Формальные параметры: пусто
        // Входные данные: дерево
        // Выходные данные: значения узлов дерева в порядке ЛКП
        public void TraversalLNR()
        {
            Console.WriteLine("In-order LNR");
            TraversalLNR(root);
            if (root == nil)
                Console.WriteLine("Empty tree.");
            Console.WriteLine();
        }

        // Выводит ключи узлов согласно симметричному обходу поддерева
        // Формальные параметры: узел-корень current поддерева
        // Входные данные: дерево
        // Выходные данные: значения узлов поддерева в порядке ЛКП
        private void TraversalLNR(Node current)
        {
            if (current != nil)
            {
                TraversalLNR(current.left);
                Console.Write("{0}.{1} ", current.data.day, current.data.month);
                TraversalLNR(current.right);
            }
        }

        // Выводит ключи узлов согласно обратному симметричному обходу дерева
        // Формальные параметры: пусто
        // Входные данные: дерево
        // Выходные данные: значения узлов дерева в порядке ПКЛ
        public void TraversalRNL()
        {
            Console.WriteLine("Reverse in-order RNL");
            TraversalRNL(root);
            if (root == nil)
                Console.WriteLine("Empty tree.");
            Console.WriteLine();
        }

        // Выводит ключи узлов согласно обратному симметричному обходу поддерева
        // Формальные параметры: узел-корень current поддерева
        // Входные данные: дерево
        // Выходные данные: значения узлов поддерева в порядке ПКЛ
        private void TraversalRNL(Node current)
        {
            if (current != nil)
            {
                TraversalRNL(current.right);
                Console.Write("{0}.{1} ", current.data.day, current.data.month);
                TraversalRNL(current.left);
            }
        }

        // Выводит ключи узлов согласно обратному обходу дерева
        // Формальные параметры: пусто
        // Входные данные: дерево
        // Выходные данные: значения узлов дерева в порядке ЛПК
        public void TraversalLRN()
        {
            Console.WriteLine("Post-order LRN");
            TraversalLRN(root);
            if (root == nil)
                Console.WriteLine("Empty tree.");
            Console.WriteLine();
        }

        // Выводит ключи узлов согласно обратному обходу поддерева
        // Формальные параметры: узел-корень current поддерева
        // Входные данные: дерево
        // Выходные данные: значения узлов поддерева в порядке ЛПК
        private void TraversalLRN(Node current)
        {
            if (current != nil)
            {
                TraversalLRN(current.left);
                TraversalLRN(current.right);
                Console.Write("{0}.{1} ", current.data.day, current.data.month);
            }
        }


        // Добавляет новый узел в дерево по правилу вставки в бинарное дерево
        // Формальные параметры: поля структуры ключа day и month
        // Входные данные: дерево
        // Выходные данные: дерево с новым узлом, удовлетворяющее свойствам КЧ дерева
        public void Insert(byte day, byte month)
        {
            if (day == 0 || day > 31 || month == 0 || month > 12 || (day > 29 && month == 2))
            {
                Console.WriteLine("Invalid data.");
                return;
            }

            Node Z = new Node(day, month);
            Node Y = nil;
            Node X = root;

            while (X != nil)
            {
                Y = X;
                if (Z.IsEqual(X))
                {
                    X.count++;
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

        // Добавляет новый узел в дерево по правилу вставки в бинарное дерево и выводит дерево на экран
        // Формальные параметры: поля структуры ключа day и month
        // Входные данные: дерево
        // Выходные данные: дерево с новым узлом, удовлетворяющее свойствам КЧ дерева,
        //          и его изображение на экране
        public void InsertAndDisplay(byte day, byte month)
        {
            Console.WriteLine("Inserting {0}.{1}", day, month);
            this.Insert(day, month);
            this.DisplayTree();
        }

        // Проверяет, нарушены ли свойства КЧ дерева после вставки узла, и исправляет нарушения
        // Формальные параметры: вставленный узел Z
        // Входные данные: дерево
        // Выходные данные: дерево, удовлетворяющее свойствам КЧ дерева
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

        // Меняет поддеревья местами
        // Формальные параметры: узел X, узел Y
        // Входные данные: дерево
        // Выходные данные: дерево с изменёнными связями
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

        // Удаляет узел из дерева по правилу удаления в бинарном дереве
        // Формальные параметры: поля структуры ключа day и month
        // Входные данные: дерево
        // Выходные данные: дерево без узла, удовлетворяющее свойствам КЧ дерева
        public void Delete(byte day, byte month)
        {
            Node Z = Find(day, month);
            Delete(Z);
        }

        // Удаляет узел из дерева по правилу удаления в бинарном дереве
        // Формальные параметры: узел Z дерева
        // Входные данные: дерево
        // Выходные данные: дерево без узла, удовлетворяющее свойствам КЧ дерева
        public void Delete(Node Z)
        {
            Node Y = Z;
            Node X = nil;
            Colour SavedColor = Y.color;

            if (Z.count > 1)
            {
                Z.count--;
                return;
            }
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
                Console.WriteLine("Minimum {0}.{1} was found.", Y.data.day, Y.data.month);
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

        // Удаляет узел из дерева по правилу удаления в бинарном дереве
        // Формальные параметры: поля структуры ключа day и month
        // Входные данные: дерево
        // Выходные данные: дерево без узла, удовлетворяющее свойствам КЧ дерева,
        //          и его изображение на экране
        public void DeleteAndDisplay(byte day, byte month)
        {
            Console.WriteLine("Deleting {0}.{1}", day, month);
            this.Delete(day, month);
            this.DisplayTree();
        }

        // Проверяет, нарушены ли свойства КЧ дерева после удаления узла, и исправляет нарушения
        // Формальные параметры: текущий узел X
        // Входные данные: дерево
        // Выходные данные: дерево, удовлетворяющее свойствам КЧ дерева
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
