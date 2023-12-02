INCLUDE globals.ink
EXTERNAL GoToAppartment()
WARNING: Their fate cannot be changed, do you wish to spend time with them regardless?
*[Yes]
    ~GoToAppartment()
*[No]
    ~GoToDiner()