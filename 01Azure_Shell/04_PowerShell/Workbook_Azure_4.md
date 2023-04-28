## AZ Fundamentals: Management and Governance
- Work through the following learning path: [Azure Fundamentals: Describe Azure Management and Governance](https://learn.microsoft.com/en-us/training/paths/describe-azure-management-governance/)

### Cost Management
- Describe factors that can impact the OpEx (Operational Expense)
	- Resource type, consumption, maintenance, subscription type, azure marketplace, geography

- Pricing Calculator
	- Calculator that gives estimate cost for each Azure resource
- TCO (Total Cost of Ownership) Calculator
	- Cost of running something on premise VS on azure

- What's the difference between the above two calcs?
	- TCO is about onpremise vs azure, Pricing Calculator is about azure resource estimate

- What does Azure Cost Management tool offer?
	- quickly manage and monitor your cost, set budgets, alerts, advisor recommendtion, etc.

- What do you use tags for? Name 6
	- provide extra metadata for resources
	- resource mngmnt , cost mngmnt optimization, operations mngmnt, security, governance, regulatory compliance, workload opt/automation

### Governance and Compliance
- Azure Blueprints
	 - standardizes plan for subscription, so you don't have to configure the same rules/policies for each subscription

- Azure Policy
	- service that enable user to assign/edit policies to audit resources

- Resource Lock
	- prevent changes/delete of resources

- Service Trust Portal
	- resources for security, privacy, compliance

### Managing and Deploying Azure Resources
- Azure Portal
	- GUI to manage your azure resources

- Azure Powershell
	- Set of commandlets to manage azure resources

- Azure CLI
	- Similar to azure powershell except it uses bash commands

- Azure Arc
	- Manage applications and services in hybrid or multicloud environment

- Azure Resource Manager (ARM) - IaC (Infrastructure as Code)
	- Create template for resource provisioning, update, delete, etc.

- Benefits of using ARM templates
	- Declarative syntax, repeatable result, orchestration, modular files, extensibility

### Monitoring Tools
- Azure Advisor
	- Makes recommendation to help you improve your azure experience/usage
- Azure Service Health : Overall health picture of azure services
	- Azure Status : Raw pic of azure global status/services
	- Service Health : Specific health of regional services
	- Resource Health : Tailored view of your individual services
- Azure Monitor
	- Azure Log Analytics : logical bundle of azure monitor 
	- Azure Monitor Alerts : detect issues before you notice them
	- Application Insights : extension of azure monitor, provides application performance monitoring
