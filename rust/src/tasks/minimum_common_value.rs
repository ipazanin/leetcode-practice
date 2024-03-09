pub struct Solution;

impl Solution {
    pub fn get_common(nums1: Vec<i32>, nums2: Vec<i32>) -> i32 {
        let mut first_pointer = 0;
        let mut second_pointer = 0;

        while first_pointer < nums1.len() && second_pointer < nums2.len() {
            let first_number = nums1[first_pointer];
            let second_number = nums2[second_pointer];

            if first_number == second_number {
                return first_number;
            }

            if first_number > second_number {
                second_pointer += 1;
            } else {
                first_pointer += 1;
            }
        }

        -1
    }
}

#[cfg(test)]
mod tests {
    use super::Solution;

    #[test]
    fn get_common() {
        let test_cases = [
            (2, Vec::from([1, 2, 3]), Vec::from([2, 4])),
            (2, Vec::from([1, 2, 3, 6]), Vec::from([2, 3, 4, 5])),
            (-1, Vec::from([]), Vec::from([5])),
            (-1, Vec::from([5]), Vec::from([])),
            (-1, Vec::from([]), Vec::from([])),
        ];

        for (expected, input1, input2) in test_cases {
            let actual = Solution::get_common(input1, input2);

            assert_eq!(expected, actual);
        }
    }
}
