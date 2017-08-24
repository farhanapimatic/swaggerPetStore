# Getting started

This is a sample server Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/).  For this sample, you can use the api key `special-key` to test the authorization filters.

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (SwaggerPetstore.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Swagger%20Petstore-CSharp&workspaceName=SwaggerPetstore&projectName=SwaggerPetstore.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the SwaggerPetstore library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Swagger%20Petstore-CSharp&workspaceName=SwaggerPetstore&projectName=SwaggerPetstore.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Swagger%20Petstore-CSharp&workspaceName=SwaggerPetstore&projectName=SwaggerPetstore.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Swagger%20Petstore-CSharp&workspaceName=SwaggerPetstore&projectName=SwaggerPetstore.PCL)

### 3. Add reference of the library project

In order to use the SwaggerPetstore library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Swagger%20Petstore-CSharp&workspaceName=SwaggerPetstore&projectName=SwaggerPetstore.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` SwaggerPetstore.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```SwaggerPetstore.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Swagger%20Petstore-CSharp&workspaceName=SwaggerPetstore&projectName=SwaggerPetstore.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Swagger%20Petstore-CSharp&workspaceName=SwaggerPetstore&projectName=SwaggerPetstore.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthClientId | OAuth 2 Client ID |
| oAuthRedirectUri | OAuth 2 Redirection endpoint or Callback Uri |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string oAuthClientId = "oAuthClientId"; // OAuth 2 Client ID
string oAuthRedirectUri = "oAuthRedirectUri"; // OAuth 2 Redirection endpoint or Callback Uri

