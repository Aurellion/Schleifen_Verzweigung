namespace Schleifen_Verzweigung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verzweigung
            Console.WriteLine("Auswahl:");
            Console.WriteLine("1:Addition");
            Console.WriteLine("2:Subtraktion");

            //Verzweigung  mit if-else
            Console.Write("Auswahl=");
            int auswahl;
            auswahl = Convert.ToInt32(Console.ReadLine());

            //if-else
            //if (Bedingung=Wahr) {mache das hier}
            //else if  (Bedingung=Wahr) {mache jenes hier}
            //else {mache dies hier}

            if (auswahl == 1)
            {
                Console.WriteLine("Addition von zwei ganzen Zahlen:");
                int a, b; //Deklaration der Variablen vom Typ Integer

                //Console.WriteLine("x") schreibt x und springt zur nächsten Zeile
                //Console.Write("x") schreibt x und bleibt in der aktuellen zeile

                //Eingabe
                Console.WriteLine("Geben Sie die Summanden ein:");
                Console.Write("a=");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b=");
                b = Convert.ToInt32(Console.ReadLine());

                //Console.ReadLine() liest den Inhalt der aktuellen Zeile als string
                //Console.Read() liest das nächste Zeichen als string
                //Convert.toXXX(a) versucht die Umwandlung von a in den Typ XXX

                //Verarbeitung
                int summe = a + b;

                //Ausgabe
                Console.WriteLine("Ergebnis lautet " + summe);
                Console.WriteLine(a + " + " + b + " = " + summe);

                //Console.WriteLine("x") schreibt x und springt zur nächsten Zeile
                //Console.WriteLine(y) schreibt den Inhalt von y und springt zur nächsten Zeile
                //Console.WriteLine("x"+y) kombiniert beide Varianten
            }
            else if (auswahl == 2)
            {
                Console.WriteLine("Subtraktion von zwei ganzen Zahlen:");
                int a, b; //Deklaration der Variablen vom Typ Integer
             
                //Eingabe
                Console.WriteLine("Geben Sie Minuend und Subtrahend ein:");
                Console.Write("Minuend a=");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Subtrahend b=");
                b = Convert.ToInt32(Console.ReadLine());

                //Verarbeitung
                int differenz = a - b;

                //Ausgabe
                Console.WriteLine("Ergebnis lautet " + differenz);
                Console.WriteLine(a + " - " + b + " = " + differenz);
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl");
            }
            Console.ReadKey(); //Liest ein welche Taste als nächstes gedrückt wird           
        }
    }
}