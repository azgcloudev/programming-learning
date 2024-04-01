# sets are unordered and unindexed

utensils = {"spoon", "knife", "fork", "spoon"}
dishes = {"plate", "bowl", "cup", "spoon"}

for util in utensils:
    print(util)

dishes.add("glass")
utensils.remove("spoon")
# utensils.clear()  # clear everything in the set

# mix a set with another
# utensils.update(dishes)
print()
for util in utensils:
    print(util)

utensils.add("spoon")

# creates a new set based on others
new_set = utensils.union(dishes)

# shows what is in the first set that is not in the second
print()
print(utensils.difference(dishes))

# what 2 sets have in common
print()
print(utensils.intersection(dishes))
