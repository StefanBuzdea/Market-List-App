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
	public static class DeleteBtns
	{
        public static void buttonDel6_Click(object sender, EventArgs e, List<ShoppingListItem> shopList, ListBox lstShoppingList)
        {
            if (lstShoppingList.SelectedIndex != -1)
            {
                var selectedItem = shopList[lstShoppingList.SelectedIndex];
                if (selectedItem.Quantity > 1)
                {
                    selectedItem.Quantity -= 0.50m;
                    lstShoppingList.Items[lstShoppingList.SelectedIndex] = $"{selectedItem.Name} ({selectedItem.Quantity.ToString("N0")})";
                }
                else
                {
                    shopList.RemoveAt(lstShoppingList.SelectedIndex);
                    lstShoppingList.Items.RemoveAt(lstShoppingList.SelectedIndex);
                }
            }
        }

        public static void buttonDeleteAll_Click(object sender, EventArgs e, List<ShoppingListItem> shopList, ListBox lstShoppingList)
        {
            lstShoppingList.Items.Clear();
            shopList.Clear();
        }

    }
}
