# GrimReaper1
INCLUDE Globals.ink
Hey you, you're finally awake.
-> Start
== Start ==
 * [Where am I?] -> Where
 * [Who are you?] -> Who
 
 == Where ==
 This is... was your house. Nice dig you've got here, by the way. Shame that it's so empty now though.
 -> Start
 
 == Who ==
 I'm the Grim Reaper, of course! And I hate to be the bearer of bad news but... you're dead. Super dead.
 * [If I'm dead then how am I talking to you?] -> Dead
 * [Dead?! Why can't I remember anything?] -> Remember
 
 == Dead ==
 'Cuz you're a ghost! Super cool, right? 
 * [Why can't I remember anything?] -> Remember
 
== Remember ==
 Because you're not supposed to be here at all! 
 It's my job to ferry souls into the afterlife, but sometimes when they die a terrible death without resolution, they stick around until they can find peace. 
 Like you. 
 * [I died a terrible death?!] -> Death
 * [Well, what do I do now?] -> DoNow
 
 == Death ==
 Haha yeah it was great. Super gory and- hey wait, no spoilers! Find out yourself! 
  * [Well, what do I do now?] -> DoNow
 
 == DoNow ==
 You have to find out why your soul won't move on, of course!
 * [What if I don't want to move on?] -> MoveOn
 
 == MoveOn ==
 HAHAHA! That's really funny, you're a funny guy...
 * [...] -> MoveOn2
 
 == MoveOn2 ==
 ... Wait, you're serious?
 I suppose you could try to bust out of this limbo you're in and bring yourself back to life, but you'd have to get through me first. 
 And it's not going to be much of a fight if you don't even have any of your memories to fight back with. 
* [So I just need to restore my memories in order to get the strength to fight you?] -> Restore

== Restore ==
Yup! But it really is easier just make your peace and move on and..... hey! Where are you going?!
 -> END