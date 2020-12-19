import java.util.Scanner;

public class JavaStdinandStdoutII {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int IntValue = input.nextInt();
        double dblValue = input.nextDouble();

        input.nextLine();
        String strValue = input.nextLine();

        System.out.println("String: "+strValue + "\nDouble: " + dblValue + "\nInt: " + IntValue);

    }
}
