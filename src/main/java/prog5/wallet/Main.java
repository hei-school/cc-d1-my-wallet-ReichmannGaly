package prog5.wallet;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
        public static void main(String[] args) {
            double initialBalance = 0.0;
            List<String> initialTransactions = new ArrayList<>();

            Wallet wallet = new Wallet(initialBalance, initialTransactions);
            Scanner scanner = new Scanner(System.in);

            while (true) {
                System.out.println("\n1. Deposit\n2. Withdraw\n3. View Balance\n4. View Transactions\n5. Logout\n");
                System.out.println("Please choose an option: ");
                int choice = scanner.nextInt();

                switch (choice) {
                    case 1 -> {
                        System.out.print("\nEnter deposit amount: ");
                        double depositAmount = scanner.nextDouble();
                        wallet.deposit(depositAmount);
                    }
                    case 2 -> {
                        System.out.print("\nEnter withdrawal amount: ");
                        double withdrawalAmount = scanner.nextDouble();
                        wallet.withdraw(withdrawalAmount);
                    }
                    case 3 -> System.out.println("\nBalance: " + wallet.getBalance());
                    case 4 -> System.out.println("\nTransactions: " + wallet.getTransactions());
                    case 5 ->  System.exit(0);
                    default -> System.out.println("\nInvalid choice!");
                }
            }
    }
}