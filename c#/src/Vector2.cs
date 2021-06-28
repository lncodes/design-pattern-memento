namespace Lncodes.Tutorial.Memento
{
    public struct Vector2
    {
        public readonly int X;
        public readonly int Y;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Vector2(int x, int y) =>
            (X, Y) = (x, y);
    }
}