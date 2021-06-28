namespace Lncodes.Tutorial.Memento
{
    public sealed class PlayerPositionOriginator
    {
        private Vector2 _positionState = new Vector2(default, default);

        /// <summary>
        /// Method to create new position of the player
        /// </summary>
        /// <param name="newPosition"></param>
        /// <returns cref="PositionMemento"></returns>
        public PositionMemento CreateNewPosition(Vector2 newPosition) =>
            new PositionMemento(newPosition);

        /// <summary>
        /// Method to get current player position state
        /// </summary>
        /// <returns cref="Vector2"></returns>
        public Vector2 GetPositionState() =>
            _positionState;

        /// <summary>
        /// Method to restore player position state
        /// </summary>
        /// <param name="positionMemento"></param>
        internal void RestorePositionState(PositionMemento positionMemento) =>
            _positionState = positionMemento.GetPositionState();
    }
}