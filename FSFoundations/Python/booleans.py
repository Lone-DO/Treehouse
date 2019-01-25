# Booleans
# # bool(0)  # False, 0 / Empty string or value
# # bool(1)  # True, anything with a value or not 0

# Scenario: Heidi wants to meet someone with kids but does not want someone who smokes.
# # has_kids = True
# # is_smoker = True

# # print(has_kids and not is_smoker)  # false
# __________________________

# Conditional Statements


class Person:
    def __init__(self, name, kids, smoker):
        self.name = name
        self.kids = kids
        self.smoker = smoker


p1 = Person("Billy", True, False)
p2 = Person("Jerrell", False, False)
p3 = Person("Bob", True, True)

name = bob()  # input( """Would you like to checkout "Bob", "Billy", or "Jerrell"? """)
# if name != "bob" or "billy" or "jerrell":
#     name = input("Please pick again  ").lower()
# else:
if name.kids == True and name.smoker == False:
    print("{} is a perefect match for you".format(name))
elif name.kids == False and name.smoker == False:
    print("{} has potential in being a healthy father".format(name))
else:
    print("{} unfortunately isn't a good match".format(name))

print("Goodbye")
