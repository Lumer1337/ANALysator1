using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace _3sem_analisator
{
    public partial class SyntaxClassD
    {
        // Состояние автомата
        private enum States
        {
            S,
            A, A1, A2, 
            B,B5,
            D,
            M,
            N,N3,N4,//TEXT
            O,O1,O2,O3,O4,O5,O6,O7,O8,//FILE
            Q,
            F,
            Y0,T0,E0,
            H0,A0,R0,
            N0,T1,E1,G0,E2,R1,
            E3,A3,L0,
            O0,U0,B1,L1,E4,
            S0,I1,N1,L2,E5,
            T2,R3,I2,N2,G2, Z, X, X1, X2

        }

        // Текущее состояние автомата


        public static string Run(string s)
        {
            States states = States.S;
            s = s.ToUpper();
            int pos = 0;
            while (pos < s.Length)
            {
                switch (states)
                {
                    case States.S:           //Проверка на пробелы или V (VAR)
                        {
                            if (s[pos] == ' ')  //Проверка на пробелы
                            {
                                states = States.S;
                                pos++;
                            }
                            else if (s[pos] == 'V')   //Проверка на V (VAR)
                            {
                                states = States.A;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидались пробел или A", pos);
                        }
                        break;
                    case States.A:       //Проверка A (VAR)
                        {
                            if (s[pos] == 'A')
                            {
                                states = States.A1;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидалось A", pos);
                        }
                        break;
                    case States.A1:   //Проверка R (VAR)
                        {
                            if (s[pos] == 'R')
                            {
                                states = States.A2;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидалось R", pos);
                        }
                        break;
                    case States.A2:   //Проверка на пробел после VAR
                        {
                            if (s[pos] == ' ')
                            {
                                states = States.B;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался пробел", pos);
                        }
                        break;
                    case States.B:    //Проверка на пробелы или начала "идентификатор переменной"
                        {
                            if (s[pos] == ' ')   //Проверка на пробелы
                            {
                                states = States.B;
                                pos++;
                            }
                            //Проверка на начало "идентификатор переменной"
                            else if (s[pos] >= 'A' && s[pos] <= 'Z')   
                            {
                                states = States.B5;
                                pos++;
                            }
                            else if (s[pos] == '_')
                            {
                                states = States.B5;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидались символы A...Z||_ ", pos);
                        }
                        break;
                    case States.B5: //Проверка "идентификатор переменной" или пробел
                        {
                            if (s[pos] >= '0' && s[pos] <= '9')
                            {
                                states = States.B5;
                                pos++;
                            }
                            else if (s[pos] >= 'A' && s[pos] <= 'Z')
                            {
                                states = States.B5;
                                pos++;
                            }
                            else if (s[pos] == '_')
                            {
                                states = States.B5;
                                pos++;
                            }
                            else if (s[pos] == ' ')  //Проверка на пробел после "идентификатор переменной"
                            {
                                states = States.D;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидались символы 0...9||A...Z||_||пробел ", pos);
                        }
                        break;
                    case States.D: //Проверка на пробелы или двоеточие
                        {
                            if (s[pos] == ' ')   //Проверка на пробелы
                            {
                                states = States.D;
                                pos++;
                            }
                            else if (s[pos] == ':')  //Проверка на двоеточие
                            {
                                states = States.M;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидались пробел или :", pos);
                        }
                        break;
                    case States.M:         //Проверка на пробелы или "описание файла"
                        {
                            if (s[pos] == ' ')   //Проверка на пробелы
                            {
                                states = States.M;
                                pos++;
                            }
                            else if (s[pos] == 'T')          //Проверка T (TEXT)                                                        
                            {
                                states = States.N;
                                pos++;
                            }
                            else if (s[pos] == 'F')          //Проверка F (FILE)
                            {
                                states = States.O;
                                pos++;
                            }
                            else if (s[pos] == 'B')          //Проверка B (BYTE)
                            {
                                states = States.Y0;
                                pos++;
                            }
                            else if (s[pos] == 'R')          //Проверка R (REAL)
                            {
                                states = States.E3;
                                pos++;
                            }
                            else if (s[pos] == 'C')          //Проверка C (CHAR)
                            {
                                states = States.H0;
                                pos++;
                            }
                            else if (s[pos] == 'I')          //Проверка I (INTEGER)
                            {
                                states = States.N0;
                                pos++;
                            }
                            else if (s[pos] == 'D')          //Проверка D (DOUBLE)
                            {
                                states = States.O0;
                                pos++;
                            }
                            else if (s[pos] == 'S')          //Проверка S (SINGLE ИЛИ STRING)
                            {
                                states = States.S0;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался пробел||T||F||B||R||C||I||D||S", pos);
                        }
                        break;
                    //FILE___________________________________________________________________________________________________________
                    case States.O:          //Проверка I (FILE)
                        {
                            if (s[pos] == 'I')  
                            {
                                states = States.O1;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался I", pos);
                        }
                        break;
                    case States.O1:          //Проверка L (FILE)
                        {
                            if (s[pos] == 'L')
                            {
                                states = States.O2;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался L", pos);
                        }
                        break;
                    case States.O2:          //Проверка E (FILE)
                        {
                            if (s[pos] == 'E')
                            {
                                states = States.O3;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался E", pos);
                        }
                        break;
                    case States.O3:          //Проверка пробела после FILE, перед OF/////////////////////////////////////////////////////////////????????
                        {
                            if (s[pos] == ' ')
                            {
                                states = States.O4;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался пробел", pos);
                        }
                        break;
                    case States.O4:          //Проверка O (FILE OF)
                        {
                            if (s[pos] == 'O')
                            {
                                states = States.O5;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался O", pos);
                        }
                        break;
                    case States.O5:          //Проверка F (FILE OF)
                        {
                            if (s[pos] == 'F')
                            {
                                states = States.O8;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался F", pos);
                        }
                        break;
                    case States.O8:       //Проверка на пробел после FILE OF
                        {
                            if (s[pos] == ' ')
                            {
                                states = States.O6;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался пробел", pos);
                        }
                        break;
                    case States.O6:      //Проверка на пробелы или "тип" или "идентификатор"
                        {
                            if (s[pos] == ' ')   //Проверка на пробелы
                            {
                                states = States.O6;
                                pos++;
                            }
                            //Проверка "тип"
                            else if (s[pos] == 'B')   //Проверка B (BYTE)
                            {
                                states = States.Y0;
                                pos++;
                            }
                            else if (s[pos] == 'R')   //Проверка R (REAL)
                            {
                                states = States.E3;
                                pos++;
                            }
                            else if (s[pos] == 'C')   //Проверка C (CHAR)
                            {
                                states = States.H0;
                                pos++;
                            }
                            else if (s[pos] == 'I')   //Проверка I (INTEGER)
                            {
                                states = States.N0;
                                pos++;
                            }
                            else if (s[pos] == 'D')   //Проверка D (DOUBLE)
                            {
                                states = States.O0;
                                pos++;
                            }
                            else if (s[pos] == 'S')   //Проверка S (SINGLE ИЛИ STRING)
                            {
                                states = States.S0;
                                pos++;
                            }
                            //Проверка начала "идентификатор переменной"
                            else if (s[pos] >= 'A' && s[pos] <= 'Z')
                            {
                                states = States.O7;
                                pos++;
                            }
                            else if (s[pos] == '_')
                            {
                                states = States.O7;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался пробел||A...Z||_", pos);
                        }
                        break;
                    case States.O7://Проверка "идентификатор переменной"
                        {
                            if (s[pos] >= '0' && s[pos] <= '9')
                            {
                                states = States.O7;
                                pos++;
                            }
                            else if (s[pos] >= 'A' && s[pos] <= 'Z')
                            {
                                states = States.O7;
                                pos++;
                            }
                            else if (s[pos] == '_')
                            {
                                states = States.O7;
                                pos++;
                            }
                            else if (s[pos] == ';')
                            {
                                states = States.F;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался символ 0...9||A...Z||_||пробел ", pos);////
                        }
                        break;

                    //TEXT___________________________________________________________________________________________________________
                    case States.N:         //Проверка E (TEXT)
                        {
                            if (s[pos] == 'E')
                            {
                                states = States.N3;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался E", pos);
                        }
                        break;
                    case States.N3:         //Проверка X (TEXT)
                        {
                            if (s[pos] == 'X')
                            {
                                states = States.N4;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался X", pos);
                        }
                        break;
                    case States.N4:         //Проверка T (TEXT)
                        {
                            if (s[pos] == 'T')
                            {
                                states = States.Q;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался T", pos);
                        }
                        break;
                    //DOUBLE___________________________________________________________________________________________________________
                    case States.O0:         //Проверка O (DOUBLE)
                        {
                            if (s[pos] == 'O')
                            {
                                states = States.U0;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался O", pos);
                        }
                        break;
                    case States.U0:         //Проверка U (DOUBLE)
                        {
                            if (s[pos] == 'U')
                            {
                                states = States.B1;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался U", pos);
                        }
                        break;
                    case States.B1:         //Проверка B (DOUBLE)
                        {
                            if (s[pos] == 'B')
                            {
                                states = States.L1;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался B", pos);
                        }
                        break;
                    case States.L1:         //Проверка L (DOUBLE)
                        {
                            if (s[pos] == 'L')
                            {
                                states = States.E4;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался L", pos);
                        }
                        break;
                    case States.E4:         //Проверка E (DOUBLE)
                        {
                            if (s[pos] == 'E')
                            {
                                states = States.Q;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался E", pos);
                        }
                        break;
                    //REAL___________________________________________________________________________________________________________
                    case States.E3:         //Проверка E (REAL)
                        {
                            if (s[pos] == 'E')
                            {
                                states = States.A3;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался E", pos);
                        }
                        break;
                    case States.A3:         //Проверка A (REAL)
                        {
                            if (s[pos] == 'A')
                            {
                                states = States.L0;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался A", pos);
                        }
                        break;
                    case States.L0:         //Проверка L (REAL)
                        {
                            if (s[pos] == 'L')
                            {
                                states = States.Q;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался L", pos);
                        }
                        break;
                    //BYTE___________________________________________________________________________________________________________
                    case States.Y0:         //Проверка Y (BYTE)
                        {
                            if (s[pos] == 'Y')
                            {
                                states = States.T0;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался Y", pos);
                        }
                        break;

                    case States.T0:         //Проверка T (BYTE)
                        {
                            if (s[pos] == 'T')
                            {
                                states = States.E0;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался T", pos);
                        }
                        break;

                    case States.E0:         //Проверка E (BYTE)
                        {
                            if (s[pos] == 'E')
                            {
                                states = States.Q;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался E", pos);
                        }
                        break;
                    //CHAR_________________________________________________________________________________________________________________________________
                    case States.H0:         //Проверка H (CHAR)
                        {
                            if (s[pos] == 'H')
                            {
                                states = States.A0;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался H", pos);
                        }
                        break;
                    case States.A0:         //Проверка A (CHAR)
                        {
                            if (s[pos] == 'A')
                            {
                                states = States.R0;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался A", pos);
                        }
                        break;
                    case States.R0:         //Проверка R (CHAR)
                        {
                            if (s[pos] == 'R')
                            {
                                states = States.Q;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался R", pos);
                        }
                        break;
                    //INTEGER___________________________________________________________________________________________________________
                    case States.N0:         //Проверка N (INTEGER)
                        {
                            if (s[pos] == 'N')
                            {
                                states = States.T1;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался N", pos);
                        }
                        break;
                    case States.T1:         //Проверка T (INTEGER)
                        {
                            if (s[pos] == 'T')
                            {
                                states = States.E1;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался T", pos);
                        }
                        break;
                    case States.E1:         //Проверка E (INTEGER)
                        {
                            if (s[pos] == 'E')
                            {
                                states = States.G0;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался E", pos);
                        }
                        break;
                    case States.G0:         //Проверка G (INTEGER)
                        {
                            if (s[pos] == 'G')
                            {
                                states = States.E2;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался G", pos);
                        }
                        break;
                    case States.E2:         //Проверка E (INTEGER)
                        {
                            if (s[pos] == 'E')
                            {
                                states = States.R1;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался E", pos);
                        }
                        break;
                    case States.R1:         //Проверка R (INTEGER)
                        {
                            if (s[pos] == 'R')
                            {
                                states = States.Q;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался R", pos);
                        }
                        break;
                    //SINGLE OR STRING___________________________________________________________________________________________________________
                    case States.S0:         //Проверка T (STRING) ИЛИ I (SINGLE)
                        {
                            if (s[pos] == 'T') //Проверка T (STRING)
                            {
                                states = States.T2;
                                pos++;
                            }
                            else if (s[pos] == 'I')   //Проверка I (SINGLE)
                            {
                                states = States.I1;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидались T или I", pos);
                        }
                        break;
                    //SINGLE___________________________________________________________________________________________________________
                    case States.I1:         //Проверка N (SINGLE)
                        {
                            if (s[pos] == 'N')
                            {
                                states = States.N1;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался N", pos);
                        }
                        break;
                    case States.N1:         //Проверка G (SINGLE)
                        {
                            if (s[pos] == 'G')
                            {
                                states = States.L2;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался G", pos);
                        }
                        break;
                    case States.L2:         //Проверка L (SINGLE)
                        {
                            if (s[pos] == 'L')
                            {
                                states = States.E5;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался L", pos);
                        }
                        break;
                    case States.E5:         //Проверка E (SINGLE)
                        {
                            if (s[pos] == 'E')
                            {
                                states = States.Q;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался E", pos);
                        }
                        break;
                    //STRING [0...9]_______________________________________________________________________________________________________
                    case States.T2:         //Проверка R (STRING)
                        {
                            if (s[pos] == 'R')
                            {
                                states = States.R3;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался R", pos);
                        }
                        break;
                    case States.R3:         //Проверка I (STRING)
                        {
                            if (s[pos] == 'I')
                            {
                                states = States.I2;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался I", pos);
                        }
                        break;
                    case States.I2:         //Проверка N (STRING)
                        {
                            if (s[pos] == 'N')
                            {
                                states = States.N2;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался N", pos);
                        }
                        break;
                    case States.N2:         //Проверка G (STRING)
                        {
                            if (s[pos] == 'G')
                            {
                                states = States.Z;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался G", pos);
                        }
                        break;
                    case States.Z:
                        {
                            if (s[pos] == '[') 
                            {
                                states = States.X1;
                                pos++;
                            }
                            else if (s[pos] == ' ')
                            {
                                states = States.X;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался пробел", pos);
                        }
                        break;
                    case States.X:
                        {
                            if (s[pos] == ' ')
                            {
                                states = States.X;
                                pos++;
                            }
                            else if (s[pos] == ';')
                            {
                                states = States.F;
                                pos++;
                            }
                            else if (s[pos] == '[')
                            {
                                states = States.X1;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался [", pos);
                        }
                        break;
                    case States.X1:
                        {
                            if (s[pos] >= '1' && s[pos] <= '9')
                            {
                                states = States.X2;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался символ 1...9", pos);
                        }
                        break;
                    case States.X2:
                        {
                            if (s[pos] >= '0' && s[pos] <= '9')
                            {
                                states = States.X2;
                                pos++;
                            }
                            else if (s[pos] == ']')
                            {
                                states = States.Q;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался символ 0...9||]", pos);
                        }
                        break;

                    //состояние Q
                    case States.Q:
                        {
                            if (s[pos] == ';')
                            {
                                states = States.F;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался символ ;", pos);
                        }
                        break;
                    case States.F:
                        {
                            if (s[pos] == ' ')
                            {
                                states = States.B5;
                                pos++;
                            }
                            else if (s[pos] >= 'A' && s[pos] <= 'Z')
                            {
                                states = States.B5;
                                pos++;
                            }
                            else if (s[pos] == '_')
                            {
                                states = States.B5;
                                pos++;
                            }
                            else throw new ExceptionWithPosition("Ожидался символ ;||A...Z||_", pos);
                        }
                        break;

                }
            }
            if (states != States.F)
            {
                throw new ExceptionWithPosition("Неверная цепочка", pos);
            }
            string result = "Ошибок не обнаружено";
            return result;
        }
    }
}