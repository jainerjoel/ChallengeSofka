//Challenge para obtar a entrar al traingin league de desarrollo de software de sofkaU.

//Jainer Joel Hernandez Sanclemente, 11/09/2021

using System;
using System.Collections.Generic;
using System.IO;

namespace ChallengeJoelHernandez
{
    class Program
    {
        static void Main(string[] arg)
        {
            string gameExit = "0";

            while (gameExit == "0")
            {
                //Se genera un array con todos los jugadores registrados
                string[] players = ReadFile();
                string[] playersNames = new string[players.Length];

                //Se genera un array con el nombre de los jugadores registrados
                for (int i = 0; i < players.Length; i++)
                {
                    int index = players[i].IndexOf(" ");
                    playersNames[i] = players[i].Substring(index + 1, players[i].Length - (index + 1));
                }

                ShowTable(players);

                //Constante que determina el numero de rondas
                const int rounds = 5;

                Jugador jugador = new Jugador();

                string userType;

                //Se crea un index para actualizar la lista al finalizar el juego
                int indexUser = 0;

                //Array con las diferentes categorias
                string[] categories = new string[5] { "Deportes", "Idiomas", "Geografía", "Farándula", "Ciencia" };

                //Crea un array para almacenar 5 preguntas.
                Question[] questions = new Question[5];

                //Se crea una puntiación inicial de 0
                int points = 0;

                //Crea un objeto de la clase Question para determinar la pregunta actual
                Question actualQuestion = new Question();

                //Crea una instancia de Function para acceder a los métodos de dicha clase.
                Function function = new Function();

                //Da la bienvenida al juego.
                function.SayHello();

                userType = function.SelectUser();

                //Sentencia para determinar el usuario
                if (userType == "0")
                {
                    function.SayHello2("anónimo");
                }
                else if (userType == "1")
                {
                    //Comprueba que el nombre de usuario no exista
                    while (true)
                    {
                        int valider = 0;
                        jugador = function.CreateUser();
                        foreach (string names in playersNames)
                        {
                            if (names == jugador.UserName)
                            {
                                valider = 1;
                            }
                        }

                        if (valider == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("El nombre de usuario ya existe. Intente otro nuevamente por favor\n");
                        }
                    }

                    function.SayHello2(jugador.UserName);
                }

                else
                {
                    //Comprueba que el usuario exista
                    while (true)
                    {
                        int valider = 0;
                        string actualName;
                        Console.WriteLine("\nDijite el nombre de usuario:");
                        actualName = Console.ReadLine();
                        for (int i = 0; i < playersNames.Length; i++)
                        {
                            if (playersNames[i] == actualName)
                            {
                                indexUser = i;
                                valider = 1;
                            }

                        }

                        if (valider == 1)
                        {
                            jugador = new Jugador();
                            jugador.Points = 0;
                            jugador.UserName = actualName;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("El nombre de usuario ingresado no existe... Inténtelo de nuevo");
                        }
                    }
                    function.SayHello2(jugador.UserName);
                }

                //Ciclo para generar las 5 rondas
                for (int i = 1; i <= rounds; i++)
                {
                    Console.WriteLine("\nRonda " + i + "\nCategoría: " + categories[i - 1] + "\n");

                    switch (i)
                    {
                        case 1:
                            //Asigna las preguntas del nivel 1 al arreglo questions
                            questions = function.CreateQuestionsLevel1();
                            break;
                        case 2:
                            //Asigna las preguntas del nivel 2 al arreglo questions
                            questions = function.CreateQuestionsLevel2();
                            break;
                        case 3:
                            //Asigna las preguntas del nivel 3 al arreglo questions
                            questions = function.CreateQuestionsLevel3();
                            break;
                        case 4:
                            //Asigna las preguntas del nivel 4 al arreglo questions
                            questions = function.CreateQuestionsLevel4();
                            break;
                        case 5:
                            //Asigna las preguntas del nivel 5 al arreglo questions
                            questions = function.CreateQuestionsLevel5();
                            break;
                    }


                    //Asigna una pregunta aleatoriamente del arreglo questions
                    actualQuestion = function.ChooseQuestion(questions);

                    //Imprime las Opciones
                    Console.WriteLine(actualQuestion.Enunciado + "\n");
                    Console.WriteLine("a : " + actualQuestion.OptionA);
                    Console.WriteLine("b : " + actualQuestion.OptionB);
                    Console.WriteLine("c : " + actualQuestion.OptionC);
                    Console.WriteLine("d : " + actualQuestion.OptionD);

                    Console.WriteLine("\nPuntos a ganar: " + actualQuestion.points);

                    //Pide la respuesta al usuario
                    Console.WriteLine("\nPor favor dijite su respues (a, b, c, d)");
                    string userAnswer = function.SelectAnswer();
                    Console.WriteLine("\n***********************************************************************************");

                    //Condición para validar respuesta
                    if (userAnswer == actualQuestion.TrueAnswer)
                    {
                        string desition;
                        Console.WriteLine("\nRespuesta correcta (+ " + actualQuestion.points + " puntos)");
                        points += actualQuestion.points;
                        Console.WriteLine("\nPuntos actuales = " + points);

                        if (i < rounds)
                        {
                            Console.WriteLine("\nDesea continuar o retirarse con los " + points + " puntos actuales?" +
                            "\n(0 = retirarse, 1 = continuar)");
                        }
                        else
                        {
                            Console.WriteLine("\nFelicidades! superó todas las rondas.");
                            if (userType == "1")
                            {
                                Console.Write("\nGracias por jugar... Su registro ha sido guardado\n");
                                jugador.Points = points;
                                function.RegisterUser(jugador);
                                players = ReadFile();
                                ShowTableUpdated(players, userType, 0);
                                gameExit = Console.ReadLine();
                            }
                            else if (userType == "2")
                            {
                                Console.Write("\nGracias por jugar... Su registro ha sido guardado\n");
                                jugador.Points = points;
                                players[indexUser] = jugador.Points.ToString() + " " + jugador.UserName;
                                function.UpdateUser(players);
                                players = ReadFile();
                                ShowTableUpdated(players, userType, indexUser);
                                gameExit = Console.ReadLine();
                            }
                            else
                            {
                                Console.Write("\nGracias por jugar...\n");
                                ShowTableUpdated(players, userType, indexUser);
                                gameExit = Console.ReadLine();
                            }
                            break;

                        }


                        //Se valida si el usuario quiere seguir o retirarse
                        while (true)
                        {
                            desition = Console.ReadLine();
                            if (desition == "0" || desition == "1")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Argumento invalido... Inténtelo nuevamente" +
                                    "\n(0 = retirarse, 1 = seguir)");
                            }
                        }
                        if (desition == "0")
                        {
                            if (userType == "1")
                            {
                                Console.Write("\nGracias por jugar... Su registro ha sido guardado\n");
                                jugador.Points = points;
                                function.RegisterUser(jugador);
                                players = ReadFile();
                                ShowTableUpdated(players, userType, 0);
                                gameExit = Console.ReadLine();
                            }
                            else if (userType == "2")
                            {
                                Console.Write("\nGracias por jugar... Su registro ha sido guardado\n");
                                jugador.Points = points;
                                players[indexUser] = jugador.Points.ToString() + " " + jugador.UserName;
                                function.UpdateUser(players);
                                players = ReadFile();
                                ShowTableUpdated(players, userType, indexUser);
                                gameExit = Console.ReadLine();
                            }
                            else
                            {
                                Console.Write("\nGracias por jugar...\n");
                                ShowTableUpdated(players, userType, indexUser);
                                gameExit = Console.ReadLine();
                            }
                            break;
                        }


                    }
                    else
                    {
                        Console.WriteLine("\nRespuesta inconrrecta... queda eliminado" +
                            "\nPierde todos los puntos");

                        if (userType == "1")
                        {
                            Console.Write("\nGracias por jugar... Su registro ha sido guardado\n");
                            jugador.Points = 0;
                            function.RegisterUser(jugador);
                            players = ReadFile();
                            ShowTableUpdated(players, userType, 0);
                            gameExit = Console.ReadLine();
                        }
                        else if (userType == "2")
                        {
                            Console.Write("\nGracias por jugar... Su registro ha sido guardado\n");
                            jugador.Points = 0;
                            players[indexUser] = jugador.Points.ToString() + " " + jugador.UserName;
                            function.UpdateUser(players);
                            players = ReadFile();
                            ShowTableUpdated(players, userType, indexUser);
                            gameExit = Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("\nGracias por jugar...\n");
                            ShowTableUpdated(players, userType, indexUser);
                            gameExit = Console.ReadLine();
                        }
                        break;
                    }

                    Console.WriteLine("\n***********************************************************************************");

                }

            }
        }
            

        static void ShowTable(string[] players)
        {
            int index;
            Console.WriteLine("\n------------------------");
            Console.WriteLine("| Registro de jugadres |" +
                "\n------------------------");
            for (int i = 0; i < players.Length; i++)
            {
                index = i + 1;
                Console.WriteLine(" " + players[i]);
            }
            Console.WriteLine("------------------------");

        }

        static void ShowTableUpdated(string[] players, string userType, int index)
        {
            if (userType != "0")
            {
                Console.WriteLine("\n------------------------");
                Console.WriteLine("| Registro de jugadres |" +
                    "\n------------------------");
                if (userType == "1")
                {
                    for (int i = 0; i < players.Length; i++)
                    {
                        if (i < players.Length - 1)
                        {
                            index = i + 1;
                            Console.WriteLine(" " + players[i]);
                        }
                        else
                        {
                            Console.WriteLine(" " + players[i] + " ------------------> Su registro!");
                        }

                    }
                    Console.WriteLine("------------------------");
                }
                else if (userType == "2")
                {
                    for (int i = 0; i < players.Length; i++)
                    {
                        if (i != index)
                        {
                            Console.WriteLine(" " + players[i]);
                        }
                        else
                        {
                            Console.WriteLine(" " + players[i] + " ------------------> Su registro!");
                        }

                    }
                    Console.WriteLine("------------------------");
                }
            }



            else
            {
                ShowTable(players);
                Console.WriteLine("\n El usuario anónimo no registra datos...");
            }
            Console.WriteLine("\nDijite 0 para reiniciar o un dijito diferente para salir.");

        }

        static string[] ReadFile()
        {
            return File.ReadAllLines("Historial.txt");
        }
        
    }
}
