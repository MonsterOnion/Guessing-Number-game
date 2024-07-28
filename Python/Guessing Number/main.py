import random as rand

class Player:

	def __init__ (self, win, lose):
		self.win = win
		self.lose = lose

p1 = Player(0, 0)

win = p1.win
lose = p1.lose


def gameLogic(x):
	global win
	global lose

	while True:
		print(x + " your score is", end = " ")
		print("Win: " + str(win), end = "and ")
		print("Lose: " + str(lose))
		playerNumber = int(input("Enter your number here:"))
		playerResult = calculate(playerNumber)
        
		if playerResult == True:
			win += 1
		else:
			lose += 1

def calculate(x):
	y = rand.randint(0, 9)
	if x == y:
		print("You win!")
		print("Correct number is: " + str(y))
		return True
	else:
		print("You lose!!!")
		print("Correct number is: " + str(y))
		return False


# main
print("Hello! welcome to the guessing number")
print("The game to guess number between 0 - 9")

while True:
	userName = input("If you want to play, please enter your name here:")
	if userName != '':
		gameLogic(userName)
