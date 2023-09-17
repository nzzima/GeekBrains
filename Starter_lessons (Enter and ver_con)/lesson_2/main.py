class SecondLesson:
    def __init__(self):
        pass

    # Скалярное произведение 2-х векторов с использованием
    # zip:----------------------------------------------------------------
    def scalar(self, vect1, vect2):
        scalar = 0
        for x, y in zip(vect1, vect2):
            scalar += x * y
        return scalar

    # Скалярное произведение 2-х векторов:-------------------------------------------------------------------------------------
    def scalar_without_zip(self, vect1, vect2, n):
        scalar = 0
        for x in range(0, n):
            scalar += vect1[x] * vect2[x]
        return scalar

    # Количество положительных элементов массива:------------------------------------------------------------------------------
    def count_of_positive_numbers(self, data):
        count = 0
        for i in data:
            if i > 0:
                count += 1
        return count

    # Сумма элементов массива с нечетными индексами:----------------------------------------------------------------------------
    def sum_by_oddIndNumbers(self, data):
        sum = 0
        for index in range(len(data)):
            if index % 2 != 0:
                sum += data[index]
        return sum

    # Сумма элементов массива с нечетным значением:-----------------------------------------------------------------------------
    def sum_by_odd_numbers(self, data):
        sum = 0
        for elem in data:
            if elem % 2 != 0:
                sum += elem
        return sum

    # Перенос самого большого значения элемента массива в правый край:----------------------------------------------------------
    def algorithm_max_to_the_right(self, data):
        max = data[0]
        ind_max = 0
        for index in range(len(data)):
            if data[index] > max:
                max = data[index]
                ind_max = index
            if data[index] == data[-1]:
                data[ind_max], data[index] = data[index], data[ind_max]
        return data

    # Сортировка пузырьком: -----------------------------------------------------------------------------------------------------
    # В процессе выполнения данного алгоритма элементы с большими значениями оказываются в конце списка,
    # а элементы с меньшими значениями постепенно перемещаются по направлению к началу списка.
    # Образно говоря, тяжелые элементы падают на дно, а легкие медленно всплывают подобно пузырькам воздуха.
    # При этом в начале сортировки отсортированным становится конец списка, а не его начало.
    # В сортировке методом пузырька количество итераций внешнего цикла определяется длинной списка минус единица,
    # так как когда второй элемент становится на свое место, то первый уже однозначно минимальный и не требует сортировки.
    # Количество итераций внутреннего цикла зависит от номера итерации внешнего цикла, так как конец списка уже отсортирован,
    # и выполнять проход по этим элементам смысла нет.
    def bubble_sort(self, data):
        for i in range(len(data) - 1):
            for j in range(len(data) - i - 1):
                if data[j] > data[j + 1]:
                    data[j], data[j + 1] = data[j + 1], data[j]
        return data

    # Сортировка выбором:---------------------------------------------------------------------------------------------------------
    # 1.Найти наименьшее значение в списке.
    # 2.Записать его в начало списка, а первый элемент - на место, где раньше стоял наименьший.
    # 3.Снова найти наименьший элемент в списке. При этом в поиске не участвует первый элемент.
    # 4.Второй минимум поместить на второе место списка. Второй элемент при этом перемещается на освободившееся место.
    # 5.Продолжать выполнять поиcк и обмен, пока не будет достигнут конец списка.
    def choose_sort(self, data):
        for i in range(len(data) - 1):
            m = i
            for j in range(i + 1, len(data)):
                if data[j] < data[m]:
                    m = j
            data[i], data[m] = data[m], data[i]

    # Максимальный и минимальный элемент массива:
    def max_min_numbers(self, data):
        max = data[1]
        min = data[0]
        for elem in data:
            if elem > max:
                max = elem
            elif elem < min:
                min = elem
        mass = [min, max]
        return mass

    # ДОМАШНЕЕ ЗАДАНИЕ ---------------------------------------------------------------------------------------------------------------------

    # Индексы максимального и минимального элемента массива:
    def ind_max_min_numbers(self, data):
        max = data[1]
        min = data[0]
        ind_max = 0
        ind_min = 0
        for index in range(len(data)):
            if data[index] > max:
                max = data[index]
                ind_max = index
            elif data[index] < min:
                min = data[index]
                ind_min = index
        mass = [ind_min, ind_max]
        return mass

    # Разворот массива. Перевернуть массив и записать его в обратном порядке.
    def reverse_data(self, data):
        #mass = []
        #for index in range(len(data) - 1, -1, -1):
            #mass += [data[index]]
        #return data
        for index in range(len(data)//2):
            temp = data[index]
            data[index] = data[len(data) - index - 1]
            data[len(data) - index - 1] = temp
        return data
            

    # **Сумма элементов массива, лежащих между максимальным и минимальным по значению элементами:
    def sum_between_max_and_min(self, data):
        sum = 0
        max = data[1]
        min = data[0]
        ind_max = 0
        ind_min = 0
        for index in range(len(data)):
            if data[index] > max:
                max = data[index]
                ind_max = index
            elif data[index] < min:
                min = data[index]
                ind_min = index
        for j in range(len(data)):
            if (ind_min < j < ind_max) or (ind_min > j > ind_max):
                sum += data[j]
        return sum

    # *Среднее арифметическое всех элементов массива:
    def average_elems_in_data(self, data):
        res = 0
        for elem in data:
            res += elem
        res = res / len(data)
        return res
