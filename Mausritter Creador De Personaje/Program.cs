
System.Random random = new Random();

int UnDeSeis()
{ 
    return random.Next(1, 6); 
}



string controladorDelSwitch = "si";

string nombreRaton = "";
int fuerza = 0;
int destreza = 0;
int voluntad = 0;
int puntosDeGolpe = 0;
int pepitas = 0;
string trasfondo = "";
string arma = "";
string signoDeNacimiento = "";
string pelajeColor = "";
string pelajePatron = ""; 
string rasgoFisico = "";


List<int> numeros_a_sumar = new List<int>();

List<int> puntos_para_atributos = new List<int>();

List<string> nombres_para_ratones = new List<string>
{
    "Ada", "Abril", "Abundio", "Acebo", "Ágata", "Ajenjo", "Aliso", "Amapola", "Ambrosio", "Anís",
    "Atilano", "Augusto", "Avellana", "Azafrán", "Basil", "Belladona", "Benigna", "Boletus", "Boniato",
    "Brandi", "Brezo", "Brie", "Caléndula", "Camembert", "Cardo", "Casilda", "Cayena", "Cebollino",
    "Céntola", "Cereza", "Cheddar", "Clarisa", "Coco", "Colín", "Colombo", "Comino", "Conrado", "Cucufato",
    "Curry", "Dalia", "Dedalera", "Edmundo", "Elsa", "Enebro", "Endrina", "Ero", "Esmeralda", "Estragón",
    "Fermín", "Feta", "Flora", "Francis", "Gallipierno", "Gil", "Ginkgo", "Gracia", "Gouda", "Gruyer",
    "Hipérico", "Horacio", "Iris", "Jacinto", "Jazmín", "Jerónima", "Laurel", "Lavanda", "Lentisco",
    "Limoncillo", "Lirio", "Lorenzo", "Macadamia", "Magnolia", "Mahón", "Margarita", "Martín", "Mate",
    "Mejorana", "Mirto", "Miso", "Nori", "Oliva", "Perla", "Picón", "Ricino", "Román", "Romanescu",
    "Roque", "Rufina", "Sauce", "Sándalo", "Saturnino", "Simón", "Shitake", "Stilton", "Tofu",
    "Valentina", "Valero", "Violeta", "Yuca", "Zoilo"
};

List<string> trasfondo_puntos_de_golpe_uno = new List<string>
{
    "\nSujeto de pruebas" + "\nHechizo: Proyectil mágico" + "\nChaleco de plomo (armad. pesada)\n",
    "\nForrajeador" + "\nEscudo y jubón (armad. ligera)" + "\nMenaje de cocina\n",
    "\nHabitante de las jaulas" + "\nHechizo: Comprensión" + "\nBotella de leche\n",
    "\nCurandero del arbusto" + "\nHechizo: Curar" + "\nIncienso\n",
    "\nCurtidor" + "\nEscudo y jubón (armad. ligera)" + "\nTijeras\n",
    "\nRatón callejero" + "\nDaga (ligera 1d6)" + "\nPetaca de café\n"
};

List<string> trasfondo_puntos_de_golpe_dos = new List<string> 
{
    "\nSacerdote mendicante" + "\nHechizo: Restaurar" + "\nSímbolo sagrado\n",
    "\nPastor de bichos" + "\nAyudante: Escarabajo fiel" + "\nPértiga 15 cm\n",
    "\nCervecero" + "\nAyudante: Portaantorchas borracho" + "\nBarril de cerveza pequeño\n",
    "\nPescador" + "\nRed" + "\nAguja (ligera 1d6)\n",
    "\nHerrero" + "\nMartillo (mediana 1d6 / 1d8)" + "\nLima de metal\n",
    "\nCableador" + "\nCable rollo" + "\nLinterna eléctrica\n"
};

List<string> trasfondo_puntos_de_golpe_tres = new List<string>
{
    "\nLeñador" + "\nHacha (mediana 1d6 / 1d8)" + "\nCordel rollo\n",
    "\nSectario del Murciélago" + "\nHechizo: Oscuridad" + "\nBolsa de dientes de murciélago\n",
    "\nMinero de latón" + "\nPico (mediana 1d6 / 1d8)" + "\nLinterna\n",
    "\nRecolector de basura" + "\nGancho para basura (pesada 1d10)" + "\nEspejo\n",
    "\nTrepamuros" + "\nAnzuelo" + "\nHilo bobina\n",
    "\nMercader" + "\nAyudante: Rata montera" + "\nPagaré de un ratón noble (20 p.)\n"
};

