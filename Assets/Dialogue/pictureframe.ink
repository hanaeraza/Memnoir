INCLUDE Globals.ink
{ picture_choice == "": 
   -> Start 
- else: 
    You have made your choice. ->END
    }

== Start == 
A picture is framed on the wall. It shows a mother, father, and 3 kids sitting around a picnic on a bright sunny day. 
A spark of memory returns to you… that father is you! You remember this scene fondly, but you are also overcome with a wave of indescribable guilt and FURY.
* [Reminisce fondly on the memory.] -> Reminisce
* [Shatter the picture frame in anger!] -> Shatter 


==  Reminisce ==
You remember that you and your family had gone for a picnic by a creek on a warm summer day. 
The kids played in the water with the dog, splashing and giggling with joy. You had smiled lovingly from your place at the picnic table... but you remember something odd. 
When you had stolen a glance at your wife, she had a strange look on her face. Conflicted and pensive. Sad. 
She knew something she shouldn’t. # boldtext
Regardless, you feel rejuvenated by the warm memory. 
~ picture_choice = "Reminisce"
-> END

== Shatter ==
YOU SLAM YOUR GHOSTLY FIST INTO THE PICTURE FRAME, SHATTERING IT.
You can only remember one thing about the scene… Your wife’s face had looked sad and knowing the entire time. 
She had known something she shouldn’t. Why couldn't she have just minded her business??? #boldtext
You feel your form flicker weakly. 
~ picture_choice = "Shatter"
-> END