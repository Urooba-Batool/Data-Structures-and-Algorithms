using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Single_Linked_List list = new Single_Linked_List();

            list.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            list.head.next = second;
            second.next = third;

            list.push(7);
            list.insertAfter(second, 5);
            list.append(9);
            list.printList();
            
        }
    }
}
