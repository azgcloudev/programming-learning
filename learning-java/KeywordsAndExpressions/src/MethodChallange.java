public class MethodChallange {

    public static void main(String[] args) {
        int highScore = calculateHighScorePosition(1500);
        displayHighScorePosition("Tim", highScore);

        highScore = calculateHighScorePosition(1000);
        displayHighScorePosition("Carlos", highScore);

        highScore = calculateHighScorePosition(500);
        displayHighScorePosition("Pedro", highScore);

        highScore = calculateHighScorePosition(100);
        displayHighScorePosition("Juan", highScore);

        highScore = calculateHighScorePosition(25);
        displayHighScorePosition("Chris", highScore);
    }

    public static void displayHighScorePosition(String playerName, int playerPosition) {
        System.out.println(playerName + " managed to get into position " + playerPosition
                + " on the high score list");
    }

    /***
     * This methods return the player position based on the score.
     * @param playerScore Player score int value.
     * @return Player position as integer.
     */
    public static int calculateHighScorePosition(int playerScore) {
        int result = 4;

        if (playerScore >= 1000) {
            result = 1;
        } else if (playerScore >= 500) {
            result = 2;
        } else if (playerScore >= 100) {
            result = 3;
        }
        
        return result;
    }
}
