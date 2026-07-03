using System;
using System.Data;




#region ClassProgram

public static class Program // INICIO DEL PROGRAMA y Clases en PascalCase



{

static void DibujarBanderaFamiliar(string nombre, string simbolo, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"{simbolo} {nombre}");
        Console.ResetColor();
    }
    
   #endregion 
#region MétodoMain
public static void Main(string[] args)



    {

        string text = "Bienvenidos a la Historia Familiar Lovera - Dahuas";
        string upperText = text.ToUpper();
        int anchoConsola = Console.WindowWidth;
        int espaciosIzquierda = (anchoConsola - upperText.Length) / 2;
        ConsoleColor colortext = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Green; // Propiedad para cambiar el color del texto a color verde.
        
        // Console.BackgroundColor = ConsoleColor.DarkYellow; // Propiedad para cambiar el color de fondo a color morado.

        


        Console.WriteLine(new string(' ', espaciosIzquierda) + upperText + colortext);
        ShowMenu(); //Que hace este showMenu 
        Console.WriteLine();
        Console.WriteLine("Presiona una tecla para salir...");
        Console.ReadKey();

    }
#endregion

#region ShowMenu, While y SwitchCase
static void ShowMenu()



    {

        bool continuar = true;
        while (continuar)
        {
            
        Console.WriteLine();
        Console.WriteLine("Seleccione una opción del menú:");
        Console.WriteLine("0. Salir");
        Console.WriteLine("1. Anécdotas Abuelo José Dahuas. ");
        Console.WriteLine("2. Anécdotas Abuela Teresa Acosta. ");
        Console.WriteLine("3. Anécdotas Mamá Pily. ");
        Console.WriteLine("4. Anécdotas Papá Walter. ");
        Console.WriteLine("5. Anécdotas Santiago Mathías y Diana. ");
        Console.WriteLine("6. Anécdotas Daniela Martínez. ");
        Console.WriteLine("7. Anécdotas Jeimy Lovera.");
        Console.Write("Ingrese el número de la opción deseada: ");

        string? input = Console.ReadLine(); // agregar el signo de interrogación para permitir valores nulos
        
        if (!int.TryParse(input, out int menuOption))

        {
            Console.WriteLine("Debes ingresar un número válido.");
            continue;

        }

        
        switch (menuOption)
        {
            case 0:
            continuar = false;
            break;
            
            case 1:
                DibujarBanderaFamiliar("Abuelo José", "🟦", ConsoleColor.Blue);
                PrintAbueloJose();
                 break;

            case 2:
                DibujarBanderaFamiliar("Abuela Teresa", "🟪", ConsoleColor.Magenta);
                PrintAbuelaTeresa();
                break;

            case 3:
                DibujarBanderaFamiliar("Mamá Pily", "🟩", ConsoleColor.Green);
                PrintMamaPily();
                break;

            case 4:
                DibujarBanderaFamiliar("Papá Walter", "🟥", ConsoleColor.Red);
                PrintPapaWalter();
                break;

            case 5:
                DibujarBanderaFamiliar("Santiago Mathías y Diana", "🟨", ConsoleColor.Yellow);
                PrintSantiagoMathiasDiana();
                break;

            case 6: 
                DibujarBanderaFamiliar("Daniela Martínez", "🟧", ConsoleColor.DarkGreen);
                PrintDanielaMartinez();
                break;
            
            case 7:
                DibujarBanderaFamiliar("Jeimy Lovera", "🟫", ConsoleColor.DarkBlue);
                PrintJeimyLovera();
                break;
            
            default:
                Console.WriteLine("Opción inválida, seleccionar un número del 1 al 7");
                break;
    

        } 

        if (continuar)

            {
                Console.WriteLine();
                Console.WriteLine("Presiona ENTER para volver al menú");
                Console.ReadLine();
            }
        }

    }

    #endregion

