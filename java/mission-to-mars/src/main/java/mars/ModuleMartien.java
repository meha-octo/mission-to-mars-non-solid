package mars;

public abstract class ModuleMartien {
    protected boolean pretPourRecuperation = false;
    Direction direction;
    Position position;

    public ModuleMartien(Direction direction, Position position) {
        this.direction = direction;
        this.position = position;
    }

    protected void avancer() {
        position = position.avancer(direction);
    }

    protected void reculer() {
        position = position.reculer(direction);
    }

    void activerRecuperation() {
        pretPourRecuperation = true;
    }

    protected Position getPosition() {
        return position;
    }

    protected boolean isPretPourRecuperation() {
        return pretPourRecuperation;
    }
}