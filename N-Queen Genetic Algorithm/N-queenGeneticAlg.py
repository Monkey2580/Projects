import random
import copy
from itertools import chain
from time import *
from time import process_time


list_of_boards = []


class EmptyBoard(object): # Makes an empty board the size of queen x queen
    def __init__(self):
        self.QLoc = []
        self.Attack = 0


class Board(object):
    def __init__(self):
        self.QLoc = []
        self.Attack = 0


def make_board(size):
    for i in range(size):
        list_of_boards.append(EmptyBoard())


def random_board(board, row, nqueen): # randomize the location of the queens in the board
    for i in range(row):
        rd = random.randrange(0, nqueen)
        board.QLoc.append(rd)


def check_fittest(board): # check how many queens are attacking each other
    for i in board:
        queen_attacked(i)


def sort_list(board):
    board.sort(key=lambda board: board.Attack)


def crossover(board): # Taking 2 parents and crossing their queens placement
    child_list = []
    for i in range(population):
        p1 = random.randrange(0, int(population / 2))
        p2 = random.randrange(0, int(population / 2))
        rd = random.randrange(0, len(board[0].QLoc))

        child_list.append(Board())
        child_list[i].QLoc.append(copy.deepcopy(board[p1].QLoc[slice(rd)]))
        child_list[i].QLoc.append(copy.deepcopy(board[p2].QLoc[slice(rd,len(board[p2].QLoc))]))
        child_list[i].QLoc = list(chain.from_iterable(child_list[i].QLoc))
        
    return child_list



def mutation(board,nQueen): # introducing some mutation to the board so there's a new variable
    random_picker = random.randrange(0, len(board))
    random_col = random.randrange(0, len(board[random_picker].QLoc))
    random_row = random.randrange(0, nQueen)
    
    board[random_picker].QLoc[random_row]=random_col

                
def queen_attacked(board): # the actual calculation of checking which queen is attacking which queen
    passed = []
    attack = 0
    
    for qLoc in board.QLoc:
        if(qLoc in passed):
            attack +=1
        else :
            passed.append(qLoc)
             
    for row in range(len(board.QLoc)):  
        for secRow in range(row+1,len(board.QLoc)):
            deltaRow = abs(secRow - row )
            deltaCol = abs(board.QLoc[row] - board.QLoc[secRow])
            
            if(deltaRow == deltaCol):
                attack+=1
                
    board.Attack=attack
            
        

print("This program is not yet optimized so the bigger the input the longer it takes to calculate")
BxB=input("Enter the amount of queens in the board (min:4) :")
print("number of population ↑ time to process ↓")
print("number of population ↓ time to process ↑")
Pop =input("How many population would you like in 1 generation (min:4) :")
Nqueen=int(BxB)
population=int(Pop)

make_board(population)
for i in range(population):
    random_board(list_of_boards[i], Nqueen, Nqueen)
check_fittest(list_of_boards)
j = 10
sort_list(list_of_boards)
gen = 1
t1_start = process_time()
solution =0
while j!=0:

    list_of_boards = crossover(list_of_boards)
    check_fittest(list_of_boards)
    sort_list(list_of_boards)
    for i in list_of_boards:
        if i.Attack == 0:
            sort_list(list_of_boards)
            j = 0
            solution = i
            break
        else:
            mutation(list_of_boards,Nqueen)
    gen += 1
    
t1_stop = process_time()
print("the visualisation of the chessboard:")
print("-------------------------------------")
for row in range(Nqueen):
    for col in range(Nqueen):
        if(col == solution.QLoc[row]):
            print(' 1 ',end='')
        else :
            print(' 0 ',end='')
    print()
print("-------------------------------------")
print("The desired output:",solution.QLoc)
print("answer found on generation:", gen)
print("Elapsed time:", t1_stop, t1_start)
if (t1_stop - t1_start) <59.99:
    print("Elapsed time during the whole program in seconds:", t1_stop - t1_start)
elif (t1_stop - t1_start) >=60.00 and (t1_stop - t1_start) < 3599.99:
    res = (t1_stop - t1_start)/60
    print("Elapsed time during the whole program in minutes: {:.2f}".format(res))
else:
    res = (t1_stop - t1_start) / 3600
    print("Elapsed time during the whole program in hours:{:.2f}".format(res))
sleep(10)

