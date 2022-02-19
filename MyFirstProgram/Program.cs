// See https://aka.ms/new-console-template for more information

Console.WriteLine(true); // Вывод True
Console.WriteLine(0b10011); // binary form
Console.WriteLine(0xA72);   // hex form

// вещественное число с фиксированной запятой (дробная часть отделяется от целой точкой)
Console.WriteLine(5.64);
// экспоненциальная форма.
Console.WriteLine(3.2e-1); //  MEp: M - мантисса (значимая часть); E(или e) - тоже самое, что и 10^; p - порядок возведения (10^)

// управляющие последовательности: '\n', '\t', '\\'
Console.WriteLine('\\');
// символы таблицы ASCII https://www.asciitable.com/
Console.WriteLine("Символы таблицы ASCII");
for (int i = 0; i < 127; i++)
    Console.Write((char)i);
Console.WriteLine();
Console.WriteLine('\x2A');    // *

// символы таблицы Unicode https://unicode-table.com/ru/
Console.WriteLine("Символы таблицы Unicode");
for (int i = 0; i < 127; i++)
    Console.Write((char)i);
Console.WriteLine();
Console.WriteLine('\u002A');    // *

Console.WriteLine("\nЕсли внутри строки необходимо вывести двойную кавычку, то такая \"внутренняя кавычка\" предваряется обратным слешем");


//                                                      ____________ТИПЫ ДАННЫХ____________
// Логические литералы.  Системны тип System.Boolean
bool alive = true;
bool isDead = false;
// Системный тип тоже можно указывать, он эквивалентен привычному типу. Например:
System.Boolean sys_alive = true;
// Как unsigned char в С++ - занимает 1 байт. System.Byte
byte bit1 = 0;
byte bit2 = 255;
// Как signed char в C++ - тоже 1 байт. System.SByte
sbyte sbit1 = -128;
sbyte sbit2 = 127;
// занимает 2 байта. System.Int16
short sshort1 = -32768;
short sshort2 = 32767;
// System.UInt16
ushort usshort = 0;
ushort usshort2 = 65535;
// 4 байта. System.Int32 - все целочисленные литералы
int from = -2147483648;
int to = 2147483647;
// System.UInt32. Суффикс - U/u
uint ufrom = 0u;
uint uto = 4294967295U;
// 8 байт. System.Int64. Суффикс - L/l
long lfrom = -9223372036854775808L;
long lto = 9223372036854775807l; // -> Лучше юзать L - читабильнее
// System.UInt64. Суффикс - UL/ul
ulong ulfrom = 0UL;
ulong ulto = 18446744073709551615ul;
// 4 байта. System.Single. Суффикс - F/f
float ffrom = -3.4e38F;
float fto = 3.4e38f;
// 8 байт. System.Double
double dfrom = -5.0e-324;
double dto = 1.7e308;
// 16 байт. Хранит 28 знаков после запятой. System.Decimal. Суффикс - M/m
decimal decfrom = -1.0e-28M;
decimal decto = 7.9228e28m;
// 2 байта. Кодировка Unicode. System.Char - Символьные литералы
char cfrom = (char)0;
char cto = (char)65535;
// Хранит набор символов Unicode. System.String - Строковые литералы
string sname = "Tom";
// '?' - позволяет хранить null
string? null_name = null; // типо ничего не считано
// Хранит значение любого типа данных. 4 байта (32-х разрядная), 8 байт (64-разрядная).
// System.Object - базовый для всех других типов и классов .NET
object a = 22;
object b = 3.14;
object c = "hello code";

// Неявная типизация - компилятор сам определяет тип данных исходя из присвоенного значения
// -> доступна только инициализация;
// -> нельзя инициализировать null'ом.
var some_value = "Something in Hebrew"; // string
var some_other_meaning = 465ul; // ulong




// ************************************************КОНСОЛЬНЫЙ ВВОД/ВЫВОД***************************************

// _______________________________________________________Ввод__________________________________________________
string? some_string = Console.ReadLine(); // считывается именно строка
// Эхх, где же мой {int x; std::cin >> x;}// почему так громоздко(((
int some_int_value = Convert.ToInt32(Console.ReadLine()); // считывается строка и конвертируется в тип int
double some_double_value = Convert.ToDouble(Console.ReadLine()); // считывается строка и конвертируется в тип double
decimal some_decimal_value = Convert.ToDecimal(Console.ReadLine()); // считывается строка и конвертируется в тип decimal
// Важно учитывать вид разделителя между целой и дробной частью при вводе чисел с плавающей запятой
// Если локализация Россия/Германия...      - ',';
// если                США/Великобритания...- '.'.

// _______________________________________________________Вывод_________________________________________________
// Вывод с переносом строки
string hello = "Привет мир";
Console.WriteLine(hello);
// Тоже самое, но без переноса строки
Console.Write(hello);
Console.WriteLine();

// ________________________________________Различные features и ухищрения с выводом______________________________
// Интерполяция - Знак '$' перед строкой - возможность в {} выводить значения переменных
Console.WriteLine($"Имя: {sname}");
// Подстановка значений с помощью placeholder - _берёт_ значения после строки и подставляет под _места_ с цифрами
// похоже на scanf() в Си
string name = "Tom";
int age = 34;
double height = 1.7;
Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age);

// +++++++++++++++++++++++++++++++++++++++++++АРИФМЕТИЧЕСКИЕ+ОПЕРАЦИИ++++++++++++++++++++++++++++++++++++++++++++
// Всё как обычно, но есть то, о чём следует помнить
double z_int_res = 10 / 4;        // результат равен 2, так как 10 - int и 4 - int
double z_double_res = 10.0 / 4.0; // результат равен 2.5

