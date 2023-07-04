// See https://aka.ms/new-console-template for more information
using CopyDataToJson;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using MongoDB.Driver;
using CopyDataToJson.Models;

Console.WriteLine("Hello, World!");

WebAlertsContext s = new WebAlertsContext();

int nbrPerfile = 5000;

//for (int i = 1344; i < s.Sources.Count()/1000; i++)
//{
//    var ss = s.Sources.Skip(i*1000).Take(1000).ToList();
//    string strJson = JsonSerializer.Serialize<List<Source>>(ss);
//    File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\source" + i+".json", strJson);  
//    Console.WriteLine("Source numero " + i);
//}

//for (int i = 0; i < s.MainSources.Count() / nbrPerfile; i++)
//{
//    var ss = s.MainSources.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
//    string strJson = JsonSerializer.Serialize<List<MainSource>>(ss);
//    File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\mainsources\\MainSources" + i + ".json", strJson);
//    Console.WriteLine("Source numero " + i);
//}

//for (int i = 0; i < s.SourceImages.Count() / nbrPerfile; i++)
//{
//    var ss = s.SourceImages.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
//    string strJson = JsonSerializer.Serialize<List<SourceImage>>(ss);
//    File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\SourcesImage\\SourcesImage" + i + ".json", strJson);
//    Console.WriteLine("Source numero " + i);
//}


void runArticleSelecteds()
{
    WebAlertsContext s = new WebAlertsContext();
    for (int i = 0; i < s.ArticleSelecteds.Count() / nbrPerfile; i++)
    {
        var ss = s.ArticleSelecteds.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<ArticleSelected>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\ArticleSelected\\ArticleSelecteds" + i + ".json", strJson);
        Console.WriteLine("ArticleSelecteds numero " + i);
    }
    s.Dispose();
}

void runArticleKeywords()
{
    WebAlertsContext s = new WebAlertsContext();
    for (int i = 0; i < s.ArticleKeywords.Count() / nbrPerfile; i++)
    {
        var ss = s.ArticleKeywords.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<ArticleKeyword>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\ArticleKeyword\\ArticleKeywords" + i + ".json", strJson);
        Console.WriteLine("ArticleKeywords numero " + i);
    }
    s.Dispose();
}

void runMedias()
{
    CopyDataToJson.Data.SourcesDbContext s = new CopyDataToJson.Data.SourcesDbContext();
    for (int i = 0; i < s.Media.Count() / nbrPerfile; i++)
    {
        var ss = s.Media.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<Medium>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\Media\\Medias" + i + ".json", strJson);
        Console.WriteLine("ArticleKeywords numero " + i);
    }
    s.Dispose();
}

void runContacts()
{
    SourcesDbContext s = new SourcesDbContext();
    for (int i = 0; i < s.Contacts.Count() / nbrPerfile; i++)
    {
        var ss = s.Contacts.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<Contact>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\Contact\\Contacts" + i + ".json", strJson);
        Console.WriteLine("Contact numero " + i);
    }
    s.Dispose();
}
void runMaplanguage()
{
    SourcesDbContext s = new SourcesDbContext();
    
    for (int i = 0; i < Math.Ceiling(((Decimal)s.MapLanguages.Count() / (Decimal)nbrPerfile)); i++)
    {
        var ss = s.MapLanguages.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<MapLanguage>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\MapLanguage\\MapLanguage" + i + ".json", strJson);
        Console.WriteLine("Contact numero " + i);
    }
    s.Dispose();
}

void runMapCountry()
{
    SourcesDbContext s = new SourcesDbContext();
    for (int i = 0; i < Math.Ceiling(((Decimal)s.MapCountries.Count() / (Decimal)nbrPerfile)); i++)
    {
        var ss = s.MapCountries.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<MapCountry>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\MapCountry\\MapCountry" + i + ".json", strJson);
        Console.WriteLine("Contact numero " + i);
    }
    s.Dispose();
}


void runArticleWordFounds()
{
    WebAlertsContext s = new WebAlertsContext();
    for (int i = 0; i < s.ArticleWordFounds.Count() / nbrPerfile; i++)
    {
        var ss = s.ArticleWordFounds.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<ArticleWordFound>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\ArticleWordFound\\ArticleWordFounds" + i + ".json", strJson);
        Console.WriteLine("ArticleWordFounds numero " + i);
    }
    s.Dispose();
}

