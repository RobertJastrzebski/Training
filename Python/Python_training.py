# a = 5.34
#
# mystring = 'abcdefghijklmnoprstuwz'
# print(mystring[::-1])
#
# print('To jest imie {}'.format("Roberta" + ' i Seby'))

# r = 12.232141
# print("the result was { r:1.3f } ".format(r))
#
# name = 'robert'
# new_list =['robert', 1234, 'karolina']
#
# print(f'MOje imie to {name} ')
#
# new_list.append('Hubi')
#
# print(new_list[1::])
# print(new_list)
# new_list.pop(0)
# print(new_list)
#
# # True and False
# b = True
# a = False
# print(b)



# ***********************************del (kasuje odpowiedni indeks z listy ale tylko pierwszy napotkany) , remove (usuwa pierwsza wartosc z listy) sort() (sortuje liste)****************************************************
# list= [1,2,3,4,5,5]
# del list[3]
# print(list)
# list.remove(5)
# print(list)
# words = [ 'banan', 'arbuz','cukinia']
# words.sort(reverse=True)
# print(words)
# print(sorted(words))
# alfabet =['a','b','c','A','B','C']
# alfabet.sort(key=str.lower)
# print(alfabet)




# ***************************setdefult dla dictionary(tworzy key value w słowniku)  oraz get (pobiera value ze słownika) , pprint (preety print moduł w python) , .join (łączy string oraz liste) ********************************************************************
# import pprint
# hobby = {'hobby': 'zbieranie pocztówek', ' ilosc': 2345, 'rodzaje': 6}
# print(hobby.get('cos','nie istnieje'))
# print(hobby.get('rodzaje','nie istnieje'))
# hobby.setdefault('patriotyczne','TX' )
# pprint.pprint(hobby)
#
# print("".join(['ro','be','rt']))



# *************************** medoty dla stringów isalpha() - ( tylko litery, isalnum()- (litery i liczby), isdecimal() - ( tylko cyfry), isspace() -(tylko spacja), istitle() (tylko sting z duza literą)
# ***************************** .ljust , .rjust ,  .center ,  .strip() (usuwa spacje z obu stron), .lstrip() usuwa z lewej strony spacje , rstrip() usuwa z prawej strony spacje ***************************************************

# litery= 'abcd'
# litery_i_liczby= 'abc123'
# liczby = '123'
# spacja= '   '
# duza_litera= 'Bob Jest Moim Bratem'
#
# print(litery.isalpha())
# print(litery_i_liczby.isalnum())
# print(liczby.isdecimal())
# print(spacja.isspace())
# print(duza_litera.istitle())
#
# print('hello'.ljust(20,' '))
# print('hello'.rjust(20,' '))
# print('hello'.center(20,' '))

# print("'      x      '")
# print("      x      ".strip())
# print("      x      ".lstrip())
# print("      x      ".rstrip())


# **************** IF ELIF ELSE************************
# place = 'w pracy'
# if place == 'dom':
#     print("jestem w domu")
# elif place == 'bank':
#     print('jestem w banku')
# elif place == 'park':
#     print ('jestem w parku')
# else:
#     print("jestem w innym miejscu")
#


# ***************FOR LOOP ************************************************
# my_list= [1,2,3,4,5,6,7,8,9,10]
# for lista in my_list:
#     print(lista)


# lista z tuple**********
# moja_lista = [(1,2,3,4),(2,3,5,6),(5,2,4,5)]
# for a,b,c,d in moja_lista:
#     print(d)
#
# *****dictionary items, keys,values,  unpacking*****************************
# d= {'k1':2,'k2': 6,'k3': 9}
# for b in d.values():
#     print(b)

# *********************************** While else loop  **************************************************
# x = 0
# while x < 5:
#     print(f'pierwsza wartosc to {x}')
#     x += 1
# else: print("koniec")

# *****************************brake continue pass*****************************
# moje_Imie = 'ucze sie programować'
# for petla in moje_Imie:
#     if petla == 'o':
#         continue
#     print(petla)
#
# moje_Imie = 'Hubert'
# for petla in moje_Imie:
#     if petla == 'e':
#         break
#     print(petla)
#
# moje_Imie = 'Hubert'
# for petla in moje_Imie:
#     if petla == 'e':
#         pass


# **********************************range, list**************************
# for num in range(0,23,3):
#     print(num)

# a = list(range(0,23))
# print(a)

# **************************************enumarate***************************
# slowo= 'wytrwaly'
# for indeks,letter in enumerate(slowo):
#     print(indeks,letter)


