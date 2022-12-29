/* Agenda: Calculate square of a number and that calculation should be done only at the very first time, and
 * after that it should be cached.
 */

var log = function (msg) {
    $('body').append('<p>' + msg + '</p>');
}

var cache = {};

var square = function (number) {
    if (typeof cache[number] === "undefined") {
        log('<p>Calculating square of ' + number + '</p>');
        var dfd = $.Deferred();
        var answer = number * number;
        dfd.resolve(answer);//We're resolving with the answer.
        /* In the below line of code, We're storing deferred object in the cache. The wonderful thing
         * about Deferred object is that, whenever we build a caching mechanism with the deferred object
         * you don't need to store the real answer, you just need to store the deferred object. */
        cache[number] = dfd;
        return dfd;
    } else {
        log('<p>Returning cached value for ' + number + '</p>');
        return cache[number];
        dfd.resolve(answer); //←We'are invoking the callback with the answer
    }
}

square(2).then(function (answer) {
    log('<p>Answer: sqaure of 2 is ' + answer + '<p>')
});

square(3).then(function (answer) {
    log('Answer: square of 3 is ' + answer)
});

square(4).then(function (answer) {
    log('Answer: sqaure of 4 is ' + answer)
});

square(5).then(function (answer) {
    log('Answer: square of 5 is ' + answer)
});

square(2).then(function (answer) {
    log('Answer: sqaure of 2 is ' + answer)
});

square(3).then(function (answer) {
    log('Answer: square of 3 is ' + answer)
});

square(4).then(function (answer) {
    log('Answer: sqaure of 4 is ' + answer)
});

square(5).then(function (answer) {
    log('Answer: square of 5 is ' + answer)
});