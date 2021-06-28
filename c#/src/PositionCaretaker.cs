using System.Collections.Generic;

namespace Lncodes.Tutorial.Memento
{
    public sealed class PositionCaretaker
    {
        private readonly PlayerPositionOriginator _playerPositionOriginator;
        private readonly Queue<PositionMemento> _mementoCollection = new Queue<PositionMemento>();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="playerPositionOriginator"></param>
        public PositionCaretaker(PlayerPositionOriginator playerPositionOriginator) =>
            _playerPositionOriginator = playerPositionOriginator;

        /// <summary>
        /// Method to save position memento
        /// </summary>
        /// <param name="positionMemento"></param>
        public void SavePositionMemento(PositionMemento positionMemento) =>
            _mementoCollection.Enqueue(positionMemento);

        /// <summary>
        /// Method to undo player position that save in the PositionCaretaker class
        /// </summary>
        public void UndoPlayerPositionState()
        {
            PositionMemento lastPlayerPositionMemento;
            var defaultPositionMemento = new PositionMemento();

            if (_mementoCollection.TryDequeue(out lastPlayerPositionMemento))
                _playerPositionOriginator.RestorePositionState(lastPlayerPositionMemento);
            else
                _playerPositionOriginator.RestorePositionState(defaultPositionMemento);
        }
    }
}