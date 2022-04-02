using System;
using System.ComponentModel.DataAnnotations;
using WandeKevin;

public class Customer
{
    public string firstname { get; set; }
    public string middlename { get; set; }
    public string lastname { get; set; }
    public DateTime dob { get; set; }
    public int age { get; set; }
    public Gender gender { get; set; }
    public string phoneno { get; set; }
    public string address { get; set; }
    public AccountType accountType { get; set; }
    public string state { get; set; }
    public string country { get; set; }
    public string bvn { get; set; }
    public string email { get; set; }

    public Customer()
    {

    }

    public Customer(string firstname, string lastname, DateTime dob, Gender gender, string phoneno, string address, AccountType accountType,
        string bvn, string email)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.dob = dob;
        this.gender = gender;
        this.phoneno = phoneno;
        this.address = address;
        this.accountType = accountType;
        this.bvn = bvn;
        this.email = email;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}