# ***************** import shuffle , random int ,   **********************************************
# from random import shuffle
# my_list10 = [1,2,3,4,5,6,7,8,9,10]
# shuffle(my_list10)
# print(my_list10)


# from random import randint
# print(randint(0,100))



# ******************input function**********************************************
# a= str(input("What is your name ?"))
# print(a)


# ******************* list comprehention *************************************************
# moj_string = 'Robert Jastrzebski'
# moja_lista2 = []
# for litery in moj_string:
#     moja_lista2.append(litery)
# print(moja_lista2)

# moja_lista2 = [litery for litery in moj_string]
# print(moja_lista2)


# moja_lista=[x**2 for x in range(0,10) if x%2==0]
# print(moja_lista)


# ******************** zadania 1*****************************************
# 1 .Use for, .split(), and if to create a Statement that will print out words that start with 's':
# st = 'Print only the words that start with s in this sentence'
# for word in st.split():
#     if word[0] == 's':
#         print(word)

# *****************************************************************************
# 2. Use range() to print all the even numbers from 0 to 10.

# b= list(range(0,11,2))
# print(b)

# *****************************************************************************
# 3.Use List comprehension to create a list of all numbers between 1 and 50 that are divisible by 3.
# b=[x for x in range(1,51) if x%3 == 0]
# print(b)
# *****************************************************************************
#     4.
# st = 'Print every word in this sentence that has an even number of letters'
#
# for word in st.split():
#     if len(word)%2 == 0:
#         print(word + " <-- has an even length!")
#
# *****************************************************************************
# Write a program that prints the integers from 1 to 100.
# But for multiples of three print "Fizz" instead of the number, and for the multiples of five print "Buzz".
# For numbers which are multiples of both three and five print "FizzBuzz".

# for num in range(1,101):
#     if num % 3 == 0 and num % 5 == 0:
#         print("FizzBuzz")
#     elif num % 3 == 0:
#         print("Fizz")
#     elif num % 5 == 0:
#         print("Buzz")
#     else:
#         print(num)

# *****************************************************************************
# Use List Comprehension to create a list of the first letters of every word in the string below:
# st = 'Create a list of the first letters of every word in this string'
# a = [word[0] for word in st.split()]
# print(a)
# **************************functions *********************************************

# def powitanie(imie='imie'):
#     return "witaj "+ imie
# result = powitanie('Robert')
# print(result)

# *********funcja dodawanie*****************
# def oblicz(liczba_1 , liczba2):
#     return liczba_1 + liczba2
#
# wynik= oblicz(2394 , 21312)
# print(wynik)

# ******************Funkcja sprawdza czy rob jest w stringu*****************
# mystring= 'Rob idzie do domu'
# def rob_check(mystring):
#     return 'rob' in mystring.lower()
# print(rob_check(mystring))

# ******************************PIG LATIN****************************************
# def pig_latin(word):
#     first_letter = word[0]
#     if first_letter in 'aeiou':
#         pig_word = word + 'ay'
#     else:
#         pig_word = word[1:] + first_letter + 'ay'
#     return pig_word
#
# print(pig_latin('Robert'))

# ************************zadania funkcje 2  print Hello Name *********************************
#
# def myfunc(name):
#
#     print('Hello {}'.format(name))
#
# myfunc('Robert')

# *************************zadania funkcje 3 simple Boolean ***********************************
# def myfunc(x):
#     if x == True:
#         # print('Hello')
#         return 'Hello'
#     elif x == False:
#         # print('Goodbye')
#         return 'Goodbye'
#
# print(myfunc(False))


# *******************************   *args (zwracaja tuple, **kwargs(zwracaja dictionary) **********************************************************************************

# def myfunc(*args):
#     return sum(args)*2
#
# print(myfunc(20,23,2))




#
# def myfunc(**kwargs):
#     print(kwargs)
#
# print(myfunc(owoce='banan',warzywo='papryka'))




# def myfunc1(**kwargs):
#     if 'owoc' in kwargs:
#         print('Moj ulubiony owoc to {}'.format(kwargs['owoc']))
#     else:
#         print('nie widze zadnego owocu')
#
# myfunc1(owoc="jabłko",warzywo='ziemniaki',mieso='indyk')


# def myfunc(*args,**kwargs):
#     print(args)
#     print(kwargs)
#     print('I would like to eat {} {}'.format(args[0],kwargs['warzywa']))
# print(myfunc(20,32,42,23,24,2314,2313,owoce='winogrona',warzywa='ziemniaki'))


# **************************Funkcje Zadanie**************************************
# Write a function that returns the lesser of two given numbers if both numbers are even,
# but returns the greater if one or both numbers are odd

