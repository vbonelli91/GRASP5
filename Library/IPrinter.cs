
namespace Full_GRASP_And_SOLID
{
    public interface IPrinter
    {
        //se modifica por principio DIP para que reciba IprinterContent en lugar de Printer
        void PrintRecipe(IPrinterContent recipe);
    }
}