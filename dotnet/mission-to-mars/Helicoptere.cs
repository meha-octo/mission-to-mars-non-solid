using System.Linq;

namespace mission_to_mars
{
    public class Helicoptere : IModuleMartien, IModuleVolant
    {
        public bool IsPretPourRecuperation { get; private set; }

        public Position Position { get; protected set; }

        private readonly Direction _direction;

        public Helicoptere(Direction direction, Position position)
        {
            _direction = direction;
            Position = position;
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

        public void Avancer()
        {
            Position = _direction switch
            {
                Direction.NORD => Position with { Y = Position.Y + 1 },
                Direction.SUD => Position with { Y = Position.Y - 1 },
                Direction.OUEST => Position with { X = Position.X - 1 },
                _ => Position with { X = Position.X + 1 },
            };
        }


        public void Reculer()
        {
            Position = _direction switch
            {
                Direction.NORD => Position with { Y = Position.Y - 1 },
                Direction.SUD => Position with { Y = Position.Y + 1 },
                Direction.OUEST => Position with { X = Position.X + 1 },
                _ => Position with { X = Position.X - 1 },
            };
        }

    }
}
