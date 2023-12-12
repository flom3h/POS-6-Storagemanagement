using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console
{
    internal class Part
    {
        #region fieldvar
        private int id;
        private int maxQuantity;
        private string name;
        private double pricePerPiece;
        private int quantity;
        #endregion

        #region Eigenschaften
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int MaxQuantity
        {
            get { return maxQuantity; }
            set { maxQuantity = value; }
        }

        public double PricePerPiece
        {
            get { return pricePerPiece; }
            set { pricePerPiece = value; }
        }
        #endregion

        #region Const
        public Part(int id, string name, double pricePerPiece)
        {
            this.Id = id;
            this.Name = name;
            PricePerPiece = pricePerPiece;

        }
        public Part(int id, string name, double pricePerPiece, int quanitity, int maxQuantity)
        {
            this.Id = id;
            Name = name;
            PricePerPiece = pricePerPiece;
            Quantity = quanitity;
            MaxQuantity = maxQuantity;
        }
        #endregion

        #region methods
        public int RemoveParts(int amount)
        {
            if (Quantity - amount < 0)
            {
                Console.WriteLine($"[{Name}] Error: Can not remove {amount}parts, only {Quantity} available.");
                return 0;
            }
            else
            {
                Quantity -= amount;
                Console.WriteLine($"[{Name}] Removed: {amount} parts.");
                return amount;
            }
        }

        public void SetMaxQuantity(int newMaxQuantity)
        {

            if (Quantity > newMaxQuantity)
            {
                throw new Exception($"[{Name}] Error: Storage limit reached.");
            }

            else
            {
                MaxQuantity = newMaxQuantity;
                Console.WriteLine($"[{Name}] Max quantity set to {newMaxQuantity}");
            }
        }

        public void AddParts(int amount)
        {
            if (Quantity + amount > MaxQuantity)
            {
                int amountToAdd = MaxQuantity - Quantity;
                Quantity += amountToAdd;
                Console.WriteLine($"[{Name}] Error: Storage limit reached. Added only {amountToAdd} of {amount} parts.");
            }
            else
            {
                Quantity += amount;
                Console.WriteLine($"[{Name}] Added: {amount} parts");
            }
        }

        public int GetMaxQuantity()
        {
            return Quantity;
        }

        public double GetPrice()
        {
            return quantity * pricePerPiece;
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"=============== PART: {Id} =============== \r\n" +
                $" Name: {Name}, Value: {PricePerPiece} \r\n" +
                $" Storage: {Quantity}/{MaxQuantity} \r\n" +
                $" ======================================= \r\n";
        }
        #endregion
    }
}
