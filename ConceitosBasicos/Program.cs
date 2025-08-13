//Console.WriteLine("Informe seu nome: ");
//string nome = Console.ReadLine();
//Console.WriteLine("informe seu salário: ");
//decimal salario = decimal.Parse(Console.ReadLine());

//Console.WriteLine("seu nome é: " + nome);
//Console.WriteLine("seu salario é: " + salario);

//informe o valor do IRPF a ser pago de acordo com o salário informado. Utilize a tabela real de desconto de IRPF

Console.WriteLine("Informe seu salário: ");
decimal salario = decimal.Parse(Console.ReadLine());
var Calculo1 = salario * 0.075m;
var Calculo2 = salario * 0.15m;
var Calculo3 = salario * 0.225m;
var Calculo4 = salario * 0.275m;



if (salario <= 2259.20m)
    Console.WriteLine("você está isento do IRPF");

else if (salario >= 2259.21m && salario <= 2826.65m)
{
    Console.WriteLine($"você terá o valor de R${Calculo1} descontado do seu salário, referente aos 7,5% da alíquota, que ficará {salario} - {Calculo1}");
    var resultado_calculo1 = salario - Calculo1;
    Console.WriteLine($"seu salário líquido é {resultado_calculo1}");
}

else if (salario >= 2826.66m && salario <= 3751.05m)
{
    Console.WriteLine($"você terá o valor de R${Calculo2} descontado do seu salário, referente aos 15% da alíquota, que ficará {salario} - {Calculo2}");
    var resultado_calculo2 = salario - Calculo2;
    Console.WriteLine($"seu salário líquido é {resultado_calculo2}");
}

else if (salario >= 3751.06m && salario <= 4664.68m)
{
    Console.WriteLine($"Você terá o valor de R${Calculo3} descontado do seu salário, referente aos 22,5% da alíquota, que ficará {salario} - {Calculo3}");
    var resultado_calculo3 = salario - Calculo3;
    Console.WriteLine($"seu salário líquido é {resultado_calculo3}");
}

else
{ 
    Console.WriteLine($"Você terá o valor de {Calculo4} descontado do seu salário, referente aos 27,5% da alíquota, que ficará {salario} - {Calculo4}");
    var resultado_calculo4 = salario - Calculo4;
    Console.WriteLine($"seu salário líquido será {resultado_calculo4}");
}