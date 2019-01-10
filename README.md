# Who-Wants-to-be-a-Millionaire-fake 0.9
A program that tries to emulate the popular quiz show "Who Wants to be a Millionaire". Includes multiple sets with different questions for each set.

The rumtime version (an installer) can be downloaded from https://dm282.host.cs.st-andrews.ac.uk/millionairefake/setup.exe.
As always, feedback about the program (or especially the questions) is always welcome.

*The soundtack and logo may not be original - copyright applies to them and fair use is assued for usage of the same.*

Information about the design of the questions and explanations for some answers is available in the questionhandbook.pdf file.

# The V0.9 update

Several improvements were made to this release.

1. Set 8 was added.
2. Several questions were changed (see questionhandbook.pdf)
3. The Stats section is now enabled and can be launched by clicking the main image.
4. A bit more personal - the name is now requested from the user at every launched.
5. Internal code improvements: unwanted forms were removed.
6. This is the first relesae which can be directly installed through an EXE: this is currently located at https://dm282.host.cs.st-andrews.ac.uk/millionairefake/setup.exe
7. The GitHub repositery now includes the run-time files.

The rest of this readme is copied from the Help section which is seen on every program launch.

---
Welcome to MillionaireFake!

NOTE:- Please keep your speakers ON!

# Introduction
The aim is to answer 15 increasingly-difficult correct questions without getting any of them wrong. If you give one wrong answer, the game will end and you risk losing points.
You start with 0 points and get one point after getting the first question right. From then on, for every correct answer, the number of points you get will be doubled, up till the last question.
There are two 'safe-zones', one obtained after getting 5 questions correct (wherein you'd get 16 points), and the second one obtained after getting 10 questions correct (wherein you'd get 512 points).
When you reach that safe zone, you are guarenteed to get at least 16 or 512 points depending on which safe zone you're in.
If you get an answer incorrect, you will drop down to the last safe zone and will forfeit all points except the safe zone points. For instance, if you've got Q9 wrong, you will drop down to the first safe zone and will get only 16 points.
If you do not know an answer and do not want to risk losing points, you can quit from the game and will retain all points obtained up to the question that you quit.

# Lifelines

The quiz has 4 lifelines, which are aids that are designed to help you when you're stuck in a question and need help with solving it. Each lifeline can only be used once.

1. 50:50 lifeline:- In this lifeline, two incorrect options are removed by the program, leaving you with two options to choose from, of which only one is correct.
2. Phone-A-Friend:- Call someone and ask them to help you within 30 seconds. (You may use your phone to search the answer if this is not feastible)
3. Internet Lifeline:- The program will open a browser, and you should search the Internet and find the answer within 40 seconds. The browser will automatically close when the time is reached. Internet access is required for this lifeline.
4. Double Dip:- In this lifeline, you can choose another option if your first option chosen is incorrect. You should select your first answer, and if incorrect, the program will inform you. If correct, you continue to the next question. The lifeline is **NOT** reinstitated if both options are not needed. Quitting the game is not allowed once this lifeline is chosen (only for that question).

You are allowed to choose multiple lifelines at once, but the 50:50 and Double-Dip lifelines cannot be used simultaneously.

It is possible to find out common stats like the highest score etc by clicking the main image.

Version 0.9
