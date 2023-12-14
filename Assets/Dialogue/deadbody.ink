INCLUDE Globals.ink
VAR checked_pockets = false

-> Body
== Body ==
{!This is... was your body. It's undeniable. There is a pool of blood beneath your body and a bloodied knife beside it.}
* [Check the coat pockets.] -> Pockets
* [Come to a final conclusion about your death.] -> Conclude

== Pockets ==
In the left coat pocket you find a letter from an unknown sender. 
"This is the final straw." It reads.
"Deliver on what you've promised immediately or we will have to pay a visit to you and your family."
The paper is crumpled, as if it has been read over and over again. 
~ checked_pockets = true
-> Body

== Conclude ==
You know now that you have all the information you need to make a conclusion. 
All you have to do is make sense of the memories you've uncovered.
So, how did you die? 
*[You must have killed yourself out of stress.] -> Wrong
*[You must have been killed for refusing to work with whoever was coercing you.] -> Right
* [Your wife must have killed you because she found out what you were doing.] -> Wrong


== Wrong ==
That doesn't seem quite right... but you don't have any better ideas. 
It's time to face the Grim Reaper. 
~ final_choice = "Wrong"
-> END

== Right == 
The conclusion settles into you with finality. This is what happened. 
It's finally time to face the Grim Reaper. 
~ final_choice = "Right"
-> END