SwaggerPetstoreClient client = new SwaggerPetstoreClient(oAuthClientId, oAuthRedirectUri);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [PetController](#pet_controller)
* [UserController](#user_controller)
* [StoreController](#store_controller)

## <a name="pet_controller"></a>![Class: ](https://apidocs.io/img/class.png "SwaggerPetstore.PCL.Controllers.PetController") PetController

### Get singleton instance

The singleton instance of the ``` PetController ``` class can be accessed from the API Client.

```csharp
PetController pet = client.Pet;
```

### <a name="update_pet"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.PetController.UpdatePet") UpdatePet

> Update an existing pet


```csharp
Task UpdatePet(Models.Pet body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Pet object that needs to be added to the store |


#### Example Usage

```csharp
var body = new Models.Pet();

await pet.UpdatePet(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid ID supplied |
| 404 | Pet not found |
| 405 | Validation exception |


### <a name="add_pet"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.PetController.AddPet") AddPet

> Add a new pet to the store


```csharp
Task AddPet(Models.Pet body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Pet object that needs to be added to the store |


#### Example Usage

```csharp
var body = new Models.Pet();

await pet.AddPet(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 405 | Invalid input |


### <a name="find_pets_by_tags"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.PetController.FindPetsByTags") FindPetsByTags

> Finds Pets by tags


```csharp
Task<List<Models.Pet>> FindPetsByTags(List<string> tags)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| tags |  ``` Required ```  ``` Collection ```  | Tags to filter by |


#### Example Usage

```csharp
List<string> tags = new List<string> { "tags" };

List<Models.Pet> result = await pet.FindPetsByTags(tags);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid tag value |


### <a name="upload_file"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.PetController.UploadFile") UploadFile

> uploads an image


```csharp
Task<Models.ApiResponse> UploadFile(long petId, string additionalMetadata = null, FileStreamInfo file = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| petId |  ``` Required ```  | ID of pet to update |
| additionalMetadata |  ``` Optional ```  | Additional data to pass to server |
| file |  ``` Optional ```  | file to upload |


#### Example Usage

```csharp
long petId = 155;
string additionalMetadata = "additionalMetadata";
FileStreamInfo file = new FileStreamInfo(new FileStream(@"pathToFile",FileMode.Open));

Models.ApiResponse result = await pet.UploadFile(petId, additionalMetadata, file);

```


### <a name="update_pet_with_form"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.PetController.UpdatePetWithForm") UpdatePetWithForm

> Updates a pet in the store with form data


```csharp
Task UpdatePetWithForm(long petId, string name = null, string status = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| petId |  ``` Required ```  | ID of pet that needs to be updated |
| name |  ``` Optional ```  | Updated name of the pet |
| status |  ``` Optional ```  | Updated status of the pet |


#### Example Usage

```csharp
long petId = 155;
string name = "name";
string status = "status";

await pet.UpdatePetWithForm(petId, name, status);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 405 | Invalid input |


### <a name="delete_pet"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.PetController.DeletePet") DeletePet

> Deletes a pet


```csharp
Task DeletePet(long petId, string apiKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| petId |  ``` Required ```  | Pet id to delete |
| apiKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
long petId = 155;
string apiKey = "api_key";

await pet.DeletePet(petId, apiKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid ID supplied |
| 404 | Pet not found |


### <a name="find_pets_by_status"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.PetController.FindPetsByStatus") FindPetsByStatus

> Finds Pets by status


```csharp
Task<List<Models.Pet>> FindPetsByStatus(List<Models.Status7Enum> status)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| status |  ``` Required ```  ``` Collection ```  | Status values that need to be considered for filter |


#### Example Usage

```csharp
List<Models.Status7Enum> status = new List<Models.Status7Enum> {Models.Status7Enum.AVAILABLE};
List<Models.Pet> result = await pet.FindPetsByStatus(status);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid status value |


### <a name="get_pet_by_id"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.PetController.GetPetById") GetPetById

> Find pet by ID


```csharp
Task<Models.Pet> GetPetById(long petId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| petId |  ``` Required ```  | ID of pet to return |


#### Example Usage

```csharp
long petId = 155;

Models.Pet result = await pet.GetPetById(petId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid ID supplied |
| 404 | Pet not found |


[Back to List of Controllers](#list_of_controllers)

## <a name="user_controller"></a>![Class: ](https://apidocs.io/img/class.png "SwaggerPetstore.PCL.Controllers.UserController") UserController

### Get singleton instance

The singleton instance of the ``` UserController ``` class can be accessed from the API Client.

```csharp
UserController user = client.User;
```

### <a name="update_user"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.UserController.UpdateUser") UpdateUser

> *Tags:*  ``` Skips Authentication ``` 

> Updated user


```csharp
Task UpdateUser(string username, Models.User body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| username |  ``` Required ```  | name that need to be updated |
| body |  ``` Required ```  | Updated user object |


#### Example Usage

```csharp
string username = "username";
var body = new Models.User();

await user.UpdateUser(username, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid user supplied |
| 404 | User not found |


### <a name="delete_user"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.UserController.DeleteUser") DeleteUser

> *Tags:*  ``` Skips Authentication ``` 

> Delete user


```csharp
Task DeleteUser(string username)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| username |  ``` Required ```  | The name that needs to be deleted |


#### Example Usage

```csharp
string username = "username";

await user.DeleteUser(username);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid username supplied |
| 404 | User not found |


### <a name="get_login_user"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.UserController.GetLoginUser") GetLoginUser

> *Tags:*  ``` Skips Authentication ``` 

> Logs user into the system


```csharp
Task<string> GetLoginUser(string username, string password)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| username |  ``` Required ```  | The user name for login |
| password |  ``` Required ```  | The password for login in clear text |


#### Example Usage

```csharp
string username = "username";
string password = "password";

string result = await user.GetLoginUser(username, password);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid username/password supplied |


### <a name="get_user_by_name"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.UserController.GetUserByName") GetUserByName

> *Tags:*  ``` Skips Authentication ``` 

> Get user by user name


```csharp
Task<Models.User> GetUserByName(string username)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| username |  ``` Required ```  | The name that needs to be fetched. Use user1 for testing. |


#### Example Usage

```csharp
string username = "username";

Models.User result = await user.GetUserByName(username);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid username supplied |
| 404 | User not found |


### <a name="create_user"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.UserController.CreateUser") CreateUser

> *Tags:*  ``` Skips Authentication ``` 

> Create user


```csharp
Task CreateUser(Models.User body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Created user object |


#### Example Usage

```csharp
var body = new Models.User();

await user.CreateUser(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | successful operation |


### <a name="create_users_with_array_input"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.UserController.CreateUsersWithArrayInput") CreateUsersWithArrayInput

> *Tags:*  ``` Skips Authentication ``` 

> Creates list of users with given input array


```csharp
Task CreateUsersWithArrayInput(List<Models.User> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  ``` Collection ```  | List of user object |


#### Example Usage

```csharp
var body = new List<Models.User>();

await user.CreateUsersWithArrayInput(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | successful operation |


### <a name="create_users_with_list_input"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.UserController.CreateUsersWithListInput") CreateUsersWithListInput

> *Tags:*  ``` Skips Authentication ``` 

> Creates list of users with given input array


```csharp
Task CreateUsersWithListInput(List<Models.User> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  ``` Collection ```  | List of user object |


#### Example Usage

```csharp
var body = new List<Models.User>();

await user.CreateUsersWithListInput(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | successful operation |


### <a name="get_logout_user"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.UserController.GetLogoutUser") GetLogoutUser

> *Tags:*  ``` Skips Authentication ``` 

> Logs out current logged in user session


```csharp
Task GetLogoutUser()
```

#### Example Usage

```csharp

await user.GetLogoutUser();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | successful operation |


[Back to List of Controllers](#list_of_controllers)

## <a name="store_controller"></a>![Class: ](https://apidocs.io/img/class.png "SwaggerPetstore.PCL.Controllers.StoreController") StoreController

### Get singleton instance

The singleton instance of the ``` StoreController ``` class can be accessed from the API Client.

```csharp
StoreController store = client.Store;
```

### <a name="get_order_by_id"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.StoreController.GetOrderById") GetOrderById

> *Tags:*  ``` Skips Authentication ``` 

> Find purchase order by ID


```csharp
Task<Models.Order> GetOrderById(long orderId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | ID of pet that needs to be fetched |


#### Example Usage

```csharp
long orderId = 155;

Models.Order result = await store.GetOrderById(orderId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid ID supplied |
| 404 | Order not found |


### <a name="delete_order"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.StoreController.DeleteOrder") DeleteOrder

> *Tags:*  ``` Skips Authentication ``` 

> Delete purchase order by ID


```csharp
Task DeleteOrder(long orderId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | ID of the order that needs to be deleted |


#### Example Usage

```csharp
long orderId = 155;

await store.DeleteOrder(orderId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid ID supplied |
| 404 | Order not found |


### <a name="get_inventory"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.StoreController.GetInventory") GetInventory

> Returns pet inventories by status


```csharp
Task<int> GetInventory()
```

#### Example Usage

```csharp

int result = await store.GetInventory();

```


### <a name="create_place_order"></a>![Method: ](https://apidocs.io/img/method.png "SwaggerPetstore.PCL.Controllers.StoreController.CreatePlaceOrder") CreatePlaceOrder

> *Tags:*  ``` Skips Authentication ``` 

> Place an order for a pet


```csharp
Task<Models.Order> CreatePlaceOrder(Models.Order body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | order placed for purchasing the pet |


#### Example Usage

```csharp
var body = new Models.Order();

Models.Order result = await store.CreatePlaceOrder(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid Order |


[Back to List of Controllers](#list_of_controllers)



