using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        //modificamos por principio DIP para que la clase FilePrinter dependa de la interfaz 
        //IPrinterContent en lugar de la clase Recipe
        public void PrintRecipe(IPrinterContent recipeContent)
        {
            File.WriteAllText("Recipe.txt", recipeContent.GetTextToPrint());
        }
    }
}