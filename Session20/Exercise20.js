// JavaScript source code

// 1

function reverseString(myStr) {
    return myStr.split("").reverse().join("");
}


// 2

function checkPalindrome(string) {

  
    const len = string.Length;

  
    for (var i = 0; i < len / 2; i++) {
        if (string[i] !== string[len - 1 - i]) {
            return 'It is not a palindrome';
        }
    }
    return 'It is a palindrome';
}
const string = prompt('Enter a string: ');
const value = checkPalindrome(string);
console.log(value);


// 3

// 4
// The function works just fine as it is.

// 5
function incrementString(myStr) {
    if (endsWithNumber(myStr)) {
        var nextNum = getNumberAtTheEnd(myStr) + 1;
        return myStr.replace(/\d+$/, "") + nextNum.toString();
    }
    return myStr + "1";
}


function endsWithNumber(myStr) {
    return /[0-9]+$/.test(myStr);
}


function getNumberAtTheEnd(myStr) {
    return Number(myStr.match(/[0-9]+$/)[0]);
}

