public class MainChallange {

    public static void main(String[] args) {

        boolean gameOver = true;
        int score = 800;
        int levelCompleted = 5;
        int bonus = 100;

        int finalScore = score;

        calculateScore(gameOver, levelCompleted, bonus, finalScore);


        /* --- CHALLANGE --- */
        //set score to 10000
        score = 10000;

        //set levelCompleted to 8
        levelCompleted = 8;

        // set bonus to 200
        bonus = 200;

        // use the same if statement before
        calculateScore(true, 8, bonus, finalScore);

        int highScore = calculateIntScore(gameOver, finalScore, levelCompleted, bonus);
        System.out.println("The highscore is: " + highScore);
    }

    // method
    public static void calculateScore(boolean gameOver, int level, int bonus, int finalScore) {
        // void returns none date types
        if (gameOver) {
            finalScore += (level * bonus);
            System.out.println("Your final score was " + finalScore);
        }
    }

    // method with return type
    public static int calculateIntScore(boolean gameOver, int score, int levelCompleted, int bonus) {

        int finalScore = score;

        if (gameOver) {
            finalScore += (levelCompleted * bonus);

            return finalScore;
        }

        return finalScore;
    }
}
