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
    public string accountType { get; set; }
    public string state { get; set; }
    public string country { get; set; }
    public string bvn { get; set; }
    public string email { get; set; }

}