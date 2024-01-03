# MatchGame

## What is this Game ? 
<br> 

MatchGame is a fun and simple memory game where the player has to find matching pairs of animal emojis. The game consists of a grid of 16 text blocks, each displaying a question mark. When the player clicks on a text block, it reveals an animal emoji behind it. The player has to remember the location of each emoji and click on another text block that has the same emoji. If the player finds a matching pair, the text blocks disappear and the player earns a point. If the player does not find a matching pair, the text blocks flip back to question marks and the player has to try again. The game ends when the player finds all the matching pairs or runs out of time. The game also displays the elapsed time and the number of attempts the player has made.

## Tech side of the game 

- The game is developed using C# and XAML in Visual Studio Code.
- The game uses a Window class to create the main window of the game, which contains a Grid element named mainGrid.
- The mainGrid element has four rows and four columns, each containing a TextBlock element that displays a question mark or an animal emoji.
- The game uses a List<string> named animalEmoji to store the 16 animal emojis that are used in the game. The animal emojis are Unicode characters that represent different animals, such as 🐱, 🐶, 🐻, etc.
- The game uses a Random object named random to generate random numbers for shuffling and selecting the animal emojis.
- The game uses a SetUpGame method to initialize the game. This method shuffles the animalEmoji list using the Fisher-Yates algorithm and assigns the animal emojis to the textBlock elements in the mainGrid. The method also sets the visibility of the textBlock elements to visible and the text of the timeTextBlock element to “Elapsed time”.
- The game uses a TextBlock_MouseDown event handler to handle the mouse clicks on the textBlock elements. This event handler checks if the textBlock element has a question mark or an animal emoji, and reveals or hides the animal emoji accordingly. The event handler also checks if the player has found a matching pair or not, and updates the score and the game state accordingly.
- The game uses a TimeTextBlock_MouseDown event handler to handle the mouse clicks on the timeTextBlock element. This event handler resets the game by calling the SetUpGame method and setting the timer to zero.
- The game uses a DispatcherTimer object named timer to keep track of the elapsed time. The timer has an interval of one second and a Tick event handler that updates the text of the timeTextBlock element with the formatted time. The timer also checks if the game is over or not, and stops the timer accordingly.
<br>




