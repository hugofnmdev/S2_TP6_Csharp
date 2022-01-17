using System;
using System.Collections.Generic;

namespace Factory06
{
    public class Hat : Machine
    {
        private readonly uint [] upgrades = { 200, 300, 400 };
        private readonly int maxLevel = 4;

        public Hat()
        {
            items = new List<Item>();
            type = MachineType.Hat;
            level = 1;
            capacity = 300;
        }

        public override bool Upgrade(ref long money)
        {
            if (money<upgrades[level-1] && level<maxLevel)
            {
                money -= upgrades[level - 1];
                level += 1;
                capacity *= 2;
                return true;
            }

            return false;
        }

        public override bool Produce(uint count, ref long money)
        {
            uint total = (uint)MachinePrice.Hat*count;
            if (total>money || count<=0)
            {
                return false;
            }
            while (count!=0)
            {
                items.Add(new Item(ItemType.Hat));
                count -= 1;
            }
            money -= total;
            return true;
        }

        public override void Clear()
        {
            items.Clear();
        }

        public override uint Destroy()
        {
            Clear();
            return (uint)MachinePrice.Hat / 3;

        }
    }
}