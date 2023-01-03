# SVEggBot
[sys-botbase](https://github.com/olliz0r/sys-botbase) client Shiny Egg Farmbot for Pokémon Scarlet and Violet.

Automatically sets up a picnic, makes a great peanut butter sandwich and checks the basket for eggs.

Sysbot is required to use this program. For more information on how to install sysbot see [sys-botbase](https://github.com/olliz0r/sys-botbase)

## Usage
* Place the Pokémon you want to breed in your party
* Clear out 3 consecutive boxes in your PC for the eggs to go and exit the PC on the first box you cleared
* Stand in a flat secluded area, preferably the area outside the Zero Gate
* Turn off Autoave and maunally save your game
* Start a picnic and take note of how many right presses and down presses it takes to navigate to the Great Peanut Butter Sandwich Recipe
* Open your party menu and ensure your cursor is on the first Pokémon in your party and close the menu
* Open the program and enter your switch's IP into the textbox and hit Connect
* Enter the number of Down and Right presses needed to reach the Recipe in the appropriate number boxes
* Enter the Box Number of the first empty box you set aside for the eggs into the appropriate number box
* Hit Start Picnic and let the bot do its work. The status message at the top will change to "Shiny Found!" when a shiny egg is found and the bot will idle in place.

## Settings
* Right Presses To Recipe: Number of right D-Pad presses required to reach the sandwich recipe (Should only need to be 0 or 1).
* Down Presses To Recipe: Number of down D-Pad presses required to reach the sandwich recipe.
* Starting Box #: First of the 3 consecutive empty boxes that eggs from the picnic will populate.
* \# of A Presses at Basket: Number of times the bot will mash the A Button at the basket when collecting eggs.
* Delay Settings (in ms)
 * Base delay for all inputs: Generic delay added to all inputs to give the game more time to open menus and process input. May need to be tweaked depending on connection strength.
 * Open Home Menu delay: Delay for opening the home menu.
 * Delay for closing game: Delay after closing game on home menu before inputs resume.
 * Delay for starting picnic: Delay between the pressing of the picnic button and when the player regains control.
 * Delay for starting sandwich: Delay between final selection of ingredients and when the player regains control to make the sandwich.
 * Sandwich Ingredient travel time: Time to move cursor to ingredients (and also back to the sandwich).
 * Walk to table time: Time to walk forward to the table after starting the picnic.
 * Basket Walk Delays: Walking to the basket is performed by walking to the left of the table, forward to the end of the table, and then right to the basket.
   * Walk to basket time part 1 (facing left): Time needed to go past left end of the table.
   * Walk to basket time part 2 (facing forward): Time needed to walk to the other end of the table.
   * Walk to basket time part 3 (facing right): Time needed to walk from the last step to the basket.
 * Game startup delay: Time needed to go from launching the game to reach the start menu and time needed to go from the start menu to gaining control of the player.
 * Basket Dialog input delay: Additional delay on top of base delay for navigating through the egg basket text boxes.
 * Time between basket checks: Time to idle at the basket before checking for eggs.

## Test Buttons
Each Test Button is used to test out delay settings for your connection
* Test Picnic Setup: Runs through the process of starting a picnic to walking up to the table (Requires the first pokemon in the party to be selected on the pause menu).
* Test Sandwich Making: Tests selecting the correct recipe, making the sandwich, and returning to the picnic (Requires player to be standing in front of the table).
* Test Basket Walk: Walks player from the front of the picnic table where they make a sandwich to the basket. Press A after running to make sure you are close enough to the basket.
* Test Game Reset: The bot should open the home menu, close the game, reopen the game and get past the start menu.
* Test Basket Dialog: Runs through one round of mashing A at the basket and then mashing B a few times to ensure we do not have an open dialog box.

Requires SysBot.Base.dll from [kwsch/SysBot.NET](https://github.com/kwsch/SysBot.NET)
