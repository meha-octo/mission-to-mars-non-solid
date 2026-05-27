namespace mission_to_mars
{
    public interface IModuleMartien
    {
        void Avancer() { }

        void Reculer();

        void ActiverRecuperation();

        bool IsPretPourRecuperation { get; }

        Position Position { get; }
    }
}
