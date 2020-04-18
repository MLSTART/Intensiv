import math
import random as rnd

from fractions import Fraction as Fr
from decimal import Decimal as De

import hashlib

print(math.pi)
print(math.e)
print(math.cos(math.pi))

print(math.radians(180.0), math.degrees(math.e))

rnd.seed(10)
print(rnd.random())
rnd.seed(10)
print(rnd.random())

r = rnd.uniform(0, 100)
print(r)

r = rnd.randint(0, 100)
print(r)
s = [1, 2, 3, 4, 5]
rnd.shuffle(s)

print(s)
print(rnd.choice(s), rnd.choice(s))

x = Fr(8, 54) - Fr(2, 32)
print(x)
print(0.3 - 0.1 - 0.1 - 0.1)

y = De("0.3") - De("0.1") - De("0.1") - De("0.1")
print(y)

x = 100_000_000
print(x)

x = y = [1, 2]
z = [1, 2]
print(x is z, x is y, x == z, y == x, 1 in x)

print(((x is y) or (y is not z)) and x is z)
print((x == y) and (x == z) or (y != z))

s = "YES" if 10 % 2 == 0 else "NO"

print(s)

for x in range(10):
    print(x ** 5)

# amount = 0
# while True:
#     number = int(input("Число:"))
#     if number == 0:
#         break
#     else:
#         amount += number
# print(amount)

obj = range(1, 100)

obj.count(1)
obj.index(50)

x, y, z = 1, 2, 3
print(x, y, z)

x, y = y, x
print(x, y, z)

h = hashlib.md5(b"password")
p = h.hexdigest()
print(p)

h2 = hashlib.md5(b"password")
if p == h2.hexdigest():
    print("Корректный")


def Show(*t):
    for x in t:
        print(x)
    print(t)


f = lambda x, y: x ** y

print(f(5, 5))
