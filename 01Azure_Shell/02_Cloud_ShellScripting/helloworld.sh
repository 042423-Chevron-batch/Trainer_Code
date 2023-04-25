#!/usr/bin/bash
# above line tells the machine to interpret this file with bash

#variable
#cannot have spaces around =
# echo "What is your name?"
# take input from the console and assign the value to name
# read name

# script arguments
#$0 $1 $2 $3...

# echo "hello, $1!"

# # $@ gives all the arguments i have passed
# # how do we individually access it until we run out of arguments?
# for name in "$@"
# do
#     echo "Hello, $name!"
# done

for num in "$@"
do
    if [ $num -eq 0 ]
    then
        echo "You entered zero"
    elif [[ $num -gt 0 && $num -le 10 ]]
    then
        echo "You entered a number between 0 and 10"
    else
        echo "you either entered a negative number or a number greater than 10"
    fi
done

echo "type 'Cats'"
read response
if [ $response == "Cats" ]
then
    echo "Thank you for professing your undying love for cats"
else
    echo "How can you not like cats"
fi

#
