import sys
MASTER_PASSWORD = "abrakadabbra"
banner = "Welcome traveler!"
for char in banner:
    print(char.upper())

password = input("Please enter the super secret password: ")
attempt_count = 3

while password != MASTER_PASSWORD:
    attempt_count -= 1
    if attempt_count <= 0:
        sys.exit("Too many invalid attempts!")
    password = input("Invalid Password, please try again: ")
print("You are now logged in")
