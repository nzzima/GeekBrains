import unittest
from main import FirstLesson


class TestFirstLesson(unittest.TestCase):
    def setUp(self):
        self.lesson = FirstLesson()

    def test_max_of_two1(self): self.assertEqual(self.lesson.max_of_two(10, 15), 15)
    def test_max_of_two2(self): self.assertEqual(self.lesson.max_of_two(12, -5), 12)
    def test_max_of_two3(self): self.assertEqual(self.lesson.max_of_two(20, 15), 20)
    def test_max_of_two4(self): self.assertEqual(self.lesson.max_of_two(30, 30), None)

    def test_min_of_four1(self): self.assertEqual(self.lesson.min_of_fourth(3, 2, 5, 6), 2)
    def test_min_of_four2(self): self.assertEqual(self.lesson.min_of_fourth(12, 14, -8, 6), -8)
    def test_min_of_four3(self): self.assertEqual(self.lesson.min_of_fourth(5, 9, 5, 12), 5)

    def test_average1(self): self.assertEqual(self.lesson.average_of_fourth(2, 4, 5, 1), 3)
    def test_average2(self): self.assertEqual(self.lesson.average_of_fourth(3, 4, 5, 6), 4.5)

    def test_summ1(self): self.assertEqual(self.lesson.sum_of_even(5), 6)
    def test_summ2(self): self.assertEqual(self.lesson.sum_of_even(100), 2550)
    
    def test_factorial1(self): self.assertEqual(self.lesson.factorial(3), 6)
    def test_factorial2(self): self.assertEqual(self.lesson.factorial(4), 24)
    def test_factorial3(self): self.assertEqual(self.lesson.factorial(5), 120)


if __name__ == "__main__":
    unittest.main()
