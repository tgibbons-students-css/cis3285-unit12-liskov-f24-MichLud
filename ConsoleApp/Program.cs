using SubtypeCovariance;

class Program
{
    static void Main(string[] args)
    {

        IEntityRepository<Entity> entityRepository = new EntityRepository();
        IEntityRepository<User> userRepository = new UserRepository();
        Entity myEntity = entityRepository.GetByID(Guid.NewGuid());
        User myUser = userRepository.GetByID(Guid.NewGuid());

        myEntity.Name = "Tom";
        myUser.Name = "Jerry";
        Console.WriteLine("New entity ID: " + myEntity.ID.ToString());
        Console.WriteLine("New entity Name: " + myEntity.Name);
        Console.WriteLine("New user ID: " + myUser.ID.ToString());
        Console.WriteLine("New user Name: " + myUser.Name);

    }
}