import math

# printing in the console
# string
print("I love pizza")

# VARIABLES and its types

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

# MULTIPLE ASSIGNMENT
first_name, my_age, attractive = "Aldair", 28, True

a = b = c = d = 30

# STRING METHODS
len(first_name)
first_name.find("A")
first_name.capitalize()
first_name.upper()
first_name.lower()
first_name.isdigit()
first_name.isalpha()
first_name.count("a")
print(first_name.replace("a", "e"))

# print the string three times
print(first_name * 3)

# MATH class (import math)
print("\nMath:")
pi = 3.14
x = 1
y = 2
z = 3
n = -4.76

print(round(pi))
print(math.ceil(pi))
print(math.floor(pi))
print(abs(n))
print(pow(pi, 2))
print(math.sqrt(420))
print(max(x, y, y))

# STRING SLICING
print("\nString Slicing:")
name = "Aldair Zamora"
first_name = name[:6]  # since index 0 to the 6
print(first_name)
last_name = name[7::]  # since index 7 to the last one
print(last_name)
# funky_name = name[0:13:2] # from first to last with step 2
funky_name = name[::2]  # alternative to previous
print(funky_name)

# reversing string
name_reversed = name[::-1]
print(name_reversed)

# slice
website = "http://google.com"
my_slice = slice(7, -4)
print(website[my_slice])

# IF STATEMENTS
print("\nIF STATEMENTS:")

age = int(input("How old are you?: "))

if age >= 18:
    print("You are an adult!")
elif age < 0:
    print("You haven't been born yet.")
else:
    print("You are a child!")

# LOGICAL OPERATORS
# and | or | not
temp = 23

# not - negates the sentences, true = false; and false = true
if not (temp >= 0 and temp <= 30):
    print("The temperature is bad today, stay inside.")
elif not (temp < 0 or temp > 30):
    print("Temperature is good today")

# WHILE LOOPS
name_input = None

while not name_input:
    name_input = input("Enter your name: ")

print("Hello " + name_input + ", welcome!")

# FOR LOOP
print("\nFor Loop:")
for i in range(10):
    print(i)

for c in name_input:
    print(c)

for i in range(10, 0, -1):  # start, stop, steps; the stop is exclusive count is from 10 to 1
    print(i)

# NESTED LOOPS
rows = int(input("How many rows?: "))
columns = int(input("How many columns?: "))
symbol = input("Which symbol to display: ")

for i in range(0, rows):
    for j in range(0, columns):
        print(symbol, end="")  # prevents next line
    print()
