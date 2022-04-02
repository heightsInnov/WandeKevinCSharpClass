public class AccountCreationImpl : AccountCreation
{
    public bool checkForDuplicateCustomer(Customer customer)
    {
        throw new System.NotImplementedException();
    }

    public void createCustomer(Customer customer)
    {
        throw new System.NotImplementedException();
    }

    public string getCustomerDetails(Customer customer)
    {
        Customer newCustomer = new Customer();
        if (string.IsNullOrEmpty(customer.bvn))
        {
            return "Customer bvn is required and cannot be empty";
        }
        if (string.IsNullOrEmpty(customer.firstname))
        {
            return "Customer firstname is required and cannot be empty";
        }
        if (string.IsNullOrEmpty(customer.lastname))
        {
            return "Customer lastname is required and cannot be empty";
        }
        if (customer.dob.AddYears(18) > System.DateTime.Now)
        {
            return "Customer must be 18 years and above";
        }
        if (customer.phoneno.Length < 11 || customer.phoneno.Length > 14)
        {
            return "Customer phone number ";
        }

    }

    public void sendCustomerDetailsByEmail(string accountNumber, string email, string phoneNumber)
    {
        throw new System.NotImplementedException();
    }

    public bool verifyCustomerBvn(string bvn)
    {
        throw new System.NotImplementedException();
    }
}