using System;
using System.Collections.Generic;
using WandeKevin;

public class AccountCreationImpl : AccountCreation
{
    List<Customer> customers = new List<Customer>();
    public bool checkForDuplicateCustomer(Customer customer)
    {
        foreach(Customer cust in customers)
        {
            if (customer.Equals(cust))
            {
                return true;
            }
        }
        return false;
    }

    public ResponseModel createCustomer(Customer customer)
    {
        customers.Add(customer);
        ResponseModel response = new ResponseModel("00", "User successfully created");
        response.Data = customers;
        return response;
    }

    public ResponseModel getCustomerDetails(Customer customer)
    {
        ResponseModel response = new("99", "Error getting Customer Details");

        if (string.IsNullOrEmpty(customer.bvn))
        {
            response.Message = "Customer bvn is required and cannot be empty";
            return response;
        }
        if (string.IsNullOrEmpty(customer.firstname))
        {
            response.Message = "Customer firstname is required and cannot be empty";
            return response;
        }
        if (string.IsNullOrEmpty(customer.lastname))
        {
            response.Message = "Customer lastname is required and cannot be empty";
            return response;
        }
        if (customer.dob.AddYears(18) > System.DateTime.Now)
        {
            response.Message = "Customer must be 18 years and above";
            return response;
        }
        if (customer.phoneno.Length < 11 || customer.phoneno.Length > 14)
        {
            response.Message = "Customer phone number is required and cannot be less than 11, neither can it be greater than 14";
        }
        if (string.IsNullOrEmpty(customer.address))
        {
            response.Message = "Customer address is required";
            return response;
        }
        if (string.IsNullOrEmpty(customer.bvn) || customer.bvn.Length != 11)
        {
            response.Message = "Customer bvn cannot be empty and must be exactly 11 digits";
            return response;
        }
        if (string.IsNullOrEmpty(customer.email) || !UtilHelper.IsValidEmail(customer.email))
        {
            response.Message = "Customer email is not a valid email";
            return response;
        }

        Customer newCustomer = new(customer.firstname, customer.lastname, customer.dob, customer.gender, customer.phoneno, customer.address, customer.accountType,
        customer.bvn, customer.email);
        newCustomer.middlename = string.IsNullOrEmpty(customer.middlename) ? "" : customer.middlename;
        newCustomer.age = DateTime.Now.Year - customer.dob.Year;
        newCustomer.country = string.IsNullOrEmpty(customer.country) ? "" : customer.country;
        newCustomer.state = string.IsNullOrEmpty(customer.state) ? "" : customer.state;

        response.Code = "00";
        response.Message = "Customer details successfull validated and recorded";
        response.Data = newCustomer;
        return response;
    }

    public void sendCustomerDetailsByEmail(string accountNumber, string email, string phoneNumber)
    {
        Console.WriteLine("Your new account number is " + accountNumber);
    }

    public bool verifyCustomerBvn(string bvn)
    {
        return UtilHelper.IsValidBvn(bvn);
    }
}