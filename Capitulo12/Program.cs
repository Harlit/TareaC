

 void factorial()

      {
         int count = 0, factorial = 1;
         Console.Write("Introduzca un Digito: ");
         int Digito = Convert.ToInt32(Console.ReadLine());
         for (int i = 1; i <= Digito; i++)
         {
            count = count + 1; 
            factorial = factorial + count;
         }
         Console.WriteLine($"El factorial de {Digito} es {factorial}");
      }
    
    
factorial();