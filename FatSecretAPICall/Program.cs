// See https://aka.ms/new-console-template for more information
using FatSecretAPICall;
using FatSecretAPICall.Authentication;
using FatSecretAPICall.Requests;
using FatSecretAPICall.ResponseObjects;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");

var cred = new FatSecretCredentials
{
    ClientKey = "",
    ClientSecret = ""
};

var client = new FatSecretClient(cred);
var foodGet = await client.FoodGetAsync(new FoodGetV2Request { FoodId = 33691 });
Console.WriteLine(foodGet.Food.ToString());
Console.WriteLine(foodGet.Food.Servings.Serving[0].ToString());

var foodSearch = await client.FoodsSearchAsync(new FoodsSearchRequest { SearchExpression = "apple" , MaxResults = 10});
Console.WriteLine(foodSearch.Foods.ToString());

if (foodSearch.Foods.Food != null)
{
    for (int i = 0; i < foodSearch.Foods.Food.Count; i++)
        Console.WriteLine(foodSearch.Foods.Food[i].ToString());
}


