# MadLibs - Practice Input and Output
#
# Template:
#    I enjoy practice! I find it helps me to __(verb)__ better.
#    Without practice, my __(noun)__ would probably not even work.
#    My code is getting more __(adjective)__ every single day!


# TODO: Prompt the user for parts of speech and store them in variables

verb = input("Can you give me a Verb? ")
noun = input("Great, now how about a Noun? ")
adjective = input("And finally, can you think of an Adjective? ")

# TODO: Output the template to the screen with the blanks filled out with what the user stated
print(" ")  # adds gutter space between questions and output
print("I enjoy practice! I find it helps me to", verb, "better.")
print("Without practice, my", noun, "would problably not even work.")
print("My code is getting more", adjective, "every single day!")
