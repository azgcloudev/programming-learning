public class Challenge {

    public static void main(String[] args) {

    }


    public static String getDurationString(int seconds) {
        if ( !(seconds >= 0) ) {
            return "Invalid seconds";
        }

        int rMinutes;
        int rSeconds;

        if (seconds < 60) {
            return getDurationString(0, seconds);
        }

        rMinutes = seconds / 60;
        rSeconds = seconds % 60;

        return getDurationString(rMinutes, rSeconds);

    }

    public static String getDurationString(int minutes, int seconds) {

        // XXh XXm XXs

    }
}
