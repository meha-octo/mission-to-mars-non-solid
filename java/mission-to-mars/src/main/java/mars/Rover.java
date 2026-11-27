package mars;

public class Rover implements ModuleMartien {

  private Direction direction;
  protected Position position;
  private boolean pretPourRecuperation = false;

  public Rover(Direction direction, Position position) {
    this.direction = direction;
    this.position = position;
  }

  public void avancer() {
    switch (direction) {
      case NORD:
        position = new Position(position.x(), position.y() + 1, position.z());
        break;
      case SUD:
        position = new Position(position.x(), position.y() - 1, position.z());
        break;
      case OUEST:
        position = new Position(position.x() - 1, position.y(), position.z());
        break;
      default:
        position = new Position(position.x() + 1, position.y(), position.z());
    }
  }

  public void reculer() {
    switch (direction) {
      case NORD:
        position = new Position(position.x(), position.y() - 1, position.z());
        break;
      case SUD:
        position = new Position(position.x(), position.y() + 1, position.z());
        break;
      case OUEST:
        position = new Position(position.x() + 1, position.y(), position.z());
        break;
      default:
        position = new Position(position.x() - 1, position.y(), position.z());
    }
  }

  public void activerRecuperation() {
    pretPourRecuperation = true;
  }

  @Override
  public Position getPosition() {
    return position;
  }

  @Override
  public boolean isPretPourRecuperation() {
    return pretPourRecuperation;
  }
}
