# Goal-Oriented Action Planning

Goal-Oriented Action Planning (GOAP) is an AI technique that is used to determine how a character should act and behave in order to achieve a goal or set of goals. This technique is especially helpful in games where a character might have to track a lot of information and change behaviors based on the information they know, like stealth games. Our job as the programmer is to determine what information the characters need to track and how to shift between behaviors in order to achieve their current goal or goals.

## Why is GOAP useful?

GOAP allows characters to behave in specific ways that correlate to the goals we've set out for them. By combining all the information that we are having the character track, we can determine a behavior for that character that would best their needs and goals. Let's take the example below.



This is a very basic exmaple, but the red player piece has two pieces of information that it is tracking: position of itself in respect to the ball and whether or not the ball has been kicked. The player's goal is to kick the ball into the goal. At the start of the simulation, the player is far away from the ball and cannot kick it, thus we give it the behavior to move toward the ball. Once this behavior gets the player within range of the ball, we shift it's behavior to have it hit the ball into the net. By doing this, we have satisfied the player's goals.

## How does GOAP function?

GOAP have a list of goals and actions that the character can perform and we assign each goal an action that will satisfy that goal, then we perform the actions in order to satisfy the goals. In order to determine which action to perform first, we can use weights in order to determine which goal the character is most interested in satisfying.

Let's take the above example of a sad person that needs to go to the store to do some shopping. This character has two goals: go shopping and pout. That character had already made plans to go shopping so we should already have set the weight of this goal, let's say it's 3 (on a scale from 1-5). Let's say the character's sadness isn't that serious. We can assign a weight of 1 to the goal of pouting. Since the character's shopping goal has a higher weight than the character's pouting goal, we prioritize sending the character to the store to go shopping over having them pout.

However, this does not mean we have to wait for the shopping to be done to start the pouting. If we recognize that we can do both at the same time, then we do so. The weights we set don't determine the _order_ of actions we take, they determine the _priority_ of actions we take. Let's take another example and say we have a soccer player who wants to kick a ball into the net. The player has two goals: getting near the ball and kicking the ball into the net. We are most interested in kicking the ball into the net so we set its weight to 4. Getting to the ball is important, but if we have teammates close to it we don't necessarily need to get near it, so we'll set its weight to 2. Now let's say the player is 40 feet away from the ball. The highest weighted goal they have is kicking the ball, but they're 40 feet away from it so they can't currently kick it, so we move on to the next goal, which in this case is getting near the ball. We perform the action of moving toward the ball until we are in a proper position to kick the ball into the goal, then since we have a higher priority of kicking the ball than we do moving near the ball, we perform the action to kick the ball into the net.
