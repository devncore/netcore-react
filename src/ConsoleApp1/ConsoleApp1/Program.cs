// See https://aka.ms/new-console-template for more information


public class test
{
    private static readonly HttpClient client = new HttpClient();
    [STAThread]
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        test1();
    }

    private static async void test1()
    {
        var values = new Dictionary<string, string>
        {
            { "thing1", "hello" },
            { "thing2", "world" }
        };

        try
        {
            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("https://localhost:7094/signin", content);

            var responseString = await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        { 
        
        }
    }
}