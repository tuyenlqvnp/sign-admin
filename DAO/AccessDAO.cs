using System;
using signadmin.Models;
using System.Collections.Generic;
using System.Linq;

namespace signadmin.DAO
{
    public struct FilterCriterio
    {
        public string Url;
        public string Description;
    }

    public class AccessDAO
    {
        private AppDbContext _appDbContext;
        public AccessDAO(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public Access Add(Access item)
        {
            _appDbContext.Access.Add(item);
            _appDbContext.SaveChanges();
            return item;
        }

        public Access Update(Access item)
        {
            _appDbContext.Access.Update(item);
            _appDbContext.SaveChanges();
            return item;
        }

        public bool Delete(Access item)
        {
            try
            {
                _appDbContext.Access.Remove(item);
                _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public List<Access> GetList(AccessFilterCriterio filter, int page, int pageSize)
        {
            List<Access> list = new List<Access>();
            if (pageSize == 0)
            {
                pageSize = Constants.PAGE_SIZE;
            }

            IQueryable<Access> query = _appDbContext.Access;
            if (filter.Id != 0)
            {
                query.Where(m => m.Id == filter.Id);
            }
            if (filter.Url != "")
            {
                query.Where(m => m.Url == filter.Url);
            }
            if (filter.Description != "")
            {
                query.Where(m => m.Url.Contains(filter.Url));
            }
            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            list = query.ToList();
            return list;
        }

        public Access GetById(int id)
        {
            AccessFilterCriterio filter = new AccessFilterCriterio();
            filter.Id = id;
            List<Access> items = this.GetList(filter, 0, 1);
            if (items.Count > 0)
                return items[0];
            return null;
        }
    }
}
