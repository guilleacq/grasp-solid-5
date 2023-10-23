using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        // Es un IPrintableContent en lugar de Recipe por DIP
        public void PrintRecipe(IPrintableContent printableContent)
        {
            Console.WriteLine(printableContent.GetTextToPrint());
        }
    }
}