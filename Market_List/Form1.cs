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
using static App_Market_List.FileHandler;
using static App_Market_List.Sort;
using static App_Market_List.AddProduct;
using static App_Market_List.DeleteBtns;
using static App_Market_List.SearchBox;
namespace App_Market_List
{
    public partial class Form1 : Form
    {
        public List<ShoppingListItem> shopList = new List<ShoppingListItem>();

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
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        
        // Add Product Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct.button1_Click(sender, e, shopList, lstShoppingList, txtItemName1, txtQuantity1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddProduct.button2_Click(sender, e, shopList, lstShoppingList, txtItemName2, txtQuantity2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AddProduct.button3_Click(sender, e, shopList, lstShoppingList, txtItemName3, txtQuantity3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AddProduct.button4_Click(sender, e, shopList, lstShoppingList, txtItemName4, txtQuantity4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            AddProduct.button5_Click(sender, e, shopList, lstShoppingList, txtItemName5, txtQuantity5);
        }


        // Delete and Exit Buttons 
        private void buttonDel6_Click(object sender, EventArgs e)
        {
            DeleteBtns.buttonDel6_Click(sender, e, shopList, lstShoppingList);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            DeleteBtns.buttonDeleteAll_Click(sender, e, shopList, lstShoppingList);
        }

        // Search Box Button
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            SearchBox.searchBox_TextChanged(sender, e, shopList, lstShoppingList, searchBox);
        }


        // Sort Buttons
        private void buttonAlfSort_Click(object sender, EventArgs e)
        {
            Sort.buttonAlfSort_Click(sender, e, shopList, lstShoppingList);
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            Sort.buttonSort_Click(sender, e, shopList, lstShoppingList);
        }
        private void btnSortByQuantity_Click(object sender, EventArgs e)
        {
            Sort.btnSortByQuantity_Click(sender, e, shopList, lstShoppingList);
        }
        


        // Save + Load Buttons
        private void btnSave_Click(object sender, EventArgs e)
        {
            FileHandler.btnSave_Click(sender, e, shopList, lstShoppingList);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FileHandler.btnLoad_Click(sender, e, shopList, lstShoppingList);
        }
        
    }
}
