# *************************************formating strings*****************************************

# first = "Mike"
# last = "Tyson"
#
# formatted = "First name {},Last name {}".format(first,last)
# print(formatted)

# ******************************************* ile km dzis biegales round (wartosc,ile po przecinku zaokraglic ) ********
# print('Wpisz ile kilometrow dzis przebiegles ?')
# km = input()
# miles= float(km)/1.6934
#
# round_miles= round(miles,2)
# print(f"Dzis przebiegles {round_miles} mil")
#

# *************************************loop through 1-20 ***************************************************************
# for i in range(1,21):
#     if i == 4 or i == 13:
#         status ="Unlucky"
#     elif i % 2 == 0:
#         status ="even"
#     else:
#         status ="odd"
#     print(f'{i} is {status}')
# *********************************************malujemy trojkat petlami for i while ************************************
# for x in range(3):
#     for num in range(1,10):
#         print("*" * num)

#
# a=1
# while a<10 :
#     print("x"*a)
#     a+=1
# *********************************************** extend() - pozwala dodac do listy kilka elementow na koniec lisy******
# instructors = []
# instructors.extend(["Colt", "Blue", "Lisa"])
# print(instructors)





# *****************************************Sprawdz czy key w slowniku maczuja sie z lista food zwroc info zwrotne ******
# food = ["cheese pizza", "quiche","morning bun","gummy bear","tea cake"] #DON'T CHANGE!
#
# #DON'T CHANGE THIS DICTIONARY EITHER!
# bakery_stock = {
#     "almond croissant" : 12,
#     "toffee cookie": 3,
#     "morning bun": 1,
#     "chocolate chunk cookie": 9,
#     "tea cake": 25
# }
#
# # YOUR CODE GOES BELOW:
# for k,v in bakery_stock.items():
#     if k in food:
#         print( f"{k} {v}")
#     else:
#         print("We don't make that")



# # ******************ZIP function, dictionary comprehenction - palacz 2 listy tak aby stworzyly dictionary  ***********
# list1 = ["CA", "NJ", "RI"]
# list2 = ["California", "New Jersey", "Rhode Island"]
#
#
# answer = dict(zip(list1,list2))
# print(answer)


#
# list1 = ["CA", "NJ", "RI"]
# list2 = ["California", "New Jersey", "Rhode Island"]
#
#
# answer = {list1[i] :list2[i] for i in  range(0,len(list1))}
# print(answer)

# ****************************************dictionary comprehenction ****************************************************

# Using a dictionary comprehension
#
# person = [["name", "Jared"], ["job", "Musician"], ["city", "Bern"]]
# answer = { i[0]:i[1] for i in person }

# An alternate solution using a dict comprehension, without any references to list indexes:
#
# person = [["name", "Jared"], ["job", "Musician"], ["city", "Bern"]]
# answer = {k:v for k,v in person}


# Finally, a really simple solution.  If you have a list of pairs, you can very easily turn it into a dictionary using dict()
#
# person = [["name", "Jared"], ["job", "Musician"], ["city", "Bern"]]
# answer = dict(person)
# print(answer)
#
# ********************************************http requests  with python ***********************************************
# import requests
# from random import choice
# url = 'http://icanhazdadjoke.com/search'
# word= input("podaj slowo po angielsku: ")
# res= requests.get(
#     url,
#     headers={"Accept":"application/json" },
#     params={"term":word}
# ).json()
# result= res['results']
#
# number_of_jokes= res['total_jokes']
# if number_of_jokes > 1:
#     print('Jest wiecej niz jeden kawal oto jeden z nich:')
#     print(choice(result)['joke'])
# elif number_of_jokes == 1:
#     print('Jest jedne kawal:')
#     print(result[0]['joke'])
# else:
#     print('brak kawalow do tego slowa')
# *************************************object orienting programming ******************************************************************

# Define Bank Account Below:
# class BankAccount:
#
#     def __init__(self, name):
#         self.owner = name
#         self.balance = 0.0
#
#     def balance(self):
#         return self.balance
#
#     def deposit(self, amount):
#         self.balance += amount
#         return self.balance
#
#     def withdraw(self, amount):
#         self.balance -= amount
#         return self.balance
#
# run = BankAccount("Arnie")
# print(run.balance)
# run.deposit(30)
# run.withdraw(20)
# print(run.balance)

# ***********************************write, read files and create new file with ,as function in python *****************

# my_list =[1,2,3,0,]
# my_file= open("first.txt","w")
# for item in my_list:
#     my_file.write(str(item))
# my_file.close()


# my_file2=open("first.txt",'r')
# print(my_file2.read())
# my_file2.close()


# # tworzy nowy plik
# with open("nowy_dokument.txt","w") as plik:
#     plik.write("stworzylem nowy pilk !!!")
# # odczytuje zawartosc.
# with open("nowy_dokument.txt","r") as plik:
#     print(plik.read())
#

# ******************************************** OOP *********************************************************************
# class Character:
#     def __init__(self, name, hp, level):
#         self.name = name
#         self.hp = hp
#         self.level = level
#
#
# class NPC(Character):
#     def __init__(self, name, hp, level):
#         super().__init__(name, hp, level)
#
#     def speak(self):
#         """zwraca zdanie"""
#         return f"{self.name}I hear there were monsters running around last night"
#
#
# villager= NPC("Rob",100,12)
# print(villager.name)
# print(villager.hp)
# print(villager.level)
# print(villager.speak())
# print(NPC.speak.__name__)
# print(NPC.speak.__doc__)

# **********************************************************************************************************************
