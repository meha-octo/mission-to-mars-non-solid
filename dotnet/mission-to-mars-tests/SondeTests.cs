using mission_to_mars;
using NUnit.Framework;
using Shouldly;

namespace mission_to_mars_tests;

[TestFixture()]
public class SondeTests
{
    private Sonde sut;

    [Test()]
    public void RoverDoitEtreRecuperer()
    {
        // Arrange
        sut = new Sonde();
        IModuleMartien perseverance = new Rover(Direction.NORD, new Position(4, 4, 0));

        // Act
        Sonde.PreparerRécupération(perseverance);

        //Assert
        perseverance.IsPretPourRecuperation.ShouldBe(true);
        perseverance.Position.ShouldBe(new Position(4, 4, 0), "Récupérer perseverance ne doit pas changer sa position");

    }

    [Test()]
    public void HelicoptereDoitEtreRecupéré()
    {
        // Arrange
        sut = new Sonde();
        IModuleMartien ingenuity = new Helicoptere(Direction.NORD, new Position(4, 4, 50));

        // Act
        Sonde.PreparerRécupération(ingenuity);

        //Assert
        ingenuity.IsPretPourRecuperation.ShouldBe(true);
        ingenuity.Position.ShouldBe(new Position(4, 4, 0), "Récupérer ingenuity implique de le faire attérir");

    }
}
