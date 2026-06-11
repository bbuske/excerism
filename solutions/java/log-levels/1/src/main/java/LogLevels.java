public class LogLevels {
    
    public static String message(String logLine) {
        return logLine.substring(logLine.indexOf(":") + 1).trim();
    }

    public static String logLevel(String logLine) {
        String [] parts = logLine.split("]");
        String errorType = parts[0].substring(1);
        return errorType.toLowerCase();
    }

    public static String reformat(String logLine) {
        return message(logLine) + " (" + logLevel(logLine) + ")";
    }
}
