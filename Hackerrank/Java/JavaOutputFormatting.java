import java.util.Scanner;

/**
 * 4_JavaOutputFormatting
 */
public class JavaOutputFormatting {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.println("================================");
        for (int i = 0; i < 3; i++) {
            String strinput = input.next();
            int intinput = input.nextInt();
            System.out.printf("%-15s%03d%n", strinput, intinput);
        }
        System.out.println("================================");
        
    }
}