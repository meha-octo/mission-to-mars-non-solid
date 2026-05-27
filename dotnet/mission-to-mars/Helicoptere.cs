using System.Linq;

namespace mission_to_mars
{
    public class Helicoptere : Rover, IModuleMartien
    {
        public bool IsPretPourRecuperation { get; private set; }

        public Helicoptere(Direction direction, Position position) : base(direction, position)
        {
        }

        public override void Monter()
        {
            Position = Position with { Z = Position.Z + 1 };
        }


        public override void Descendre()
        {
            Position = Position with { Z = Position.Z - 1 };
        }

        public override void ActiverRecuperation()
        {
            PoserHelicoptere(this);
            this.IsPretPourRecuperation = true;
        }

        private void PoserHelicoptere(IModuleMartien module)
        {
            int altitude = module.Position.Z;
            Atterir(module, altitude);
        }

        private void Atterir(IModuleMartien module, int altitude)
        {
            foreach (var _ in Enumerable.Range(0, altitude))
            {
                module.Descendre();
            }
        }

    }
}
