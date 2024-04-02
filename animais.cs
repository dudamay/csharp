using System;

public class Animal
{
    private string nome;
    private int idade;
 
    {
        this.nome = nome;
        this.idade = idade;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string novoNome)
    {
        nome = novoNome;
    }

    public int GetIdade()
    {
        return idade;
    }

    public void SetIdade(int novaIdade)
    {
        idade = novaIdade;
    }

    public virtual string FazerSom()
    {
        return "Som do animal";
    }
}

public class Cachorro : Animal
{
    public Cachorro(string nome, int idade) : base(nome, idade)
    {
    }

    public override string FazerSom()
    {
        return "Au au!";
    }
}

public class Gato : Animal
{
    public Gato(string nome, int idade) : base(nome, idade)
    {
    }

    public override string FazerSom()
    {
        return "Miau!";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cachorro cachorro = new Cachorro("Rex", 3);
        Gato gato = new Gato("Whiskers", 2);

        Console.WriteLine($"{cachorro.GetNome()} tem {cachorro.GetIdade()} anos e faz {cachorro.FazerSom()}");
        Console.WriteLine($"{gato.GetNome()} tem {gato.GetIdade()} anos e faz {gato.FazerSom()}");
    }
}