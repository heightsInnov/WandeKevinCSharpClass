public class Bank{
    public string bankName {get; set;}
    public string hqAddress {get; set;}
    public string bankAccronym {get; set;}
    public string logoLink {get; set;}
    public int hqSortCode {get; set;}
    public string swiftCode {get; set;}

    public string[] bankBranches {get; set;}

    public BankBranch createNewBranch(BankBranch newBranch){
        //Do feasibility study on the area
        //Get a land in the area
        //Get CBN authorization
        //Build a branch --->
        //Populate the branch with staff and ammenities
        return newBranch;
    }

}