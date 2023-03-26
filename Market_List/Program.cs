using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using App_Market_List;
namespace ShoppingListApp
{
    public class ShoppingList
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            string jsonFilePath = "shoppingList.json";
            JArray shoppingList = LoadShoppingList(jsonFilePath);

            Console.WriteLine("Your current shopping list:");
            Console.WriteLine("==========================");

            foreach (JObject item in shoppingList)
            {
                Console.WriteLine(item.GetValue("Name") + " - " + item.GetValue("Quantity"));
            }

            Console.WriteLine("==========================");

            Console.WriteLine("Enter item name (or \"exit\" to quit):");
            string itemName = Console.ReadLine();

            while (itemName != "exit")
            {
                Console.WriteLine("Enter quantity:");
                int quantity = Convert.ToInt32(Console.ReadLine());

                JObject newItem = new JObject();
                newItem.Add("Name", itemName);
                newItem.Add("Quantity", quantity);
                shoppingList.Add(newItem);

                Console.WriteLine(itemName + " - " + quantity + " added to shopping list.");
                Console.WriteLine("Enter item name (or \"exit\" to quit):");
                itemName = Console.ReadLine();
            }

            SaveShoppingList(shoppingList, jsonFilePath);
            Console.WriteLine("Shopping list saved.");
        }

        static JArray LoadShoppingList(string filePath)
        {
            JArray shoppingList;

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                shoppingList = JArray.Parse(json);
            }
            else
            {
                shoppingList = new JArray();
            }

            return shoppingList;
        }

        static void SaveShoppingList(JArray shoppingList, string filePath)
        {
            string json = shoppingList.ToString();
            File.WriteAllText(filePath, json);
        }
    }
}
