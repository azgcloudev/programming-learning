foods = ["pizza", "hamburger", "hotdog"]

print(foods)
print(foods[2])

for food in foods:
    print(food)

# append to the list
foods.append("ice screm")
foods.append("french fries")

# remove an element
foods.remove("hotdog")

# remove the last element
foods.pop()
print(foods)

# add at specific index
foods.insert(1, "sushi")
print(foods)

# sort a list
foods.sort()
print(f"Sorted: {foods}")

# remove all the elements in the list
foods.clear()
print(foods)

# 2D LISTS
comidas = [["ice scream", "cheese cake", "torta chilena"],
           ["hot dog", "hamburger", "fries"],
           ["spaghetti", "soup", "rice and beans"]]

print("Comidas", end=" ")
print(comidas)

print(comidas[0][1])
