namespace CRUDMongo.models;

public class MovieDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string MoviesCollectionName { get; set; } = null!;
}