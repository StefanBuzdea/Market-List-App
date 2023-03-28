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
    public static class AddProduct
    {
        public static void button1_Click(object sender, EventArgs e, List<ShoppingListItem> shopList, ListBox lstShoppingList, TextBox txtItemName1, TextBox txtQuantity1)
        {
            // Citim textul introdus de utilizator
            string item = txtItemName1.Text;
            int quantity = Convert.ToInt32(txtQuantity1.Text);
            //
            // Verificăm dacă numele produsului este gol
            if (string.IsNullOrWhiteSpace(txtItemName1.Text))
            {
                MessageBox.Show("Numele produsului este obligatoriu!");
                return;
            }

            // Verificăm dacă cantitatea este un număr valid
            if (!int.TryParse(txtQuantity1.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Cantitatea trebuie să fie un număr întreg pozitiv!");
                return;
            }

            //
            // Verificăm dacă textul este gol
            if (!string.IsNullOrWhiteSpace(item))
            {
                // Adăugăm elementul la lista de cumpărături
                var newItem = new ShoppingListItem(item, quantity);
                lstShoppingList.Items.Add($"{newItem.Name} ({newItem.Quantity})");
                shopList.Add(newItem);

                // Golește caseta de text pentru a permite utilizatorului să adauge un nou element
                txtItemName1.Clear();
                txtQuantity1.Clear();

            }
        }
        public static void button2_Click(object sender, EventArgs e, List<ShoppingListItem> shopList, ListBox lstShoppingList, TextBox txtItemName2, TextBox txtQuantity2)
        {
            // Citim textul introdus de utilizator
            string item = txtItemName2.Text;
            int quantity = Convert.ToInt32(txtQuantity2.Text);
            if (string.IsNullOrWhiteSpace(txtItemName2.Text))
            {
                MessageBox.Show("Numele produsului este obligatoriu!");
                return;
            }

            // Verificăm dacă cantitatea este un număr valid
            if (!int.TryParse(txtQuantity2.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Cantitatea trebuie să fie un număr întreg pozitiv!");
                return;
            }
            // Verificăm dacă textul este gol
            if (!string.IsNullOrWhiteSpace(item))
            {
                // Adăugăm elementul la lista de cumpărături
                var newItem = new ShoppingListItem(item, quantity);
                lstShoppingList.Items.Add($"{newItem.Name} ({newItem.Quantity})");
                shopList.Add(newItem);

                // Golește caseta de text pentru a permite utilizatorului să adauge un nou element
                txtItemName2.Clear();
                txtQuantity2.Clear();

            }
        }

        public static void button3_Click(object sender, EventArgs e, List<ShoppingListItem> shopList, ListBox lstShoppingList, TextBox txtItemName3, TextBox txtQuantity3)
        {
            // Citim textul introdus de utilizator
            string item = txtItemName3.Text;
            int quantity = Convert.ToInt32(txtQuantity3.Text);
            if (string.IsNullOrWhiteSpace(txtItemName3.Text))
            {
                MessageBox.Show("Numele produsului este obligatoriu!");
                return;
            }

            // Verificăm dacă cantitatea este un număr valid
            if (!int.TryParse(txtQuantity3.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Cantitatea trebuie să fie un număr întreg pozitiv!");
                return;
            }
            // Verificăm dacă textul este gol
            if (!string.IsNullOrWhiteSpace(item))
            {
                // Adăugăm elementul la lista de cumpărături
                var newItem = new ShoppingListItem(item, quantity);
                lstShoppingList.Items.Add($"{newItem.Name} ({newItem.Quantity})");
                shopList.Add(newItem);

                // Golește caseta de text pentru a permite utilizatorului să adauge un nou element
                txtItemName3.Clear();
                txtQuantity3.Clear();

            }
        }

        public static void button4_Click(object sender, EventArgs e, List<ShoppingListItem> shopList, ListBox lstShoppingList, TextBox txtItemName4, TextBox txtQuantity4)
        {
            // Citim textul introdus de utilizator
            string item = txtItemName4.Text;
            int quantity = Convert.ToInt32(txtQuantity4.Text);
            if (string.IsNullOrWhiteSpace(txtItemName4.Text))
            {
                MessageBox.Show("Numele produsului este obligatoriu!");
                return;
            }

            // Verificăm dacă cantitatea este un număr valid
            if (!int.TryParse(txtQuantity4.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Cantitatea trebuie să fie un număr întreg pozitiv!");
                return;
            }
            // Verificăm dacă textul este gol
            if (!string.IsNullOrWhiteSpace(item))
            {
                // Adăugăm elementul la lista de cumpărături
                var newItem = new ShoppingListItem(item, quantity);
                lstShoppingList.Items.Add($"{newItem.Name} ({newItem.Quantity})");
                shopList.Add(newItem);

                // Golește caseta de text pentru a permite utilizatorului să adauge un nou element
                txtItemName4.Clear();
                txtQuantity4.Clear();

            }
        }

        public static void button5_Click(object sender, EventArgs e, List<ShoppingListItem> shopList, ListBox lstShoppingList, TextBox txtItemName5, TextBox txtQuantity5)
        {
            // Citim textul introdus de utilizator
            string item = txtItemName5.Text;
            int quantity = Convert.ToInt32(txtQuantity5.Text);
            if (string.IsNullOrWhiteSpace(txtItemName5.Text))
            {
                MessageBox.Show("Numele produsului este obligatoriu!");
                return;
            }

            // Verificăm dacă cantitatea este un număr valid
            if (!int.TryParse(txtQuantity5.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Cantitatea trebuie să fie un număr întreg pozitiv!");
                return;
            }
            // Verificăm dacă textul este gol
            if (!string.IsNullOrWhiteSpace(item))
            {
                // Adăugăm elementul la lista de cumpărături
                var newItem = new ShoppingListItem(item, quantity);
                lstShoppingList.Items.Add($"{newItem.Name} ({newItem.Quantity})");
                shopList.Add(newItem);

                // Golește caseta de text pentru a permite utilizatorului să adauge un nou element
                txtItemName5.Clear();
                txtQuantity5.Clear();

            }
        }
    }
}