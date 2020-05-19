# Columns: Name, Day/Month, Celebrates, Age
def blank():
    print("_____________________________\n")


Birthdays = (
    ("James", "9/8", True, 9),
    ("Shawna", "12/6", True, 22),
    ("Amaya", "28/2", False, 8),
    ("Kamal", "29/4", True, 19),
    ("Sam", "16/7", False, 22),
    ("Xan", "14/6", False, 34)
)
Months = ("Jan", "Feb", "Mar", "Apr", "May", "Jun",
          "Jul", "Aug", "Sep", "Oct", "Nov", "Dec")
# Problem 1: Celebrations
# Loop through all of the people in BIRTHDAYS
for birthday in Birthdays:
    [name, date, bool, age] = birthday
    month = int(date[1 + date.index("/"):])

    # If they celebrate their birthday, print out
    if bool:
        if age <= 10:
            # Problem 4: Wishing stars
            # Loop through BIRTHDAYS
            # If the person celebrates their birthday,
            # AND their age is 10 or less,
            # Print out their name and as many stars as their age
            print("{} is {}".format(name, "*" * age))
        else:
            # "Happy Birthday" and their name
            print("Happy Birthday {}!".format(name))
            blank()

    # Problem 2: Half birthdays
    # Loop through all of the people in BIRTHDAYS
    # Calculate their half birthday (six months later)
    halfBirthday = month + 6
    if halfBirthday > 12:
        halfBirthday -= 12
    # Print out their name and half birthday
    print("{}'s half birthday is {}".format(name, Months[halfBirthday - 1]))
    blank()

    # Problem 3: Only school year birthdays
    # Loop through the people in BIRTHDAYS
    # If their birthday is between September (9)
    if month >= 6 and month <= 9:
        print("{} is a summer child".format(name))
        blank()
    # And June (6), print their name
