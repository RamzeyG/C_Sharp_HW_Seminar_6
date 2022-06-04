// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//y = k1 * x + b1
//y = k2 * x + b2
//y - y = k1*x-k2*x + b1-b2
//0 = (k1-k2)*x + b1-b2
//(b2-b1)/(k1-k2)=x

double k1 = 0;
double b1 = 0;
double k2 = 0;
double b2 = 0;
void IntersectionPoint(){
    
    void Input(){
        try{
            Console.WriteLine("Введите значение переменной k1");
            k1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной b1");
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной k2");
            k2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной b2");
            b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2}");
        }
        catch{
            Console.WriteLine("Вы ввели не число, пожалуйста повторно введите данные.");
            Input();
        
        }
                
    }
    
    Input();
    
    Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2}");
    
    double x = (b2 - b1)/(k1-k2);
    double y1 = k1*x + b1;
    //double y2 = k2*x + b2;
    if (k1 != k2){
        Console.WriteLine($"Точка пересечения прямых имеет координаты: x = {x}, y = {y1}");
        
    }
    else if (k1 == k2 & b1==b2){
        Console.WriteLine("Прямые имеют множество точек пересечения, так как они совпадают");
    }
    else if(k1 == k2){
        Console.WriteLine("Прямые не имеют точек пересечения, так как они параллельны");
    }
    
    
}

IntersectionPoint();


