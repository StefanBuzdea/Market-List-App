using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyShoppingList;
using static App_Market_List.Form1;
namespace App_Market_List
{
	public static class Sort
	{
        public class ShoppingListItemAlphabeticalComparer : IComparer<ShoppingListItem>
        {
            public int Compare(ShoppingListItem x, ShoppingListItem y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        public static void buttonAlfSort_Click(object sender, EventArgs e, List<ShoppingListItem> shopList, ListBox lstShoppingList)
        {
            shopList.Sort(new ShoppingListItemAlphabeticalComparer()); // sortează lista alfabetic
            lstShoppingList.Items.Clear(); // șterge elementele vechi din ListBox

            // Adaugă elementele sortate în ListBox
            foreach (var item in shopList)
            {
                //lstShoppingList.Items.Add(item.ToString());
                lstShoppingList.Items.Add($"{item.Name} ({item.Quantity.ToString("N0")})");
            }
        }
        public class ShoppingListItemLengthComparer : IComparer<ShoppingListItem>
        {
            public int Compare(ShoppingListItem x, ShoppingListItem y)
            {
                return x.Name.Length.CompareTo(y.Name.Length);
            }
        }

        public static void buttonSort_Click(object sender, EventArgs e, List<ShoppingListItem> shopList, ListBox lstShoppingList)
        {
            shopList.Sort(new ShoppingListItemLengthComparer()); // sortează lista după lungimea numelui
            lstShoppingList.Items.Clear(); // șterge elementele vechi din ListBox

            // Adaugă elementele sortate în ListBox
            foreach (var item in shopList)
            {
                //lstShoppingList.Items.Add(item.ToString());
                lstShoppingList.Items.Add($"{item.Name} ({item.Quantity.ToString("N0")})");
            }
        }

        public static  void btnSortByQuantity_Click(object sender, EventArgs e, List<ShoppingListItem> shopList, ListBox lstShoppingList)
        {
            // Sortează lista de cumpărături în funcție de cantitatea fiecărui element
            shopList.Sort((x, y) => x.Quantity.CompareTo(y.Quantity));

            // Actualizează afișajul listei
            lstShoppingList.Items.Clear();
            foreach (var item in shopList)
            {
                lstShoppingList.Items.Add($"{item.Name} ({item.Quantity.ToString("N0")})");
            }
        }
    }
}
