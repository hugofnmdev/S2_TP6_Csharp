using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace Factory06
{
    public class Factory
    {
        private long money;
        private int maxNbMachines = 50;
        private List <Machine> machines;

        public long Money => money;
        
        public Factory(long initialMoney)
        {
            money = initialMoney;
            machines = new List<Machine>();
        }

        // TODO
        /**
         * Return a list of all the machines of the corresponding type.
         * <param name="type">The type of machine to search for</param>
         */
        public List <Machine> GetMatchMachines(MachineType type)
        {
            throw new NotImplementedException("Fix me!");
        }

        // TODO
        /**
         * Returns a machine of the specified type which still has
         * some capacity left to produce an item.
         * <param name="type">The type of the machine to search for</param>
         */
        public Machine FindAvailableMachine(MachineType type)
        {
            throw new NotImplementedException("Fix me!");
        }

        // TODO
        /**
         * Build a new machine of the specified type if the factory
         * has enough money and places.
         * Returns true if built, false otherwise
         * <param name="type">The type of the machine to build</param>
         */
        public bool Build(MachineType type)
        {
            throw new NotImplementedException("Fix me!");
        }

        // TODO
        /**
         * Try to produce count items from machines of the specified type
         * in the factory.
         * Returns true if count items were produced, false otherwise.
         * <param name="type">The type of machine to search for</param>
         * <param name="count">The number of items to produce</param>
         */
        public bool Produce(MachineType type, int count)
        {
            throw new NotImplementedException("Fix me!");
        }

        // TODO
        /**
        * Upgrade all machine on the factory if enough money.
        * Returns true if all upgrade were done, false otherwise.
        */
        public bool UpgradeAll()
        {
            throw new NotImplementedException("Fix me!");
        }

        // TODO
        /**
        * Upgrade up to count machine on the factory of the specified type
        * and level if the factory has enough money.
        * Returns true if count upgrades were done, false otherwise
        * <param name="type">The type of the machines to upgrade</param>
        * <param name="level">The level of the machines to upgrade</param>
        * <param name="count">The number of machine to upgrade</param>
         */
        public bool UpgradeMatch(MachineType type, int level, int count)
        {
            throw new NotImplementedException("Fix me!");
        }

        // TODO
        /**
         * Destroy all the machines in the factory.
         * Returns the total money gained, and also updates the factory's money.
         */
        public uint DestroyAll()
        {
            throw new NotImplementedException("Fix me!");;
        }

        // TODO
        /**
         * Destroy all the machines in the factory of the specified type.
         * Returns the total money gained, and also updates the factory's money.
         * <param name="type">The type of machine to destroy</param>
         */
        public uint DestroyMatch(MachineType type)
        {
            throw new NotImplementedException("Fix me!");
        }

        // TODO
        /**
         * Collect all the items on the factory.
         */
        public List <Item> CollectAll()
        {
            throw new NotImplementedException("Fix me!");
        }

        // TODO
        /**
         * Collect all the items on the factory from the machine of the
         * corresponding type.
         * <param name="type">The type of machine to collect from</param>
         */
        public List <Item> CollectMatch(MachineType type)
        {
            throw new NotImplementedException("Fix me!");
        }

        // TODO
        /**
         * Sell all the machines' items on the factory.
         * Returns the total money gained, and updates the factory's money.
         */
        public uint SellAll()
        {
            throw new NotImplementedException("Fix me!");
        }

        // TODO
        /**
         * Sell all the items on the factory from the machine of the
         * corresponding type.
         * <param name="type">The type of machine to sell items</param>
         */
        public uint SellMatch(MachineType type)
        {
            throw new NotImplementedException("Fix me!");
        }

        // TODO
        /**
         * Clear all machines items on the factory.
         */
        public void ClearAll()
        {
            throw new NotImplementedException("Fix me!");
        }

        // TODO
        /**
         * Clear the items on the factory from the machine of the
         * corresponding type.
         * <param name="type">The type of machine to clear items</param>
         */
        public void ClearMatch(MachineType type)
        {
            throw new NotImplementedException("Fix me!");
        }
    }
}