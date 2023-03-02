import os
os.system("cls")
def register():
    while True:
        username = input("Felhasználónév: ")
        password = input("Jelszó: ")
        # felhasználónév ellenőrzése
        with open("Felhasznalok.txt", "r") as f:
            for sor in f:
                if sor.startswith(username):
                    print("A felhasználónév már foglalt.")
                    break
            else:  # ha a break nem hajtódik végre

                # Kiírjuk a megadott adatokat
                with open("Felhasznalok.txt", "a") as f:
                    f.write(f"{username}|{password}\n")
                    print("Sikeres regisztráció!")
                    return username
        print("Kérjük adjon meg egy másik felhasználónevet.\n")
def login():
    attempts = 0
    while attempts < 3:
        username = input("Felhasználónév: ")
        password = input("Jelszó: ")
        with open("Felhasznalok.txt", "r") as f:
            felhasznalo = [line.strip().split("|") for line in f]
        for user in felhasznalo:
            if user[0] == username and user[1] == password:
                print("Sikeres bejelentkezés!")
                return
        os.system("cls")
        print("Hibás felhasználónév vagy jelszó!\nPróbálkozz újra!\n")
        attempts+=1
    os.system("cls")
    print("Sajnos túl sokszor hibáztad el a bejelentkezést, átírányítunk a regisztrációhoz")
    register()      

    
    
    
    

    
username = register()
print(f"Üdvözöljük, {username}!")
asd = input("Mit szeretne tenni? (register/login) ")
os.system("cls")
if asd == "register":
    register()
elif asd == "login":
    login()
else:
    print("Helytelen akció! Kérjük, adja meg a 'register' vagy 'login' parancsot.")