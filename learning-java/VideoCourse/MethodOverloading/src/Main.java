public class Main {

    public static void main(String[] args) {

    }

    // method 1
    public static int calculateScore(String playerName, int score) {
        System.out.println("Player " + playerName + " scored " + score + " points");
        return score * 1000;
    }

    // method 2
    public static int calculateScore(int score) {
        return score * 1000;
    }
}
