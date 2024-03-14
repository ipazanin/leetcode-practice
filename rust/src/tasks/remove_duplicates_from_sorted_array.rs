pub struct Solution;

impl Solution {
    pub fn remove_duplicates(nums: &mut Vec<i32>) -> i32 {
        let mut unique_counter = 0;
        let mut previous_number = i32::MIN;

        for index in 0..nums.len() {
            let number = nums[index];

            if number != previous_number {
                previous_number = number;
                nums[unique_counter] = number;
                unique_counter += 1;
            }
        }

        unique_counter as i32
    }
}

#[cfg(test)]
mod tests {
    use super::Solution;

    #[test]
    fn remove_duplicates_tests() {
        let test_cases = [
            (2, Vec::from([1, 1, 2])),
            (5, Vec::from([0, 0, 1, 1, 1, 2, 2, 3, 3, 4])),
        ];

        for (expected_result, mut numbers) in test_cases {
            let actual_result = Solution::remove_duplicates(&mut numbers);

            assert_eq!(expected_result, actual_result)
        }
    }
}
