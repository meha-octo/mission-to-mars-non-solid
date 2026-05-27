namespace mission_to_mars;

public class Rover(Direction direction, Position position) : ModuleMartien(direction, position)
{
    public override void PreparerRécupération()
    {
        ActiverRecuperation();
    }

    public override void ActiverRecuperation()
    {
        IsPretPourRecuperation = true;
    }
}
