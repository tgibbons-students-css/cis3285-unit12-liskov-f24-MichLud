using SubtypeCovariance;

class Program
{
    static void Main(string[] args)
    {

        IEntityRepository<Entity> entityRepository = new EntityRepository();
        // IEntityRepository<User> entityRepository = new UserRepository();
        Entity myEntity = entityRepository.GetByID(Guid.NewGuid());

        myEntity.Name = "Tom";
        Console.WriteLine("New entity ID: " + myEntity.ID.ToString());
        Console.WriteLine("New entity Name: " + myEntity.Name);


    }
}