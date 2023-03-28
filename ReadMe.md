Technical Test BE Kata - Victorian Plumbing

A "Work in Progress" project according to the specification provided.
Various functions were specified:
Accept Coins
Select Product
Make Change
Return Coins
Sold Out
Exact Change Only

The basic framework of the vending machine, displaying specified base products with price, and a "Select" button have been added.
A button-based interface for simulating adding coins of various denominations has been added.

Due to time constraints, the functionality is currently a work in progress. A basic framework for adding coins (note - no identification yet included for 
identifing / rejecting invalid coins) and to add the coin value to the machine "balance", with the intent to display that (incomplete). Basic framework
also added for selecting a product, with logic path for various options at this point (out of stock, insufficient balance, correct balance, requires change), 
thought the operation of these functions has not yet been added.

Note that the code is not ready for deployment and should only be run from VS. 

TODO list:
Add the functionality to logic paths for various scenarios to update the main display as required.
Add an "in stock" int property to the Product model. Required to decrement when the product is sold to monitor whether available, display SOLD OUT if 0
Change the interface for adding coins to include an "invalid" option, with a reject / return.
Add a "Coin Return" function
Refactoring to split out the functionality as required and share functions where available (e.g. the "coin return" for both change and reject)

Current State:
The project will compile, and display products. Options related to select product / add coin are visible but not yet functional. 
On run, click the indicated link to display the selection page.
