# Fingoti SDK

The Fingoti SDK makes it easy to use Fingoti infrastructure to manage your organisations & users as well as communicate with your devices, follow the examples below to get started

---

<br>

### Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

<br>
<br>

## Install

Some cmd here for install

<br>
<br>

## Getting Started

Here we will briefly cover the steps needed to get up and running with the SDK

<br>

### Create a configuration

The first step to communicating with the Fingoti infrastructure is authentication and configureation, to do this you will need an API key which can be obtained from http://account.fingoti.com, once you have an API key you can create a configuration as shown below

```csharp
using Fingoti.Client;

namespace Example {
    public class Example {
        public static Main(string[] args) {
            Configuration config = new Configuration();
            config.ApiKey.Add("Authorization", "<your-api-key>");
            config.ApiKeyPrefix.Add("Authorization", "Bearer");
        }
    }
}

```

Now you have a configuration we can use that to authenticate requests to the Fingoti infrastructure, lets start with a basic Organisation information request.

<br>

### Using the APIs

In the SDK the diffrent sections of the infrastructure are split into seperate API's in the example below, we are going to use the Organisation API to retrieve basic information about your Organisation.

```csharp
using System.Diagnostics;
using Fingoti.Api;

//Namespace, Class & Config section ommited for brevity

try
{
    var organisationApi = new OrganisationApi(config);
    var response = organisationApi.GetOrganisation();
    Debug.WriteLine(response);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GetOrganisation: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

Running that code should print a response in the console, if it does, great! You can now explore the rest of the docuemntation to find API's that fit your requirements.

<br>

### Device Control/Communication

Alongside the API's this package also comes with what we call a command builder which allows you to assemble requests to send to your Fingoti devices. It works in a similar way to the other API's and takes the same configuration shown in [Create a configuration](#create-a-configuration), see below

```csharp
using Fingoti.Command;

//Namespace, Class & Config section ommited for brevity

var commandBuilder = new Builder(config, "A0B1C2D3E4");

/*
Device commands can have read or write operation, generally read commands do not require a payload although
there are some exceptions to this rule, see below for some examples

All write operations require a payload
*/

//Adds a deviceColour read command
commandBuilder.AddDeviceColour();

//Adds a deviceColour write command
commandBuilder.AddDeviceColour(100, 20, 225);

//Adds a devicePower read command, only possible operation for this command
commandBuilder.AddDevicePower();

//Adds a uartData write command, only possible operation for this command
commandBuilder.AddUARTData(new List<int>() { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100 });

//Adds a scheduleCron read command, this read command requires a payload of slot number
commandBuilder.AddScheduleCron(2);

//Adds a scheduleCron write command, the payload for this command includes the slot
commandBuilder.AddScheduleCron(2, "20 * * * *");

try
{
    var result = commandBuilder.Send();
    Debug.WriteLine(JsonConvert.SerializeObject(result));
}
catch (ApiException e)
{
    Debug.Print("Exception when sending commands to device: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```
After running this example you should see 2 outputs in your console, the first one is the what was sent to the device and the second is what the device responded with, This is just a small introduction into the command builder and you can find a full list of [avaliable commands](https://developer.fingoti.com/hardware/protocol)