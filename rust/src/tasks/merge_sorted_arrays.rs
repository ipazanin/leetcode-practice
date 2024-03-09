pub struct Solution;

impl Solution {
    pub fn merge(nums1: &mut Vec<i32>, m: i32, nums2: &mut Vec<i32>, n: i32) {
        let (mut first_pointer, mut second_pointer) = (m as usize, n as usize);

        while second_pointer > 0 {
            if first_pointer > 0 && nums1[first_pointer - 1] > nums2[second_pointer - 1] {
                nums1[first_pointer + second_pointer - 1] = nums1[first_pointer - 1];
                first_pointer -= 1;
            } else {
                nums1[first_pointer + second_pointer - 1] = nums2[second_pointer - 1];
                second_pointer -= 1;
            }
        }
    }
}

#[cfg(test)]
mod tests {
    use super::Solution;

    #[test]
    fn merge_tests() {
        let test_cases = [
            (
                Vec::from([1, 2, 2, 3, 5, 6]),
                Vec::from([1, 2, 3, 0, 0, 0]),
                3,
                Vec::from([2, 5, 6]),
                3,
            ),
            (Vec::from([1]), Vec::from([1]), 1, Vec::from([]), 0),
            (Vec::from([1]), Vec::from([0]), 0, Vec::from([1]), 1),
        ];

        for (result, mut nums1, m, mut nums2, n) in test_cases {
            Solution::merge(&mut nums1, m, &mut nums2, n);

            assert_eq!(result, nums1);
        }
    }
}
