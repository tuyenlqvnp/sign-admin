using System;
using signadmin.Models;
using System.Collections.Generic;
using System.Linq;

namespace signadmin.DAO
{   
    public class AccessDetailDAO
    {
  //      private AppDbContext _appDbContext;
		//public AccessDetailDAO(AppDbContext appDbContext)
  //      {
  //          this._appDbContext = appDbContext;
  //      }

		//public AccessDetail Add(AccessDetail item) 
  //      {
		//	_appDbContext.AccessDetail.Add(item);
  //          _appDbContext.SaveChanges();
  //          return item;
  //      }

		//public AccessDetail Update(AccessDetail item)
  //      {
		//	_appDbContext.AccessDetail.Update(item);
  //          _appDbContext.SaveChanges();
  //          return item;
  //      }

		//public bool Delete(AccessDetail item)
  //      {
  //          try
  //          {
		//		_appDbContext.AccessDetail.Remove(item);
  //              _appDbContext.SaveChanges();
  //              return true;
  //          }
  //          catch (Exception ex)
  //          {
  //              Console.WriteLine(ex);
  //              return false;
  //          }
  //      }

		//public List<AccessDetail> GetList(AccessDetailFilterCriterio filter, int page, int pageSize)
   //     {
			//List<AccessDetail> list = new List<AccessDetail>();
   //         if (pageSize == 0)
   //         {
   //             pageSize = Constants.PAGE_SIZE;
   //         }

			//IQueryable<AccessDetail> query = _appDbContext.AccessDetail;
    //        if (filter.Id != 0)
    //        {
    //            query.Where(m => m.Id == filter.Id);
    //        }
    //        if (filter.IdAccount != 0)
    //        {
				//query.Where(m => m.Id_account == filter.IdAccount);
    //        }
    //        if (filter.IdAccess != 0)
    //        {
				//query.Where(m => m.Id_access == (filter.IdAccess));
    //        }
    //        query = query.Skip((page - 1) * pageSize).Take(pageSize);
    //        list = query.ToList();
    //        return list;
    //    }

    //    public AccessDetail GetById(int id)
    //    {
    //        AccessDetailFilterCriterio filter = new AccessDetailFilterCriterio();
    //        filter.Id = id;
    //        List<AccessDetail> items = this.GetList(filter, 0, 1);
    //        if (items.Count > 0)
    //        {
    //            return items[0];
    //        }
    //        return null;
    //    }
    }
}
