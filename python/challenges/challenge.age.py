from datetime import date


def getInfo():
    name = input("What is your name? ")
    birthYear = input("What year were you born in? ")
    if birthYear.isnumeric():
        calculate(name, int(birthYear))
    else:
        print("invalid Year, Please try again")
        return getInfo()


def calculate(name, birthYear):
    thisYear = date.today().year
    age = thisYear - birthYear
    print("Hi {}, you are {}yrs old".format(name, age))

    def until(age, goal):
        print("You'll be {} in {}".format(goal, thisYear + (goal - age)))

    if age < 25:
        until(age, 25)
    if age < 50:
        until(age, 50)
    if age < 75:
        until(age, 75)
    if age < 100:
        until(age, 100)


getInfo()
