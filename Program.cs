using System;
public class Seminar04 {
    static void Zadanie01(){
        Console.WriteLine("Программа бесконечно запрашивает числа с консолию. \nПрограмма завершается при вводе символа 'q' или при вводе числа, \nсумма цифр которого чётная.");
        
        Console.Write("Введите число: ");
        string a = Console.ReadLine();
        int n = 0;
        
        while (a != "q") {
            
            
            if (int.TryParse(a,out n)){
                n = int.Parse(a);
            }
            int summ = 0;
            for (int i=0; i <= a.Length; i++){
                summ += n%10;
                n = n / 10;
            }
            
            if (summ%2 == 0) {
                Console.WriteLine("Сумма цифр четно!");
                break;
            }
            
            Console.Write("Введите число: ");
            a = Console.ReadLine();
            
        }
        Console.WriteLine("Завершение прграммы!");
    }            
    static void Zadanie02(){
        Console.WriteLine("Алгоритм заполняет массив слуяайными числами \nи выводит количество чётных чисел в массиве.");
        
        Console.Write("Введите количество элементов массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] Array = new int[n];
        Random R = new Random();

        for (int i = 0; i < n; i++){
            Array[i] = R.Next(100,1000);
        }
        int k=0;
        Console.Write("Пулученный массив: [");
        for (int i = 0; i < n-1; i++) {
            Console.Write(Array[i]+", ");
            if (Array[i]%2==0) k++;
        }
        Console.WriteLine(Array[n-1]+"]");
        Console.WriteLine($"В массиве {k} чётных чисел.");
        
    }


    
    static void Main(){
        Console.Clear();
        // Zadanie01();
        // Console.Write("Нажмите любую клавишу, чтобы перейти ко второму заданию...");
        // Console.ReadLine();
        // Console.Clear();
        // Zadanie02();
        // Console.Write("Нажмите любую клавишу, чтобы перейти ко второму заданию...");
        // Console.ReadLine();
        // Console.Clear();
        
    }
}