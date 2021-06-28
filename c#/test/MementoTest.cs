using Xunit;

namespace Lncodes.Tutorial.Memento.Test
{
    public class MementoTest
    {
        [Theory]
        [ClassData(typeof(PositionTheoryData))]
        public void Undo_PlayerPosition_AreEqual(Vector2 expected, Vector2 newPlayerPosition)
        {
            var playerPositionOriginator = new PlayerPositionOriginator();
            var positionCaretaker = new PositionCaretaker(playerPositionOriginator);

            var expectedPlayerPositionMemento = playerPositionOriginator.CreateNewPosition(expected);
            positionCaretaker.SavePositionMemento(expectedPlayerPositionMemento);

            var newPlayerPositionMemento = playerPositionOriginator.CreateNewPosition(newPlayerPosition);
            positionCaretaker.SavePositionMemento(newPlayerPositionMemento);

            positionCaretaker.UndoPlayerPositionState();
            var actual = playerPositionOriginator.GetPositionState();

            Assert.Equal(expected, actual);
        }
    }
}
