import java.util.*;

public class JavaEnd_of_file {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int line_nubmer = 1;
        while (scanner.hasNext()) {
            System.out.println(line_nubmer + " " + scanner.nextLine());
            line_nubmer++;

        }
        scanner.close();
    }
}