# def lesser_of_two_evens(a,b):
#     if a%2 == 0 and b%2 == 0:
#         return min(a,b)
#     else:
#         return max(a,b)
# print(lesser_of_two_evens(2, 4))
# print(lesser_of_two_evens(2,5))




# ANIMAL CRACKERS: Write a function takes a two-word string and returns True
# if both words begin with same letter
# def animal_crackers(text):
#     słowa= text.split()
#     return słowa[0][0]==słowa[1][0]
#
# print(animal_crackers('Levelheaded Llama'))
# print(animal_crackers('Crazy Kangaroo'))



# Given two integers, return True if the sum of the integers is 20 or
# if one of the integers is 20. If not, return False

# *******Opcja 1.
# def makes_twenty(n1, n2):
#     return (n1 + n2) == 20 or n1 == 20 or n2 == 20

# *******Opcja 2.
# def makes_twenty(n1, n2):
#     if n1+n2==20:
#         return True
#     elif n1==20 or n2==20:
#         return True
#     else:
#         return False


# print(makes_twenty(0,10))
# print(makes_twenty(20,3))


# ************************************* zadanie 1.************************************************
# Napisz funkcje ktora spowoduje zmiane na wielka litere znak pierwszy oraz 4.
# opcja 1
# def old_macdonald(name):
#
#     pierwsza_litera= name[0]
#     pomiedzy= name[1:3]
#     czwarta_litera=name[3]
#     pozostale=name[4:]
#     return pierwsza_litera.upper()+pomiedzy+czwarta_litera.upper()+pozostale
# print(old_macdonald('macdonald'))


# opcja2
# def old_macdonald(name):
#     first_half=name[:3]
#     rest= name[3:]
#     return first_half.capitalize()+rest.capitalize()
#
# print(old_macdonald('macdonald'))


# ***********************Given a sentence, return a sentence with the words reversed*********
# def reversed (text):
#     wordList = text.split()
#     wordList_reverserd = wordList[::-1]
#     result= "".join(wordList_reverserd)
#     return result
# print(reversed('I am home'))
# print(reversed('We are ready'))

# *************** Given a list of ints, return True if the array contains  a 3 next to a 3 somewhere.

# def has_33(nums):
#     for i in range(0, len(nums) - 1):
#         if nums[i] == 3 and nums[i+1] == 3:
#             return True
#     return False
#
#
# print(has_33([2, 3, 3]))
# print(has_33([1, 3, 1, 3]))

# **********Given a string, return a string where for every character in the original there are three characters**********

# def paper_doll(text):
#     result = ""
#     for i in text:
#         result += i*3
#     return result
#
# print(paper_doll('Hello'))
# print(paper_doll('Mississippi'))

# ***BLACKJACK: Given three integers between 1 and 11, if their sum is less than or equal to 21, return their sum.
# If their sum exceeds 21 *and* there's an eleven, reduce the total sum by 10. Finally, if the sum (even after adjustment) exceeds 21, return 'BUST'**********
# def blackjack(a, b, c):
#     if sum([a,b,c]) <= 21:
#         return sum([a, b, c])
#
#     elif sum([a, b, c]) < 31 and 11 in [a, b, c]:
#         return sum([a, b, c]) - 10
#     else:
#         return "BUST"
# print(blackjack(5,6,7))
# print(blackjack(9,9,9))
# print(blackjack(9,9,11))


# ***************SUMMER OF '69: Return the sum of the numbers in the array, except ignore sections of numbers starting with a 6
# and extending to the next 9 (every 6 will be followed by at least one 9). Return 0 for no numbers.**************************************************************
#
# def summer_69(arr):
#     total = 0
#     add = True
#     for num in arr:
#         while add:
#             if num != 6:
#                 total += num
#                 break
#             else:
#                 add = False
#         while not add:
#             if num != 9:
#                 break
#             else:
#                 add = True
#                 break
#     return total
#
# print(summer_69([1, 3, 5]))
# print(summer_69([4, 5, 6, 7, 8, 9]))
# print(summer_69([2, 1, 6, 9, 11]))

# *********************************Write a Python function that accepts a string and calculates the number of upper case letters and lower case letters.******************************
# Sample String : 'Hello Mr. Rogers, how are you this fine Tuesday?'
# Expected Output :
# No. of Upper case characters : 4
# No. of Lower case Characters : 33

