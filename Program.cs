string[] a = new string[4];


string[] b = new string[4];

int c = 0;

for (int i = 0; i < a.Length; i++)
 {
    Console.WriteLine("введите строку");
    
    a[i] = Convert.ToString(Console.ReadLine());
    if (a[i].Length <= 3)
    {
        b[c] = a[i];
        c+=1;
    }
 }

Console.Write("[");
for (int i = 0; i < a.Length; i++)
 {
    Console.Write(a[i] + " ");
 }

Console.Write("] -> [");

for (int i = 0; i < b.Length; i++)
 {
    Console.Write(b[i] + " ");
 }

Console.Write("]");



