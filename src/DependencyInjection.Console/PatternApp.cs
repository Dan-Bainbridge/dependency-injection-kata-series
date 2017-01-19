namespace DependencyInjection.Console
{
    internal class PatternApp
    {
        private readonly PatternWriter _patternWriter;
        private readonly PatternGenerator _patternGenerator;

        public PatternApp(bool useColours, PatternGenerator patternGenerator)
        {
            _patternWriter = new PatternWriter(useColours);
            _patternGenerator = patternGenerator;
        }

        public void Run(int width, int height)
        {
            var pattern = _patternGenerator.Generate(width, height);
            _patternWriter.Write(pattern);
        }
    }
}