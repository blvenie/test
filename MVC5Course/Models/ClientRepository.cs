using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Course.Models
{   
	public  class ClientRepository : EFRepository<Client>, IClientRepository
	{
        public override IQueryable<Client> All()
        {
            return base.All().Where(p => p.Gender == "M");
        }
        public Client find(int id)
        {
            return this.All().FirstOrDefault(p => p.IsDelete == true);
        }
        //public void Delete()
        //{
        //    var db =  (FabricsEntities)this.UnitOfWork.Context;
        //    foreach(var item in db.Order.ToList())
        //    {
        //        db.OrderLine.RemoveRange(item.OrderLine);
        //    }
        //    db.Order.RemoveRange(db.Order);

        //}
	}

	public  interface IClientRepository : IRepository<Client>
	{

	}
}