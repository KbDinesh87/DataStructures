const recursion = require('./recursion')

recursion.simplePrint(3);

const arr = [1, 2, 3, 4, 5];

const sum = recursion.sumofArray(arr, arr.length);
console.log(sum);

const strLen = recursion.stringLength("Dinesh B");
console.log(strLen);

const pow = recursion.pow(2, 3);
console.log(pow);

const num = 126;
const num_palin = recursion.isPalindromeNumber(num, 0);
console.log(num_palin === num); 

const str_palin = recursion.isPalindromeString("ABABA");
console.log(str_palin); 

const uCase = recursion.findUpperase("dinEsh B", 0);
console.log(uCase);

const stringToInt = recursion.stringToInt("10060");
console.log(stringToInt);

