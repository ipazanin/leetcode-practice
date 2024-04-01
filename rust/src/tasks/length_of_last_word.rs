pub struct Solution;

impl Solution {
    pub fn length_of_last_word(s: String) -> i32 {
        let words = s.trim().split_whitespace();
        let last_word = words.last().unwrap();

        last_word.len() as i32
    }
}

#[cfg(test)]
mod tests {
    use super::Solution;

    #[test]
    fn merge_tests() {
        let test_cases = [
            (5, "Hello World"),
            (4, "   fly me   to   the moon  "),
            (6, "luffy is still joyboy"),
        ];

        for (result, s) in test_cases {
            let actual_result = Solution::length_of_last_word(s.to_owned());

            assert_eq!(result, actual_result);
        }
    }
}
