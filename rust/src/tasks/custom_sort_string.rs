use std::collections::HashMap;

pub struct Solution;

impl Solution {
    pub fn custom_sort_string(order: String, s: String) -> String {
        let mut result = String::with_capacity(s.len());
        let mut character_occurrences = Self::get_character_occurrences(s);

        for character in order.chars() {
            let character_occurrence = character_occurrences.get(&character);

            if character_occurrence.is_some() {
                let count = *character_occurrence.unwrap();
                character_occurrences.remove(&character);

                for _ in 0..count {
                    result.push(character);
                }
            }
        }

        for (character, count) in character_occurrences {
            for _ in 0..count {
                result.push(character);
            }
        }

        result
    }

    fn get_character_occurrences(input: String) -> HashMap<char, i32> {
        let mut character_occurrences = HashMap::new();

        for character in input.chars() {
            *character_occurrences.entry(character).or_insert(0) += 1;
        }

        character_occurrences
    }
}

#[cfg(test)]
mod tests {
    use super::Solution;

    #[test]
    fn custom_sort_string_tests() {
        let test_cases = [("cbad", "cba", "abcd"), ("bcad", "bcafg", "abcd")];

        for (expected_result, order, s) in test_cases {
            println!("{}", expected_result);
            println!("{}", s);
            let actual_result = Solution::custom_sort_string(order.to_owned(), s.to_owned());

            assert_eq!(expected_result.to_owned(), actual_result);
        }
    }
}
