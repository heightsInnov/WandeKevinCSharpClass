using System;

namespace WandeKevin
{
    public class BankingOperations
    {
        public static void Main()
        {
            ResponseModel response = new ResponseModel("99", "Error encountered");
            DateTime.Parse("1994-4-3");
            Customer customer = new("Oluwasegun", "Akinjewe", DateTime.Parse("1994-4-3"), Gender.FEMALE, "07037993372", "282C Ikoyi Agbede, Lagos",
                AccountType.Current, "227743661", "a.kevin@l.com");

            AccountCreationImpl accountCreation = new AccountCreationImpl();

            Customer customerValidated = (Customer)accountCreation.getCustomerDetails(customer).Data;
            if (accountCreation.verifyCustomerBvn(customerValidated.bvn))
            {
                if (!accountCreation.checkForDuplicateCustomer(customerValidated))
                {
                    response = accountCreation.createCustomer(customerValidated);
                }
            }
            Console.WriteLine(response.ToString());
        }
    }
}
