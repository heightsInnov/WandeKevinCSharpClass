using System.Collections.Generic;
using WandeKevin;

public interface AccountCreation{
    public ResponseModel getCustomerDetails(Customer customer);
    public bool verifyCustomerBvn(string bvn);
    public bool checkForDuplicateCustomer(Customer customer);
    public ResponseModel createCustomer(Customer customer);
    public void sendCustomerDetailsByEmail(string accountNumber, string email, string phoneNumber);
}

//Readup SOLID Principle