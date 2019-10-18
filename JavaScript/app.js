const recursion = require('./recursion');
const faq = require('./faq');

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

const factorial = recursion.factorial(5);
console.log(factorial);

const greatCommonDivisor = recursion.greatCommonDivisor(10,20);
console.log(greatCommonDivisor);

// currting OR partial invocation
const currying = faq.currying(10);
const res1 = currying(4);
const res2 = currying(15);
console.log(res1);
console.log(res2);

// method chaining
const chaining = faq.chaining().first().second();


