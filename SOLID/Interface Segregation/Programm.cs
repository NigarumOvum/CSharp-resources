
public class SaleService : IBasicActions<Sale>
{
    public void Add(Sale entity)
    {
        Console.WriteLine("Creamos la venta");
    }
    public Sale Get(int id) => new Sale();
    public List<Sale> GetList() => new List<Sale>();
}
public class UserService : IBasicActions<User>, IEditableAction<User>
{
    public void Add(User entity)
    {
        Console.WriteLine("Creamos el usuario");
    }
    public void Delete(User entity)
    {
        Console.WriteLine("Borramos el usuario");
    }
    public User Get(int Id)
    {
        Console.WriteLine("Obtenemos el usuario");
        return new User();

    }
}

// from one interface create two segregated interfaces
public interface IBasicActions<T>
{
    public T Get(int id);
    public List<T> Getlist();
    public void Add(T entity);
}

public interface IEditableAction<T>
{
    public void Update(T entity);
    public void Delete(T entity);
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

}

public class Sale
{
    public decimal amount { get; set; }
    public DateTime Date { get; set; }
}