public interface AccountCreation{
    public void getCustomerDetails();
    public bool verifyCustomerBvn();
    public bool checkForDuplicateCustomer();
    public void createCustomer();
    public void sendCustomerDetailsByEmail();
}