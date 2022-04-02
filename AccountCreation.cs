public interface AccountCreation{
    public string getCustomerDetails(Customer customer);
    public bool verifyCustomerBvn(string bvn);
    public bool checkForDuplicateCustomer(Customer customer);
    public void createCustomer(Customer customer);
    public void sendCustomerDetailsByEmail(string accountNumber, string email, string phoneNumber);
}

//Readup SOLID Principle