List<string> trasfondo_puntos_de_golpe_cuatro = new List<string>
{
    "\nBalsero" + "\nMartillo (mediana 1d6 / 1d8)" + "\nClavos de madera\n",
    "\nDomador de gusanos" + "\nPértiga 15 cm" + "\nJabón\n",
    "\nJinete de gorrión" + "\nAnzuelo" + "\nGafas protectoras\n",
    "\nGuía de alcantarillas" + "\nLima para metal" + "\nHilo bobina\n",
    "\nGuarda de prisión" + "\nCadena 15 cm" + "\nLanza (pesada 1d10)\n",
    "\nJardinero de hongos" + "\nHongos secos (como ración)" + "\nMáscara antiesporas\n"
};

List<string> trasfondo_puntos_de_golpe_cinco = new List<string>
{
    "\nConstructor de presa" + "\nPala" + "\nClavos de madera\n",
     "\nCartógrafo" + "\nPluma y tintero" + "\nBrújula\n",
     "\nLadrón trampero" + "\nCuña de queso" + "\nPegamento\n",
     "\nVagabundo" + "\nTienda" + "\nMapa del tesoro no fiable\n",
     "\nAgricultor de grano" + "\nHorca (pesada 1d10)" + "\nSilbato\n",
     "\nMensajero" + "\nSaco de dormir" + "\nDocumentos sellados\n"
};

List<string> trasfondo_puntos_de_golpe_seis = new List<string>
{
    "\nTrovador" + "\nInstrumento musical" + "\nKit de disfraz\n",
    "\nTahúr" + "\nJuego de dados trucados" + "\nEspejo\n",
    "\nExtractor de savia" + "\nCubo" + "\nClavos de madera\n",
    "\nApicultor" + "\nTarro de miel" + "\nRed\n",
    "\nBibliotecario" + "\nFragmento de libro oscuro" + "\nPluma y tintero\n",
    "\nNoble empobrecido" + "\nSombrero de fieltro" + "\nPerfume\n"
};

List<string> rasgos_signo_de_nacimiento = new List<string> 
{
    "La Estrella : Valiente y Descuidado",
    "La rueda: Diligente y Sin Imaginacion",
    "La Bellota: Inquisitivo y Cabezota",
    "La Tormenta: Generoso e Iracundo",
    "La Luna: Sabio y Misterioso",
    "La Madre: Protector y Preocupado"
};

List<string> rasgos_pelajes_color = new List<string> 
{
    "Chocolate",
    "Negro",
    "Blacno",
    "Pardo",
    "Gris",
    "Azul"
};

List<string> rasgos_pelajes_patron = new List<string> 
{
    "Solido",
    "Manchas grandes",
    "Cabeza y cuerpo distinto color",
    "A rayas",
    "Moteado",
    "Calvo, solo pelusilla"
};

List<string> rasgos_fisicos = new List<string> 
{
    "Cicatrices",
    "Corpulento",
    "Esqueletico",
    "Esbelto",
    "Diminuto",
    "Enorme",
    "Puntura de guerra",
    "Ropajes extranjeros",
    "Ropajes elegantes",
    "Ropajes remendados",
    "Ropajes de moda",
    "Ropajes sucios",
    "Oreja amputada",
    "Rostro abultado",
    "Rostro hermoso",
    "Rostro redondeado",
    "Rostro delicado",
    "Rostro alargado",
    "Pelaje cuidado",
    "Rastas",
    "Pelaje teñido",
    "Pelaje afeitado",
    "Pelaje encrespado",
    "Pelaje sedoso",
    "Ojos negros intensos",
    "Parche en el ojo",
    "Ojos rojo sangre",
    "Mirada sabia",
    "Mirada aguda",
    "Ojos luminosos",
    "Cola recortada",
    "Cola fina",
    "Cola anudada",
    "Cola rechoncha",
    "Cola prensil",
    "Cola rizada"
};

List<string> arma_inicial = new List<string>
{
    "\nTipo: Improvisadas\n" +
    "1D6\n" +
    "Lugar: Pata principal/Dos patas\n" +
    "Especial: Siempre marca una casilla tras cada combate\n" +
    "Precio: n/a",

    "\nTipo: Ligeras\n" +
    "Daño: 1D6\n" +
    "Lugar: Pata principal/Pata secundaria\n" +
    "Especial: Si atacas con dos armas, tira ambos dados y usa el mejor resultado.\n" +
    "Precio: 10p",

    "\nTipo: Medianas\n"+
    "Daño: 1D6/1D8\n"+
    "Lugar: Pata principal/Dos patas\n"+
    "Especial: Hace 1D6 de daño con una pata y 1D8 si se usa con dos patas.\n" +
    "Precio: 20p\n",

    "\nTipo: Pesadas\n"+
    "Daño: 1D10\n"+
    "Lugar: Dos Patas\n" +
    "Especial: no\n"+
    "Precio: 40p\n",

    "\nTipo: A distancia ligera\n"+
    "Daño: 1D6\n"+
    "Lugar: Pata principal\n"+
    "Precio: 10p\n" +
    "Necesita y viene con: Bolsa con piedras\n" +
    "Especial: Usa espacio de cuerpo\n"+
    "Precio: 1p\n",

    "\nTipo: A distancia, pesadas\n"+
    "Daño: 1D8\n"+
    "Lugar: Dos patas\n"+
    "Precio: 40p\n" +
    "Necesita y viene con: Carcaj con flechas\n" +
    "Especial: Usa espacio de cuerpo\n" +
    "Precio: 5p\n",

};

