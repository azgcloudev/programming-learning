public class Challange1 {

    public static void main(String[] args) {
        double num1 = 20.00;
        double num2 = 80.00;
        double num3 = (num1 + num2) * 100.00;
        double numRemainder = num3 % 40.00;
        boolean bool1 = numRemainder == 0 ? true : false;

        System.out.print("The boolean result is: " + bool1 + "\n");

        if (!bool1) {
            System.out.println("Got some remainder");
        }
    }
}
