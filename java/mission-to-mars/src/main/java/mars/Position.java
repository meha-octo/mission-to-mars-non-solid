package mars;

public record Position(int x, int y, int z) {

    public Position avancer(Direction direction) {
        return switch (direction) {
            case NORD -> new Position(x, y + 1, z);
            case SUD -> new Position(x, y - 1, z);
            case OUEST -> new Position(x - 1, y, z);
            case EST -> new Position(x + 1, y, z);
        };
    }

    public Position reculer(Direction direction) {
        return switch (direction) {
            case NORD -> new Position(x, y - 1, z);
            case SUD -> new Position(x, y + 1, z);
            case OUEST -> new Position(x + 1, y, z);
            case EST -> new Position(x - 1, y, z);
        };
    }
}