#region PrintAbueloJose
    static void PrintAbueloJose() //Recomendable usar métodos en PascalCase

    {
        Console.WriteLine();
        //Console.WriteLine("Anécdotas Abuelo José Dahuas: " );
        string tituloGrandFather = "Anécdotas Abuelo José Dahuas: ";
        Console.WriteLine(tituloGrandFather.ToUpper());
        

        var nameGrandFather = "José Rafael Dahuas Pinedo";
        var ageGrandFather = 82;
        var professionWork = "Sociólogo";
        var favoriteSport = "Fútbol";
        var hobbiesOne = "Lectura";
        var foodFavorite = "Pescado";
        var bornCountry = "Perú";
        

        DateTime dateOfBirth = new DateTime(1942, 7, 30);

        var briefHistory = $@"El nombre de mi abuelo es {nameGrandFather}, tiene {ageGrandFather} años, su país de nacimiento es {bornCountry}, nació el {dateOfBirth:dd/MM/yyyy} y se graduó de {professionWork} en la universidad de Lima.
Se vino a Venezuela muy joven a buscar oportunidades laborales, es un hombre muy inteligente, disfruta mucho ver partidos de {favoriteSport}, le encanta la {hobbiesOne} y su comida favorita es el {foodFavorite}.";

        Console.WriteLine(briefHistory);
        
        


    }
    #endregion

#region PrintAbuelaTeresa
static void PrintAbuelaTeresa()

{

Console.WriteLine();
// Console.WriteLine("Anécdotas Abuela Teresa: ");

string tituloGrandMother = "Anécdotas Abuela Teresa: ";
Console.WriteLine(tituloGrandMother.ToUpper());

 var nameGrandMother = "Teresa de Jesús Acosta Ruiz";
        var ageGrandMother = 74;
        var professionWorkGM = "Comerciante";
        var favoriteSportGM = "Fútbol";
        var hobbiesGrandMother = "Hacer Tortas";
        var foodFavoriteGrandMother = "Pasticho de Berenjena";
        var bornCountryGrandMother = "Perú";
        DateTime dateOfBirthGM = new DateTime(1945, 11, 07);

        var grandMotherHistory = $@"Mi abuela se llama {nameGrandMother}, nació el {dateOfBirthGM:dd/MM/yyyy}, lamentablemente falleció en el año 2020 a los {ageGrandMother} años, trabajó como {professionWorkGM} en los mercados populares vendiendo ropa.
Le encantaba ver partidos de {favoriteSportGM} con mi abuelo José, disfrutaba {hobbiesGrandMother} para todos los miembros de la familia en los respectivos cumpleaños, su comida favorita fue el {foodFavoriteGrandMother}, su país de nacimiento es {bornCountryGrandMother}.";

        Console.WriteLine(grandMotherHistory);

}
#endregion

#region PrintMamaPily
static void PrintMamaPily()

    {
        Console.WriteLine();
        // Console.WriteLine("Anécodotas Teresa Del Pila: ");

        string tituloMother = "Anécdotas Teresa Del Pilar Dahuas Acosta: ";
        Console.WriteLine(tituloMother.ToUpper());

        var nameMother = "Teresa Del Pilar Dahuas Acosta";
        var ageMother = 55;
        var professionMother = "Contadora";
        var favoriteSportM = "Fútbol y Béisbol";
        var hobbiesMother = "Bailar";
        var foodFavoriteMother = "Causa Peruana";
        var bornCountryMother = "Perú";
        DateTime dateOfBirthMother = new DateTime(1970, 4, 20);

        var motherHistory = $@"Mi madre querida se llama {nameMother}, tiene {ageMother} años, nació el {dateOfBirthMother:dd/MM/yyyy}, es {professionMother} de profesión, se graduó en la UCV.
En su tiempo libre disfruta mucho {hobbiesMother}, sus deportes favoritos son {favoriteSportM}, su comida favorita es {foodFavoriteMother}, y su país de nacimiento es {bornCountryMother}.";

        Console.WriteLine(motherHistory);

    }
#endregion

