void fizzbuzz()
{
	
	Console.WriteLine("ingrese el numero hasta donde quieras que se realize el ejerccio");
	int a = Convert.ToInt32(Console.ReadLine());
	
	for (int i = 0; i <= a; i++)
	{
		if (i % 3 == 0)
		{
			if (i % 5 == 0)
			{
				Console.WriteLine("FizzBuzz");
			}
			else
			{
				Console.WriteLine("Fizz");
			}
		}
		else
		{
			if (i % 5 == 0)
			{
				Console.WriteLine("Buzz");
			}
			else
			{
				Console.WriteLine(i);
			}
		}
	}
}
fizzbuzz();
