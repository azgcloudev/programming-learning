public class FirstClass {

    public static void main(String[] args) {
        System.out.print("Hello Aldair!\n");
        System.out.print("Hello world\n");

        // if statement
        boolean isAlien = false;
        if (!isAlien) {
            System.out.print("Is not an Alien!.\n");
        }

        // AND operator
        int topScore = 80;
        int secondTopScore = 60;
        if (topScore > secondTopScore && topScore < 100) {
            System.out.print("Greater than second top score and less than 100\n");
        }

        // OR operator
        if ((topScore > 90) || (secondTopScore <= 90)) {
            System.out.print("Either or both of the conditions are true\n");
        }

        // TERNARY OPERATOR
        // syntax
        // operand1 ? operand2 : operand3
        String makeOfCar = "Volkswagen";
        boolean isDomestic = makeOfCar == "Volkswagen" ? false : true;
        /*
        If makeOfCar == "Volkswagen" is true, it will return what is prior the :
         */
        if (isDomestic) {
            System.out.println("Make is not VW");
        }
        if (!isDomestic) {
            System.out.println("Das Auto");
        }

        
    }
}