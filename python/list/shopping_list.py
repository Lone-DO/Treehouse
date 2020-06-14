shopping_list = []


def addItem(item):
    shopping_list.append(item)
    print(f"You have {len(shopping_list)} items on your list")


def show_help():
    print("What should we pick up at the store?")
    print("""
Enter 'DONE' to stop adding items.
Enter 'HELP' for this help.
""")


show_help()
while True:
    new_item = input("> ")

    if new_item.upper() == 'DONE':
        break
    elif new_item == 'HELP':
        show_help()
        continue
    else:
        if new_item not in shopping_list:
            addItem(new_item)