#region PrintPapaWalter
    static void PrintPapaWalter()

    {
        Console.WriteLine();
        // Console.WriteLine("Anécdotas Walter Amado Lovera: ");
        
        string tituloFather = "Anécdotas Walter Amado Lovera Álvarez: ";
        Console.WriteLine(tituloFather.ToUpper());

        var nameFather = "Walter Amado Lovera Álvarez";
        var ageFather = 58;
        var professionFather = "Mudanzas";
        var hobbiesFather = "Beber y jugar Dominó";
        var foodFavoriteFather = "Sopa de Mondongo";
        var bornCountryFather = "Venezuela";
        DateTime dateOfBirthFather = new DateTime(1966, 10, 30);

        var fatherHistory = $@"Mi papá se llama {nameFather}, tiene {ageFather} años de edad, trabaja en {professionFather}, nació en {bornCountryFather}.
Para distraerse y no estresarse, le gusta {hobbiesFather}, disfruta mucho la {foodFavoriteFather}.";

        Console.WriteLine(fatherHistory);

    }
#endregion

#region PrintSantiagoMathiasDiana
    static void PrintSantiagoMathiasDiana()

    {
        Console.WriteLine();
        string tituloSon1 = "Anécdotas Santiago: ";
        Console.WriteLine(tituloSon1.ToUpper());

        var nameSon1 = "Santiago Ignacio Lovera Muñoz";
        var ageSon1 = 12;
        var professionSon1 = "Estudia";
        var favoriteSportsSon1 = "Básquet y Natación";
        var hobbiesSon1 = "Cine y Videojuegos";
        var favoriteFoodSon1 = "Hamburguesas y papas fritas";
        var bornCountrySon1 = "Venezuela";
        DateTime dateOfBirthSon1 = new DateTime(2013, 5, 19);

        var son1History = $@"Esta personita se llama {nameSon1}, es mi primer hijo y tiene {ageSon1} años, nació el {dateOfBirthSon1:dd/MM/yyyy} y
Vive en Chile desde 2019 y {professionSon1} con una profesora particular. Sus deportes favoritos son {favoriteSportsSon1}.
Disfruta mucho {hobbiesSon1} y su comida preferida es {favoriteFoodSon1}. Nació en {bornCountrySon1}.";

        Console.WriteLine(son1History);

        Console.WriteLine();
        string tituloSon2 = "Anécdotas Andrés Mathias: ";
        Console.WriteLine(tituloSon2.ToUpper());

        var nameSon2 = "Andres Mathías Marcano";
        var ageSon2 = 10;
        var professionSon2 = "Estudiar";
        var favoriteSportSon2 = "Todavía no tiene un deporte favorito";
        var hobbiesSon2 = "Ver Televisión y Jugar Videojuegos";
        var favoriteFoodSon2 = "Hamburguesas y papas fritas";
        var bornCountrySon2 = "Venezuela";
        DateTime dateOfBirthSon2 = new DateTime(2016, 7, 28);

        var son2History = $@"Su nombre es {nameSon2}, tiene {ageSon2} años, nació el {dateOfBirthSon2:dd/MM/yyyy}, le gusta {professionSon2} y su deporte favorito aún no está definido.
Para distraerse disfruta {hobbiesSon2}. Su comida preferida es {favoriteFoodSon2}. Nació en {bornCountrySon2} y {favoriteSportSon2}.";

        Console.WriteLine(son2History);

        Console.WriteLine();
        string tituloDaughter = "Anécdotas Dianita: ";
        Console.WriteLine(tituloDaughter.ToUpper());

        var nameDaughter = "Diana Isabella Lovera Martínez";
        var ageDaughter = 3;
        var professionDaughter = "Ir al Maternal";
        var favoriteSportDaughter = "Quedarse en casa";
        var hobbiesDaughter = "Comer y ver televisión";
        var favoriteFoodDaughter = "Arroz con Camarones";
        var bornCountryDaughter = "Venezuela";
        DateTime dateOfBirthDaughter = new DateTime(2022, 10, 29);   

        var daughterHistory = $@"Diana tiene {ageDaughter} años, nació el {dateOfBirthDaughter:dd/MM/yyyy}, le encanta {professionDaughter} y le gusta {favoriteSportDaughter}.
Disfruta {hobbiesDaughter} y su comida preferida es {favoriteFoodDaughter}. Nació en {bornCountryDaughter}, su nombre completo es {nameDaughter}.";

        Console.WriteLine(daughterHistory);

    }
    #endregion

#region PrintDanielaMartinez

