param(
	 [Parameter(Mandatory=$True)]
	 [String] $ResourceGroupName,
	 [Parameter(Mandatory=$True)]
	 [String[]] $ResourcesToRemove)

Write-Host "This script will remove all resources in resource group."
foreach ($resourceName in $ResourcesToRemove)
{
	Write-Host "Removig resource with name:$resourceName from a resource group: $ResourceGroupName"
	Remove-AzureRmResource -ResourceName $resourceName -ResourceType Microsoft.Storage/storageAccounts -ResourceGroupName $ResourceGroupName
}