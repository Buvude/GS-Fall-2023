VAR pokemon_name=""

LIST BBuns1 = (Plain), (Lettucebun), (Sourdough) //(Bun_of_the_Deep) only orderable by O'ryan
LIST Pickles1 = (Chips), (Relish), (Plain) 
LIST Greens1 = (Wholeleaf), (Chopped), (Purple) //(Biblically_Accurate_Green) only orderable by O'ryan
LIST patty1 = (Beef), (Vegan) //(Unspeakable_Horror) Unspeakable horror will not be orderable except by O'Ryan
LIST Condiments1 = (Ketchup), (Mustard), (Both) 
LIST Veggies1 = (Tomatoe), (Onion), (OnionRings) 
LIST TBuns1 = (Plain), (Lettucebun), (Sourdough) //(Bun_of_the_Deep) same as above
VAR convo_numberCS=0
VAR convo_numberF=0

VAR BAMLevel = 0
VAR TTMLevel = 0
VAR TBMLevel = 1
VAR currentConvo="test"

//Imma try to integrate the variables here since it'll save it 

VAR dayVar = 1//may not need to be used
VAR weekDay = "Mon"
//Cheff Swatts variables
VAR affectionCS = 0
VAR chaosCS = 0
VAR irritatedCS = 0
//Nico variables
VAR affectionN = 0
VAR chaosN = 0
VAR irritatedN = 0
//CeCe variables
VAR affectionC = 0
VAR chaosC = 0
VAR irritatedC = 0
//Gnomies variables
VAR affectionG = 0
VAR chaosG = 0
VAR irritatedG = 0
//Morgan variables
VAR affectionM = 0
VAR chaosM = 0
VAR irritatedM = 0
//Fred variables
VAR affectionF = 0
VAR chaosF = 0
VAR irritatedF = 0

LIST BBuns2 = (Plain), (Lettucebun), (Sourdough) //(Bun_of_the_Deep) only orderable by O'ryan
LIST Pickles2 = (Chips), (Relish), (Plain), (Peppers)
LIST Greens2 = (Wholeleaf), (Chopped), (Purple) //(Biblically_Accurate_Green) only orderable by O'ryan
LIST patty2 = (Beef), (Vegan),(Chicken) //(Unspeakable_Horror) Unspeakable horror will not be orderable except by O'Ryan
LIST Condiments2 = (Ketchup), (Mustard), (Both), (Mayo)
LIST Veggies2 = (Tomatoe), (Onion), (OnionRings), (Mushrooms) 
LIST TBuns2 = (Plain), (Lettucebun), (Sourdough) //(Bun_of_the_Deep) same as above

LIST BBuns3 = (Plain), (Lettucebun), (Sourdough), (Pretzel) //(Bun_of_the_Deep) only orderable by O'ryan
LIST Pickles3 = (Chips), (Relish), (Plain), (Peppers)
LIST Greens3 = (Wholeleaf), (Chopped), (Purple),(Leaf) //(Biblically_Accurate_Green) only orderable by O'ryan
LIST patty3 = (Beef), (Vegan),(Chicken),(Cheeseburger) //(Unspeakable_Horror) Unspeakable horror will not be orderable except by O'Ryan
LIST Condiments3 = (Ketchup), (Mustard), (Both), (Mayo)
LIST Veggies3 = (Tomatoe), (Onion), (Onionrings), (Mushrooms) 
LIST TBuns3 = (Plain), (Lettucebun), (Sourdough),(Pretzel) //(Bun_of_the_Deep) same as above