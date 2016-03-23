namespace RegimentOfFoot.Game.Generators
{
    public abstract class Generator<T>
    {
        public abstract T Generate(GeneratorParams parameters);
    }

    public abstract class GeneratorParams
    {
    }
}