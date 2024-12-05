# Goal-Oriented Action Planning

Goal-Oriented Action Planning (GOAP) is an AI technique that is used to determine how a character should act and behave in order to achieve a goal or set of goals. This technique is especially helpful in games where a character might have to track a lot of information and change behaviors based on the information they know, like stealth games. Our job as the programmer is to determine what information the characters need to track and how to shift between behaviors in order to achieve their current goal or goals.

## Why are Goal-Oriented Behaviors useful?

GOAP allows characters to behave in specific ways that correlate to the goals we've set out for them. By combining all the information ___For example, let's say we have a character whose favorite sports team just lost. This character would be sad and we can use GOAP to have them act sad, such as placing a rain cloud above their head and have them move around slouching over. As another example, let's say one of our characters needs to go shopping at a specific time. We can have a GOAP setup to have them act normally, but the moment that time comes, they head to the store.

We can also combine these two scenarios. Let's say this character needs to go to the store but they are also sad. The GOAP will determine how they act. If they are too sad to go to the store, they might choose to not go despite the fact that they made plans to go. If they end up going to the store anyway, they might still act sad while at the store. These examples are very basic ideas for GOAP that probably don't need GOAP implementation to pull off, but in scenarios where a character might have 50 or so goals, it will be incredibly helpful to implement this concept.

GOAP allow for characters to have multiple goals and behaviors and iterate between them to determine what goals are most beneficial to them, what goals are possible for them to do, or how they should act based on how they feel. 

## How do GOAP function?

GOAP have a list of goals and actions that the character can perform and we assign each goal an action that will satisfy that goal, then we perform the actions in order to satisfy the goals. In order to determine which action to perform first, we can use weights in order to determine which goal the character is most interested in satisfying.

Let's take the above example of a sad person that needs to go to the store to do some shopping. This character has two goals: go shopping and pout. That character had already made plans to go shopping so we should already have set the weight of this goal, let's say it's 3 (on a scale from 1-5). Let's say the character's sadness isn't that serious. We can assign a weight of 1 to the goal of pouting. Since the character's shopping goal has a higher weight than the character's pouting goal, we prioritize sending the character to the store to go shopping over having them pout.

However, this does not mean we have to wait for the shopping to be done to start the pouting. If we recognize that we can do both at the same time, then we do so. The weights we set don't determine the _order_ of actions we take, they determine the _priority_ of actions we take. Let's take another example and say we have a soccer player who wants to kick a ball into the net. The player has two goals: getting near the ball and kicking the ball into the net. We are most interested in kicking the ball into the net so we set its weight to 4. Getting to the ball is important, but if we have teammates close to it we don't necessarily need to get near it, so we'll set its weight to 2. Now let's say the player is 40 feet away from the ball. The highest weighted goal they have is kicking the ball, but they're 40 feet away from it so they can't currently kick it, so we move on to the next goal, which in this case is getting near the ball. We perform the action of moving toward the ball until we are in a proper position to kick the ball into the goal, then since we have a higher priority of kicking the ball than we do moving near the ball, we perform the action to kick the ball into the net.
