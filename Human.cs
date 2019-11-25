namespace human
{
    public class Human
    {
        public string name {get; set;}
        public int strength {get; set;} = 3;
        public int intelligence {get; set;} = 3;
        public int dexterity {get; set;} = 3;
        private int health {get; set;} = 100;
    

    public Human(string name)
    {
        this.name = name;
    }
    
    public Human(string name, int strength, int intelligence, int dexterity, int health)
    {
        this.name = name;
        this.strength = strength;
        this.intelligence = intelligence;
        this.dexterity = dexterity;
        this.health = health;
    }

    public int ShowHealth
    {
        get
        {
            return health;
        }
    }
    public void Attack(Human enemy)
    {
        enemy.health -= 5 * strength;
    }

    }
}