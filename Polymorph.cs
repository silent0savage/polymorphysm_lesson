
using System.Runtime.CompilerServices;

public abstract class Brain {
    public abstract void Think();

    public void ShowInfo() {
        Console.WriteLine(GetType().Name);
    }
}

class Memory : Brain {
    public override void Think() {
        Console.WriteLine("Вспомнил!");
    }
}

class Cerebrum: Brain {
    public override void Think()
    {
        Console.WriteLine("Придумал!");
    }
}

class Cerebellum: Brain {
    public override void Think()
    {
        Console.WriteLine("Я отвечаю за осанку, равновесие и многое другое!");
    }
}

class Person { // полиморфизм
    public void Think(Brain brain) {
        brain.Think();
    }

    public void CheckInfo(Brain brain) {
        brain.ShowInfo();
    }
}

class Program {
    static void Main(string[] args) 
    {
        Person person = new Person();
        /*Memory memory = new Memory();
        person.Think(memory);*/

        Brain[] regions = {new Memory(), new Cerebrum(), new Cerebellum()};

        foreach (var item in regions) {
            person.CheckInfo(item);
            person.Think(item);
            Console.WriteLine();
        }
    
    }
}
