#wersja tylko dla liczby nieparzystej
#import time
#t1 = time.time()
number1 = 600851475143
i = 3

while number1 > 1:
    if number1 % i != 0:
        i = i + 2 
    else:
        number1 = number1/i
print(i)
#t2=time.time()
#print(t2-t1)