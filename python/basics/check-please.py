import math


def split_check(total, num_of_ppl):
    if num_of_ppl < 1:
        raise ValueError("At least one person is required to split the check")
    if total <= 0:
        raise ValueError("Bill cannot be negative, Please try again!")
    elif total == 0:
        return "nothing, this order was on the house!"
    return math.ceil(total / num_of_ppl)


def pay():
    try:
        total_due = float(input("What is the total? "))
        num_of_ppl = float(input("How many people? "))
        amount_due = split_check(total_due, num_of_ppl)
    except Exception as err:
        print("Invalid Input, Please try again!")
        print("({})".format(err))
        pay()
    else:
        print("Each person owes ${}".format(amount_due))


pay()
