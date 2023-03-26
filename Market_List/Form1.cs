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

namespace App_Market_List
{
    public partial class Form1 : Form
    {
        private List<ShoppingListItem> shopList = new List<ShoppingListItem>();

        public Form1()
        {
            InitializeComponent();
            // Afisati lista de cumparaturi in controlul ListBox
            lstShoppingList.SelectedIndex = -1;
            buttonDel6.Click += new EventHandler(buttonDel6_Click);
            buttonDeleteAll.Click += new EventHandler(buttonDeleteAll_Click);
            btnSave.Click += new EventHandler(btnSave_Click);
            // Afisam un mesaj informativ pentru utilizatori
            MessageBox.Show("OBSERVATII:\n\nPentru a adauga un produs, scrieti in caseta din dreapta lui cantitatea (numar intreg)\n\nProdusele dorite pot fi modificate (scrieti in caseta alt produs)\n\nPentru a sterge un produs, selectati-l din lista de cumparaturi si apasati butonul Delete Product\n\nListele deja salvate si incarcate in aplicatie nu pot fi modificate\n\nEnjoy!");
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
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
        private void buttonDel6_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
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
   
        public class ShoppingListItemAlphabeticalComparer : IComparer<ShoppingListItem>
        {
            public int Compare(ShoppingListItem x, ShoppingListItem y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        private void buttonAlfSort_Click(object sender, EventArgs e)
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

        private void buttonSort_Click(object sender, EventArgs e)
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

        public class ShoppingListItem
        {
            public string Name { get; set; }
            public decimal Quantity { get; set; }
            public ShoppingListItem(string name, int quantity)
            {
                Name = name;
                Quantity = quantity;
               
            }
            public override string ToString()
            {
                return $"{Name} ({Quantity})";
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            lstShoppingList.Items.Clear();
            shopList.Clear();
        }

        private void btnSortByQuantity_Click(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
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
        private void btnLoad_Click(object sender, EventArgs e)
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
