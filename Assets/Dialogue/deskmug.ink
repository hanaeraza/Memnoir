INCLUDE Globals.ink

-> Desk
== Desk ==
{!You approach the desk with a sense of familiarity. This desk must have been yours.}
* [Investigate the papers on the desk.] -> Papers
* [Notice the mug lying on the ground.] -> Mug
* -> END

== Papers ==
You look over the papers and find a stack of completed assignments ready for grading. 
You also find a letter hidden at the bottom the stack. The sender is demanding that you "stop being sloppy" and to "double your monthly deliveries" or face the consequences.
The letter is unsigned. 
-> Desk


== Mug == 
The mug looks like it was knocked off the desk in a rush. Emblazoned on the side are the words "\#1 Professor!"
You feel a spark of memory. You were a university professor! Not only that, your students must have liked you too!
It's a shame they never knew what you were doing until it was too late... #boldtext
* [Gently put the mug back on the desk.] -> Replace
* [Kick away the mug in shame.] -> Kick

== Replace ==
You gently return the mug to its rightful place. You loved your students. It's only fair that you take care of the things they gave you. 
If only you could have a second chance to make things right. 
You feel your resolve strengthen. 
~ mug_choice = "Replace"
-> Desk

== Kick ==
You kick away the mug in shame. You can't stand to look at it any longer. Not after what you did. 
You feel your resolve weaken. 
~ mug_choice = "Kick" 
-> Desk






