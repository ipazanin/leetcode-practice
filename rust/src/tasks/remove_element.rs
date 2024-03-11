pub struct Solution;

impl Solution {
    pub fn remove_element(nums: &mut Vec<i32>, val: i32) -> i32 {
        let mut count = 0;

        for index in 0..nums.len() {
            let value = nums[index];

            if value != val {
                nums[count] = value;
                count += 1;
            }
        }

        count.try_into().unwrap()
    }
}

#[cfg(test)]
mod tests {
    use super::Solution;

    #[test]
    fn remove_element_tests() {
        let test_cases = [
            (2, Vec::from([3, 2, 2, 3]), 3),
            (5, Vec::from([0, 1, 2, 2, 3, 0, 4, 2]), 2),
            (0, Vec::from([1]), 1),
            (0, Vec::from([]), 0),
        ];

        for (expected, mut nums, val) in test_cases {
            let actual = Solution::remove_element(&mut nums, val);

            assert_eq!(expected, actual);
        }        
    }
}
