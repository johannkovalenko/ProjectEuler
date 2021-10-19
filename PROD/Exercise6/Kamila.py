#import time
#t1 = time.time()
def Sum_square_diff(x): 
    y = x + 1
    z = 2*x + 1 
    sumofsquares = (x*y*z)/6
    squareofsum = ((x*y)/2)**2
    return int(squareofsum-sumofsquares)

print (Sum_square_diff(100))
#t2=time.time()
#print(t2-t1)
