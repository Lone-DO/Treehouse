# TODO: Ask the user by name if they understand Python while loops
name = input("What's your name? ")
repeat = 0
check = input(
    "{}, Do you understand Python while loops?\n(Enter Yes/No): ".format(name))


# TODO: Write a while statement that checks if the user doesn't understand while loops
while check.lower() != "yes":
    # TODO: Since the user doesn't understand while loops, let's explain them.
    print("A while loop statement in Python programming language repeatedly executes a target statement as long as a given condition is true.")
    # TODO: Ask the user again, by name, if they understand while loops.
    check = input("Do you now understand Python?\n(Enter Yes/No) :")
    if check.lower() != "yes":
        repeat += 1
# TODO: Outside the while loop, congratulate the user for understanding while loops
if repeat > 1:
    print("{}, I'm pleased that you understand while loops now. That was getting repetitive".format(name))
else:
    print("Glad you understand Python {}".format(name))

