class Player
  attr_accessor :win, :lose

  def initialize(win, lose)
    @win = win
    @lose = lose
  end

end

class GameLogic

  def start(name)
    player1 = Player.new(0, 0)
    computer = Player.new(0, 0)

puts "Hello #{name}"

    loopdo
      puts "#{name}: Wins #{player1.win}, Loses #{player1.lose}"
      puts "Computer: Wins #{computer.win}, Loses #{computer.lose}"

      puts "Guess a number between 0 and 9: "
    input = gets.chomp
    number = input.to_i

    result = calculate(number)
    if result
      player1.win += 1
      computer.lose += 1
      else
        player1.lose += 1
        computer.win += 1
    end

      puts "Do you want to play again? (yes to continue, anything else to quit): "
      continue = gets.chomp.downcase
      break unless continue == 'yes'
    end
  end

  def calculate(x)
    y = rand(10)

    if x == y
      puts "You win!! The correct number was: #{y}"
      return true
      else
        puts "You lose. The correct number was: #{y}"
        return false
    end
  end
end

puts "Welcome to the Ruby edition of the guessing number game"
puts "In this game, you have to guess a number between 0 and 9"

running = true
while running
  puts "Enter your name to start playing: "
  player_name = gets.chomp

  if player_name.strip.empty?
    puts "The name cannot be empty!"
  else
    game = GameLogic.new
    game.start(player_name)
    puts "Do you want to start a new game? (yes to start, anything else to quit): "
    continue = gets.chomp.downcase
    running = false unless continue == 'yes'
  end
end
