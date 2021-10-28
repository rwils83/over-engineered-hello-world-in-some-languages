a=int(input("Enter the number"))
for i in range(2,int(a/2)):
    if a%i==0:
        print("it is not prime")
        break;
else:
    print("It is prime")
