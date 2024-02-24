namespace WebBooks.Configurations;

public class DbSettings
{
    public string ConnectionString { get; set; } = null!;
    public string DatabaseName { get; set; } = null!;
    public string UserCollectionName { get; set; } = null!;
    public string ProductCollectionName { get; set; } = null!;
    public string OrderCollectionName { get; set; } = null!;
    public string CategoryCollectionName { get; set; } = null!;
}