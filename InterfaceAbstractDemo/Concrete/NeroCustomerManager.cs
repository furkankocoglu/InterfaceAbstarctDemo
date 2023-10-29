using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    internal class NeroCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService checkCustomerService;

        public NeroCustomerManager(ICustomerCheckService checkCustomerService)
        {
            this.checkCustomerService = checkCustomerService;
        }

        public override void Save(Customer customer)
        {
            if (checkCustomerService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
