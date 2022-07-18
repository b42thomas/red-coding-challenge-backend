using System;
using System.Collections.Generic;

namespace API.Interfaces
{
    public interface IDataProvider
    {
        public IEnumerable<Projections.Order> GetData();

        public Projections.Order FindData(Guid id);

        public Projections.Order CreateOrder(string customerName, int orderType, string createdByUserName); // fill in inputs

        public void DeleteData(Guid id);
    }
}