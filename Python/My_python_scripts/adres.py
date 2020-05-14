#! python3
import sys, webbrowser, pyperclip

sys.argv
historia=[]
historia.append(sys.argv[1])
    #sprawdz czy adres został wpisany
if len(sys.argv)>1:
    adres = ' '.join(sys.argv[1:])
    print(adres)
else:
    adres = pyperclip.paste()

webbrowser.open('https://www.google.pl/maps/place/'+adres)
print(historia)


