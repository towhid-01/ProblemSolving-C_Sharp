// SAZIM interview task
/**1. Write 5 additional unique test cases as part of your submission. HINT: You can achieve this more efficiently if you follow Test Driven Development.

2. State time and space complexity

Implement a function to determine if a string has all unique characters. Treat uppercase and lowercase letters as the same character. For example, 'A' and 'a' are considered duplicates. Do not use built-in functions or methods that check for duplicates directly (e.g., converting the string to a set).


Characters: All Unicode characters.


Input: "aB3@G!9"

Output: True


Input: "Password123!"

Output: False


Input: "mèêt"

Output: True


Input: "😊😉😊"

Output: False**/

                                                                //My Solutions
                                                                
//1. Write 5 additional unique test cases as part of your submission. HINT: You can achieve this more efficiently if you follow Test Driven Development.

function hasUniqueCharacters(str) {
    let seen = new Array(65536).fill(false);

    for (let i = 0; i < str.length; i++) {
        let charCode = str[i].toLowerCase().charCodeAt(0);

        if (seen[charCode]) {
            return false;
        }
        seen[charCode] = true;
    }

    return true;
}


console.log(hasUniqueCharacters("aB3@G!9"));
console.log(hasUniqueCharacters("Password123!")); 
console.log(hasUniqueCharacters("mèêt"));
console.log(hasUniqueCharacters("😊😉😊")); 
console.log(hasUniqueCharacters("ToWhiD")); 
console.log(hasUniqueCharacters("Sorting"));
console.log(hasUniqueCharacters("1234567890"));
console.log(hasUniqueCharacters("aabaa"));
console.log(hasUniqueCharacters("CodeForces")); 


// 2. State time and space complexity of my solution

// Time Complexity: O(n)
// Space Complexity: O(1)