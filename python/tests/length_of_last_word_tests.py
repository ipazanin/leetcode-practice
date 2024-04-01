import unittest

from python.tasks.length_of_last_word import Solution


class LengthOfLastWordTests(unittest.TestCase):

    def test_sum(self):
        test_data = (
            [
                (5, "Hello World"),
                (4, "   fly me   to   the moon  "),
                (6, "luffy is still joyboy"),
            ],
        )

        solution = Solution()

        for data in test_data:
            for expected_result, s in data:
                actual_result = solution.lengthOfLastWord(s)
                self.assertEqual(expected_result, actual_result)


if __name__ == "__main__":
    unittest.main()
