# Order of operations
# PEMDAS - Please excuse my dear Aunt sally
# Floating: float(11), 11.0
# Intergar: int("10"), 10
# Round: round(11.4), 11 | round(11.7), 12
# Console results are stored within the underscore (_) Variable
# Escape sequence: 'I can\'t understand'
# __________________________
# Triple quotes: """Allows for inputs while ignoring instances of both Single...
# ... Single, Double quotes, and spaces within a string"""
# __________________________

# Strings, str()
# str.upper(), str.lower(), str.title(),
# Placeholder
subject_template = "Thanks for learning {} with us {}!"
print(subject_template.format("Programming", "Billy"))
# -> "Thanks for learning Programming with us Billy!"
# __________________________

# Booleans
bool(0)  # False, 0 / Empty string or value
bool(1)  # True, anything with a value or not 0
# Scenario: Heidi wants to meet someone with kids but does not want someone who smokes.
has_kids = True
is_smoker = True

print(has_kids and not is_smoker)  # false
# __________________________
