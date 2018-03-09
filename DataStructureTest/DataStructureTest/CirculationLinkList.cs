using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureTest
{   

    class CirculationLinkList
    {  
        private class Node
        {
            public object item;
            public CirculationLinkList.Node next;
            public override string ToString()
            {
                return item.ToString();
            }
            public Node(object value)
            {
                item = value;
            }
            
        }
        private int count;

        private Node tail;

        private Node curPrev;

        public int Count
        {
            get { return count; }
        }
        public void Add(object value)
        {
            Node newNode = new Node(value);
            if (tail == null)
            {
                tail = newNode;
                tail.next = newNode;
                curPrev = newNode;
            }
            else
            {
                newNode.next = tail.next;
                tail.next = newNode;
                if (curPrev == tail)
                {
                    curPrev = newNode;
                }
                tail = newNode;
            }
            count++;
        }

        public void RemoveCurrNode()
        {
            if (tail == null)
            {
                ThrowNAOORE("null");
            }
            else if (count == 1)
            {
                tail = null;
                curPrev = null;
            }
            else
            {
                if (curPrev.next == tail)
                {
                    tail = curPrev;
                }
                curPrev.next = curPrev.next.next;
                count--;
            }
        }
        public void Move(int step)
        {
            if (step < 0)
            {
                ThrowNAOORE("step");
            }
            if (tail == null)
            {
                ThrowNAOORE("null");
            }
            for (int i = 0; i < step; i++)
            {
                curPrev = curPrev.next;
            }
        }
        public object CurrentNode
        {
            get { return curPrev.next.item; }
        }
        public override string ToString()
        {
            if (tail == null)
            {
                return string.Empty;
            }
            string s = "";
            Node head = tail.next;
            for (int i = 0; i < count; i++)
            {
                s += head.ToString() + "   ";
                head = head.next;
            }
            return s;
        }
        public void ThrowNAOORE(string name)
        {
            string message = "";
            StringBuilder sb = new StringBuilder("the" + name + message, 40);
            switch (name)
            {
                case "null":
                    message = "Node";
                    throw new ArgumentOutOfRangeException(name, sb.ToString());
                    break;
                case "step":
                    message = "is not less than zero";
                    throw new ArgumentOutOfRangeException(name, sb.ToString());
                    break;
                case "capacity":
                    message = "can not Null";
                    throw new ArgumentOutOfRangeException(name, sb.ToString());
                    break;
                default:
                    break;
            }
        }
    }
}
