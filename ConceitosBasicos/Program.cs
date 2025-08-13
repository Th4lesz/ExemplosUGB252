//Console.WriteLine("Informe seu nome: ");
//string nome = Console.ReadLine();
//Console.WriteLine("informe seu salário: ");
//decimal salario = decimal.Parse(Console.ReadLine());

//Console.WriteLine("seu nome é: " + nome);
//Console.WriteLine("seu salario é: " + salario);

//informe o valor do IRPF a ser pago de acordo com o salário informado. Utilize a tabela real de desconto de IRPF

Console.WriteLine("Informe seu salário: ");
decimal salario = decimal.Parse(Console.ReadLine());

if (salario <= 2259.20m)
    Console.WriteLine("você está isento do IRPF");

else if (salario >= 2259.21m && salario <= 2826.65m)
    Console.WriteLine("sua aliquota é de 7,5% do seu salário");

else if (salario >= 2826.66m && salario <= 3751.05m)
    Console.WriteLine("sua aliquota é de 15% do seu salário");

else if (salario >= 3751.06m && salario <= 4664.68m)
    Console.WriteLine("sua aliquota é de 22,5% do seu salário");


