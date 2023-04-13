using System;

class Program {

public static void Main (string[] args) {
    Program chamaFuncao = new Program();
    chamaFuncao.CombustivelIdeal();
    string respostauser;
    Console.WriteLine("Deseja fazer um novo cálculo?");
   respostauser=Console.ReadLine();
   while(respostauser.Equals("Sim")){
     chamaFuncao.CombustivelIdeal();
     Console.WriteLine("Deseja fazer um novo cálculo?");
     respostauser=Console.ReadLine();
   }
 }
  
public void CombustivelIdeal(){
  double gasolina, etanol,valor; 
  Console.WriteLine("Informe o preço da gasolina"); 
 gasolina=double.Parse(Console.ReadLine()); 
 Console.WriteLine("Digite o preço do etanol"); 
 etanol=double.Parse(Console.ReadLine()); 
 valor = etanol / gasolina; 
 if(valor>0.7){ 
 Console.WriteLine("O combustível mais vantajoso para abastecer é a gasolina"); 
 } 
 else if(valor<0.7){ 
Console.WriteLine("O combustível mais vantajoso para abastecer é o etanol");
} 
else{ 
Console.WriteLine("Tanto faz o combustível");
}
} 
  
}