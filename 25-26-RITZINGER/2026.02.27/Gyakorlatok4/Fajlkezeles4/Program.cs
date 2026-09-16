namespace Fajlkezeles4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fajl = @"c:\Temp\szoveg.txt";

            try
            {
                File.WriteAllText(fajl, "Első sor\nMásodik sor.");
            }
            catch(FieldAccessException ex)
            {
                Console.WriteLine($"Fájl nem található: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"IO hiba:{ex.Message}");
            }
            catch(UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Nincs jogosultság: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Váfratlan hiba:{ex.Message}");
            }
        }
    }
}
