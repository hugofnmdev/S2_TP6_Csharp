using System;
using System.Collections.Generic;

namespace Factory06
{
    public class Coat : Machine
    {
        private readonly uint [] upgrades = { 200, 500 };
        private readonly int maxLevel = 3;
        
        public Coat()
        {
            items = new List<Item>();
            type = MachineType.Coat;
            level = 1;
            capacity = 30;
        }
        
        public override bool Upgrade(ref long money)
        {
            if (level == 1)
            {
                capacity += 10;
                money -= upgrades[level - 1];
                level += 1;
                return true;
            }
            
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
            uint total = (uint)MachinePrice.Coat * count;
            if (total>money || count<=0)
            {
                return false;
            }
            while (count!=0)
            {
                items.Add(new Item(ItemType.Coat));
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
            return (uint)MachinePrice.Coat / 3;
        }
    }
}