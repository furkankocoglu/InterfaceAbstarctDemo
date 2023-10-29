using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Abstract
{
    internal interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
