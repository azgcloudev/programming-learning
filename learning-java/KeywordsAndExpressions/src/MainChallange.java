public class MainChallange {

    public static void main(String[] args) {

        boolean gameOver = true;
        int score = 800;
        int levelCompleted = 5;
        int bonus = 100;

        int finalScore = score;

        if (gameOver) {
            finalScore += (levelCompleted * bonus);
            System.out.println("Your final score was " + finalScore);
        }


        /* --- CHALLANGE --- */
        //set score to 10000
        score = 10000;

        //set levelCompleted to 8
        levelCompleted = 8;

        // set bonus to 200
        bonus = 200;

        // use the same if statement before
        if (gameOver) {
            finalScore += (levelCompleted * bonus);
            System.out.println("Your final score was " + finalScore);
        }
    }
}
