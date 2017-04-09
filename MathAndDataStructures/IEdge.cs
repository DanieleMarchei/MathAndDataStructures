namespace MathAndDataStructures
{
    public interface IEdge
    {
        double Weight { get; set; }

        object From { get; set; }

        object To { get; set; }

        bool IsDirected();
    }
}