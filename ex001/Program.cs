// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


void Func(){
    Console.WriteLine("Введите любое число. Или введите n для завершения программы");
    var a = Console.ReadLine();
    int count = 0;
    int count1 = 0;
    while(a != "n"){
        try{
            double b = Convert.ToDouble(a);
            count++;
            if(b > 0){
                count1++;
            }
            Console.WriteLine("Введите следущее число: ");
            a = Console.ReadLine();
        }
        catch{
            Console.WriteLine("Введите следущее число: ");
            a = Console.ReadLine();
        }
        
    
    }
    Console.WriteLine($"Пользователем введено {count} чисел. Из них {count1} больше нуля.");
    
    
    
    //while(a != "n")
    


}

Func();