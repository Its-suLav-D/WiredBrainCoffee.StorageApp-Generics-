using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class ListRepository<T> where T:class, IEntity, new()
    {

        private readonly List<T> _items = new(); 
        public void Add(T item)
        {
            _items.Add(item);
        }

        public T CreateItem()
        {
            return new T();
        }

        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }
        public void Remove(T item)
        {
            item.Id = _items.Any() ? _items.Max(item => item.Id) +1: 1;
            _items.Remove(item);
        }
        public void Save()
        {
            foreach (T item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }

}
