namespace mission_to_mars
{
    public class Rover : IModuleMartien
    {
        public bool IsPretPourRecuperation { get; private set; }

        public Position Position { get; protected set; }

        private readonly Direction _direction;

        public Rover(Direction direction, Position position)
        {
            _direction = direction;
            Position = position;
        }

        public virtual void ActiverRecuperation()
        {
            this.IsPretPourRecuperation = true;
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