void runProfilLock()
{
    WebAlertsContext s = new WebAlertsContext();
    double count = (double)s.ProfileLocks.Count() / (double)nbrPerfile;
    var ceil = Math.Ceiling(count);
    for (int i = 0; i < ceil; i++)
    {
        var ss = s.ProfileLocks.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<ProfileLock>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\ProfileLock\\ProfileLocks" + i + ".json", strJson);
        Console.WriteLine("ProfileLocks numero " + i);
    }
    s.Dispose();
}

void runProfilHistory()
{

    WebAlertsContext s = new WebAlertsContext();
    double count = (double)s.ProfileHistories.Count() / (double)nbrPerfile;
    var ceil = Math.Ceiling(count);
    for (int i = 0; i < ceil; i++)
    {
        var ss = s.ProfileHistories.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<ProfileHistory>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\ProfileHistory\\ProfileHistory" + i + ".json", strJson);
        Console.WriteLine("ProfileHistory numero " + i);
    }
    s.Dispose();
}

void runKeywordGroup()
{

    ProfileDbContext s = new ProfileDbContext();
    double count = (double)s.KeywordGroups.Count() / (double)nbrPerfile;
    var ceil = Math.Ceiling(count);
    for (int i = 0; i < ceil; i++)
    {
        var ss = s.KeywordGroups.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<KeywordGroup>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\KeywordGroup\\KeywordGroups" + i + ".json", strJson);
        Console.WriteLine("KeywordGroups numero " + i);
    }
    s.Dispose();
}

void runOrderSettings()
{

    ProfileDbContext s = new ProfileDbContext();
    double count = (double)s.OrderSettings.Count() / (double)nbrPerfile;
    var ceil = Math.Ceiling(count);
    for (int i = 0; i < ceil; i++)
    {
        var ss = s.OrderSettings.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<OrderSetting>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\OrderSetting\\OrderSettings" + i + ".json", strJson);
        Console.WriteLine("OrderSettings numero " + i);
    }
    s.Dispose();
}

void runKeywordLine()
{

    ProfileDbContext s = new ProfileDbContext();
    double count = (double)s.KeywordLines.Count() / (double)nbrPerfile;
    var ceil = Math.Ceiling(count);
    for (int i = 0; i < ceil; i++)
    {
        var ss = s.KeywordLines.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<KeywordLine>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\KeywordLine\\KeywordLines" + i + ".json", strJson);
        Console.WriteLine("KeywordLine numero " + i);
    }
    s.Dispose();
}

void runKeywordHits()
{

    ProfileDbContext s = new ProfileDbContext();
    double count = (double)s.KeywordHits.Count() / (double)nbrPerfile;
    var ceil = Math.Ceiling(count);
    for (int i = 0; i < ceil; i++)
    {
        var ss = s.KeywordHits.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<KeywordHit>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\KeywordHit\\KeywordHits" + i + ".json", strJson);
        Console.WriteLine("KeywordHit numero " + i);
    }
    s.Dispose();
}

void runKeywordDescription()
{

    ProfileDbContext s = new ProfileDbContext();
    double count = (double)s.KeywordDescriptions.Count() / (double)nbrPerfile;
    var ceil = Math.Ceiling(count);
    for (int i = 0; i < ceil; i++)
    {
        var ss = s.KeywordDescriptions.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<KeywordDescription>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\KeywordDescription\\KeywordDescriptions" + i + ".json", strJson);
        Console.WriteLine("KeywordDescriptions numero " + i);
    }
    s.Dispose();
}

void runOrderWebRubric()
{

    ProfileDbContext s = new ProfileDbContext();
    double count = (double)s.OrderWebRubrics.Count() / (double)nbrPerfile;
    var ceil = Math.Ceiling(count);
    for (int i = 0; i < ceil; i++)
    {
        var ss = s.OrderWebRubrics.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<OrderWebRubric>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\OrderWebRubric\\OrderWebRubrics" + i + ".json", strJson);
        Console.WriteLine("OrderWebRubrics numero " + i);
    }
    s.Dispose();
}

void runMapLocation()
{

    ProfileDbContext s = new ProfileDbContext();
    double count = (double)s.MapLocations.Count() / (double)nbrPerfile;
    var ceil = Math.Ceiling(count);
    for (int i = 0; i < ceil; i++)
    {
        var ss = s.MapLocations.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<MapLocation>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\MapLocation\\MapLocations" + i + ".json", strJson);
        Console.WriteLine("MapLocation numero " + i);
    }
    s.Dispose();
}

