# Describe Azure architecture and services: Part 2
## Describe Azure Storage Services
Work through [Describe Azure Storage Services](https://learn.microsoft.com/en-us/training/modules/describe-azure-storage-services/) and define the following terms 
- Azure Storage Account
	- account that provide unique namespace for storage needs, accessible over http/s
- Storage Redundancy : the process of creating multiple copies so it remains accessible/available even when one gets lost
	- Locally redundant storage
		- 3 copies within Single Data center
	- Zone-redundant storage
		- copies across 3 azure AZ within primary region
	- Geo-redundant storage
		- Locally redundant over 2 regions
	- Geo-zone-redundant storage
		- Zone-redundant in primary region, locally redundant in secondary region
- Azure Blobs and its use case
	- Store binary, text, data for analysis, good for storing unstructured data
	- Access Tiers
		- Hot
		- Cold
		- Archive
- Azure Files and its use case
	- managed file share for cloud or on-premise deployment
	- sort of 'dropbox for azure'

- Azure Queues
	- store/manage messages in a queue

- Azure Disks
	- block level storage for use within VMs

- Azure Migrate
	- migration/modernization/optimization for azure
	- over the web

- Azure Data Box
	- Is a _Physical_ migration that can migrate up to 80TB of data

- AzCopy
	- Command line utility to copy files from local machine to storage account 

- Azure Storage Explorer
	- GUI for Storage account

- Azure File Sync
	- Sync on-premise files with azure storage account 

#### Questions:
- What are benefits of Azure Storage?
	- Accessible over Http/s
	- Handles Hardware maintenance
	- Highly Available
	- Scalable

## Describe Azure Identity, Access, and Security
Work through [Describe Azure identity, access, and security](https://learn.microsoft.com/en-us/training/modules/describe-azure-identity-access-security/) and define the following terms:
- Azure Active Directory
	- Cloud based identity access management service
- Single Sign-on (SSO)
	- single username and pw that gives access to multiple apps

- Multi factor Authentication
	- multiple layers to security/confirmation to sign in
	- ex: sending code on phone
	- username + password + something else
		- Something you have (like your phone, authenticator app)
		- something you are (biometrics, face id, finger print)

- Password-less Authentication
	- similar to MFA that uses something you have, are, know
		- have: common access card
		- are: biometrics
		- know: security question

- Azure AD External Identities
	- Manage External Identities (ie. Customer/Partner/Suppliers) in Azure AD

- Azure Conditional Access
	- accept/deny access to resources based on identity
	- based on a certain condition, enforce more or less security when logging in, etc.

- Azure Role-based Access Control (RBAC)
	- System that provides access management for azure resources
	- create separate roles within org, and assign people to those roles

- principle of least privilege

- Zero Trust model : model that assumes the worst case scenario
	- Verify Explicitly
	- Use least privilege access
	- Assume breach

- Defense in depth : Prevent information from being stolen to people who shouldn't have access to those 
	- What security measures are taken in following levels?
		- Physical security : making sure only people with authorization can access the data center, etc.
		- Identity and Access : AD, principle of least privilege
		- Perimeter
		- Network
		- Compute
		- Application
		- Data

- Defender for Cloud
	- Security posture management and threat protection

- Authentication (AuthN)
	- Verifying that you are who you are
	- TSA agent checking you vs your id
	- logging in is authentication

- Authorization (AuthZ)
	- Verifying that you can do the action that you're trying to do
	- bouncer checking for your age in your id
	- TSA agent making sure your boarding pass is valid
	- in your machine, having local admin privilege to install certain software