void Nombre()
{
    nombreRaton = nombres_para_ratones[random.Next(0,(nombres_para_ratones.Count-1))];
};

void Mostrar()
{
    Console.WriteLine($"\nel nombre de su raton es {nombreRaton}\n" +
        $"Sus atributos son:\n" +
        $"Puntos de golpe {puntosDeGolpe}\n" +
        $"Pepitas: {pepitas}\n" +
        $"FUE: {fuerza}\n" +
        $"DES: {destreza}\n" +
        $"VOL: {voluntad}\n" +
        $"Equipo inicial:\n" +
        $"■Antorchas\n" +
        $"■Raciones de viajes\n" +
        $"■Arma:\n" +
        $"{arma}" +
        $"Trasfondo y objetos extra por trasfondo:\n" +
        $"{trasfondo}\n" +
        $"Tiene un pelaje de color {pelajeColor} y un patron de {pelajePatron}\n" +
        $"Tiene un rasgo fisico que es: {rasgoFisico}\n" +
        $"Su signo de nacimiento es: {signoDeNacimiento}\n");
};

void ArmaInicial()
{
    arma = arma_inicial[random.Next(0,(arma_inicial.Count-1))];
};

void ResultadoTresDeSeis()
{
    for(int i = 1; i <= 3; i++)
    {
        numeros_a_sumar.Add(UnDeSeis());
        numeros_a_sumar.Add(UnDeSeis());
        numeros_a_sumar.Add(UnDeSeis());

        numeros_a_sumar.Sort();

        puntos_para_atributos.Add(numeros_a_sumar[1] + numeros_a_sumar[2]);
        numeros_a_sumar.Clear();
    }
   
}

void AsignacionDeAtributos()
{

    fuerza = puntos_para_atributos[0];
    destreza = puntos_para_atributos[1];
    voluntad = puntos_para_atributos[2];
    puntos_para_atributos.Clear();
}


void PuntosDeGolpeYPepitas()
{
    puntosDeGolpe = UnDeSeis();
    pepitas = UnDeSeis();
};

void Trasfondo()
{
    if (puntosDeGolpe == 1)
    {
        trasfondo = trasfondo_puntos_de_golpe_uno[UnDeSeis()];
    }
    else if (puntosDeGolpe == 2)
    {
        trasfondo = trasfondo_puntos_de_golpe_dos[UnDeSeis()];
    }
    else if (puntosDeGolpe == 3)
    {
        trasfondo = trasfondo_puntos_de_golpe_tres[UnDeSeis()];
    }    
    else if (puntosDeGolpe == 4)
    {
        trasfondo = trasfondo_puntos_de_golpe_cuatro[UnDeSeis()];
    }    
    else if (puntosDeGolpe == 5)
    {
        trasfondo = trasfondo_puntos_de_golpe_cinco[UnDeSeis()];
    }
    else
    {
        trasfondo = trasfondo_puntos_de_golpe_seis[UnDeSeis()];
    }
}

void Pelaje()
{
    pelajeColor = rasgos_pelajes_color[UnDeSeis()];
    pelajePatron = rasgos_pelajes_patron[UnDeSeis()];
};

void RasgoFisico()
{
    rasgoFisico = rasgos_fisicos[random.Next(0,(rasgos_fisicos.Count()-1))];
};

void SignoDeNacimiento()
{
    signoDeNacimiento = rasgos_signo_de_nacimiento[UnDeSeis()];
};

while (true)
{
    switch (controladorDelSwitch)
    {
        case "si":
            Console.WriteLine("Bienvenido al generado de ratones aleatorios para mouseritter\n" +
                "toque enter para continuar");
            Console.ReadLine();
            Nombre();
            ResultadoTresDeSeis();
            PuntosDeGolpeYPepitas();
            ArmaInicial();
            Trasfondo();
            Pelaje();
            RasgoFisico();
            SignoDeNacimiento();
            AsignacionDeAtributos();
            Mostrar();
            Console.WriteLine("Si desea crear otro personaje escriba si y enter <CUALQUIER OTRAS COSA QUE PONGA EN LA CONSOLA Y ENTER HARA QUE SE SALGA>");
            controladorDelSwitch = Console.ReadLine();
            break;

        default:
            Environment.Exit(0);
            break;




    }

        
}