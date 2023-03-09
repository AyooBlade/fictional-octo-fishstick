

map=["-","-","-",
     "-","-","-",
     "-","-","-",]

#SEX

CurrentPlayer='X'
winner=None
Gamerunning=True

# Print the map
def printmap(map):
    '''Kiírja a játékteret'''
    print (map[0]+ " | " + map[1] + " | " + map[2])
    print("---------")
    print (map[3]+ " | " + map[4] + " | " + map[5])
    print("---------")
    print (map[6]+ " | " + map[7] + " | " + map[8])

def playerinput(map):
    '''Bekéri hova szeretne lépni a játékos'''
    playermove = int(input("Hova szeretnél lépni? "))
    if playermove>=0 and playermove<=9 and map[playermove-1]=="-":
        map[playermove-1]=CurrentPlayer
    else:
        print("Már foglalt az a pozíció")
        playerinput(map)
        
def check_x(map):
    '''ellenőrzi hogy x tengelyen nyert-e valaki'''
    global winner
    if map[0] == map[1] == map[2] and map[1] != "-":
        winner = map[0]
        return 
    elif map[3] == map[4] == map[5] and map[3] != "-":
        winner = map[3]
        return 
    elif map[6] == map[7] and map[8] and map[6] != "-":
        winner = map[6]
        return 

def check_y(map):
    '''ellenőrzi hogy y tengelyen nyert-e valaki'''
    global winner
    if map[0] == map[3] == map[6] and map[3] != "-":
        winner = map[0]
        return 
    elif map[1] == map[4] == map[7] and map[1] != "-":
        winner = map[1]
        return 
    elif map[2] == map[5] == map[8] and map[8] != "-":
        winner = map[2]
        return 
    
def checkdiag(map):
    '''Ellenőrzi valaki nyert-e átlóba'''
    global winner
    if map[0] == map[4] == map[8] and map[4] != "-":
        winner = map[0]
        return 
    elif map[2] == map[4] == map[6] and map[4] != "-":
        winner = map[2]
        return 

def checktie(map):
    '''ellenőrzi hogy döntetlen lett-e a játék'''
    global Gamerunning
    if "-" not in map:
        printmap(map)
        print("Döntetlen lett!")
        Gamerunning = False

def switchplayer(Cplayer):
    '''Átvált a másik játékosra'''
    global CurrentPlayer
    if Cplayer == 'X':
        CurrentPlayer='O'
    elif Cplayer =='O':
        CurrentPlayer='X'

def end(winner):
    '''kiírja ki nyert'''
    if winner =='X':
        print (f"A nyertes az {winner} játékos")
        exit()
    elif winner =='O':
        print (f"A nyertes az {winner} játékos")
        exit()


def main():
    '''This is the main program'''
    while Gamerunning:
        printmap(map)
        playerinput(map)
        check_x(map)
        check_y(map)
        checkdiag(map)
        checktie(map)
        end(winner)
        switchplayer(CurrentPlayer)
        

main()

