using System;
using System.Collections.Generic;

namespace Factory06
{
    public class Flask : Machine
    {
        private readonly uint [] upgrades = { 300 };
        private readonly int maxLevel = 2;
        
        public Flask()
        {
            items = new List<Item>();
            type = MachineType.Flask;
            level = 1;
            capacity = 20;
        }
        
        public override bool Upgrade(ref long money)
        {
            if (level == 1)
            {
                capacity += 4;
                money -= upgrades[level - 1];
                level += 1;
                return true;
            }

            return false;
        }
        
        public override bool Produce(uint count, ref long money)
        {
            uint total = (uint)MachinePrice.Flask * count;
            if (total>money || count<=0)
            {
                return false;
            }
            while (count!=0)
            {
                items.Add(new Item(ItemType.Flask));
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
            return (uint)MachinePrice.Flask / 3;
        }
    }
}