
class Reto1
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("**LENGUAJE DEL HAKER**");

        string txt = "";

        Console.WriteLine("\nIngrese el texto que se quiere convertir: ");
        txt = Console.ReadLine();

        txt = txt.ToLower().Replace("a", "4").Replace("b", "I3").Replace("c", "[").Replace("d", ")").Replace("e", "3")
                            .Replace("f", "|=").Replace("g", "&").Replace("h", "#").Replace("i", "1").Replace("j", ",_|")
                            .Replace("k", ">|").Replace("l", "1").Replace("m", "/\\/\\")
                            .Replace("n", "^/").Replace("o", "0").Replace("p", "|*").Replace("q", "(_,)")
                            .Replace("r", "I2").Replace("s", "5").Replace("t", "7").Replace("u", "(_)").Replace("v", "\\/")
                            .Replace("w", "\\/\\/").Replace("x", "><").Replace("y", "j").Replace("z", "2");
                            
                            //No me funciona bien con los números :/
                            //.Replace("0", "o").Replace("1", "L").Replace("2", "R").Replace("3", "E").Replace("4", "A")
                            //.Replace("5", "S").Replace("6", "b").Replace("7", "T").Replace("8", "B").Replace("9", "g");
        
        Console.WriteLine("\n***TEXTO CONVERTIDO***\n");
        Console.WriteLine(txt);

        
    }
}
