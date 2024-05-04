using tasks;
/* ATIVIDADE 1

double N1 = Convert.ToDouble(Console.ReadLine());
double N2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(AtSoma.soma(N1, N2));
*/

/* ATIVIDADE 2

double N1 = Convert.ToDouble(Console.ReadLine());
AtPrimo.pegaPrimo(N1);
*/

/* ATIVIDADE 3

double N1 = Convert.ToDouble(Console.ReadLine());
double N2 = Convert.ToDouble(Console.ReadLine());
double N3 = Convert.ToDouble(Console.ReadLine());
AtMax.Max(N1, N2, N3);
*/

/* ATIVIDADE 4

double N1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(AtFato.Fat(N1));
*/

double[] notas = new double[20]{0, 1, 1.5, 2, 2.5, 3, 3.5, 4, 4.5, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10};
double l = 0, e = 0, m = 0;
for(int n = 0; n < notas.Length; n++){
    if(notas[n] > 6){m++; Console.WriteLine("Nota: "+notas[n]+"   (ACIMA DA MÉDIA)");}
    else if(notas[n] < 6){l++; Console.WriteLine("Nota: "+notas[n]+"   (MENOR DO QUE A MÉDIA)");}
    else{e++;  Console.WriteLine("Nota: "+notas[n]+"   (NA MÉDIA!)");}
    }
Console.WriteLine("\n\nNotas maiores do que 6: {0}\nNotas iguais a 6: {1}\nNotas menores do que 6: {2}",m,e,l);