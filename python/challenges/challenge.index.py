# TODO Create an empty list to maintain the player names
team = []
# TODO Ask the user if they'd like to add players to the list.
# If the user answers "Yes", let them type in a name and add it to the list.
# If the user answers "No", print out the team 'roster'
answer = input("Would you like to add a player to your team? ")

while True:
    if answer.lower() == 'yes':
        player = input("Please enter player name: ")
        # x = input('Enter your name:')
        team.append(player)
    if answer.lower() == "no":
        if len(team) <= 0:
            print("You have no team setup")
            break
        else:
            print("There are {len(team)} players on the team.")
            num = 1
            for member in team:
                print(f"Player {num}: {member}")
                num += 1
            pick = input(
                f"Please select the goal keeper by selecting the player number (1 - {len(team)}) ")
            print(
                f"Great, the goalkeeper for the game will be {team[int(pick) -1]}")
            break
    answer = input("Would you like to add another player? ")


# TODO print the number of players on the team


# TODO Print the player number and the player name
# The player number should start at the number one


# TODO Select a goalkeeper from the above roster


# TODO Print the goal keeper's name
# Remember that lists use a zero based index
