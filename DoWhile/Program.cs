

Console.Write("Bir limit değeri giriniz:");
int limit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("While döngüsü sonucu:");

int i = 1;
while (i <= limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    i++;
}


Console.WriteLine("Do-While döngüsü sonucu:");

int j = 1;
do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    j++;
}while (j <= limit);

//while döngüsü döngü bloğundaki işlemleri gerçekleştirmeden önce koşulu kontrol eder. Eğer koşul baştan sağlanmıyorsa döngü hiç çalışmaz.

//do -while döngüsü ise önce döngü içindeki işlemleri bir kez çalıştırır, ardından koşulu kontrol eder. Bu yüzden koşul en başta yanlış olsa bile döngü en az bir kere çalışır.
