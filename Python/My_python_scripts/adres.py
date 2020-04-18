#! python3
import sys, webbrowser, pyperclip

sys.argv
historia=[]
historia.append(sys.argv[1])
    #sprawdz czy adres został wpisany
if len(sys.argv)>1:
    adress = ' '.join(sys.argv[1:])
    print(adress)
else:
    adress = pyperclip.paste()

webbrowser.open('https://www.google.pl/maps/place/'+adress)
print(historia)


