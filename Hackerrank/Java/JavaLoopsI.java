import java.util.*;

/**
 * JavaLoopsI
 */
public class JavaLoopsI {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int intInput = input.nextInt();
        for (int i = 1; i <= 10; i++) {
            System.out.println(intInput + " x " + i + " = " + intInput * i);
        }
    }
}