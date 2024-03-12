# printing in the console
# string
print("I love pizza")

## VARIABLES and its types

# integers
age = 28
print("My age is " + str(age))  # to concatenate need to change the type to string

# float
height = 1.73
print("My height is " + str(height))

# boolean
human = True
is_adult = False
print("Is he adult? " + str(is_adult) + ", and is he human? " + str(human))

## MULTIPLE ASSIGNMENT
first_name, my_age, attractive = "Aldair", 28, True

a = b = c = d = 30


### STRING METHODS
len(first_name)
first_name.find("A")
first_name.capitalize()
first_name.upper()
first_name.lower()
first_name.isdigit()
first_name.isalpha()
first_name.count("a")
print(first_name.replace("a", "e"))

#print the string three times
print(first_name*3)
