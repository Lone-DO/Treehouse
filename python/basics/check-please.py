import math


def split_check(total, num_of_ppl):
    return math.ceil(total / num_of_ppl)


total_due = float(input("What is the total? "))
num_of_ppl = float(input("How many people? "))

amount_due = split_check(total_due, num_of_ppl)
print("Each person owes ${}".format(amount_due))
