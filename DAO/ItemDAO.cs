using System;
using signadmin.Models;
using System.Collections.Generic;
using System.Linq;

namespace signadmin.DAO
{
    public class ItemDAO
    {
        private AppDbContext _appDbContext;

        public ItemDAO(AppDbContext appDbContext) {
            this._appDbContext = appDbContext;
        }

        public Item Add(Item item) {
            _appDbContext.Item.Add(item);
            _appDbContext.SaveChanges();
            return item;
        }

        public Item Update(Item item)
        {
            _appDbContext.Item.Update(item);
            _appDbContext.SaveChanges();
            return item;
        }

        public bool Delete(Item item)
        {
            try
            {
                _appDbContext.Item.Remove(item);
                _appDbContext.SaveChanges();
                return true;
            } catch(Exception ex) {
                Console.WriteLine(ex);
                return false;
            }
        }

        public List<Item> GetList(ItemFilterCriterio filter, int page, int pageSize)
        {
            List<Item> list = new List<Item>();
            if (pageSize == 0)
            {
                pageSize = Constants.PAGE_SIZE;
            }

            IQueryable<Item> query = _appDbContext.Item;
            if (filter.Id != 0)
            {
                query.Where(m => m.Id == filter.Id);
            }
            if (filter.IdCompany != "")
            {
                query.Where(m => m.Id_company == filter.IdCompany);
            }
            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            list = query.ToList();
            return list;
        }

        public Item GetById(int id)
        {
            ItemFilterCriterio filter = new ItemFilterCriterio();
            filter.Id = id;
            List<Item> items = this.GetList(filter, 0, 1);
            if (items.Count > 0)
                return items[0];
            return null;
        }
        
    }
}