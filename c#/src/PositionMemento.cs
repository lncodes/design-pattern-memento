namespace Lncodes.Tutorial.Memento
{
    public sealed class PositionMemento
    {
        private readonly Vector2 _positionState;

        /// <summary>
        /// Constructor for default position memento
        /// The default value is Vector2(0, 0)
        /// </summary>
        public PositionMemento() =>
            _positionState = new Vector2(default, default);

        /// <summary>
        /// Constructor if want to create custom position
        /// </summary>
        /// <param name="positionState"></param>
        public PositionMemento(Vector2 positionState) =>
            _positionState = positionState;

        /// <summary>
        /// Method to get position state
        /// </summary>
        /// <returns></returns>
        public Vector2 GetPositionState() =>
            _positionState;
    }
}
