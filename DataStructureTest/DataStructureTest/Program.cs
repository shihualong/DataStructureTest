using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrrayList
            //MyArrayList arr = new MyArrayList();
            //Console.WriteLine("arr当前的容量为：" + arr.Capacity + "  长度为：" + arr.Count);

            //arr.Add(1);
            //Console.WriteLine("arr当前的容量为：" + arr.Capacity + "  长度为：" + arr.Count);

            //for (int i = 2; i < 6; i++)
            //{
            //    arr.Add(i);
            //}
            //Console.WriteLine("arr当前的容量为：" + arr.Capacity + "  长度为：" + arr.Count);

            //arr.Deleted(arr.Count - 1);
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    Console.WriteLine("第" + i + "个元素为： " + arr[i].ToString());
            //}
            //Console.WriteLine("arr当前的容量为：" + arr.Capacity + "  长度为：" + arr.Count);

            //arr.TrimToSize();

            //Console.WriteLine("arr当前的容量为：" + arr.Capacity + "  长度为：" + arr.Count);

            //Console.ReadLine(); 
            #endregion
            #region MyRegion
            CirculationLinkList lst = new CirculationLinkList();
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
            lst.Add(6);
            Console.WriteLine(lst.ToString());

            Console.WriteLine(lst.CurrentNode.ToString());
            lst.RemoveCurrNode();

            Console.WriteLine(lst.ToString());
            lst.Move(3);

            Console.WriteLine(lst.ToString());
            Console.ReadLine();
            #endregion
            
        }
    }
}
