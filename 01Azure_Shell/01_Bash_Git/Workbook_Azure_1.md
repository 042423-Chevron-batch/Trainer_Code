Work through the Microsoft Learning Path [Microsoft Azure Fundamentals: Describe cloud concepts](https://learn.microsoft.com/en-us/training/paths/microsoft-azure-fundamentals-describe-cloud-concepts/) and answer the following questions in *your own words*. Be ready to share some of the answers with the class the next day!

Additional points if you:
- Handwrite this 
- Create your own diagrams

### Define following concepts:
- Cloud Computing
	- Is a virtualization of physical things such as server, storage, db's provided over internet. No need for YOUR OWN data center.
	- "using someone else's machines"
- Shared Responsibility Model
	- For the successful deployment of applications, Azure and the users share responsibilities. And those shares change depending on what type of service the customer purchase.
	- ![image](https://f.hubspotusercontent30.net/hubfs/508286/Microsoft%20Azure%20Shared%20Responsibility%20Model%20600x300.png)

- Cloud Models: 
	- Public cloud
		- cloud that anyone can access, ex: Azure, AWS, GCP
	- Private cloud
		- when there are restrictions to access
		- Cloud that exists solely for one entity/company
	- Hybrid cloud
		- mix of public and private
		- ex: a company can choose to run on-premise IT alongside with Azure

- Capital Expenditure (CapEx)
	- One time upfront cost to purchase resources, new server, data center, etc
- Operational Expenditure (OpEx)
	- money spent on service or product over time

- Consumption Based Model (and its benefits)
	- Don't really have to pay for the cost associated with data centers, only use and pay for the one you need and don't pay for the ones you don't use

- Cloud Benefits:
	- High Availability
		- cloud offers resources that are readily available (no matter what happens).

	- Scalability
		- Easy to use resources that can change up or down overtime based on user needs.

	- Reliability / Fault Tolerance
		- making sure resources are always available (despite disasters, internet outage, server failure, earthquake, sudden fire)
		- making sure data centers are in different locations and having back ups somewhere else

	- Predictability
		- being able to have prior knowledge for certain services
		- Cloud offers a way to predict those cost/service capability 

	- Security and Governance
		- management approach that enables effect operation and security management in cloud environment, reflect business goals of an organization
		- Many cloud service providers offer high level of up to date security practices
			- compliance to security standards HIPPA, etc.
			- physical security practices
			- network security practices
		- They offer ability for you as a customer/company to enforce your own policy to your employees

	- Manageability
		- management of the cloud
			- how you deploy the resources / monitoring of the performance
		- management in the cloud
			- management of cloud environment

	- Economics of Scale
		- "bulk discount"
		- cost benefit that company receives from csp having big infrastructure

- Service Level Agreement (SLA)
	- contract between the provider and customer of services and support that will be delivered to the customer
	- SLA is guarantee of uptime
		- 99.9%, 99.99%, 99.999% levels
- Vertical Scaling
	- upgrading existing machines with more compute/storage, etc. 
- Horizontal Scaling
	- adding more machines

- Infrastructure as a Service (IaaS) and common use cases
	- development/testing environment, customization of website online application, backup recovery, on premise workload
	- Offers really great customization ability
	- Lift and Shift operations, which means when you're taking existing on-premise infrastructure and moving that onto cloud
	- Ex: Azure Virtual Machines

- Platform as a Service (PaaS) and common use cases
	- cloud platform hardware, software, development application w/o cost, comes with buildin platform on premises
	- CSP manages hardware and OS/Software,
	- When you want to only worry about your application/project
	- Ex: Azure App Service, Azure SQL Server, Azure Functions

- Software as a Service (SaaS) and common use cases
	- Customer uses fully developed application, most of the responsibility is placed on the cloud provider
	- ex: microsoft 365, gmail, etc.

### Define following Azure Services:
- Azure Arc
	- manages resources outside of azure cloud environment
	- connects Azure and other cloud infrastructure together