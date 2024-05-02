using System;

// Definição da interface IAtacante
 interface IAtacante
{
    void Atacar();
}

// Definição da classe abstrata Heroi
public abstract class Heroi
{
    public abstract void Especial();


}

// Definição da classe Guerreiro
public class Guerreiro : IAtacante, Heroi
{
    public override void Especial();
    {
        Console.WriteLine("Guerreiro usando habilidade especial!");
    }

    public void Atacar();
    {
        Console.WriteLine("Guerreiro ataca com espada!");
    }
}

// Definição da classe Mago
public class Mago : IAtacante, Heroi
{
    
    public override void Especial();
    {
        Console.WriteLine("Mago usando habilidade especial!");
    }

    public  void Atacar();
    {
        Console.WriteLine("Mago lança um feitiço!");
    }
}

// Definição da classe Arqueiro
public class Arqueiro : IAtacante, Heroi
{
    public override void Especial();
    {
        Console.WriteLine("Arqueiro usando habilidade especial!");
    }

    public  void Atacar();
    {
        Console.WriteLine("Arqueiro dispara uma flecha!");
    }
}

class Program{
    static void Main(string[] args){
        Guerreiro guerreiro = new Guerreiro();
        guerreiro.Especial();
        guerreiro.Atacar();

        Mago mago = new Guerreiro();
        mago.Especial();

        Arqueiro arqueiro = new Arqueiro();
        arqueiro.Especial();

    }
}
