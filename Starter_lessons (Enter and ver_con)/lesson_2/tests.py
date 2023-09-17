import unittest
from random import randint
from main import SecondLesson

class TestSecondLesson(unittest.TestCase):
    def setUp(self):
        self.lesson = SecondLesson()

    def test_scalar(self):
        self.assertEqual(self.lesson.scalar([1,2,3], [2,3,4]), 20)

    def test_scalar_without_zip1(self):
        self.assertEqual(self.lesson.scalar_without_zip([1,2,3], [2,3,4], 3), 20) 
    
    def test_scalar_without_zip2(self):
        self.assertEqual(self.lesson.scalar_without_zip([3,5,7], [5,-1,0], 3), 10)
    
    def test_scalar_without_zip3(self):
        self.assertEqual(self.lesson.scalar_without_zip([1,2,3,4], [2,3,4,5], 4), 40)

    def test_count_positive(self):
        self.assertEqual(self.lesson.count_of_positive_numbers([1,2,0,-3,-4,5,0,-1,11,-12]), 4)

    def test_sum_byOddIndNumbers(self):
        self.assertEqual(self.lesson.sum_by_oddIndNumbers([1,2,3,4,5,6,7,8,9,10]), 30)
    
    def test_sum_by_odd_numbers1(self):
        self.assertEqual(self.lesson.sum_by_odd_numbers([1,2,3,4,5,6,-1,-2,-3]), 5)

    def test_sum_by_odd_numbers2(self):
        self.assertEqual(self.lesson.sum_by_odd_numbers([1,2,4,6,-1,-2,-3]), -3)
    
    def test_algorithm_max_to_the_right1(self):
        self.assertEqual(self.lesson.algorithm_max_to_the_right([1,2,13,4,5,6]), [1,2,6,4,5,13])
    
    def test_algorithm_max_to_the_right2(self):
        self.assertEqual(self.lesson.algorithm_max_to_the_right([1,2,-13,4,15,6]), [1,2,-13,4,6,15])
    
    def test_bubble_sort1(self):
        self.assertEqual(self.lesson.bubble_sort([1,2,-13,4,15,6]), [-13, 1, 2, 4, 6, 15])
    
    def test_bubble_sort2(self):
        self.assertEqual(self.lesson.bubble_sort([1,2,-13,4,-15,6,10,11,-5]), [-15,-13,-5,1,2,4,6,10,11])
    
    def test_choose_sort(self):
        data = [randint(1,99) for item in range(10)]
        print('\n\n', "Unsorted data -->", data)
        self.lesson.bubble_sort(data)
        print("Sorted data -->", data, '\n')
    
    def test_max_min_numbers(self):
        data = [randint(1,999) for item in range(10)]
        print('\n\n', data)
        mass = self.lesson.max_min_numbers(data)
        print(mass, '\n')

    def test_ind_max_min_numbers(self):
        data = [randint(1,999) for item in range(10)]
        print('\n\n', data)
        mass = self.lesson.ind_max_min_numbers(data)
        print(mass, '\n')

    def test_reverse_data (self):
        data = [randint(1,9) for item in range(11)]
        print('\n\n', data)
        mass = self.lesson.reverse_data(data)
        print(mass, '\n')
    
    def test_sum_between_max_and_min(self):
        data = [randint(1,15) for item in range(10)]
        print('\n\n', data)
        sum = self.lesson.sum_between_max_and_min(data)
        print(sum, '\n')

    def test_average(self):
        data = [randint(1,10) for item in range(5)]
        print('\n\n', data)
        average = self.lesson.average_elems_in_data(data)
        print(average, '\n')


if __name__ == "__main__":
    unittest.main()