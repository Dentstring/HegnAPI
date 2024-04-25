using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace HegnTilbudApi.Model
{
    public class RaftHegn
    {
        private const decimal unitPrice = 386.00m; 
        private const int minimumOrderQuantity = 25; 

        public string Description { get; private set; }
        public int Quantity { get; private set; }
        public string Unit { get; private set; } 
        public decimal Price { get; private set; }

        public RaftHegn(string description, int quantity)
        {
            if (quantity % minimumOrderQuantity != 0)
            {
                throw new ArgumentException("Quantity must be in multiples of 25.");
            }

            Description = description;
            Quantity = quantity;
            Unit = "stk."; // Assuming 'stk.' is the unit for RaftHegn
            Price = CalculatePrice(quantity);
        }

        private static decimal CalculatePrice(int quantity)
        {
            return (quantity / minimumOrderQuantity) * unitPrice;
        }

    }
}
