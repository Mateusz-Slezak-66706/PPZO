Liczba_ocen = int(input("Podaj liczbę ocen: "))

Suma = 0

for i in range(Liczba_ocen):
    while True:
        ocena = float(input(f"Podaj ocenę {i + 1} (1–6): "))
        if 1 <= ocena <= 6:
            Suma += ocena
            break
        else:
            print("Błąd! Ocena musi być w zakresie od 1 do 6.")

srednia = Suma / Liczba_ocen

if srednia >= 3:
    print(f"Zdałeś! Średnia ocen to: {srednia}")
else:
    print(f"Nie zdałeś! Średnia ocen to: {srednia}")