#
# def up_low(s):
#     dictionary = {'upper': 0,'lower': 0}
#     for i in s:
#         if i.isupper():
#             dictionary["upper"] +=1
#         elif i.islower():
#             dictionary["lower"] +=1
#         else:
#             pass
#     print ("orginal string: ", s)
#     print ("No. of Upper case characters :", dictionary['upper'])
#     print ("No. of lower case characters :", dictionary['lower'])
#
#
# s = 'Hello Mr. Rogers, how are you this fine Tuesday?'
# print(up_low(s))
#


# **************************Write a Python function that takes a list and returns a new list with unique elements of the first list.*****************************************
# def unique_list(list):
#     x = []
#     for a in list :
#         if a not in x:
#             x.append(a)
#     return x
#
#
# print(unique_list([1,1,1,1,2,2,3,3,3,3,4,5,324,235,235,34,5,43,543,5,34,5,3]))




# **************************************************************Write a Python function to multiply all the numbers in a list.***************************************************
# def multiply(numbers):
#     total = 1
#     for x in numbers:
#         total *=x
#     return total
# print(multiply([2,1,1,-4]))


# **************************** Palindrome - Write a Python function that checks whether a passed string is palindrome or not. ************************************************************

# def palindrome(a):
#     a = a.replace(" ","")
#
#     return a == a[::-1]
#
# print(palindrome('helleh'))
# print(palindrome('abcba'))

# ********************************************************************************Object Oriented Programming Challenge**************************************************************************
# For this challenge, create a bank account class that has two attributes:
#
# * owner
# * balance
#
# and two methods:
#
# * deposit
# * withdraw
#
# As an added requirement, withdrawals may not exceed the available balance.
#
# Instantiate your class, make several deposits and withdrawals, and test to make sure the account can't be overdrawn.

# class Account:
#
#     def __init__(self, owner, balance=0):
#         self.owner = owner
#         self.balance = balance
#
#     def deposit(self, dep_amount):
#         self.balance += dep_amount
#         print('deposit accepted')
#
#     def withdraw(self, wd_amount):
#         if self.balance >= wd_amount:
#             self.balance -= wd_amount
#             print('transaction accepted')
#         else:
#             print('withdraw rejected ')
#
#     def __str__(self):
#         return f'Owner is {self.owner} \nAccount balance: {self.balance}$'
#
# # 1. Instantiate the class
# acct1 = Account('Jose', 100)
#
# # 2. Print the object
# print(acct1)
#
# # 3. Show the account owner attribute
# acct1.owner
#
# # 4. Show the account balance attribute
# acct1.balance
#
# # 5. Make a series of deposits and withdrawals
# acct1.deposit(50)
#
# acct1.withdraw(75)
#
# # 6. Make a withdrawal that exceeds the available balance
# acct1.withdraw(500)


# ************************************************* regular expressions (re.compile, search, group -znajdzie tylko pierwszy)
# ( (  )* moze wystawipic albo 0 albo wiele razy, ( )? moze wystapic ale nie musi,
# ( )+ musi wystapic przynajmniej raz ,( ) { } tu definiujemy ile razy ma wystapic wyraznie
# ^ znak przeciwstawny, .sub zamienia wertosci znalezione , | albo   , \! \( \ + zna *****************************************************************************************************
# import re
# do_analizy = r'moj numer to  a mojej siostry (+48)666-456-191, (+48)666-456-192, 666-456-192, '
# # do_analizy2= 'batman jedze do domu batmobile batman!!!!!!!!!!!!!!!!'
# #
# numer_regex = re.compile(r'''
# ((\(\+\d\d\))?    #prefix opcjonalny
# \d\d\d          #pierwsze 3 liczby
# -               #
# \d\d\d          # kolejne 3 liczby
# -               #
# \d\d\d(,)?)     # ostatnie 3 liczby  z opcjonalnym,
# ''',re.VERBOSE)
# zmaczowany= numer_regex.findall( do_analizy)
# # "'".join(zmaczowany)
# telefony= []
#
# for phonenumer in zmaczowany:
#     telefony.append(phonenumer[0])
# print(telefony)
# lista_telefonów='\n'.join(telefony)
# print(lista_telefonów)
#


# word_regex = re.compile(r'bat(man|mobile|copter)(!)*')
# zmaczowany2 = word_regex.search(do_analizy2)
# print(zmaczowany2.group())
#
#
# vowelRegex = re.compile(r'[^aeiouAEIOU]{1}')
# nowy3= vowelRegex.findall('Robocop eats baby food. baby food.')
# print(nowy3)
# namesregex =re.compile(r'Agent (\w)\w+')
# names=namesregex.findall('Agent Bob gave the secret documents to Agent Tom')
# print(names)
# tajne=namesregex.sub(r'Tajne \1****','Agent Bob gave the secret documents to Agent Tom')
# print(tajne)