static void PrintDanielaMartinez()

    {
        Console.WriteLine();
        string tituloPerlita = "Anécdotas Daniela Martínez: ";
        Console.WriteLine(tituloPerlita.ToUpper());

        var namePerlita = "Daniela Alejandra Martínez Sánchez";
        var agePerlita = 40;
        var professionPerlita = "Ingeniera en Sistemas";
        var hobbiesPerlita = "Películas y Series";
        var favoriteFoodPerlita = "Cochino Frito";
        var bornCountryPerlita = "Venezuela";
        DateTime dateOfBirthPerlita = new DateTime(1985, 9, 2);

        var perlitaHistory = $@"Esta señorita es mi esposita, se llama {namePerlita}, tiene {agePerlita} años, nació el {dateOfBirthPerlita:dd/MM/yyyy}, se graduó como {professionPerlita}.
Disfruta ver {hobbiesPerlita} y le gusta comer {favoriteFoodPerlita}. Nació en {bornCountryPerlita}.";

        Console.WriteLine(perlitaHistory);


    }
#endregion

#region PrintJeimyLovera
    static void PrintJeimyLovera()

    {
        Console.WriteLine();
        string tituloJeicito = "Anécdotas Jeimy Lovera: ";
        Console.WriteLine(tituloJeicito.ToUpper());

        var nameJeicito = "Jeimy Rafael Lovera Dahuas";
        var ageJeicito = 37;
        var professionJeicito = "Consultor de Tecnología";
        var hobbiesJeicito = "Lectura y Aprender a Programar en C#";
        var favoriteFoodJeicito = "Sushi";
        var bornCountryJeicito = "Venezuela";
        DateTime dateOfBirthJeicito = new DateTime(1989, 3, 14);

        var jeicitoHistory = $@"Mi nombre es {nameJeicito}, tengo {ageJeicito} años, nací el {dateOfBirthJeicito:dd/MM/yyyy}, trabajo como {professionJeicito}.
En mi tiempo libre disfruto {hobbiesJeicito}. Me encanta comer {favoriteFoodJeicito} y nací en {bornCountryJeicito}.";

        Console.WriteLine(jeicitoHistory);


    }
#endregion

    }




