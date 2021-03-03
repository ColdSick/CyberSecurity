
#!/bin/bash

#List of states
states=(
'Nebraska'
'Hawaii'
'California'
'Texas'
'Ohio'
)

for state in ${states[@]};
do
        if [ $state = 'Hawaii' ]; 
        then 
                echo "Hawaii is the best"
        else 
                echo "I am not fond of Hawaii"
        fi
done
  
#Second part of activity
num_list=$(echo {0..9})
for num in ${num_list[@]};
do
        if [ $num = 3 ] || [ $num = 5 ] || [ $num = 7 ] 
        then 
                echo $num
        fi
done
 





