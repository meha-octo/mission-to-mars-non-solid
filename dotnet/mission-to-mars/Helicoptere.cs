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

        public void Avancer()
        {
            Position = MouvementModule.Avancer(Position, _direction);
        }


        public void Reculer()
        {
            Position = MouvementModule.Reculer(Position, _direction);
        }

    }
}
