namespace mission_to_mars
{
    public class Rover : MouvementModule, IModuleMartien
    {
        public bool IsPretPourRecuperation { get; private set; }

        public Rover(Direction direction, Position position) : base(position, direction)
        {
        }

        public virtual void ActiverRecuperation()
        {
            this.IsPretPourRecuperation = true;
        }
    }
}
