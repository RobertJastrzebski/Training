# ********************************************  rock , paper, scissors game 2 score wins the game. ***********************************************************************
from random import randint

player_wins = 0
computer_wins = 0

print('Welcome to rock paper scissors game!!!!!!!!!!')
while player_wins < 3 and computer_wins < 3:

    print(f'player score: {player_wins}\ncomputer score: {computer_wins}')

    player1 = input('Player 1 please make your move: ').lower()
    if player1 == 'quit' or player1 == 'q':
        player_wins = 0
        break
    print('**********************************************************************\n' * 20)
    print('Computer move: ')
    player_random = randint(0, 3)
    if player_random == 0:
        computer = 'rock'
    elif player_random == 1:
        computer = 'paper'
    else:
        computer = 'scissors'
    print(computer)

    if player1 == computer:
        print('Draw!')


    elif player1 == 'rock' and computer == 'scissors':
        print('Player 1 wins')
        player_wins += 1
    elif player1 == 'scissors' and computer == 'paper':
        print('Player 1 wins')
        player_wins += 1
    elif player1 == 'paper' and computer == 'rock':
        print('Player 1 wins')
        player_wins += 1


    else:
        print('Computer wins')
        computer_wins += 1


if player_wins > computer_wins:
    print('player wins')
elif computer_wins > player_wins:
    print('Computer wins')
else:
    print('draw')
print(f' final score: \nplayer score: {player_wins}\ncomputer score: {computer_wins}')
