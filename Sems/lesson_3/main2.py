numbers = [1,8,3,8,8,6,8,8]
index = 0
max = numbers[index]
count = 0
while index < len(numbers):
    if numbers[index] > max:
        max = numbers[index]
        count = 1
    else:
        if numbers[index] == max:
            count += 1
    index += 1
print(count)