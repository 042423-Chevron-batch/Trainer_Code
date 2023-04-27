$name = "Auryn"

Write-Output "Hello $name!"

$username = Read-Host -Prompt "What's your name?"

"Hello $username!"

# In powershell, script arguments are availabe as $args
$arr = "one", "two", "three", "four"
foreach($a in $arr) {
    # The first time it loops, $a is "one"
    # The second it it loops, $a is "two"

    Write-Output $a
}

$firstNum = $args[0]
$secondArg = $args[1]
Write-Output "first argument is $firstNum"
Write-Output "second argument is $secondArg"

# For each argument
foreach($num in $args) {
    if($num -eq 0) {
        Write-Output "You entered Zero"
    }
    elseif ( ($num -gt 0) -and ($num -le 10) ) {
        Write-Output "you entered a number between 0 and 10"
    }
    else {
        Write-Output "you either entered a negative number or a number grater than 10"
    }
} 

$response = Read-Host -Prompt "Type 'I Love Cats'"

if ($response -eq "I Love Cats") {
    Write-Output "Thank you for professing your undying love for cats"
}
else {
    "How can you not like cats"
}