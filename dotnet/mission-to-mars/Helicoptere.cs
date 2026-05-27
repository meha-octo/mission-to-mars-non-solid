using System.Linq;

namespace mission_to_mars
{
    public class Helicoptere : MouvementModule, IModuleMartien, IModuleVolant
    {
        public bool IsPretPourRecuperation { get; private set; }

        public Helicoptere(Direction direction, Position position) : base(position, direction)
        {
        }

        public void Monter()
        {
            Position = Position with { Z = Position.Z + 1 };
        }


        public void Descendre()
        {
            Position = Position with { Z = Position.Z - 1 };
        }

        public void ActiverRecuperation()
        {
            PoserHelicoptere();
            this.IsPretPourRecuperation = true;
        }

        private void PoserHelicoptere()
        {
            int altitude = Position.Z;
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
}
