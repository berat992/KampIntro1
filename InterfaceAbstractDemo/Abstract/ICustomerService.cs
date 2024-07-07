using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
        // müşteri işlemleri için ortak bir standart
    {
        public void Save(Customer customer); // Müşteri kaydetme
        // Bu operasyon nero ve starbucks da ortak var
        // Ancak içi farklı kodlar vs. Bu yüzden interface kullanırız
        
    }
}
