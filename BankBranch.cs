public class BankBranch : Bank {

    public string branchName {get; set;}
    public string branchAddress {get; set;}
    public decimal ledgerBalance {get; set;} = 0;
    public int staffStrength {get; set;}
    public int branchSortCode {get; set;}

    void closeBranch(){
    }

    void disableBranch(){ 
    }

    public override string ToString(){
        return "Bank name: "+ bankName
                + "\n Bank Address: "+ hqAddress
                + "\n Branch Name: " + branchName
                + "\n Branch Sort Code: " + branchSortCode
                + "\n Branch Balance: " + ledgerBalance;

    }
}