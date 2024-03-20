using project.dao;
using WindowsFormsApp3.entity;

namespace WindowsFormsApp3;

public class Service
{
    private static readonly string server = "localhost";
    private static readonly string database = "project";
    private static readonly string uid = "root";
    private static readonly string password = "root";
    private static readonly string connectionString = $"Server={server};Database={database};Uid={uid};Pwd={password};";

    public void addUser(string login, string password)
    {
        var userDao = new UserDao(connectionString);
        userDao.AddUser(login, Service.password);
    }

    public User findUserByLogin(string login)
    {
        var userDao = new UserDao(connectionString);
        return userDao.GetUserByLogin(login);
    }

    public void addProduct(Product product)
    {
        ProductDao productDao = new ProductDao(connectionString);
        productDao.AddProduct(product);
    }
}