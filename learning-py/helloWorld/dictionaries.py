# DICTIONARY
# they are changeable, unordered and uses key value pairs
# dicts are fast because they use hashing

capitals = {
    "Costa Rica": "San Jose",
    "Norway": "Oslo",
    "Spain": "Madrid"
}

print(capitals["Norway"])
print(capitals.get("Spain"))
print(capitals.keys())
print(capitals.values())
print(capitals.items())

capitals.update({"Germany": "Berlin"})

print()
for key, value in capitals.items():
    print(key + " " + value)

capitals.pop("Spain")
capitals.clear()