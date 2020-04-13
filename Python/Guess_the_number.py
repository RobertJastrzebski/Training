#This is guess the number game
import random
print('hello. What is you name?')
name = input()

print('Well, '+ name + ', I am thinking of a number between 1 and 20')
secretNumber = random.randint(1,20)

for zgadnij in range(1,7):
    print('take a guess.')
    guess = int(input())
    if guess < secretNumber:
        print('Your guess is to low, try again')
    elif guess > secretNumber :
        print(' Your guess is to high')
    else:
        break

if guess == secretNumber:
    print('Good job,' + name + '! you guessed my number in ' + str(zgadnij) + ' guesses.' )
else:
    print('Sorry, THe number I was thinking was '+ str(secretNumber))




