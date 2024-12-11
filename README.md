# Goal-Oriented Action Planning

Goal-Oriented Action Planning (GOAP) is an AI technique that is used to determine how a character should act and behave in order to achieve a goal or set of goals. This technique is especially helpful in games where a character might have to track a lot of information and change behaviors based on the information they know, like stealth games. Our job as the programmer is to determine what information the characters need to track and how to shift between behaviors in order to achieve their current goal or goals.

## Why is GOAP useful?

GOAP allows characters to behave in specific ways that correlate to the goals we've set out for them. By combining all the information that we are having the character track, we can determine a behavior for that character that would best their needs and goals. Let's take the example below.

![image](https://github.com/user-attachments/assets/6190ff75-3fa4-4bde-8a56-63445fcfcf2b)

The red player piece is trying to kick to white ball into the goal on the right. In order to do this, the red piece has two pieces of information that it is tracking: the position of itself in respect to the ball and whether or not the ball has been kicked. At the start of the simulation, the player is far away from the ball and cannot kick it, thus we give it the behavior to move toward the ball.

![image](https://github.com/user-attachments/assets/3fca5394-ffdd-43e5-804a-5f98ff487f3e)

Once this behavior gets the player within range of the ball, we shift it's behavior to have it hit the ball into the net. By doing this, we have satisfied the player's goals.

![image](https://github.com/user-attachments/assets/1d41bf3b-7c9d-4175-829a-9344c95367eb)

## How does GOAP function?

GOAP has a list of boolean values that will determine how a character behaves. So for the above example, the red player piece had to track whether it was at the ball and whether or not the ball was kicked. If neither were true, we moved the player toward the ball. Once the player reached the ball, we shift the behavior to kicking the ball. Once the ball is kicked, the player no longer needs to do anything because its goals have been met.

The above example is a very basic example however. The best way to utilize this technique is when a character is tracking multiple different things. This can work extremely well in spy games because of how many things a guard might need to track. For example, let's a charater who is guarding a specific safe from the player. This guard might need to track a ton of things, such as whether they know the player is near them, if they have taken damage, if the player is dead, if they are in immidiate danger, and even some smaller things like whether they have a weapon or even if they have decided to take cover. These are a ton of boolean values that the character needs to keep track of and it could be somewhat difficult to manage, but with GOAP, it becomes a lot easier to manage.
