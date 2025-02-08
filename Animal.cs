using System;

// Base class representing a generic animal
public class Animal {
    // Private member variables for encapsulation
    private string name;
    private int age;

    // Constructor to initialize an animal with name and age
    public Animal(string name, int age) {
        this.name = name;
        this.age = age;
    }

    // Getter method for name
    public string GetName() {
        return name;
    }

    // Setter method for name
    public void SetName(string name) {
        this.name = name;
    }

    // Getter method for age
    public int GetAge() {
        return age;
    }

    // Setter method for age
    public void SetAge(int age) {
        this.age = age;
    }

    // Method to be overridden by subclasses
    public virtual string MakeSound() {
        return "Animal makes a sound";
    }
}

// Dog class inheriting from Animal
public class Dog : Animal {
    // Constructor calling the parent constructor
    public Dog(string name, int age) : base(name, age) {
    }

    // Override makeSound method for Dog-specific behavior
    public override string MakeSound() {
        return "Dog barks: Woof! Woof!";
    }
}

// Cat class inheriting from Animal
public class Cat : Animal {
    // Constructor calling the parent constructor
    public Cat(string name, int age) : base(name, age) {
    }

    // Override makeSound method for Cat-specific behavior
    public override string MakeSound() {
        return "Cat meows: Meow!";
    }
}

// Bird class inheriting from Animal
public class Bird : Animal {
    // Constructor calling the parent constructor
    public Bird(string name, int age) : base(name, age) {
    }

    // Override makeSound method for Bird-specific behavior
    public override string MakeSound() {
        return "Bird chirps: Tweet! Tweet!";
    }
}

// Main class
public class Program {
    public static void Main(string[] args) {
        // Create instances of different animals
        Animal dog = new Dog("Buddy", 3);
        Animal cat = new Cat("Whiskers", 2);
        Animal bird = new Bird("Tweety", 1);

        // Demonstrate polymorphism
        Console.WriteLine(dog.GetName() + ": " + dog.MakeSound());
        Console.WriteLine(cat.GetName() + ": " + cat.MakeSound());
        Console.WriteLine(bird.GetName() + ": " + bird.MakeSound());
    }
}
