pub struct Solution;

impl Solution {
    pub fn majority_element(nums: Vec<i32>) -> i32 {
        let mut majority_element = i32::min_value();
        let mut majority_element_count = 0;

        for number in nums {
            if majority_element_count == 0 {
                majority_element = number;
                majority_element_count = 1;
            } else if majority_element == number {
                majority_element_count += 1;
            } else {
                majority_element_count -= 1;
            }
        }

        majority_element
    }
}

#[cfg(test)]
mod tests {
    use super::Solution;

    #[test]
    fn tests() {
        let test_cases = [
            (3, Vec::from([3, 2, 3])),
            (2, Vec::from([2, 2, 1, 1, 1, 2, 2])),
            (5, Vec::from([6, 5, 5])),
        ];

        for (result, numbers) in test_cases {
            let actual_result = Solution::majority_element(numbers);

            assert_eq!(result, actual_result);
        }
    }
}
