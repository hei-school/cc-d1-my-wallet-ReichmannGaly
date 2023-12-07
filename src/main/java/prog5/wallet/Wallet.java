package prog5.wallet;

import java.util.List;

public class Wallet {
    private double balance;
    private List<String> transactions;

    public Wallet(double balance, List<String> transactions) {
        this.balance = balance;
        this.transactions = transactions;
    }

    public double getBalance() {
        return balance;
    }

    public void setBalance(double balance) {
        this.balance = balance;
    }

    public List<String> getTransactions() {
        return transactions;
    }

    public void deposit(double amount){
        if (amount > 0){
            setBalance(balance + amount);
            transactions.add("Deposit: +" + amount);
            System.out.println("\nSuccessful withdrawal");
        } else {
            System.out.println("\nPlease enter a valid amount!");
        }
    }

    public void withdraw(double amount){
        if (balance >= amount){
            setBalance(balance - amount);
            transactions.add("Withdrawal: -" + amount);
        } else {
            System.out.println("\nInsufficient funds!");
        }
    }
}
