reset = 0
while reset == 0:

    choice = input("\nC - stopnie Celsjusza na Fahrenheity\nF - stopnie Fahrenheita na Celsjusze\nTwój wybór: ")

    if choice == str("f"):
        c = float(input("Podaj ilośc stopni Fahrenheita: "))
        x = (c-32)/1.8
        print(x)

    elif choice == str("F"):
        c = float(input("Podaj ilośc stopni Fahrenheita: "))
        x = (c-32)/1.8
        print(x)

    elif choice == str("c"):
        c = float(input("Podaj ilośc stopni Celcjusza: "))
        y = (c*1.8) + 32
        print(y)

    elif choice == str("c"):
        c = float(input("Podaj ilośc stopni Celcjusza: "))
        y = (c * 1.8) + 32
        print(y)

    else:
        print("Błąd")

