using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    internal class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService checkCustomerService;

        public StarbucksCustomerManager(ICustomerCheckService checkCustomerService)
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
