import java.util.*;

public class JavaLoopsII {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int t = input.nextInt();
        for (int i = 0; i < t; i++) {
            int a = input.nextInt();
            int b = input.nextInt();
            int n = input.nextInt();
            for (int j = 0; j < n; j++) {
                a += b;
                if (j > 0)
                    System.out.print(" ");

                System.out.print(a);
                b *= 2;
            }
            System.out.println();
        }

    }
}
