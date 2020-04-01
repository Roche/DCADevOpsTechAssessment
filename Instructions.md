Instructions:

1. Create a free Azure Account (in case you don't have one available)
https://azure.microsoft.com/en-gb/offers/ms-azr-0044p/
Note: in Azure, you will have available 170€ (if a remember correctly) of free Azure credits. You will need to introduce a debit/credit card, but no charghes will be applied until you get over 170€ of expenses
Remember to delete that account so Microsoft won't charge anything in your bank account.
My recommendations is for you to create a new Microsoft account, do not use your personal(in case you have it)

2. Create a service connection(in Azure DevOps, https://dev.azure.com/ ) so you can deploy resources from Azure Devops to Azure portal(https://portal.azure.com)
https://docs.microsoft.com/en-us/azure/devops/pipelines/library/service-endpoints?view=azure-devops&tabs=yaml

3. Clone the repository https://github.com/AleksAlonso/RocheDevOpsAssessment.git (ask for permissions on the repo first with a GitHub account)

4. Open RocheDevOpsAssessment.sln. Download VS Community from here https://visualstudio.microsoft.com/vs/express/
	4.a Make it compile
	4.b Make all Unit tests green
	
5. You should push the changes to your own repository in Azure Devops, not to the github acccount
	5.a Use GitFlow branching strategy
	5.b Add a build policy in the PR (When the pipeline is ready, see 6)
	5.c Follow best practiques
	
6. Make use of IaC to create the resources needed in Azure (Webapp + SQL server + Database).
	6.a Use UI (Azure portal)
	6.b Use ARM templates
	6.c Use Terraform	
	
6. Create a pipeline or pipelines (up to you) that is able to:
	6.a Builds the application
	6.b Runs Unit Tests
	6.c Create the infrastructure with both approaches(ARM and terraform) one at a time
	6.d Release the application in Azure (preferred)
	
7. Build a powershell script that is able to:
	7.a Get the duration (average) of your pipeline in seconds
	7.b Show the results in the pipeline in the format you choose	
	
	Tip: https://docs.microsoft.com/en-us/rest/api/azure/devops/?view=azure-devops-rest-5.1
	
9. When everything is ready and deployed in Azure, make sure all UI tests in the VS solution are working by:	
	9.a Modify the UI tests so they run against your brand new cloud environment
	9b. Selenium tests are green
	
If you find yourself blocked in any of these steps, please continue with the rest of them, or at least try it.
	