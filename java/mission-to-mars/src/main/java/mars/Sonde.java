package mars;

import java.util.stream.IntStream;

public class Sonde {

  public void preparerRecuperation(ModuleMartien moduleMartien) {
    if (moduleMartien instanceof Helicoptere) {
      poserHelicoptere(moduleMartien);
    }
    moduleMartien.activerRecuperation();
  }

  private void poserHelicoptere(ModuleMartien moduleMartien) {
    int altitude = moduleMartien.getPosition().z();
    atterir(moduleMartien, altitude);
  }

  private void atterir(ModuleMartien moduleMartien, int altitude) {
    IntStream.range(0, altitude).forEach((i -> moduleMartien.descendre()));
  }
}