void runMapSendingLink()
{

    ProfileDbContext s = new ProfileDbContext();
    double count = (double)s.MapSendingLinks.Count() / (double)nbrPerfile;
    var ceil = Math.Ceiling(count);
    for (int i = 0; i < ceil; i++)
    {
        var ss = s.MapSendingLinks.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<MapSendingLink>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\MapSendingLink\\MapSendingLinks" + i + ".json", strJson);
        Console.WriteLine("MapSendingLinks numero " + i);
    }
    s.Dispose();
}

void runMapCutType()
{

    ProfileDbContext s = new ProfileDbContext();
    double count = (double)s.MapCutTypes.Count() / (double)nbrPerfile;
    var ceil = Math.Ceiling(count);
    for (int i = 0; i < ceil; i++)
    {
        var ss = s.MapCutTypes.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<MapCutType>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\MapCutType\\MapCutTypes" + i + ".json", strJson);
        Console.WriteLine("MapCutTypes numero " + i);
    }
    s.Dispose();
}

void runMapOriginalFlow()
{

    ProfileDbContext s = new ProfileDbContext();
    double count = (double)s.MapFlows.Count() / (double)nbrPerfile;
    var ceil = Math.Ceiling(count);
    for (int i = 0; i < ceil; i++)
    {
        var ss = s.MapFlows.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<MapFlow>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\MapFlow\\MapFlows" + i + ".json", strJson);
        Console.WriteLine("MapFlows numero " + i);
    }
    s.Dispose();
}

var connectionString = "mongodb://localhost:27017";

var client = new MongoClient(connectionString);
var database = client.GetDatabase("DBWebselect");

void insertSource(string dataDirectory, string CollectionName)
{
    try
    {
        string[] filePaths = Directory.GetFiles(Path.Combine(@"\\madastation1\Soccha\MADAMONITOR\DEV\boss\", dataDirectory));

        for (int i = 0; i < filePaths.Length; i++)
        {
            if (i == 2) break;
            string text = System.IO.File.ReadAllText(filePaths[i]);
            var document = BsonSerializer.Deserialize<List<BsonDocument>>(text);
            var collection = database.GetCollection<BsonDocument>(CollectionName);
            collection.InsertMany(document);
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }

}



void runVWebOrders1()
{
    AuxipressContext s = new AuxipressContext();
    var ssss = s.VwebOrders1s.Count();

    for (int i = 0; i < Math.Ceiling(((Decimal)s.VwebOrders1s.Count() / (Decimal)nbrPerfile)); i++)
    {
        var ss = s.VwebOrders1s.Skip(i * nbrPerfile).Take(nbrPerfile).ToList();
        string strJson = JsonSerializer.Serialize<List<VwebOrders1>>(ss);
        File.WriteAllText("\\\\madastation1\\Soccha\\MADAMONITOR\\DEV\\boss\\VwebOrders1\\VwebOrders1s" + i + ".json", strJson);
        Console.WriteLine("ArticleSelecteds numero " + i);
    }
    s.Dispose();
}

//insert to MongoDB
//Parallel.Invoke(() => insertSource("Media", "Media"));//,
//    () => insertSource("ArticleKeyword", "ArticleKeyword"),
//    () => insertSource("ArticleWordFound", "ArticleWordFound"),
//    () => insertSource("ProfileLock", "ProfileLock"),
//    () => insertSource("ProfileHistory", "ProfileHistory"),
//    () => insertSource("KeywordGroup", "KeywordGroup"),
//    () => insertSource("OrderSetting", "OrderSetting"),
//    () => insertSource("KeywordLine", "KeywordLine"),
//    () => insertSource("KeywordHit", "KeywordHit"),
//    () => insertSource("OrderWebRubric", "OrderWebRubric"),
//    () => insertSource("MapLocation", "MapLocation"),
//    () => insertSource("MapSendingLink", "MapSendingLink"),
//    () => insertSource("MapCutType", "MapCutType"),
//    () => insertSource("MapFlow", "MapFlow"));

//Parallel.Invoke(() => runMapOriginalFlow(),
//    () => runMapCutType(),
//    () => runMapSendingLink(),
//    () => runMapLocation(),
//    () => runOrderWebRubric(),
//    () => runKeywordDescription(),
//    () => runKeywordHits(),
//    () => runKeywordLine(),
//    () => runOrderSettings(),
//    () => runKeywordGroup());

Parallel.Invoke(() => runMaplanguage(),
    //()=> runContacts(),
    ()=> runMapCountry());

//Parallel.Invoke(() => insertSource("source", "source"));