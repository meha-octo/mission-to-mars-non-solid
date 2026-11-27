package mars;

public class Helicoptere extends Rover implements ModuleMartien {

  public Helicoptere(Direction direction, Position position) {
    super(direction, position);
  }

  public void monter() {
    position = new Position(position.x(), position.y(), position.z() + 1);
  }

  public void descendre() {
    position = new Position(position.x(), position.y(), position.z() - 1);
  }
}
