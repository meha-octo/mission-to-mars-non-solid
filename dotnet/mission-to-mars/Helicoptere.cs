using System.Linq;

namespace mission_to_mars;

public class Helicoptere(Direction direction, Position position) : ModuleMartien(direction, position)
{
    public void Monter()
    {
        Position = Position with { Z = Position.Z + 1 };
    }

    public void Descendre()
    {
        Position = Position with { Z = Position.Z - 1 };
    }

    public override void PreparerRécupération()
    {
        PoserHelicoptere();
        ActiverRecuperation();
    }

    public override void ActiverRecuperation()
    {
        IsPretPourRecuperation = true;
    }

    private void PoserHelicoptere()
    {
        var altitude = Position.Z;
        Atterir(altitude);
    }

    private void Atterir(int altitude)
    {
        foreach (var _ in Enumerable.Range(0, altitude))
        {
            Descendre();
        }
    }
}
