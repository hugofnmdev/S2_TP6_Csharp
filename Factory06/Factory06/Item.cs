using System;

namespace Factory06
{
    public class Item
    {
        private readonly uint price;
        private ItemType type;

        public uint Price => price;
        public ItemType Type => type;
        
        public Item(ItemType type)
        {
            this.type = type;
            this.price = (uint)type;
        }

        // TODO
        /**
         * Sell the item.
         * A hat is worth 3 times its price.
         * A coat is worth 4 times its price.
         * A flask is worth 6 times its price.
         */
        public uint Sell()
        {
            if (Type == ItemType.Hat)
                return (price * 3);
            if (Type == ItemType.Coat)
                return (price * 4);
            else
                return (price * 6);
        }
    }
}