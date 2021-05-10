import random
'''
print("hello world\nHello World")
owoc = input("co lubisz jeść?")
print(owoc)
----------------
imie = len(input("what is your \n"))
print(imie)

a= input("a:\n")
b= input("b:\n")
c=a
a=b
b=c

print("a jest :" + a)
print("b jest :" + b)

liczba = input("podaj liczba dwucyfrowa")

pierwsza_liczba=liczba[0]
druga_liczba=liczba[1]
rezultat = int(pierwsza_liczba) + int(druga_liczba)
print(rezultat)
-------------Love calculator--------------------
imie1 = "Robert"
imie2 = "Asia"
polaczone_imiona = imie1.lower()+imie2.lower()
print(polaczone_imiona)

ile_T= polaczone_imiona.count("t")
ile_R= polaczone_imiona.count("r")
ile_U= polaczone_imiona.count("u")
ile_E= polaczone_imiona.count("e")

ile_L= polaczone_imiona.count("l")
ile_O= polaczone_imiona.count("o")
ile_V= polaczone_imiona.count("v")
ile_E= polaczone_imiona.count("e")

total_True=ile_T+ile_R+ile_U+ile_E

total_Love=ile_L+ile_O+ile_V+ile_E

result = int(str(total_True)+str(total_Love))
if (result>90 or result<10):
    print(f"twoj wynik to {result} super jak kola i mentos")
elif(result>40 and result<50):
    print(f"twoj wynik to {result} bedzie wam dobrze razem")
else:
    print(f"twoj wynik to {result})")
'''
# --------------random -----------------------------
# random_int=random.random()*5
# print(random_int)

# -----------listy------------------------------------
# owoce=["jablko","banan","arbuz"]
# print(owoce[2])

# ----------------kto płaci za rachunek ruletka:)----------------------------
# lista= "Angela, Ben, Jenny, Michael, Chloe"
# lista_imion= lista.split(", ")
# print(lista_imion)
# dlugosc_listy =len(lista_imion)
# losowa_liczba = random.randint(0,dlugosc_listy-1)
# print(f"dzis za rachunek placi {lista_imion[losowa_liczba]}")


# Papier, kamień, nożyce
# komputer_wybor= random.randint(0,2)
# wybór = int(input("Co wybierasz 0 dla kamienia,1 dla papieru, 2 dla nozyczek \n"))
# elementy=["kamien","papier","nozyczki"]
#
#
# if komputer_wybor==0:
#     print(f"komputer wybrał {elementy[0]}")
# elif komputer_wybor==1:
#     print(f"komputer wybrał {elementy[1]}")
# else:
#     print("Komputer wybrał nożyczki")
#
# if wybór==0:
#     print("Gracz wybrał kamień")
# elif wybór==1:
#     print("Gracz wybrał papier")
# else:
#     print("Gracz wybrał nożyczki")
#
#
#
# if (wybór==komputer_wybor):
#     print("Remis")
# if (wybór>2 or wybór<0):
#     print("Przegrtywasz wpisałes nieprawidłowy numer.")
# elif(wybór==0 and komputer_wybor==1):
#     print("Komputer wygrywa")
# elif(wybór==0 and komputer_wybor==2):
#     print("Wygrywasz")
# elif (wybór == 1 and komputer_wybor == 0):
#     print("Wygrywasz")
# elif (wybór == 1 and komputer_wybor == 2):
#     print("Komputer wygrywa")
# elif (wybór == 2 and komputer_wybor == 0):
#     print("Komputer wygrywa")
# elif (wybór == 2 and komputer_wybor == 1):
#     print("Wygrywasz")
#
#
# ----------------petle----------------------------
# owoce = [1,2,3]
# for liczba in owoce:
#     print(liczba)


# ----------zadanie loops--------------------------
# student_heights = [180, 124, 165, 173, 189, 169, 146]
# ilosc_uczniów = len(student_heights)
# print(ilosc_uczniów)
# łączna_suma = 0
# for student in student_heights:
#     łączna_suma+=student
# srednia = round(łączna_suma/ilosc_uczniów)
# print(srednia)

# ------------zadanie 2 loops-------------------------
# student_scores = [78, 65, 89, 86, 55, 91, 64, 89]
# najwyzsza_ocena=0
# for score in student_scores:
#     if score>najwyzsza_ocena:
#         najwyzsza_ocena=score
# print(f"najwyzsza ocena to {najwyzsza_ocena}")
# --------------------------adding even number------------------------
# suma=0
# for number in range(1,101):
#     if number%2==0:
#         suma+=number
#
# print(suma)


# --------------FizzBuzz ---------------------

#
# for numer in range(1,101):
#     if numer%3==0 and numer%5==0:
#         print("FizzBuzz")
#     elif numer%5==0:
#         print("Buzz")
#     elif numer % 3 == 0:
#         print("Fizz")

# ------------------random.choice wybiera losowo a  random.shuffle miesza ----------------

# s = ["robert","asia"]
# random.shuffle(s)
# wybor= random.choice(s)
# print(wybor)
# print(s)

# ------------------------Functions -------------------------------------------------------
#
# def my_function():
#     print("hello Robert")
#
# my_function()

# -----------------------wile loop----------------------------------------------------------
# liczba=1
# while  liczba <10:
#     print(liczba)
#     liczba+=1
# ------------------------------------------------------------------------------------------
