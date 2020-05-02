# azure-computer-vision
Leveraging Azure Cognitive Service - Computer Vision for batch processing Optical Character Recognition

After creating a Cognitive Service resource in the Azure portal, you'll get an endpoint and a key for authenticating your applications.

From the quickstart pane that opens, you can access your key and endpoint.

Configure an environment variable for authentication

To set the environment variable, open a console window, and follow the instructions for your operating system. Replace your-key with one of the keys for your resource.

```powershell
setx COGNITIVE_SERVICE_KEY "your-key"
```
The preferred way of storing such secrets for development is creating local.settings.json

Or run SetEnvVars.cs with argument pointing at local.settings.json

Restart your IDE