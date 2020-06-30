### INFO 5340 / CS 5650: Virtual and Augmented Reality - Fall 2019

# Assignment 1

Read: [Assignment Instructions](https://docs.google.com/document/d/1La3bKARSi58KifaHSFowvJsRRt2wocoFOD25dy8ox_Q/edit?usp=sharing "Detailed Assignment Instructions")

**Remember that you also have to submit information through Canvas before the submission deadline**

<hr>

### Student Name:

\<Prithvi Sriram\>


### Student NetID:

\<ps976\>

<hr>

### Solution

In addition to your code in this repository, please submit screen recordings showing your solutions in action for each part of the assignment. Host the videos on your Cornell Google Drive account and provide a link as instructed below. They have to be accessible to other Cornell accounts, streamable and downloadable (mp4/mov).

**Screen Recording: Part 1**

[https://drive.google.com/open?id=1YPpYZCE1YrUOcksgS3w3F5CPg9r56Jif]
Filename: a1-2019-part1-ps976.*
  
**Screen Recording: Part 2**

[https://drive.google.com/open?id=1t-RMahlEN45W-h0OT-QP-WodvDwDiQII]
Filename: a1-2019-part2-ps976.*

**Screen Recording: Part 3**

[https://drive.google.com/open?id=1m-vs1S78oFuKYgnPSm3qyVDlOS0yKTUS]
Filename: a1-2019-part3-ps976.*

**Screen Recording: Part 4**

[https://drive.google.com/open?id=1yMQJIEOmD35NrOYB_a30Ucu7-nWcv4G8]
Filename: a1-2019-part4-ps976.*

**Screen Recording: Part 5**

[https://drive.google.com/open?id=1jvhwA77x1xnhfvJPh7cYazQzXE0PnZKX]
Filename: a1-2019-part5-ps976.*

<hr>

### Writeup

**Work Summary**

[Write a short summary of your approach to this assignment and list the main challenges you faced]

The assignment was started last Friday, and the commits were done at the end of almost every day. I had a great time learning Unity by doing this assignment.

Part 1 was very helpful to understand the basics of Unity and C#. The instructions were clear to a large extent and helped understand what a tag is? and how to move objects around, and getting used to the GUI.

Part 2, however, seemed quite challenging, especially at the time of making dominoes. The spark cube took me about 3-4 hours to make - had to go through multiple iterations - to finally understand how rigidbodies work. The dominoes, however weren't working accurately, and I had skipped that part until the last day. Once I've finished everything else, I came back to the dominoes part and solved it on the 10th of October. 

Part 3 was fairly easy to do, especially because unity forums/API/Resources had great examples to refer to.

Part 4 was a combination of parts 1,2, and 3. Doing it all by myself with little instructions helped tremendously in thinking through the process. Through this process, I've learned extensively about coroutine and IEnumerator. Learnt about how I could control the script in real-time, with user inputs.

Part 5 was a fun way to add what I've learned in class about depth cues.
I added a background with a horizon across, thus providing a "Height in the Visual Field" depth cue.

**Final Five**

[If you implemented the Final Five part, tell us about your solution, what you did and why]

In Part 5, I have introduced a background for 2 primary reasons:

1. There were no significant depth cues in the demo2 scene.
2. The current background of pink was very bright and contrasting to the eyes.

It was a great opportunity to put to use - what I've learned in class about depth cues.

I added a background with a horizon across, thus providing a "Height in the Visual Field" depth cue.
Since most of the objects were around the central horizontal line, I placed the background scene such that the horizon was situated right across these objects - about the central horizontal line. This has significantly helped in perceiving depth.

The background is shades of blue and white, hence, this background is less contrasting and bright in comparison to the earlier pink background.
