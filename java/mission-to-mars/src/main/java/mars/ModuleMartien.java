package mars;

public abstract class ModuleMartien {
//test
	private Direction direction;

	Position getPosition();

	void avancer();

	void reculer();

	void monter();

	void descendre();

	void activerRecuperation();

	boolean isPretPourRecuperation();
}