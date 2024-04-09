pub struct Solution;

const MAX_REPETITION: i32 = 2;

impl Solution {
    pub fn remove_duplicates(nums: &mut Vec<i32>) -> i32 {
        let mut result_count = 0;
        let mut repetition_count = 1;
        let mut previous_number = i32::min_value();

        for i in 0..nums.len() {
            let number = nums[i];

            if number != previous_number {
                nums[result_count] = number;
                result_count += 1;

                repetition_count = 1;
                previous_number = number;
            } else if repetition_count < MAX_REPETITION {
                nums[result_count] = number;
                result_count += 1;

                repetition_count += 1;
            } else {
                continue;
            }
        }

        result_count as i32
    }
}

#[cfg(test)]
mod tests {
    use super::Solution;

    #[test]
    fn remove_duplicates_tests() {
        let test_cases = [
            (5, Vec::from([1, 1, 1, 2, 2, 3])),
            (7, Vec::from([0, 0, 1, 1, 1, 1, 2, 3, 3])),
        ];

        for (expected_result, mut numbers) in test_cases {
            let actual_result = Solution::remove_duplicates(&mut numbers);

            assert_eq!(expected_result, actual_result)
        }
    }
}
