// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


class Program
{
    static void Main(string[] args)
    {
        //Tutorial

        //https://www.twilio.com/docs/sms/quickstart/csharp-dotnet-core


        // Find your Account Sid and Token at twilio.com/console
        // and set the environment variables. See http://twil.io/secure


        var accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
        var authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");

       TwilioClient.Init(accountSid, authToken);
    
        var message = MessageResource.Create(
            body: "Hi coach rony ,this message sent from twilio-package",
            from: new Twilio.Types.PhoneNumber("Twilio_Phone_number"),
            to: new Twilio.Types.PhoneNumber("Your_Phone_number_verificated")
        );

        Console.WriteLine(message.Sid);
    }
}
