int x = 100 / 50;
int sum1 = 100 + 50;
int sum2 = sum1 + 250;
int sum3 = sum2 + sum1;

sum3++;
sum3 = sum3 + 1;
sum3--;
sum3 = sum3 - 1;
x = 5;
x += 5;
x = x + 5;
x -= 5;
x = x - 5;
x *= 5;
x = x * 5;
x /= 5;
x = x / 5;


//if (!(x >= y))
//{
//}

//-6*x^3+5*x^2-10*x+15
int num = -6;
double xx = -6 * Math.Pow(num, 3) + 5 * Math.Pow(num, 2) - 10 * num + 15;
Console.WriteLine($"-6*x^3+5*x^2-10*x+15 = {xx}");

// Homework

double y = Math.Abs(num) * Math.Sin(num);
Console.WriteLine($"abs(num)*sin(num) = {y}");

double z = 2 * Math.PI * num;
Console.WriteLine($"2*pi*x = {z}");

int a = 5;
int b = -1;
int c = Math.Max(a, b);
Console.WriteLine($"Max({a},{b}) = {c}");

// Homework Extra

DateTime dateNow = DateTime.Now;
DateTime startYear = new DateTime(2022, 1, 1);
DateTime finishYear = new DateTime(2023, 1, 1);

TimeSpan datePassed = DateTime.Now - startYear;
TimeSpan dateLeft = finishYear - DateTime.Now;
Console.WriteLine($"{datePassed.Days} days left to New Year");
Console.WriteLine($"{dateLeft.Days} days passed from New Year");

//checked






