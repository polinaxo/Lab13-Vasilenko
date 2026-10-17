// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader() {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("Дата формирования отчёта: 17.10.2026");
//     Console.WriteLine("0_0");
// }

// void PrintFooter() {
//     Console.WriteLine(">_<");
//     Console.WriteLine("Конец программы");
//     Console.WriteLine("X_X");
// }


// void PrintStudentCard(string name, int age, string group) {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, группа: {group}");
// }

// PrintStudentCard("Erop", 18, "ИСП-251");
// PrintStudentCard("Валерия", 17, "ИСП-252");

// double CalculateScholarship(double baseAmount, double bonusPercent) {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }

// bool IsEligibleForBonus(double averageGrade) {
//     return averageGrade >= 4.5;
// }

// double baseAmount = 2000;
// double bonusPercent = 15;
// double averageGrade = 4.7;

// if (IsEligibleForBonus(averageGrade)) {
//     double result = CalculateScholarship(baseAmount, bonusPercent);
//     Console.WriteLine($"Стипендия с надбавкой: {result}");
// } else {
//     Console.WriteLine($"Базовая стипендия: {baseAmount}");
// }


// double CalculateAverageGrade(int[] grades) {
//     int sum = 0;
//     foreach (int grade in grades) {
//         sum += grade;
//     }
//     return (double)sum / grades.Length;
// }

// int CountFives(int[] grades) {
//     int count = 0;
//     foreach (int grade in grades) {
//         if (grade == 5) {
//             count++;
//         }
//     }
//     return count;
// }

// int[] grades = { 4, 5, 3, 5, 4 };
// double average = CalculateAverageGrade(grades);
// int fivesCount = CountFives(grades);

// Console.WriteLine($"Средний балл: {average}");
// Console.WriteLine($"Количество пятёрок: {fivesCount}");


// void PrintGreeting() {
//     Console.WriteLine("^");
//     Console.WriteLine("Добро пожаловать!");
// }

// PrintGreeting();
// PrintGreeting();


// void PrintGreeting(string userName) {
//     Console.WriteLine($"Добро пожаловать, {userName}!");
// }

// PrintGreeting("Ярослав");
// PrintGreeting("Дмитрий");


// int Add(int a, int b) {
//     return a + b;
// }

// int result = Add(5, 3);
// Console.WriteLine(result);


// int SumArray(int[] numbers) {
//     int total = 0;
//     foreach (int number in numbers) {
//         total += number;
//     }
//     return total;
// }

// int[] values = { 10, 20, 30 };
// int sum = SumArray(values);
// Console.WriteLine(sum);




//Самост задания А и Б

// void PrintDivider() {
//     Console.WriteLine("-------------");
// }

// Console.WriteLine("Начало программы");
// PrintDivider();
// Console.WriteLine("Середина программы");
// PrintDivider();
// Console.WriteLine("Конец программы");
// PrintDivider();


// void PrintPerson(string name, int age) {
//     Console.WriteLine($"Имя: {name}");
//     Console.WriteLine($"Возраст: {age} лет");
// }

// PrintPerson("Анна", 25);
// PrintPerson("Михаил", 30);


// Console.Write("Введите свою фамилию: "); 
// string surname = Console.ReadLine()!.Trim(); 
// if (string.IsNullOrEmpty(surname)) { 
// Console.WriteLine("Фамилия не введена. Завершение работы."); 
// return; 
// } 
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
// var assigned = Enumerable.Range(1, 10) 
// .OrderBy(_ => rnd.Next()) 
// .Take(2) 
// .OrderBy(x => x) 
// .ToList(); 
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}"); 

//Инд вар номер 2 и 6
//2

double CalculateArea(double width, double height) {
    return width * height;
}

double width = 5.5;
double height = 3.2;
double area = CalculateArea(width, height);
Console.WriteLine($"Площадь прямоугольника: {area}");

//6
int CountVowels(string word) {
    string vowels = "ауоыиэяюёеАУОЫИЭЯЮЁЕ";
    int count = 0;
    foreach (char c in word) {
        if (vowels.Contains(c)) {
            count++;
        }
    }
    return count;
}

string word = "программирование";
int vowelsCount = CountVowels(word);
Console.WriteLine($"В слове '{word}' найдено {vowelsCount} гласных букв");