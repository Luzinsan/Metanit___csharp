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


//____________________________________________________ТИПЫ ДАННЫХ_______________________________________________________
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




// ************************************************КОНСОЛЬНЫЙ ВВОД/ВЫВОД************************************************

// _______________________________________________________Ввод__________________________________________________________
string? some_string = Console.ReadLine(); // считывается именно строка
// Эхх, где же мой {int x; std::cin >> x;}// почему так громоздко(((
int some_int_value = Convert.ToInt32(Console.ReadLine()); // считывается строка и конвертируется в тип int
double some_double_value = Convert.ToDouble(Console.ReadLine()); // считывается строка и конвертируется в тип double
decimal some_decimal_value = Convert.ToDecimal(Console.ReadLine()); // считывается строка и конвертируется в тип decimal
// Важно учитывать вид разделителя между целой и дробной частью при вводе чисел с плавающей запятой
// Если локализация Россия/Германия...      - ',';
// если                США/Великобритания...- '.'.

// _______________________________________________________Вывод_________________________________________________________
// Вывод с переносом строки
string hello = "Привет мир";
Console.WriteLine(hello);
// Тоже самое, но без переноса строки
Console.Write(hello);
Console.WriteLine();

// ________________________________________Различные features и ухищрения с выводом_____________________________________
// Интерполяция - Знак '$' перед строкой - возможность в {} выводить значения переменных
Console.WriteLine($"Имя: {sname}");
// Подстановка значений с помощью placeholder - _берёт_ значения после строки и подставляет под _места_ с цифрами
// похоже на scanf() в Си
string name = "Tom";
int age = 34;
double height = 1.7;
Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age);

// +++++++++++++++++++++++++++++++++++++++++++АРИФМЕТИЧЕСКИЕ+ОПЕРАЦИИ+++++++++++++++++++++++++++++++++++++++++++++++++++
// Всё как обычно, но есть то, о чём следует помнить
double z_int_res = 10 / 4;        // результат равен 2, так как 10 - int и 4 - int
double z_double_res = 10.0 / 4.0; // результат равен 2.5

// префикный и постфиксный инкременты - вспомнить
int x1 = 2;
x1 = x1++ + ++x1; // x=6 {_2_ (x=3)  + _4_ (x=3+1)}

 // приоритет операций
int a0 = 3;
int b0 = 5;
int c0 = 40;
int d0 = c0---b0*a0;    // int d0 = (c0--)-(b0*a0);
Console.WriteLine($"a0={a0}  b0={b0}  c0={c0}  d0={d0}");

// Все арифметические операторы - левоассоциативные - выполняются слева направо, в случае совпадения приоритета
int x0 = 10 / 5 * 2; // int x0 = (10 / 5) * 2

//-----------------------------------------------ПОРАЗРЯДНЫЕ ОПЕРАЦИИ---------------------------------------------------
// Логические операции: &, |, ^(XOR), ~ ;    Сдвиговые операции: <<, >>
int x2 = 45; // Значение, которое надо зашифровать - в двоичной форме 101101
int key2 = 102; //Пусть это будет ключ - в двоичной форме 1100110
 
int encrypt = x2 ^ key2; //Результатом будет число 1001011 или 75
Console.WriteLine($"Зашифрованное число: {encrypt}") ;
 
int decrypt = encrypt ^ key2; // Результатом будет исходное число 45
Console.WriteLine($"Расшифрованное число: {decrypt}");

// Операции присваивания - низний приоритет - правоассоциативные: =, +=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=
a = b = c = 34 * 2 / 4; // 17
int a2 = 8;
int b2 = 6;
int c2 = a2 += b2 -= 5;    // c = (a += (b-=5)) = 9

//???????????????????????????????????????????ПРЕОБРАЗОВАНИЯ ТИПОВ ДАННЫХ????????????????????????????????????????????????
// Сужающие (narrowing) и расширяющие (widening) преобразования
// Явные (explicit) и неявные (implicit) преобразования (conversions)
// Явные: 
// byte -> short -> int -> long -> decimal
// int -> double
// short -> float -> double
// char -> int
// Потеря данных и ключевое слово checked
try // При использовании ключевого слова checked приложение выбрасывает исключение в случае переполнения
{
    int a3 = 33;
    int b3 = 600;
    byte c3 = checked((byte)(a3 + b3));
    Console.WriteLine(c3);
}
catch (OverflowException ex)
{
    Console.WriteLine(ex.Message);
}
// Условные выражения:
// Операции сравнения: ==, !=, <, >, <=, >= 
// Логические операции: |, &  - обычные     дизъюнкция и конъюнкция (В выражении z=x|y; будут вычисляться оба значения - x и y.)
//                     ||, && - укороченные дизъюнкция и конъюнкция (сначала вычисляется x, и если true, то y не вычисляется. Аналогично с конъюнкцией)

//::::::::::::::::::::::::::::::::::::::::::КОНСТРУКЦИЯ if..else и ТЕРНАРНАЯ ОПЕРАЦИЯ:::::::::::::::::::::::::::::::::::
// и всё как обычно, как в плюсах: условная конструкция
// if(first condition - bool) {first block} else if (second condition) {} else if... else {end block}
// тернарный оператор: (condition) ? (first expression) : (second expression)

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ЦИКЛЫ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
// циклы - управляющие конструкции: for(как обычно), foreach, while, do...while
// итерация - однократное выполнение блока цикла
// альтернативное использование, как пример:
var iii = 1;
for (Console.WriteLine("Начало выполнения цикла"); iii < 4; Console.WriteLine($"i = {iii}"))
    iii++;
// или
for (int i = 1, j = 1; i < 10; i++, j++)
    Console.WriteLine($"{i * j}");
// цикл do...while - гарантирует хотя бы единократное выполнение
// цикл while - сразу проверяет условие
// цикл foreach - перебор набора или коллекции элементов
//foreach(data_type variable in collection)
//{
//     cycle actions
//}
foreach(char symbol in "Tom")// или var
{
    Console.WriteLine(symbol);
}
// break - exit the loop without waiting for it to complete
// continue - skip the current iteration and go to the next one