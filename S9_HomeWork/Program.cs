/* 
1. Показать натуральные числа от 1 до N, N задано
2. Показать натуральные числа от N до 1, N задано
3. Показать натуральные числа от M до N, N и M заданы
4. Найти сумму элементов от M до N, N и M заданы
5. Найти сумму цифр числа
6. Написать программу вычисления функции Аккермана
7. Написать программу возведения числа А в целую стень B
8. Написать программу показывающие первые N чисел, для которых каждое следующее
равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем */

internal class Program
{
  private static void Main(string[] args)
  {
    int Proverca_chisla(string text)
    {
      System.Console.Write(text);
      int num;
      while (true)
        if (int.TryParse(System.Console.ReadLine(), out num))
          return num;                                                   // обработка при успехе и выход из цикла
        else                                                         // обработка при ошибке
        {
          System.Console.WriteLine("[ERROR]: Некоректные данные по пробуйте еще раз!");
          System.Console.Write("Введите число: ");
        }
    }

  /*  //Создание одномерного массива с случайными числами
    int[] CreateMass1d(int n, int min, int max)
    {
      int[] Matrix = new int[n];
      for (int i = 0; i < Matrix.Length; i++)
        Matrix[i] = new Random().Next(min, max);
      return Matrix;
    }
    //Создание двухмерного массива с случайными числами
    int[,] CreateMass2d(int strok, int stolbtsov, int min, int max)
    {
      int[,] Matrix = new int[stolbtsov, strok];
      for (int i = 0; i < Matrix.GetLength(0); i++)
        for (int j = 0; j < Matrix.GetLength(1); j++)
          Matrix[i, j] = new Random().Next(min, max);
      return Matrix;
    }*/

    //Печать одномерного массива
    void PrintMass1d(int[] Matrix)
    {
      for (int i = 0; i < Matrix.GetLength(0); i++)
        System.Console.Write($"{Matrix[i]} ");
      System.Console.WriteLine();
    }
    //Печать двухмерного массива
   /* void PrintMass2d(int[,] Matrix)
    {
      for (int i = 0; i < Matrix.GetLength(0); i++)
      {
        for (int j = 0; j < Matrix.GetLength(1); j++)
          System.Console.Write($"{Matrix[i, j]} ");
        System.Console.WriteLine();
      }
    }*/

    ulong Akerman(ulong n, ulong m)
    {
      if (n == 0)
        return m + 1;
      else
        if ((n != 0) && (m == 0))
          return Akerman(n - 1, 1);
        else
          return Akerman(n - 1, Akerman(n, m - 1));
    }

    int answer1 = 0;
    string? answer2;
    do
    {
      do
      {
        System.Console.Clear();

        System.Console.WriteLine("Добрый день, прошу выбрать цифру из списка что Вы хотите сделать?");
        System.Console.WriteLine("__________");
        System.Console.WriteLine("1. Показать натуральные числа от 1 до N, N задано.");
        System.Console.WriteLine("2. Показать натуральные числа от N до 1, N задано.");
        System.Console.WriteLine("3. Показать натуральные числа от M до N, N и M заданы.");
        System.Console.WriteLine("4. Найти сумму элементов от M до N, N и M заданы.");
        System.Console.WriteLine("5. Найти сумму цифр числа.");
        System.Console.WriteLine("6. Написать программу вычисления функции Аккермана.");
        System.Console.WriteLine("7. Написать программу возведения числа А в целую стень B.");
        System.Console.WriteLine("8. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем.");
        System.Console.WriteLine(" ");
        answer1 = Proverca_chisla("Ваш ответ: ");

        if (answer1 > 8 ^ answer1 < 1)
        {
          System.Console.WriteLine("Такой задачи тут нету!");
          System.Console.Write("Нажмите <Enter> для повторго ввода... ");
          while (System.Console.ReadKey().Key != System.ConsoleKey.Enter) { }
        }

      } while (answer1 > 8 ^ answer1 < 1);

      System.Console.Clear();

      //Начало тела задач
      
      //1. Показать натуральные числа от 1 до N, N задано.
      if (answer1 == 1)
      {
        int n = Proverca_chisla("Введите до какого число вывести натуральные числа: ");
        for(int i=1;i<n;i++)
          System.Console.Write($"{i} ");
        System.Console.WriteLine("");
      }

      //2. Показать натуральные числа от N до 1, N задано.
      if (answer1 == 2)
      {
        int n = Proverca_chisla("Введите до какого число вывести натуральные числа: ");
        for(int i=n;i > 0;i--)
          System.Console.Write($"{i} ");
        System.Console.WriteLine("");
      }

      //3. Показать натуральные числа от M до N, N и M заданы.
      if (answer1 == 3)
      {
      int m = Proverca_chisla("Введите от какого число нужны вывести натуральные числа: ");
      int n = Proverca_chisla("Введите до какого число вывести натуральные числа: ");
      for(int i=m;i<n;i++)
          System.Console.Write($"{i} ");
        System.Console.WriteLine("");
      }

      //4. Найти сумму элементов от M до N, N и M заданы.
      if (answer1 == 4)
      {
      int m = Proverca_chisla("Введите от какого число нужны вывести натуральные числа: ");
      int n = Proverca_chisla("Введите до какого число вывести натуральные числа: ");
      int sum=0;
      for(int i=m;i<n;i++)
          sum+=i;
      System.Console.WriteLine($"Cумму элементов от M до N равна: {sum}.");
      }

      //5. Найти сумму цифр числа.
      if (answer1 == 5)
      {
        int chislo = Proverca_chisla("Введите число для определения суммы цифр числа: ");
          int sum = 0; 
          while (chislo > 0)
          {
            sum = sum + chislo % 10;
            chislo = chislo /10;
          }
        System.Console.WriteLine($"Cумму цифр числа: {sum}.");
      }

      //6. Написать программу вычисления функции Аккермана.
      if (answer1 == 6)
      {
        int n = Proverca_chisla("Введите число N: ");
        int m = Proverca_chisla("Введите число M: ");
        ulong result = Akerman(Convert.ToUInt64(n),Convert.ToUInt64(m));
        System.Console.WriteLine($"Функции Аккермана равна: {result}.");
      }

      //7. Написать программу возведения числа А в целую стень B.
      if (answer1 == 7)
      {
        int n = Proverca_chisla("Введите число для возведения в степень: ");
        int m = Proverca_chisla("Введите целую степнь: ");
        long kvadrat = 1;
        for(int i = 0; i < m; i++)
          kvadrat = kvadrat * n;
        System.Console.WriteLine($"Возведения числа {n} в степень: {kvadrat} .");
      }

      //8. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
      // Первые два элемента последовательности задаются пользователем.
      if (answer1 == 8)
      {
        int lenght = Proverca_chisla("Введите длинну: ");
        int n = Proverca_chisla("Введите первый элемент: ");
        int m = Proverca_chisla("Введите второй элемент: ");
        int [] maxtrix = new int [lenght];
        maxtrix[0]= n;
        maxtrix[1]= m;
        for(int i = 0; i < maxtrix.Length-2; i++)
          {
            maxtrix[i+2]= maxtrix[i]+ maxtrix[i+1];
          }
        PrintMass1d(maxtrix);
      }

      //Конец тела задач    
      System.Console.Write("Нажмите <Enter> для продолжения... ");
      while (System.Console.ReadKey().Key != System.ConsoleKey.Enter) { }

      do
      {
        System.Console.Clear();
        System.Console.WriteLine("Вы хотите воспользоваться еще одним решением? Yes/No");
        System.Console.WriteLine(" ");
        answer2 = System.Console.ReadLine();

        if (answer2 != "No" && answer2 != "no" && answer2 != "NO" && answer2 != "n" && answer2 != "N"
            && answer2 != "Yes" && answer2 != "yes" && answer2 != "YES" && answer2 != "y" && answer2 != "Y")
        {
          System.Console.WriteLine("Некоректный ответ");
          System.Console.Write(" Нажмите <Enter> для повторго ввода... ");
          while (System.Console.ReadKey().Key != System.ConsoleKey.Enter) { }
        }
      }
      while (answer2 != "No" && answer2 != "no" & answer2 != "NO" && answer2 != "n" && answer2 != "N"
            && answer2 != "Yes" && answer2 != "yes" && answer2 != "YES" && answer2 != "y" && answer2 != "Y");

    }
    while (answer2 != "No" & answer2 != "no" & answer2 != "NO" & answer2 != "n" & answer2 != "N");

    System.Console.Clear();

    System.Console.WriteLine("Спасибо, что воспользовались программой. Досвидание!!!");
    System.Console.Write("Нажмите <Enter> для выхода... ");
    while (System.Console.ReadKey().Key != System.ConsoleKey.Enter) { }

    System.Console.Clear();
  }
}