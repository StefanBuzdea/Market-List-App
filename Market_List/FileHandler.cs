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
	public static class FileHandler
	{
        public static void btnSave_Click(object sender, EventArgs e, List<ShoppingListItem> shopList, ListBox lstShoppingList)
        {
            if (shopList.Count > 0)
            {
                // Deschide o casetă de dialog pentru a permite utilizatorului să selecteze locația de salvare a fișierului
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.Title = "Save Shopping List";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Salvam lista de cumparaturi in fisier
                    string filename = saveFileDialog.FileName;

                    try
                    {
                        using (StreamWriter writer = new StreamWriter(filename))
                        {
                            foreach (ShoppingListItem item in shopList)
                            {
                                writer.WriteLine($"{item.Name},{item.Quantity.ToString("N0")}");
                            }
                        }

                        MessageBox.Show("Lista de cumpărături a fost salvată cu succes!", "Salvare reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"A apărut o eroare la salvarea fișierului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lista de cumpărături este goală!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void btnLoad_Click(object sender, EventArgs e, List<ShoppingListItem> shopList, ListBox lstShoppingList)
        {
            // Deschide o casetă de dialog pentru a permite utilizatorului să selecteze fișierul de încărcat
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog.Title = "Load Shopping List";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Incarcam lista de cumparaturi din fisier
                string filename = openFileDialog.FileName;
                using (StreamReader reader = new StreamReader(filename))
                {
                    shopList.Clear();
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');
                        string name = values[0];
                        int quantity = int.Parse(values[1]);
                        ShoppingListItem item = new ShoppingListItem(name, quantity);
                        shopList.Add(item);
                    }
                }

                // Actualizeaza ListBox-ul cu lista de cumparaturi
                lstShoppingList.DataSource = null;
                lstShoppingList.DataSource = shopList;
            }

        }
    }
}