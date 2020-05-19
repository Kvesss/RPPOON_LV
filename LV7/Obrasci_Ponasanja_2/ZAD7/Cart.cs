using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD7
{
    class Cart : IItem
    {
        private List<IItem> items;

        public Cart()
        {
            items = new List<IItem>();
        }
        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
            }
        }

        public IItem GetItemAt(int index)
        {
            return items[index];
        }

        public double Accept(IVisitor visitor)
        {
            double sum = 0;
            foreach(IItem item in items)
            {
                sum += item.Accept(visitor);
            }
            return sum;
        }
    }
}
