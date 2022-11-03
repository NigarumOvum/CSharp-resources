// Dependency Invertion allows our code to have Low-coupling
using System.Text.Json;

string origin = @"folder/path";
string dbPath = @"folder/path";

IInfo info = new InfoByRequest(origin);

Monitor monitor = new Monitor(origin, info);
await monitor.Show();

FileDB monitor = new FileDB(dbPath, origin, info);
await fileDB.Save();

public class Monitor
{
    private string _origin;
    private IInfo _info;
    public Monitor(string origin, IInfo info)
    {
        _origin = origin;
    }
    public async Task Show()
    {
        // We need to get rid of the next dependency that creates the Object inside Show()
        // InfoByFile info = new InfoByFile(_origin);
        var posts = await info.Get();
        foreach (var post in posts)
            Console.WriteLine(post.title);
    }

}
public class FileDB
{
    private string _path;
    private string _origin;
    private IInfo _info;

    public FileDB(string path, string origin)
    {
        _path = path;
        _origin = origin;
        _info = info;
    }

    public async Task Save()
    {
        // We need to get rid of the next dependency that creates the Object inside Show()
        // InfoByRequest info = new InfoByRequest(_origin);
        var posts = await _info.Get();
        string json = JsonSerializer.Serialize(posts);
        await File.WriteAllTextAsync(_path, json);
    }
}

public class InfoByFile : IInfo
{
    private string _path;
    public InfoByFile(string path)
    {
        _path = path;
    }

    public async Task<IEnumerable<Post>> Get()
    {
        var contentStream = new FileStream(_path, FileMode.Open, FileAccess.Read);
        IEnumerable<Post> posts =
        await JsonSerializer.DeserializeAsync<IEnumerable<Post>>(contentStream);
        return posts;
    }
}

public class InfoByRequest : IInfo
{
    private string _url;
    public InfoByRequest(string url)
    {
        _url = url;
    }

    public async Task<IEnumerable<Post>> Get()
    {
        HttpClient httpClient = new HttpClient();
        var response = await httpClient.GetAsync(_url);
        //Stream for async, String for sync
        var stream = await response.Content.ReadAsStreamAsync();

        List<Post> posts = await JsonSerializer.DeserializeAsync<IEnumerable<Post>>(stream);
        return posts;
    }
}
//
public interface IInfo
{
    public Task<IEnumerable<Post>> Get();
}

public class Post
{
    public Internal userId { get; set; }
    public Internal id { get; set; }
    public Internal title { get; set; }
    public Internal completed { get; set; }
}