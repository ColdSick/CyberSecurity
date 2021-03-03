Automated ELK Stack Deployment

The files in this repository were used to configure the network depicted below.

 ![image](https://user-images.githubusercontent.com/73406341/109869407-6cc32400-7c2e-11eb-8816-2243b8868b50.png)


These files have been tested and used to generate a live ELK deployment on Azure. They can be used to either recreate the entire deployment pictured above. Alternatively, select portions of the ELK Playbook file may be used to install only certain pieces of it, such as Filebeat.

•	ELK Playbook

This document contains the following details:
- Description of the Topology
- Access Policies
- ELK Configuration
  - Beats in Use
  - Machines Being Monitored
- How to Use the Ansible Build


Description of the Topology

The main purpose of this network is to expose a load-balanced and monitored instance of DVWA, the D*mn Vulnerable Web Application.

Load balancing ensures that the application will be highly available, in addition to restricting access to the network.

What aspect of security do load balancers protect? What is the advantage of a jump box?
•	Load balancers protect against traffic flows. It can help mitigate DDOS attacks. Advantages to the jump box is ensuring that your network has support all of the time and is a reasonable solution when there is not direct office. 

Integrating an ELK server allows users to easily monitor the vulnerable VMs for changes to the logs and system metrics.

What does Filebeat watch for?
•	Filebeat monitors the log files or locations that you specify. 

What does Metricbeat record?
•	Metricbeat collects metrics from the OS and services running on a server

The configuration details of each machine may be found below.

| Name     | Function   | IP Address | Operating System |
|----------|------------|------------|------------------|
| Jump Box | Gateway    | 10.0.0.4   | Linux            |
| Web-1    | Web server | 10.0.0.5   | Linux            |
| Web-2    | Web server | 10.0.0.6   | Linux            |
| ELk-VM   | Log server | 10.1.0.4   | Linux            |


Access Policies

The machines on the internal network are not exposed to the public Internet. 

Only the load balancer machine can accept connections from the Internet. Access to this machine is only allowed from the following IP addresses:

Personal IP address 

Machines within the network can only be accessed by Jump-box-provisioner utilizing docker

To access the ELK machine, you would have to use the Jump-box-provisioner, connecting via IP address 10.1.0.4


A summary of the access policies in place can be found in the table below.

| Name                | Publicly Accessible | Allowed IP addresses |
|---------------|---------------------|---------------------|
| Load Balancer  | Yes                | Personal            |
| Jump Box         | Yes                | Personal            |
| Web-1              | No                  | 10.0.0.4            |
| Web-2              | No                  | 10.0.0.4            |
| ELK-VM         | Yes                 |                          |

Elk Configuration

Ansible was used to automate configuration of the ELK machine. No configuration was performed manually, which is advantageous because an IT administrator can update and makes changes across different machines. 


What is the main advantage of automating configuration with Ansible?
•	The main advantage is to free up time for IT administrators to concentrate on more important tasks. 

The playbook implements the following tasks:
•	Increases virtual memory 
•	Instructs the system to utilize the increased memory
•	Installs and enables docker
•	Installs python 
•	Initializes on reboot

The following screenshot displays the result of running `docker ps` after successfully configuring the ELK instance.
 

Target Machines & Beats

This ELK server is configured to monitor the following machines:
•	Web-1 10.0.0.5
•	Web-2 10.0.0.6

We have installed the following Beats on these machines:
•	Filebeat
•	Metricbeat

These Beats allow us to collect the following information from each machine:
•	Filebeat is used for forwarding and centralizing log data. Filebeat monitors the log files or locations that you specify, collects log events, and forwards them either to Elasticsearch or Logstash for indexing.
•	Metricbeat is installed on your servers to periodically collect metrics from the operating system and from services running on the server. Metricbeat takes the metrics and statistics that it collects and ships them to the output that you specify, such as Elasticsearch or Logstash.

Using the Playbook

In order to use the playbook, you will need to have an Ansible control node already configured. Assuming you have such a control node provisioned: 

SSH into the control node and follow the steps below:
•	Copy the ELK playbook file to /etc/ansible directory of your current ansible container
•	Update the ansible.cfg to include the hosts you would like to be affected.
•	Run the playbook, and navigate to your ELK server to check that the installation worked as expected.

Which file is the playbook? Where do you copy it? 
•	File-beat playbook and Metricbeat playbook are the playbooks needed to install either filebeat or metricbeat. Copy it to your /etc/ansible directory on each individual machine you would like monitored. 

Which file do you update to make Ansible run the playbook on a specific machine? How do I specify which machine to install the ELK server on versus which to install Filebeat on?
•	You would need to update the /etc/anisble/hosts file to add the specific machines. To specify which ones you want ELK or Filebeat you would create groups that can be updated with which machines you want either one. 

Which URL do you navigate to in order to check that the ELK server is running?
•	You would navigate to http//:[your_elk_server_ip:5601]/app/kibana 


