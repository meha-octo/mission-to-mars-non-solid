package mars;

import static mars.Direction.*;

public abstract class ModuleMartien {
	Direction direction;
	Position position;
	protected boolean pretPourRecuperation = false;

	public ModuleMartien(Direction direction, Position position) {
		this.direction = direction;
		this.position = position;
	}

	void avancer() {
		switch (direction) {
			case NORD:
				position = new Position(position.x(), position.y() + 1, getPosition().z());
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

	void reculer() {
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