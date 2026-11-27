package mars;

public enum Direction {

    NORD(0, 1),
    SUD(0, -1),
    OUEST(-1, 0),
    EST(1, 0);

    public final int dx, dy;

    Direction(int dx, int dy) {
        this.dx = dx;
        this.dy = dy;
    }
}