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
	public static class SearchBox
	{
        public static void searchBox_TextChanged(object sender, EventArgs e, List<ShoppingListItem> shopList, ListBox lstShoppingList, TextBox searchBox)
        {

            string searchValue = searchBox.Text.ToLower();
            lstShoppingList.Items.Clear();
            foreach (var item in shopList)
            {
                if (item.Name.ToLower().Contains(searchValue))
                {
                    lstShoppingList.Items.Add($"{item.Name} ({item.Quantity})");
                }
            }

        }
    }
}
