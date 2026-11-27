package mars;

public record Position(int x, int y, int z) {

    public Position avancer(Direction direction) {
        return new Position(x + direction.dx, y + direction.dy, z);
    }

    public Position reculer(Direction direction) {
        return new Position(x - direction.dx, y - direction.dy, z);
    }
}
