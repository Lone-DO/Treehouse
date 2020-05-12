def yell(txt):
    chars = len(txt)
    result = txt.upper() + "!" * (chars // 4)
    return print(result)


yell("You are doing great")
yell("Don't forget to ask for help")
yell("Don't Repeat Yourself. Keep things DRY")
