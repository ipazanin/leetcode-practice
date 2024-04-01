import unittest

from python.tasks.remove_element import Solution


class RemoveElementTests(unittest.TestCase):

    def test_sum(self):
        test_data = (
            [
                (2, [3, 2, 2, 3], 3),
                (5, [0, 1, 2, 2, 3, 0, 4, 2], 2),
                (0, [1], 1),
                (0, [], 0),
            ],
        )

        solution = Solution()

        for data in test_data:
            for expected_result, numbers, value in data:
                actual_result = solution.removeElement(numbers, value)
                self.assertEqual(expected_result, actual_result)


if __name__ == "__main__":
    unittest.main()
