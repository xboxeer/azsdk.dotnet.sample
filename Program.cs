// See https://aka.ms/new-console-template for more information

const string RESOURCE_GROUP_NAME = "myRg";
const string SERVICEBUS_NAMESPACENAME = "myNamespace";//The name might already exist in Azure, better to change it when runnning the code
const string SERVICEBUS_QUEUENAME = "mySBQueueName";

Console.WriteLine("Azure SDK for .Net usability study");

Console.WriteLine("Create Resource Group");
CreateResourceGroup(RESOURCE_GROUP_NAME);

Console.WriteLine("Create Service Bus Namespace and Queue");
CreateServiceBusQueue(RESOURCE_GROUP_NAME,SERVICEBUS_NAMESPACENAME,SERVICEBUS_QUEUENAME);

Console.WriteLine("List all queue in a service bus namespace");
ListAllQueue(RESOURCE_GROUP_NAME, SERVICEBUS_NAMESPACENAME);

Console.WriteLine("Delete a queue in namespace");
DeleteQueue(RESOURCE_GROUP_NAME, SERVICEBUS_NAMESPACENAME, SERVICEBUS_QUEUENAME);

void CreateResourceGroup(string resourceGroupName)
{

}
void CreateServiceBusQueue(string resourceGroupName, string serviceBusNamespaceName, string queueName)
{

}
void ListAllQueue(string resourceGroupName, string serviceBusNamespaceName)
{
    
}
void DeleteQueue(string resourceGroupName, string serviceBusNamespaceName, string queueName)
{
    
}
