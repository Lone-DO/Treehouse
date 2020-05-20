def blank():
    print("____________________________\n")


# Problem 1: Warm the oven
# Write a while loop that checks to see if the oven
# is 350 degrees. If it is, print "The oven is ready!"
# If it's not, increase current_oven_temp by 25 and print
# out the current temperature.
current_oven_temp = 75

# Solution 1 here
while current_oven_temp < 350:
    current_oven_temp += 25
    if current_oven_temp >= 350:
        print("The oven is ready!")
    else:
        print("out the current temperature, {}".format(current_oven_temp))
blank()

# Problem 2: Total and average
# Complete the following function so that it asks for
# numbers from the user until they enter 'q' to quit.
# When they quit, print out the list of numbers,
# the sum and the average of all of the numbers.


def total_and_average():
    numbers = []
    # Solution 2 here
    response = input("Enter a Number: ")
    while response.lower() != "q":
        if response.isnumeric():
            numbers.append(float(response))
        else:
            print("Invalid number, please try again")
        response = input("Enter another number ('q' to quit): ")
    if bool(numbers):
        sum = 0
        for num in numbers:
            sum += num
        average = sum / len(numbers)
        print("Sum: {}, Average: {}".format(sum, average))
    print(numbers)
    blank()


total_and_average()

# Problem 3: Missbuzz
# Write a while loop that increments current by 1
# If the new number is divisible by 3, 5, or both,
# print out the number. Otherwise, skip it.
# Break out of the loop when current is equal to 101.
current = 1

# Solution 3 here
while current <= 100:
    def isModular(num, module):
        return num % module == 0
    if isModular(current, 3) or isModular(current, 5):
        print(current)

    current += 1
