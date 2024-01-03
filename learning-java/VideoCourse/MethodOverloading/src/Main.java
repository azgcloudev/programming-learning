public class Main {

    public static void main(String[] args) {
        calculateScore("Tim", 500);
        calculateScore();
        calculateScore(300);
    }

    // method 1
    public static int calculateScore(String playerName, int score) {
        System.out.println("Player " + playerName + " scored " + score + " points");
        return score * 1000;
    }

    // method 2
    public static int calculateScore() {
        System.out.println("No player name, no score");
        return 0;
    }

    // method 3
    public static int calculateScore(int score) {
        System.out.println("Unnamed player, scored " + score + " points");
        return 1000 * score;
    }
}
