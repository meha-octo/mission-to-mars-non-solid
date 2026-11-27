package mars;

public abstract class ModuleMartien {
    protected boolean pretPourRecuperation = false;
    Direction direction;
    Position position;

    public ModuleMartien(Direction direction, Position position) {
        this.direction = direction;
        this.position = position;
    }

    void avancer() {
        position = position.avancer(direction);
    }

    void reculer() {
        position = position.reculer(direction);
    }

    void activerRecuperation() {
        pretPourRecuperation = true;
    }

    Position getPosition() {
        return position;
    }

    boolean isPretPourRecuperation() {
        return pretPourRecuperation;
    }
}