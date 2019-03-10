#Requires -Version 3.0
param([String[]] $ResourcesToRemove, [String] $ResourceGroupName)

Write-Host "This script will remove all resources in resource group."
$host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")
foreach ($resourceName in $ResourcesToRemove)
{
	Remove-AzureRmResource -ResourceName $resourceName -ResourceType Microsoft.Storage/storageAccounts -ResourceGroupName $ResourceGroupName
}

