# Dinner-Picker
A program designed to keep a record of items for dinner, and through participation, will help you decide what to have for dinner.

Includes the project file and the executible to be ran on your own machine.

It will open up a new windows form window with 2 text areas, a search bar, and a selection of buttons. Some are greyed out upon startup.

The LEFT TEXT AREA is for the program to convey item options to the user. The RIGHT TEXT AREA is the master list of all items added. It is also fully interactible by the user through the rest of the buttons.

SELECT "chooses" an item for dinner for the night by the user. It communicates to the program that item has been chosen at least once. 

RANDOM will randomly select a few items from the MASTER LIST to display for choice. The more master list items, the more useful IMO.

GENERATE will select a few items that are least-frequently selected. 

To get a new item added into the form, click the ADD ITEM button. This will open up a new window to name an item you would like to have for dinner at some point. Here, you can also add some tags associated with the item for searchability later. You will see it appear on the right text area. This can be selected via cursor, to allow for a few options, which are available through the buttons. Such as editing the information in the item via the EDIT ITEM button

You can also click DELETE ITEM if you no longer require it to be in the master list.

      (There is a bug that allows this to appear a few times in the right text area, but its been too long for me to want to go back and fix it. Upon closure of the program the bug no longer persists. I apologize for the inconvienience.)
     
  
After a few items have been added to the program for review, generate will produce items with the lowest score attributed to them. The score it given after SELECT-ing the item for dinner. The idea is, if you have something for dinner, you are not to want it again for some time. Thus a score is given to the item upon selection, which will decrease with each other selection. If you select the item again, it will still increase the item's score.

The program creates a folder in the user's DOCUMENTS folder, called DINNERJOURNEL. Within a text file is created with values for re-creating the master list after closing the program. Technically, you could edit the data in there yourelf without opening up the program. However breaking the format of the file will break the program on load. 

If I were to resurrect this project, I would add an option to delcare how much score the dinner item should recienve on select, and probably be an option to be edited later. Perhaps an upper limit for the program to go no higher on select, no make it so an item isn't technically impossible to be generated again by the program.

It could also be more present in the user's mind as a tray application that at a certain time(-frame) remind the user to pick what they are having for dinner. Which helps to keep the program and user in-sync. Keeping track of dates would also help this, but that sounds like an extra level of complication right now. 

It would also be nice to have a selectable number of random items, instead of what I thought was best at the time. 