#region ComentariosCodigoOriginalSinRefactorizar
/*var MenuOption = 0;


 switch (MenuOption)

{
    case 1:
        Console.WriteLine("Anécdotas Abuelo José Dahuas");
        break;

    case 2:
        Console.WriteLine("Anécdotas Abuela Teresa Acosta");
        break;

    case 3:
         Console.WriteLine("Anécdotas Mamá Pily");
         break;

    case 4:
        Console.WriteLine("Anécdotas Papá Walter");
        break;

    case 5: 
        Console.WriteLine("Anécdotas Santiago Mathías y Diana");
        break;

    case 6: 
        Console.WriteLine("Anécdotas Daniela Martínez");
        break;

    case 7: 
        Console.WriteLine("Anécdotas Jeimy Lovera");
        break;
    
}


public class AbueloJosé



{
        static void Main(string[] args) // HAY MUCHOS MAIN, SOLO DEBE ESTAR UN SOLO MAIN, DEBE DEJAR UN SOLO MAIN 
    {

        Console.WriteLine("Anécdotas Abuelo José Dahuas");

        var nameGrandFather = "José Rafael Dahuas Pinedo";
        var ageGrandFather = 82;
        var ProfessionWork = "Sociólogo";
        var FavoriteSport = "Fútbol";
        var HobbiesOne = "Lectura";
        var FoodFavorite = "Pescado";
        var BornCountry = "Perú";
        var BriefHistory = $@"El nombre de mi abuelo es {nameGrandFather}, tiene {ageGrandFather} años, su país de nacimiento es {BornCountry} y se gradúo de {ProfessionWork} en la universidad de Lima.
Se vino a Venezuela muy joven a buscar oportunidades laborales, es un hombre muy inteligente, disfruta mucho ver partidos de {FavoriteSport}, le encanta la {HobbiesOne} y su comida favorita es el {FoodFavorite}.";

        Console.WriteLine(BriefHistory);

    }

}


public class AbuelaTeresa

{
    static void Main(string[] args)
    {

        Console.WriteLine("Anécdotas Abuela Teresa");

        var nameGrandoMother = "Teresa de Jesús Acosta Ruiz";
        var ageGrandMother = 74;
        var ProfessionWorkGM = "Comerciante";
        var FavoriteSportGM = "Fútbol";
        var HobbiesGrandMother = "Hacer Tortas";
        var FoodFavoriteGrandMother = "Pasticho de Berenjena";
        var BornCountryGrandMother = "Perú";
        var GrandMotherHistory = $@" Mi abuela se llama {nameGrandoMother}, falleció en el año 2020 a los {ageGrandMother} años, trabaja como {ProfessionWorkGM} en los mercados populares vendiendo ropa.
Le encantaba ver partidos de {FavoriteSportGM} con mi abuelo José, disfrutaba {HobbiesGrandMother} para todos los miembros de la familia en los respectivos cumpleaños, su comida favorita fue el {FoodFavoriteGrandMother}, su país de nacimiento es {BornCountryGrandMother}.";

Console.WriteLine(GrandMotherHistory); // REFACTORIZADO

    }

}



public class Mamá

{
   public static void Main(string[] args)

    {
    Console.WriteLine("Anécdotas Teresa Del Pilar Dahuas Acosta");

        var nameMother = "Teresa Del Pilar Dahuas Acosta";
        var ageMother = 55;
        var ProfessionMother = "Contadora";
        var FavoriteSportM = "Fútbol y Béisbol";
        var HobbiesMother = "Bailar";
        var FoodFavoriteMother = "Causa Peruana";
        var BornCountryMother = "Perú";
        var MotherHistory = $@"Mi madre querida y fastidiosa jajajaja se llama {nameMother}, hasta los momentos tiene jajajaja {ageMother} años, es {ProfessionMother} de profesión, se gradúo en la UCV.
En sus tiempo libre disfruta mucho {HobbiesMother}, sus deportes favorites son el {FavoriteSportM}, su comida favorita es la {FoodFavoriteMother}, y su país de nacimiento es {BornCountryMother}";

Console.WriteLine(MotherHistory); // REFACTORIZADO

        }

}



public class Papá

{

    static void Main(string[] args)

    {

        Console.WriteLine("Anécdotas Walter Amado Lovera Álvarez");

        var nameFather = "Walter Amado Lovera Álvarez";
        var ageFather = 58;
        var ProfessionFather = "Mudanzas";
        var HobbiesFather = "Beber y jugar Dominó";
        var FoodFavoriteFather = "Sopa de Mondongo";
        var BornCountryFather = "Venezuela";
        var FatherHistory = $@"Mi papá se llama {nameFather}, tiene {ageFather} años de edad, de vez en cuando y de cuando en vez jajajaja, trabaja en {ProfessionFather} de una ciudad a otra ciudad, nació en {BornCountryFather}.
Para distraerse y no estresarse, le gusta {HobbiesFather}, disfruta mucho la {FoodFavoriteFather}.";

       Console.WriteLine(FatherHistory); // REFACTORIZADO


    }

}


public class Santiago_Mathias_Diana

{
    public static void Main(string[] args)

    {
        Console.WriteLine("Anécdotas Santiago Ignacio Lovera Muñoz");

        var nameSon1 = "Santiago Ignacio Lovera Muñoz";
        var ageSon1 = 12;
        var ProfessionSon1 = "Estudiar";
        var FavoriteSportOneSon1 = "Basquet";
        var FavoriteSporTwotSon1 = "Natación";
        var HobbiesOneSon1 = "Cine";
        var HobbiesTwoSon1 = "Video Juegos";
        var AllHobbiesSon1 = HobbiesOneSon1 + HobbiesTwoSon1;
        var FavoriteFoodSon1 = "Hamburguesas y papas fritas";
        var BornCountrySon1 = "Venezuela";
        var Son1History = $@" Esta personita que voy a describir en esta historia se llama {nameSon1}, es mi primer hijo, y para mí es muy especial, actualmente tiene {ageSon1} años, vive en Chile desde el año 2019.
Una profesora particular lo ayuda a {ProfessionSon1}, motivado que mi chamo tiene condición de Autismo, sus deportes favoritos son el {FavoriteSportOneSon1} y {FavoriteSporTwotSon1}.
Disfruta mucho comer {FavoriteFoodSon1}, adicionalmente y muy importante ama ir al {AllHobbiesSon1}, su país de nacimiento es {BornCountrySon1} ";

Console.WriteLine(Son1History); // REFACTORIZADO

        Console.WriteLine("Anécdotas Andrés Mathías Marcano");

        var nameSon2 = "Andres Mathías Marcano";
        var ageSon2 = 10;
        var ProfessionSon2 = "Estudiar";
        var FavoriteSportSon2 = "Todavía no tiene un deporte favorito";
        var HobbiesOneSon2 = "Ver Televisión";
        var HobbiesTwonSon2 = " y Jugar Video Juegos";
        var AllHobbiesSon2 = HobbiesOneSon2 + HobbiesTwonSon2;
        var FavoriteFoodSon2 = "Hamburguesas y papas fritas";
        var BornCountrySon2 = "Venezuela";
        var Son2History = $@" Les presentó a otra personita muy especial su nombre es {nameSon2}, es mi segundo hijo jajajaja, tiene {ageSon2} años, le fascina {ProfessionSon2}, por los momentos {FavoriteSportSon2}.
Para distraerse le encante {AllHobbiesSon2}, su comida preferida es {FavoriteFoodSon2}, mi chamo nació en {BornCountrySon2}.";

Console.WriteLine(Son2History); // REFACTORIZADO

        Console.WriteLine("Anécdotas Dianita");

        var nameDaughter = "Diana Isabella Lovera Martínez";
        var ageDaughter = 3;
        var ProfessionDaughter = "Ir al Maternal";
        var FavoriteSportDaughter = "Quedarse en casa";
        var HobbiesDaughter = "Comer y ver televisión";
        var FavoriteFoodDaughter = "Arroz con Camarones";
        var BornCountryDaughter = "Venezuela";
        var DaughterHistory = $@"Bueno la tremendura se llama {nameDaughter}, es mi tercera hija y tiene mi carácter jajaja, tiene {ageDaughter} años, su oficio es {ProfessionDaughter}, el país de mi hija es {BornCountryDaughter}.
Dianita prefiere {FavoriteSportDaughter}, para {HobbiesDaughter}, aunque su comida preferida {FavoriteFoodDaughter}.";

Console.WriteLine(DaughterHistory); // REFACTORIZADO

    }

}

public class Daniela

{
    static void Main(string[] args)

    {
        Console.WriteLine("Anécdotas Perlita");

        var namePerlita = "Daniela Alejandra Martínez Sánchez";
        var agePerlita = 40;
        var ProfessionPerlita = "Ingeniera en Sistemas";
        var HobbiesPerlita = "Películas y Series";
        var FavoriteFoodPerlita = "Cochino Frito";
        var BornCountryPerlita = "Venezuela";
        var PerlitaHistory = $@" Esta señorita es mi esposita, se llama {namePerlita}, apodo Perlita Divina jajaja, tiene {agePerlita} años , se graduó como {ProfessionPerlita}, disfruta ver {HobbiesPerlita} pero que no sean de Terror.
Pero lo más importante es que le gusta comer {FavoriteFoodPerlita} y sobre todo mi perla divina nació en {BornCountryPerlita}";

        Console.WriteLine(PerlitaHistory); // REFACTORIZADO
    }
}

public class Jeimy

{
    static void Main(string[] args)

    {
        Console.WriteLine("Anécdotas Jeicito");

        var nameJeicito = "Jeimy Rafael Lovera Dahuas";
        var ageJeicito = 37;
        var ProfessionJeicito = "Consultor de Tecnología";
        var HobbiesOneJeicito = "Lectura";
        var HobbiesTwoJeicito = "Aprender a Programar en C#";
        var FavoriteFoodJeicito = "Sushi";
        var BornCountryJeicito = "Venezuela";
        var JeicitoHistory = $@"Para finalizar este blog, mi nombre es {nameJeicito}, tengo {ageJeicito} años, trabajo como {ProfessionJeicito}, en mi tiempo libre disfruto la {HobbiesOneJeicito} y {HobbiesTwoJeicito}.
Me encanta comer {FavoriteFoodJeicito} y nací en {BornCountryJeicito}";

        Console.WriteLine(JeicitoHistory); // REFACTORIZADO

    }


}


 */

#endregion








