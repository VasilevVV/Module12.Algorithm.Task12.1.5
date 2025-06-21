namespace Module12;
/// <summary>
/// Пользователь
/// </summary>
public class User
{
    /// <summary>
    /// Логин пользователя
    /// </summary>
    public string Login { get; set; }
    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Имеется ли премиум-подписка. True - есть премиум-подписка.
    /// </summary>
    public bool IsPremium { get; set; }
}
