from typing import List


class Solution:
    def removeElement(self, nums: List[int], val: int) -> int:
        count = 0

        for i in range(len(nums)):
            value = nums[i]

            if value != val:
                nums[count] = value
                count = count + 1

        return count