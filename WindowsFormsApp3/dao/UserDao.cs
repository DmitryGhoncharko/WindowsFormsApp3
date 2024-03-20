using System;
using MySql.Data.MySqlClient;
using WindowsFormsApp3.entity;

namespace project.dao;

public class UserDao
{
    private readonly string connectionString;

    public UserDao(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void AddUser(string userLogin, string userPassword)
    {
        using var connection = new MySqlConnection(connectionString);
        connection.Open();
        var sql = "INSERT INTO _user (user_login, user_password) VALUES (@UserLogin, @UserPassword)";
        using var command = new MySqlCommand(sql, connection);
        command.Parameters.AddWithValue("@UserLogin", userLogin);
        command.Parameters.AddWithValue("@UserPassword", userPassword);
        command.ExecuteNonQuery();
    }

    public User GetUserById(long userId)
    {
        using var connection = new MySqlConnection(connectionString);
        connection.Open();
        var sql = "SELECT * FROM _user WHERE user_id = @UserId";
        using var command = new MySqlCommand(sql, connection);
        command.Parameters.AddWithValue("@UserId", userId);
        using var reader = command.ExecuteReader();
        if (reader.Read())
            return new User
            {
                UserId = Convert.ToInt64(reader["user_id"]),
                UserLogin = reader["user_login"].ToString(),
                UserPassword = reader["user_password"].ToString()
            };
        return null;
    }

    public User GetUserByLogin(string userLogin)
    {
        using var connection = new MySqlConnection(connectionString);
        connection.Open();
        var sql = "SELECT * FROM _user WHERE user_login = @UserLogin";
        using var command = new MySqlCommand(sql, connection);
        command.Parameters.AddWithValue("@UserLogin", userLogin);
        using var reader = command.ExecuteReader();
        if (reader.Read())
            return new User
            {
                UserId = Convert.ToInt64(reader["user_id"]),
                UserLogin = reader["user_login"].ToString(),
                UserPassword = reader["user_password"].ToString()
            };
        return null;
    }
}