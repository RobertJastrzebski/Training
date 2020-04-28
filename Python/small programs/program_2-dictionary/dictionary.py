import json
from difflib import get_close_matches

data = json.load(open("data.json","r"))



def find_word (user_word):
    user_word = user_word.lower()
    if user_word in data:
        return data[user_word]
    elif user_word.title() in data:
        return data[user_word.title()]
    elif user_word.upper() in data:
        return data[user_word.upper()]
    elif len(get_close_matches(user_word, data.keys())) > 0:
        answer = input("Did you mean {} ?, enter Yes or No : ".format(get_close_matches(user_word,data.keys())[0]))
        if answer =="yes".lower() :
            return data[get_close_matches(user_word, data.keys())[0]]
        else:
            return "Word does not exist in dictionary"
    else:
        return "Word does not exist"


user_word = input("Please enter a word: ")
output = find_word(user_word)
if type(output) == list:
    for i in output:
        print(i)
else:
    print(output)
