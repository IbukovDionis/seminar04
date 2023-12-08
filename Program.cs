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
    static void Main(){
        Console.Clear();
        Zadanie01();
        Zadanie02();
    }
}