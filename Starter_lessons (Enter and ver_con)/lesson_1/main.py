class FirstLesson:
    def __init__(self):
        pass
    #Максимальное значение из двух чисел 
    def max_of_two(self, a, b):
        if a > b: return a
        elif b > a: return b
        else: return None

    #Минимальное значение из четырех чисел
    def min_of_fourth(self, a, b, c, d):
        min = a
        if b < min: min = b
        if c < min: min = c
        if d < min: min = d
        return min
    
    #Среднее арифметическое четырех чисел
    def average_of_fourth(self, a, b, c, d):
        return  (a + b + c + d)/4
    
    #Сумма четных чисел от 1 до n
    def sum_of_even(self, n):
        sum = 0
        for i in range(1, n + 1):
            if i % 2 == 0:
                sum += i
        return sum
    
    #Факториал числа n
    def factorial(self, n):
        fact = 1
        for i in range(1, n + 1):
            fact *= i
        return fact
