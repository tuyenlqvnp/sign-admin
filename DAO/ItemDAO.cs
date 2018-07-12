using System;
using signadmin.Models;
using System.Collections.Generic;


namespace signadmin.DAO
{
    public class ItemDAO
    {
        private AppDbContext _appDbContext;

        public struct Filter {
            public int IdCompany;
        }

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

        public List<Item> GetList(Filter filter, int page, int pageSize) {
            List<Item> list = new List<Item>();
            if (pageSize == 0) {
                pageSize = Constants.PAGE_SIZE;
            }
            return list;
        }
        
    }
}