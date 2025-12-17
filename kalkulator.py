reset = 0
while reset == 0:
    choice = int(input("1.Dodawanie\n2.Odejmowanie\n3.Mnożenie\n4.Dzielenie\n5.Zakończ\nWybierz rodzaj działania: "))
    if choice == 1:
        print("Wybrano dodawanie")
        x = float(input("Podaj pierwszą liczbę: "))
        y = float(input("Podaj drugą liczbę: "))
        print(x+y)
        reset + 1
    elif choice == 2:
        print("Wybrano odejmowanie")
        x = float(input("Podaj pierwszą liczbę: "))
        y = float(input("Podaj drugą liczbę: "))
        print(x-y)
        reset + 1
    elif choice == 3:
        print("Wybrano mnożenie")
        x = float(input("Podaj pierwszą liczbę: "))
        y = float(input("Podaj drugą liczbę: "))
        print(x * y)
        reset + 1
    elif choice == 4:
        print("Wybrano dzielenie")
        x = float(input("Podaj pierwszą liczbę: "))
        y = float(input("Podaj drugą liczbę: "))
        if y == 0:
            print("Nie można dzielić przez 0.")
            reset + 1
        else:
            print(x / y)
            reset + 1
    else:
        print("Niepoprawny wybór")


