## Describe the core architectural components of Azure
Work through [Describe the core architectural components of Azure](https://learn.microsoft.com/en-us/training/modules/describe-core-architectural-components-of-azure/) and define following terms and Azure services.
### Define the following terms:
- Region
	- geographical location that contains one or more data center
- Azure Data centers
	- facility with servers racks, dedicated power, network, infrastructure
- Availability Zone
	- it's physically separate zones within a Azure Region, they have _its own separate power, network, etc._
	- this ensures when something catastrophic happens, other az's are still up and running
- Region Pairs
	- connects to azure region in same geographic area to deliver geographically redundant solution
- Resource Groups
	- logical grouping of resources, ie VM's, being able to keep resources organized
	- can't have one resources in two groups  
	- put related resources for one project in resource group
- Subscriptions
	- access to resources and serve as unit of management for billing and scale
	- simply put, this is your billing account
- Management Groups
	- containers for organizing subscription into hierarchy, for managing policies and access control

### Questions:
- What benefit do Availability Zones and Region Pairs bring? (Choose from High Availability, Scalability, Reliability, Predictability, Security, Governance, Manageability)- High Availability, Reliability
- When would you want to create multiple subscriptions under one account?
	<!-- - if you need access to more resources? if your subscription is limited  -->
	- if you want to organize billing by different purposes

## Describe Azure compute and networking services
Work through [Describe Azure compute and networking services](https://learn.microsoft.com/en-us/training/modules/describe-azure-compute-networking-services/) and define following terms.

### Questions:
- Define the following Azure Compute services
	- Azure Virtual Machines (VMs) (IaaS)
		- Azure VMs are provides on demand computing power
	- Virtual machine scale sets (VMSS)
		- it's a set of identical vms that can scale up or down
	- Virtual machine availability sets
		- vm updates are staggered, and have separate power/connectivity
		- so you don't lose all your vms when there is a power failure
	- Azure Virtual Desktop (AVD) 
		- desktop and application virtualization service
		- GUI
	- Azure Container Instances (PaaS)
		- standardize repeatable way to package and deploy apps
		- Run containers w/o managing underlying structure
	- Azure Functions (PaaS)
		- Serverless compute service where you don't have to worry about infrastructure need
	- Azure App Services (PaaS)
		- Fully managed platform for building/deploying/scaling web apps and API
- What's the difference between virtual machine scale set and virtual machine availability sets?
	- VMSS have identical vms that scales up or down based on demand, VMAS, have same vms but is scattered, so they are more resilient
- What is the difference between public and private endpoints?
	- public endpoints are accessible via Internet, private endpoints exist in Azure VNets, and have private ip address
- How do you expose an azure resource to internet? (2 ways)
	- Public IP address and network security group
	- Azure Load Balancer or Application Gateway

- Define the following Azure Networking Services
	- Azure Virtual Network (VNet)
		- provide secure reliable access to azure resources
	- Service Endpoints
		- this allows private ip address to talk to azure resource without having to go through public internet
	- *Point-to-site
		- single resource connects to VNET in Azure
	- Site-to-site
		- on premise network to azure network
	- Azure ExpressRoute
		- Doesn't go through Internet
		- Private connection between On Premise and Azure
	- Route Table
		- allows you do define rules on how traffic should be directed (within Azure)
	- Border Gateway Protocol (BGP)
		- Exchange of routing info *between network*
	- Network security groups
		- Rule that determines who has access to certain network
	- Virtual Network Appliances
		- VMs that control network traffic
		- firewall
	- Virtual Private Network (VPN) Gateway
		- clients to securely access network through Encrypted connection
	- Azure DNS
		- Hosting service for domains

- What is virtual network peering?
	- Link VNETs together through private connection