using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using System.Diagnostics;

namespace BTree.UT
{
    class Test
    {
        public static void Main()
        {
            //Tree ArvoreB = new Tree();
            BTree<string, int> tree = new BTree<string, int>(5);

            DateTime time = DateTime.Now;

            int j = 0;
            for (int i = 0; i < 500000; i++)
            {
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);
                tree.Insert(string.Format("j = {0}", j), j++);


                //if (i % 10000 == 0)
                {
                    //  Console.WriteLine("i = {0}", i);
                    //Console.ReadKey();
                }
            }


            DateTime time2 = DateTime.Now;
            Entry<string, int> local = tree.Search("j = 65545");
            DateTime time3 = DateTime.Now;
            Entry<string, int> local1 = tree.Search("j = 195876");
            DateTime time4 = DateTime.Now;
            Entry<string, int> local2 = tree.Search("j = 1");
            DateTime time5 = DateTime.Now;
            Entry<string, int> local3 = tree.Search("j = 2499999");
            DateTime time6 = DateTime.Now;

            Console.WriteLine("Tempo para inserir: " + (time2 - time));
            Console.WriteLine(local.Key + "\t" + local.Pointer);
            Console.WriteLine("Tempo para pesquisar local: " + (time3 - time2));
            Console.WriteLine(local1.Key + "\t" + local1.Pointer);
            Console.WriteLine("Tempo para pesquisar local1: " + (time4 - time3));
            Console.WriteLine(local2.Key + "\t" + local2.Pointer);
            Console.WriteLine("Tempo para pesquisar local2: " + (time5 - time4));
            Console.WriteLine(local3.Key + "\t" + local3.Pointer);
            Console.WriteLine("Tempo para pesquisar local3: " + (time6 - time5));

            TextWriter ex = File.CreateText("teste.txt");
            Stopwatch timea = Stopwatch.StartNew();
            ex.WriteLine("Start: " + timea.ElapsedMilliseconds);
            Random number = new Random();

            Stopwatch timeaux;
            Entry<string, int> aux;
            for (int k = 0; k < 1000000; k++)
            {
                timeaux = Stopwatch.StartNew();
                aux = tree.Search("j = " + number.Next(0, j));
                timeaux.Stop();

                ex.WriteLine(aux.Key + "\t" + aux.Pointer);
                ex.WriteLine("Tempo para pesquisar " + k + ": " + timeaux.ElapsedMilliseconds + "\n");
            }
            ex.WriteLine("End: " + timea.ElapsedMilliseconds);
            ex.Close();


            foreach (var entry in tree.Root.Entries)
            {
                Console.WriteLine("Key: {0}\tPointer: {1}", entry.Key, entry.Pointer);
            }
            Console.WriteLine("Has reached max entries? " + tree.Root.HasReachedMaxEntries);
            Console.WriteLine("Has reached min entries? " + tree.Root.HasReachedMinEntries);
            Console.WriteLine("Tree height is " + tree.Height);

            for (int i = 0; i < 50000; i++)
            {
                tree.Delete(String.Format("j = {0}", j++));
            }




            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();


        }
    }
}
