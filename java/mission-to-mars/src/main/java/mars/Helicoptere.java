package mars;

public class Helicoptere extends Rover implements ModuleMartien {

  public Helicoptere(Direction direction, Position position) {
    super(direction, position);
  }

  @Override
  public void monter() {
    position = new Position(position.x(), position.y(), position.z() + 1);
  }

  @Override
  public void descendre() {
    position = new Position(position.x(), position.y(), position.z() - 1);
  }
}
