int n, a;

Console.WriteLine("Digite quantos níveis vai ter o seu triângulo");
n = Convert.ToInt32(Console.ReadLine());
string[,] nivel = new string[n,n];
a = n - 1;

if (n < 3 || n > 8)
{
    Console.WriteLine("ERRO: Digite um valor entre 3 e 8");
}
else
{
    
    for(int l = 0; l < n; l++)
    {
        for(int c=0; c < n; c++)
        {
            if ( c >= a)
            {
                Console.Write( "#");
                
            }
            else
            {
                Console.Write(' ');
            }
            
        }
        a = a - 1;
        Console.WriteLine();
    }

}