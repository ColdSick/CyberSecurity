
---
  - name: installing and launching metricbeat
    hosts: webservers
    become: yes
    tasks:

    - name: download metricbeat deb
      command: curl -L -O https://artifacts.elastic.co/downloads/beats/metricbeat/metricbeat-7.6.1-amd64.deb

    - name: install metricbeat deb
      command: sudo dpkg -i metricbeat-7.6.1-amd64.deb

    - name: drop in metricbeat.yml
      copy:
        src: /etc/ansible/files/metricbeat-config.yml
        dest: /etc/metricbeat/metricbeat.yml

    - name: enable and configure system module
      command: metricbeat modules enable docker

    - name: setup metricbeat
      command: metricbeat setup

    - name: e command
      command: metricbeat -e%

    - name: enable service metricbeat on boot
      systemd:
        name: metricbeat
        enabled: yes
