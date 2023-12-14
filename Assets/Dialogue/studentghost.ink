INCLUDE Globals.ink

-> Start
== Start ==
{!"Y-you... it's you again. Please, I can't do this anymore. Haven't you hurt me enough?"}
* [Who are you?] -> Who
* [What happened?] -> What

== Who ==
"You don't remember me...? I was your student. I loved your lectures and would stay after class to ask you questions." 
"I trusted you, you know? You were my favorite professor... w-which is why I didn't think... didn't think you'd..."
-> Start

== What ==
"I was a broke college student... I needed money and I was desperate. You let me petsit your dog one day." 
"I thought you were so kind... until you led me to this backroom and k-killed me." 
"I-I think you chopped me up for parts... I don't know, I try not to think about it..." 
"Now I'm stuck here... forever... I can't even move on. It's torture."
* ["I remember now... I'm so sorry. If I could take it all back, I would."] -> Apologize
* ["I don't really care about your sob story. I did what I had to and you were painfully naive."] ->  Unapologetic

== Apologize ==
"..."
"I forgive you... You know, since I can't leave this place, I went poking around for answers." 
"You weren't doing this for fun, were you? You were being coerced... Your family would die if you didn't."
"T-thank you... for apologizing. I think it's what I needed to hear. I want to move on now... it's finally time for me to go. 
"Goodbye, professor..."
~ victim_choice = "Apologize"
-> END

== Unapologetic ==
"..." \*sniffle\*
"I really... thought you were different. I went poking around for information after I died, you know?"
"You were being coerced into doing this... Your family would die if you didn't."
"But maybe you still enjoyed what you were doing, huh?"
"Maybe I really am just naive..." \*sniffle\*
"I'm never going to leave this place, am I?" 
~ victim_choice = "Unapologetic"
-> END










