#Код на Python
#Проверка контроля версий
#One more test for control version

numbers = [2, 5, 13, 7, 6, 4]
size = 6
sum = 0
avg = 0
index = 0

while index < size:
    sum += numbers[index]
    index += 1
avg = sum / size
print(avg)
