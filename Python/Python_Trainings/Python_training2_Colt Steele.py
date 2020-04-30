# *************************************formating strings*****************************************

# first = "Mike"
# last = "Tyson"
#
# formatted = "First name {},Last name {}".format(first,last)
# print(formatted)

# ******************************************* ile km dzis biegales round (wartosc,ile po przecinku zaokraglic ) *****************************
# print('Wpisz ile kilometrow dzis przebiegles ?')
# km = input()
# miles= float(km)/1.6934
#
# round_miles= round(miles,2)
# print(f"Dzis przebiegles {round_miles} mil")
#
# ******************************************** game rock , paper, scissors ***********************************************************************

print('Welcome to rock paper scissors game')
print('***Rock***')
print('***Paper***')
print('***Scissors***')
player1 = input('Player 1 plase make your move: ')
print('**********************************************************************\n'*20 )
player2 = input('Player 2 plase make your move: ')


if player1 == 'rock'.lower() and player2 =='scissors'.lower():
    print('Player 1 wins')
elif player1 == 'rock'.lower() and player2 =='paper'.lower():
    print('Player 2 wins')
elif player1 == 'paper'.lower() and player2 == 'scissors'.lower():
    print('Player 2 wins')

elif player2 == 'rock'.lower() and player1 =='paper'.lower():
    print('Player 1 wins')
elif player2 == 'rock'.lower() and player1 == 'scissors'.lower():
    print('Player 2 wins')
elif player2 == 'paper'.lower() and player1 == 'scissors'.lower():
    print('Player 1 wins')

elif player1 == player2:
    print('Draw!')
else:
    print('something go wrong')


