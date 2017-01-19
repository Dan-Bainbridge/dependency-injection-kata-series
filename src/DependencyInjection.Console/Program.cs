using DependencyInjection.Console.CharacterWriters;
using DependencyInjection.Console.SquarePainters;
using NDesk.Options;

namespace DependencyInjection.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var useColors = false;
            var width = 25;
            var height = 15;
            var pattern = "circle"; // TODO: Hook this up

            var optionSet = new OptionSet
            {
                {"c|colors", value => useColors = value != null},
                {"w|width=", value => width = int.Parse(value)},
                {"h|height=", value => height = int.Parse(value)},
                {"p|pattern=", value => pattern = value}
            };
            optionSet.Parse(args);

            AsciiWriter asciiWriter = new AsciiWriter();
            PatternGenerator patternGenerator = new PatternGenerator(new CircleSquarePainter());
            var app = new PatternApp(patternGenerator, new PatternWriter(useColors ? (ICharacterWriter) new ColorWriter(asciiWriter) : asciiWriter));
            app.Run(width, height);

            System.Console.ReadLine();
        }
    }
}
