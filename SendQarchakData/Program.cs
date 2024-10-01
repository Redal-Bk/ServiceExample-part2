using SendQarchakData.Entities;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Text;
class Program
{   

    //Main Thred
    static async Task Main()
    {

        Console.WriteLine("Sending Items Is Proccecing...");
        await SendDataAsync();
        await Finish();
        
    }


    //Getting Access Token 
    public static async Task<string> GetTokenAsync()
    {
       
        HttpClient _httpClient = new HttpClient();   
       

       
        var url = "http://sjapi.irtusan.ir";
        var jsoncontent = new Input
        {
            username = "WsUserGharchak",
            password = "hZ?&fL284e19",
            wstoken  = "kKzaQgjcwNSeiasRlOdompVlVQmqTlJg"
        };
        var jsonOBJ = JsonConvert.SerializeObject(jsoncontent);
        var requestbody = new StringContent(jsonOBJ, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(url, requestbody);

        if(response.IsSuccessStatusCode)
        {
            Console.WriteLine("Connection Successfull From GetTokenAsync");
            var result = await response.Content.ReadAsStringAsync();
            var access_token = result;
            Console.WriteLine(access_token);
            return access_token;
            

        }
        return "T";   
    }

    //Get Import Token
    public static async Task<string> GetImportToken()
    {   
        HttpClient _httpClient = new HttpClient();
        var url = "http://sjapi.irtusan.ir/api/Receive/GenerateImportToken";
        var Token = await GetTokenAsync();
        Console.WriteLine(Token);
        var req = new HttpRequestMessage(HttpMethod.Post, url);
        req.Headers.Add("Authorization" , "Bearer " + Token.ToString());
        var bodyRequest = new
        {
            organizationId = 1
        };
        var jsonOBJ = JsonConvert.SerializeObject(bodyRequest);
        req.Content = new StringContent(jsonOBJ,Encoding.UTF8, "application/json");
        var response = await _httpClient.SendAsync(req);
        if(response.IsSuccessStatusCode)
        {
            Console.WriteLine("Connection Successfull From GetImportToken");
            var result = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Import Token Is : " + result);
            return result;
        }
        return "T";
    }

    //Send Items To Service
    public static async Task<string> SendDataAsync()
    {
        TaxitaniQarchakContext _context = new TaxitaniQarchakContext();
        HttpClient _httpClient = new HttpClient();
        var url = "http://sjapi.irtusan.ir/api/Receive/Import";
        var req = new HttpRequestMessage(HttpMethod.Post, url);
        var ListOfInformation = await _context.VetehadieJameTables.ToListAsync();
        Console.WriteLine("The Number Of Items Is : " +  ListOfInformation.Count);
        var access_token = await GetImportToken();
        if (string.IsNullOrEmpty(access_token) || access_token == "T" || string.IsNullOrWhiteSpace(access_token))
        {
            return "Token NotFound";
        }
        var jsonContent =  JsonConvert.SerializeObject(ListOfInformation);
        req.Headers.Add("Authorization", "Bearer " + access_token);
        req.Content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
        var response = await _httpClient.SendAsync(req);
        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadAsStringAsync();
            Console.WriteLine("List Of Items Sent Succesfull!!");
            return result;
        }
        return "T";


    }

    //Finish Oparation
    public static async Task<string> Finish()
    {   
        HttpClient _httpClient = new HttpClient();
        var access_token = await GetTokenAsync();
        var Token = await GetImportToken();
        var url = "http://sjapi.irtusan.ir/api/Receive/FinishImport";
        var req = new HttpRequestMessage(HttpMethod.Put, url);
        var jsonbody = new
        {
            organizationId = 0,
            importToken = ""
        };
        var jsonOBJ = JsonConvert.SerializeObject(jsonbody);

        var response = await _httpClient.SendAsync(req);

        if (response.IsSuccessStatusCode)
        {
            return "Succesfull Oparation";
        }
        return "T";
    }
        
}