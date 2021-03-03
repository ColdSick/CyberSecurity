#!/bin/bash

path_list={$(sudo ls /etc/passwd) $(sudo ls /etc/shadow)}
        for file in $(find /etc/passwd);
        do 
        ls -lah $file
done
