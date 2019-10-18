
function globalVariable() {
    let a = b = 0;

    console.log("a->", a)
    console.log("b->", b)
    console.log("is 'a' global", window.a);
    console.log("is 'b' global", window.b);
}

function currying(base) {
    return function (num) {
        return base + num;
    }
}

function chaining() {
    const fns = {
        first: () => { console.log('First'); return fns },
        second: () => { console.log('Second'); return fns },
    }
    return fns;
}


// to run in html comment below module 

module.exports = {
    currying: currying,
    chaining: chaining
}