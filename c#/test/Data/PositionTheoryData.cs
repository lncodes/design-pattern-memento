using Xunit;

namespace Lncodes.Tutorial.Memento.Test
{
    public sealed class PositionTheoryData : TheoryData<Vector2, Vector2>
    {
        public PositionTheoryData()
        {
            Add(new Vector2(1,5), new Vector2(3,5));
        }
    }
}
