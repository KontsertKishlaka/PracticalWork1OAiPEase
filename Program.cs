namespace PracticalWork1OAiPEase;

public class Program
{
    public static void Main(string[] args)
    {
        // Задание 0 (вычисления стороны и площади треугольника)
        double side, diagonal, area; // Сторона, Диагональ, Площадь

        Console.WriteLine("Введите площадь квадрата S: "); // Блок вычисления стороны и площади треугольника
        area = Convert.ToDouble(Console.ReadLine());

        side = Math.Round(Math.Sqrt(area), 2);
        diagonal = Math.Round((Math.Sqrt(2) * side), 2);

        Console.WriteLine($"Сторона квадрата равна: {side}");
        Console.WriteLine($"Диагональ квадрата равна: {diagonal}\n");



        // Задание 1 (Вычисления суммы двух чисел)
        double number1, number2; // 1-ое число, 2-ое число

        Console.WriteLine($"Введите 1-ое число: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Введите 2-ое число: ");
        number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Сумма двух чисел равна: {number1 + number2}\n");



        // Задание 2 (вычисления площади круга)
        double radius; // Радиус круга
        const double PI = 3.14; // Можно использовать Math.PI

        Console.WriteLine($"Введите радиус круга: ");
        radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Площадь круга равна: {PI * Math.Pow(radius, 2)}\n");



        // Задание 3 (вычисления температуры)
        double celsiusDegrees;

        Console.WriteLine($"Введите температура в градусах Цельсия: ");
        celsiusDegrees = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Температура в Фаренгейтах равна: {Math.Round(celsiusDegrees * (9f / 5f) + 32, 2)}\n");



        // Задание 4 (вычисления скидки)
        double productPrice, salePercent; // Цена товара, Процент скидки

        Console.WriteLine($"Введите стоимость товара: ");
        productPrice = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Введите процент скидки: ");
        salePercent = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Сумма скидки: {Math.Round(productPrice * (salePercent / 100), 2)}\n" +
            $"Итоговая сумма: {Math.Round(productPrice - (productPrice * (salePercent / 100)), 2)}\n");
    }
}