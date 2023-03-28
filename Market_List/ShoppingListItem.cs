using System;

namespace MyShoppingList
{
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
}