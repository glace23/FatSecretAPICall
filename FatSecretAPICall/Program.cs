// See https://aka.ms/new-console-template for more information
using FatSecretAPICall.Authentication;

Console.WriteLine("Hello, World!");

var cred = new FatSecretCredentials
{
    ClientKey = "44a3ee4ca84b42ebb3234bc6bf66518c",
    ClientSecret = "29c8029e8f1b4fdcae11abc7d1babfdd"
};

var auth = new FatSecretAuthenticationManager(cred);
Console.WriteLine(await auth.GetAuthHeaderAsync());
Console.WriteLine();