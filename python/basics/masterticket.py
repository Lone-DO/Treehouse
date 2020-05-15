TICKET_PRICE = 10
tickets_remaining = 100
exit = False

# Output how many tickets are remaining using the tickets_remaining variable

while tickets_remaining > 0 and not exit:
    print("There are {} tickets remaining!".format(tickets_remaining))
    # Gather Users name and sign it to new variable
    name = input("What is your name? ")
    # Prompt user by name and ask how many
    num_tickets = input(
        "Hello {}, how many tickets do you want? ".format(name))
    if num_tickets == "0" or num_tickets == "quit":
        exit = True
    else:
        num_tickets = int(num_tickets)
        # Calculate the price (amount * price)
        total = TICKET_PRICE * num_tickets
        # Output the price to the screen
        confirm = input(
            "You have ordered {} tickets, your total will be ${}. Please confirm (Enter: yes/no) ".format(num_tickets, total))
        if confirm.lower() == "yes":
            if num_tickets <= tickets_remaining:
                tickets_remaining -= num_tickets
                print("Thank you for your order {}".format(name))
            else:
                print("Error, Cannot process order over available tickets")
        else:
            print("Order has been cancelled, Have a great day!")
if tickets_remaining:
    print("SOLD OUT!")
