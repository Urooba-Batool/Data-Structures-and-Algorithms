using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1D_Arrays_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Specify the size of the inventory: ");
            int size = Convert.ToInt32(Console.ReadLine());

            String[] inventory = new String[size];
            int count = 0;
            String itemName;
            char exit;

            Console.Write("Enter the number of inventory items you want to setup? : ");
            int items = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            if (items < size)
            {
                for (int i = 0; i < items; i++)
                {
                    Console.Write("Enter the item name: ");
                    inventory[count] = Console.ReadLine();
                    count++;
                }
                Console.WriteLine("Successful Inventory Setup");
            }
            else
            {
                Console.WriteLine("Items limit is exceeded");
            }

            do
            {
                Console.WriteLine("\n");
                Console.Write("Action list: \n 1.Add Items \n 2.Remove Items \n 3.Search Items \n 4.Display Inventory \nSelect actions: ");
                int action = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n");
                switch (action)
                {
                    case 1:
                        Console.Write("Enter the number of items you want to add in the inventory: ");
                        items = Convert.ToInt32(Console.ReadLine());
                        if ((count + items) <= size)
                        {
                            for (int i = 0; i < items; i++)
                            {
                                Console.Write("Enter the item name: ");
                                inventory[count] = Console.ReadLine();
                                count++;
                            }
                            Console.WriteLine("Items added successfully");
                        }
                        else
                        {
                            Console.WriteLine("Items exceeds inventory limit");
                        }
                        break;

                    case 2:
                        Console.Write("Enter the number of items you want to remove from the inventory: ");
                        items = Convert.ToInt32(Console.ReadLine());
                        bool itemsRemoved = false;
                        if (items < count)
                        {
                            if ((count - items) >= 0)
                            {
                                for (int i = 0; i < items; i++)
                                {
                                    Console.Write("Enter the item name: ");
                                    itemName = Console.ReadLine();
                                    for (int j = 0; j < count; j++)
                                    {
                                        if (itemName == inventory[j])
                                        {
                                            for (int k = j; k < count - 1; k++)
                                            {
                                                inventory[k] = inventory[k + 1];
                                            }
                                            --count;
                                            itemsRemoved = true;
                                            Console.WriteLine("Item removed successfully");
                                        }
                                    }

                                    if (itemsRemoved != true)
                                    {
                                        Console.WriteLine("Selected item not found in the inventory");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Items exceeds minimum inventory limit");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invenotry does not contain {0} items", items);
                        }
                        break;

                    case 3:
                        Console.Write("Enter the item name: ");
                        itemName = Console.ReadLine();
                        bool itemFound = false;
                        for (int i = 0; i < count; i++)
                        {
                            if (itemName == inventory[i])
                            {
                                itemFound = true;
                                Console.WriteLine("Item found in inventory");
                            }
                        }
                        if (itemFound != true)
                        {
                            Console.WriteLine("Item not found in the inventory");
                        }
                        break;

                    case 4:
                        Console.Write("All the items list in inventory\n");
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine("Item {0} in inventory: {1}", i + 1, inventory[i]);
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid action selected");
                        break;
                }

                Console.Write("Do you want to end the program? (y/n): ");
                exit = Convert.ToChar(Console.ReadLine());
            }
            while (exit == 'n' || exit == 'N');
        }
    }
}
