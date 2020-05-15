TICKET_PRICE = 10
tickets_remaining = 100
exit = False

# Output how many tickets are remaining using the tickets_remaining variable


def Quantity(customer):
    tickets = input("How many tickets do you want, {}? ".format(customer))
    if tickets == "0" or tickets == "quit":
        return "cancelled"
    elif tickets.isnumeric():
        return int(tickets)
    else:
        print("Error, Invalid Input")
        return Quantity(customer)


def Sum(amount, cost):
    return amount * cost


def Checkout(amount, total, stock):
    confirm = input(
        "You have ordered {} tickets, your total will be ${}. Please confirm (Enter: yes/no) ".format(amount, total))
    if confirm.lower() == "yes":
        if tickets <= stock:
            print("Thank you for your order {}".format(name))
            return stock - tickets
        else:
            print("Error, Cannot process order over available tickets")
            return stock
    else:
        print("Order has been cancelled, Have a great day!")
        return stock


while tickets_remaining > 0 and not exit:
    print("There are {} tickets remaining!".format(tickets_remaining))
    # Gather Users name and sign it to new variable
    name = input("What is your name? ")
    # Prompt user by name and ask how many tickets
    tickets = Quantity(name)
    if tickets == "cancelled":
        exit = True
    else:
        # Calculate the price (amount * price)
        total = Sum(tickets, TICKET_PRICE)
        # Output the price to the screen
        tickets_remaining = Checkout(tickets, total, tickets_remaining)

if not tickets_remaining:
    print("SOLD OUT!")
else:
    print("Exiting Program... GOODBYE!")
