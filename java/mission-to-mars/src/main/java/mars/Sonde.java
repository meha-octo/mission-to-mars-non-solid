package mars;

import java.util.stream.IntStream;

public class Sonde {

  public void preparerRecuperation(ModuleMartien moduleMartien) {
    if (moduleMartien instanceof Helicoptere) {
      poserHelicoptere((Helicoptere) moduleMartien);
    }
    moduleMartien.activerRecuperation();
  }

  private void poserHelicoptere(Helicoptere moduleMartien) {
    int altitude = moduleMartien.getPosition().z();
    atterir(moduleMartien, altitude);
  }

  private void atterir(Helicoptere moduleMartien, int altitude) {
    IntStream.range(0, altitude).forEach((i -> moduleMartien.descendre()));
  }
}
