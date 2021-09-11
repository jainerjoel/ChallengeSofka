using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ChallengeJoelHernandez
{
    //Crea una clase que contendrá los métodos para desarrollar el juego.
    class Function
    {

        public Question ChooseQuestion(Question[] questions)
        {
            var randomNumber = new Random();
            return questions[randomNumber.Next(0, 5)];
        }

        public Question[] CreateQuestionsLevel1()
        {
            Question[] questions = new Question[5];

            questions[0] = new Question();
            questions[0].Enunciado = "Con qué elemento se juega al futbol: ";
            questions[0].OptionA = "Raqueta";
            questions[0].OptionB = "Balón";
            questions[0].OptionC = "Bate";
            questions[0].OptionD = "Bastón";
            questions[0].TrueAnswer = "b";

            questions[1] = new Question();
            questions[1].Enunciado = "Cuál de los siguientes es un deporte de agua: ";
            questions[1].OptionA = "Futbol";
            questions[1].OptionB = "Baloncesto";
            questions[1].OptionC = "Boxeo";
            questions[1].OptionD = "Natación";
            questions[1].TrueAnswer = "d";

            questions[2] = new Question();
            questions[2].Enunciado = "Cuál de los siguientes no es un deporte: ";
            questions[2].OptionA = "Escritura";
            questions[2].OptionB = "Futbol";
            questions[2].OptionC = "Natación";
            questions[2].OptionD = "Tenis";
            questions[2].TrueAnswer = "a";

            questions[3] = new Question();
            questions[3].Enunciado = "Quién es el máximo goleador de la selección Colombia: ";
            questions[3].OptionA = "Hugo Rodallega";
            questions[3].OptionB = "Santos Borré";
            questions[3].OptionC = "Radamel Falcao";
            questions[3].OptionD = "David Ospina";
            questions[3].TrueAnswer = "c";

            questions[4] = new Question();
            questions[4].Enunciado = "Cuál es la selección con más mundiales ganados: ";
            questions[4].OptionA = "Colombia";
            questions[4].OptionB = "Brasil";
            questions[4].OptionC = "Alemania";
            questions[4].OptionD = "Francia";
            questions[4].TrueAnswer = "b";

            //Asigna los puntos que se obtienen al acertar
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i].points = 100;
            }

            return questions;

        }


        public Question[] CreateQuestionsLevel2()
        {
            Question[] questions = new Question[5];

            questions[0] = new Question();
            questions[0].Enunciado = "Cuál de los siguientes verbos es irregular: ";
            questions[0].OptionA = "Play";
            questions[0].OptionB = "Run";
            questions[0].OptionC = "Jump";
            questions[0].OptionD = "Like";
            questions[0].TrueAnswer = "b";

            questions[1] = new Question();
            questions[1].Enunciado = "Cuál es el pasado participio de draw: ";
            questions[1].OptionA = "drawn";
            questions[1].OptionB = "drew";
            questions[1].OptionC = "draw";
            questions[1].OptionD = "drewn";
            questions[1].TrueAnswer = "a";

            questions[2] = new Question();
            questions[2].Enunciado = "Cuál de los siguientes no es un verbo: ";
            questions[2].OptionA = "Love";
            questions[2].OptionB = "swim";
            questions[2].OptionC = "height";
            questions[2].OptionD = "boil";
            questions[2].TrueAnswer = "c";

            questions[3] = new Question();
            questions[3].Enunciado = "Cuál es el auxiliar que se utiliza para el pasado: ";
            questions[3].OptionA = "Will";
            questions[3].OptionB = "Do";
            questions[3].OptionC = "Can";
            questions[3].OptionD = "Did";
            questions[3].TrueAnswer = "d";

            questions[4] = new Question();
            questions[4].Enunciado = "Cuál es el pasado simple de forget: ";
            questions[4].OptionA = "Forgot";
            questions[4].OptionB = "Forgeted";
            questions[4].OptionC = "Forgotten";
            questions[4].OptionD = "Forget";
            questions[4].TrueAnswer = "a";

            //Asigna los puntos que se obtienen al acertar
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i].points = 300;
            }

            return questions;

        }

        public Question[] CreateQuestionsLevel3()
        {
            Question[] questions = new Question[5];

            questions[0] = new Question();
            questions[0].Enunciado = "Cuál es la capital de Bélgica: ";
            questions[0].OptionA = "Bruselas";
            questions[0].OptionB = "Pekín";
            questions[0].OptionC = "Ottawa";
            questions[0].OptionD = "Brasilia";
            questions[0].TrueAnswer = "a";

            questions[1] = new Question();
            questions[1].Enunciado = "Cuál es la capital de Canadá: ";
            questions[1].OptionA = "Ruanda";
            questions[1].OptionB = "Séul";
            questions[1].OptionC = "Ottawa";
            questions[1].OptionD = "Abu Dabi";
            questions[1].TrueAnswer = "c";

            questions[2] = new Question();
            questions[2].Enunciado = "Cuál es la capital de filipinas: ";
            questions[2].OptionA = "Dublín";
            questions[2].OptionB = "Tokyo";
            questions[2].OptionC = "Helsinki";
            questions[2].OptionD = "Manila";
            questions[2].TrueAnswer = "d";

            questions[3] = new Question();
            questions[3].Enunciado = "Cuál es la capital de Grecia: ";
            questions[3].OptionA = "Monaco";
            questions[3].OptionB = "Atenas";
            questions[3].OptionC = "Ottawa";
            questions[3].OptionD = "París";
            questions[3].TrueAnswer = "b";

            questions[4] = new Question();
            questions[4].Enunciado = "Cuál no es un departamento de Colombia: ";
            questions[4].OptionA = "Amazonas";
            questions[4].OptionB = "Valle del Cauca";
            questions[4].OptionC = "Tuluá";
            questions[4].OptionD = "Tolima";
            questions[4].TrueAnswer = "c";

            //Asigna los puntos que se obtienen al acertar
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i].points = 700;
            }

            return questions;

        }

        public Question[] CreateQuestionsLevel4()
        {
            Question[] questions = new Question[5];

            questions[0] = new Question();
            questions[0].Enunciado = "Familia que se volvió famosa por un reality: ";
            questions[0].OptionA = "Kardashian";
            questions[0].OptionB = "Obama";
            questions[0].OptionC = "Trump";
            questions[0].OptionD = "Smith";
            questions[0].TrueAnswer = "a";

            questions[1] = new Question();
            questions[1].Enunciado = "Quién es el esposo de Ricky Martin: ";
            questions[1].OptionA = "Jwan Yosef";
            questions[1].OptionB = "Juan Gabriel";
            questions[1].OptionC = "Maluma";
            questions[1].OptionD = "Elton John";
            questions[1].TrueAnswer = "a";

            questions[2] = new Question();
            questions[2].Enunciado = "Señorita Colombia amputada de una pierna: ";
            questions[2].OptionA = "Carolina Cruz";
            questions[2].OptionB = "Paola Turbay";
            questions[2].OptionC = "Vanessa Mendoza";
            questions[2].OptionD = "Daniella Álvarez";
            questions[2].TrueAnswer = "d";

            questions[3] = new Question();
            questions[3].Enunciado = "Cantante Colombiano que se casó con la hija de Montaner: ";
            questions[3].OptionA = "Carlos Vives";
            questions[3].OptionB = "J Balvin";
            questions[3].OptionC = "Camlo Echeverry";
            questions[3].OptionD = "Maluma";
            questions[3].TrueAnswer = "c";

            questions[4] = new Question();
            questions[4].Enunciado = "Pareja actual de Jlo: ";
            questions[4].OptionA = "Marc Antony";
            questions[4].OptionB = "Ben Afleck";
            questions[4].OptionC = "Alex Rodriguez";
            questions[4].OptionD = "Tommy Mottola";
            questions[4].TrueAnswer = "b";

            //Asigna los puntos que se obtienen al acertar
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i].points = 1500;
            }

            return questions;

        }

        public Question[] CreateQuestionsLevel5()
        {
            Question[] questions = new Question[5];

            questions[0] = new Question();
            questions[0].Enunciado = "Cuales son las leyes de Newton: ";
            questions[0].OptionA = "Ley de Hess, ley de avogadro";
            questions[0].OptionB = "Ley de inercia, ley de acción y reacción, ley de la dinámica";
            questions[0].OptionC = "Ley de atracción, ley de reacción, ley de elasticidad";
            questions[0].OptionD = "Ley de la cinemática, ley del magnetismo";
            questions[0].TrueAnswer = "b";

            questions[1] = new Question();
            questions[1].Enunciado = "Cuál es el elemento mas pequeño del átomo: ";
            questions[1].OptionA = "Protón";
            questions[1].OptionB = "Neutrón";
            questions[1].OptionC = "Electrón";
            questions[1].OptionD = "Quarks";
            questions[1].TrueAnswer = "d";

            questions[2] = new Question();
            questions[2].Enunciado = "Porceso por el cual las plantas capturan CO2 y liberan Oxígeno: ";
            questions[2].OptionA = "Fotosíntesis";
            questions[2].OptionB = "Mitosis";
            questions[2].OptionC = "Quimiosíntesis";
            questions[2].OptionD = "Telefase";
            questions[2].TrueAnswer = "a";

            questions[3] = new Question();
            questions[3].Enunciado = "Cuales son las fases de la mitosis: ";
            questions[3].OptionA = "Citoplasma, nucleo, ribosomas";
            questions[3].OptionB = "Útero, embrion, feto";
            questions[3].OptionC = "Profase, metafase, anafase, telofase";
            questions[3].OptionD = "Clorofila, fotosíntesis, meiosis";
            questions[3].TrueAnswer = "c";

            questions[4] = new Question();
            questions[4].Enunciado = "Cuál es el símbolo químico del Torio: ";
            questions[4].OptionA = "T";
            questions[4].OptionB = "Th";
            questions[4].OptionC = "Tr";
            questions[4].OptionD = "To";
            questions[4].TrueAnswer = "b";

            //Asigna los puntos que se obtienen al acertar
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i].points = 3400;
            }

            return questions;

        }


        public void SayHello()
        {
            Console.WriteLine("\nBienvenido al juego... \n\nPor favor digite 0 para jugar como anónimo," +
                " 1 para crear un nuevo usuario o 2 para jugar con un usuario existente");
        }

        public string SelectUser()
        {
            while (true)
            {
                //Lee la entrada de teclado (0, 1, 2)
                string userNumber = Console.ReadLine();

                //Comprueba que la entrada de teclado esté dentro del rango
                if (userNumber == "0" || userNumber == "1" || userNumber == "2")
                {
                    return userNumber;
                }
                else
                {
                    Console.WriteLine("Argumento inválido... inténtelo nuevamente por favor.\n" +
                            "(0 = usuario anónimo, 1 = nuevo usuario, 2 = usuario existente)");
                }
            }              
        }

        public string SelectAnswer()
        {
            while (true)
            {
                string answer = Console.ReadLine();
                if (answer == "a" || answer == "b" || answer == "c" || answer == "d")
                {
                    return answer;
                }
                else
                {
                    Console.WriteLine("Argumento inválido... inténtelo nuevamente por favor.\n" +
                        "(a, b, c, d)\n");
                }
            }
            
        }

        public void SayHello2(string usuario)
        {
            Console.WriteLine("\n***********************************************************************************");
            Console.WriteLine("\nHola " + usuario + ", tiene una oportunidad para responder todas las preguntas" +
                " y obtener el puntaje máximo o retirarse con el puntaje adquirido en cada nivel");
        }

        public void RegisterUser(Jugador jugador)
        {
            TextWriter writer = new StreamWriter("Historial.txt", true);
            writer.WriteLine( jugador.Points + " " + jugador.UserName);
            writer.Close();
        }

        public void UpdateUser(string[] players)
        {
            TextWriter writer = new StreamWriter("Historial.txt");
            foreach (string player in players)
            {
                writer.WriteLine(player);
            }
           
            writer.Close();
        }

        public Jugador CreateUser()
        {
            Console.WriteLine("Dijite el nombre de usuario (no debe contener espacios en blanco)");

            while (true)
            {
                string userName = Console.ReadLine();
                if (userName.Contains(" "))
                {
                    Console.WriteLine("El nombre de usuario no debe contener espacios..." +
                        "Inténtelo nuevamente por favor");
                }
                else
                {
                    Jugador jugador = new Jugador();
                    jugador.Points = 0;
                    jugador.UserName = userName;

                    return jugador;
                }
                 
            }
  
        }

    }


}
