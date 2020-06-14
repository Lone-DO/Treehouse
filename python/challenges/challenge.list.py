# Step 1:
# Make two strings, each should be 8 characters long, made up of Xs and Os.
x = "XO"*4
o = "OX"*4
# First string should start with X, second string should start with O.
# Both strings should alternate between the two characters.
# You can use multiplication for this.

list = []
# Step 2:
# Make a list
# Add 1 of the X-started strings.
# Add 1 of the O-started strings.
while len(list) <= 8:
    if (not list):
        list.append(x)
    if list[-1][0] != x[0]:
        list.append(x)
    elif list[-1][0] != o[0]:
        list.append(o)
# Repeat until you have 8 items total in the list.
# You can use multiplication for this, too.


# Step 3:
# Print out the list of strings, joined with newlines \n.
print(f"""
    List: {list}
    O: {o}
    X: {x}
""")

for check in list:
    print(check)
