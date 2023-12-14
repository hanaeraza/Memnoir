INCLUDE Globals.ink

Back so soon? 
Are you sure you have enough memories to fight me?
* [Yes, I know what happened to me.] -> Ready
* [Nevermind, I'm still unsure...] -> NotReady

== Ready ==
If you say so! Then follow me, let's do this somewhere more fitting...
~ ready_to_fight = true 
-> END

== NotReady ==
Come back to me once you're sure you've got the strength to face me!
-> END