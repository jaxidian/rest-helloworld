# RestHelloWorld

This is a .NET 6 MVC API application that implements nothing more than Hello World GET requests. Swagger docs & Swagger UI is a part of this.

This application is meant to be reused for quick proof-of-concept scenarios and is intended to be configurable in some unique ways.

Specifically, I plan to hook this Github repo to Azure Deployments to feed proof-of-concept applications hosted in Azure App Services.

## Configuration

This application enables Swagger docs and Swagger UI in Production. This is not best-practice, but is useful for the role this application will server. To access Swagger Docs, navigate to the `/v1/swagger.json` endpoint. To access Swagger UI, navigate to the `/swagger/index.html` endpoint.

You may also set the `CustomGreeting` app setting/environment variable to change the "Hello" greeting to something else, such as "Howdy" or "Hi". This only changes the text that's returned. It **does not** change the `/Hello/` endpoint.

## Deployment to an App Service

You can clone this repo and use Github Actions or you can use Azure DevOps Pipelines or any other CI/CD tooling you'd like to use.

However, one quick & easy option is to provision a default App Service, initially with the Deloyment stuff disabled. Then go back into the Deployment Center for that App Service and configure it with the following settings:

- Source: External Git
- Repository: https://github.com/jaxidian/rest-helloworld
- Branc: main
- Repository Type: Public

Click Save and this should deploy the site (it takes a few minutes, you can view the progress in the Logs tab of the Deployment Center). This will not implement continuous delivery, but you can always click the Sync button to deploy updates, if/when needed.