def isFizz(value):
    return int(value) % 3 == 0


def isBuzz(value):
    return int(value) % 5 == 0


def method():
    name = input("Please enter your name: ")
    number = input("Please enter a number: ")
    print("Hey {}".format(name))
    print("The number {}...".format(number))

    if isFizz(number) and isBuzz(number):
        print("is a FizzBuzz")
    elif isFizz(number):
        print("is a Fizz")
    elif isBuzz(number):
        print("is a Buzz")
    else:
        print("is neither a fizzy or a buzzy number.")

    cont = input("Enter 'y' to continue: ")
    if cont == "y":
        method()
    else:
        print("goodbye")


method()
