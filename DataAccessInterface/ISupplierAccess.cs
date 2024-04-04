using DataObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessInterface
{
    public interface ISupplierAccess
    {
        List<SupplierVM> GetSuppliers();

        SupplierVM GetSupplierById(int id);

        bool AddSupplier(SupplierVM supplier);

        bool UpdateSupplier(SupplierVM supplier);

        bool DeleteSupplier(SupplierVM supplier);


    }
}
