

function simplePrint(test) {
    if (test < 1)
        return;
    else {
        console.log(test + " ");

        // statement 2 
        simplePrint(test - 1);

        console.log(test + " ");
        return;
    }
}

function stringLength(str) {
    // if we reach at the end of the string 
    if (str === "")
        return 0;
    else
        return stringLength(str.substring(1)) + 1;
}

function sumofArray(array, length) {
    console.log('sum..')
    if (length <= 0)
        return 0;
    return (sumofArray(array, length - 1) + array[length - 1]);
}

function pow(x, n) {
    console.log('pow..')
    if (n == 1) {
        return x;
    } else {
        return x * pow(x, n - 1);
    }
}

function isPalindromeNumber(n, temp) {
    if (n == 0)
        return temp;

    temp = (temp * 10) + (n % 10);

    return isPalindromeNumber(parseInt(n / 10), temp);
}

function isPalindromeString(str) {
    if (str.length == 0 || str.length == 1) {
        return true;
    }

    if (str.charAt(0) == str.charAt(str.length - 1)) {
        return isPalindromeString(str.substring(1, str.length - 1));
    }
    return false;
}

function findUpperase(str, i) {
    if (str == '') {
        return 0;
    }
    if (str[i] == str[i].toUpperCase()) {
        return str[i];
    }
    return findUpperase(str, i + 1);
}

function stringToInt(str) {
    if (str.length == 1)
        return (str[0]);

    var y = stringToInt(str.substring(1));

    var x = str[0];

    x = x * Math.pow(10, str.length - 1) + y;
    return (parseInt)(x);
}

function factorial(num) {
    if (num == 0) {
        return 1;
    }
    return num * factorial(num - 1)
}

function greatCommonDivisor(a, b) {
    if (!b) {
        return a;
    }
    return greatCommonDivisor(b, a % b);
}

module.exports = {
    simplePrint: simplePrint,
    sumofArray: sumofArray,
    pow: pow,
    findUpperase: findUpperase,
    stringLength: stringLength,
    isPalindromeNumber: isPalindromeNumber,
    isPalindromeString: isPalindromeString,
    stringToInt: stringToInt,
    factorial: factorial,
    greatCommonDivisor : greatCommonDivisor
}

