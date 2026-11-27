package mars;

import java.util.stream.IntStream;

public class Helicoptere extends ModuleMartien {


  public Helicoptere(Direction direction, Position position) {
    super(direction, position);
  }

  public void monter() {
    position = new Position(position.x(), position.y(), position.z() + 1);
  }

  public void descendre() {
    position = new Position(position.x(), position.y(), position.z() - 1);
  }

  @Override
  void activerRecuperation() {
    poser();

    super.activerRecuperation();
  }

  private void poser() {
    int altitude = getPosition().z();
    atterir(altitude);
  }

  private void atterir(int altitude) {
    IntStream.range(0, altitude).forEach((_ -> descendre()));
  }
}
