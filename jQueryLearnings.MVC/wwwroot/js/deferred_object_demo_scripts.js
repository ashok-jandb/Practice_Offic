$.doit = function () {
    var dfd = $.Deferred();

    if (Math.floor(Math.random() * 100) % 2 === 0) {
        dfd.resolve();
    } else {
        dfd.reject();
    }
    return dfd;
}

var outerDeferred = $.doit();

outerDeferred.then(
    function () { $('body').append('<p>Success</p>') },
    function () { $('body').append('<p>Failure</p>') }
);

outerDeferred.then(
    function () {
        $('body').append('<p>Success2</p>')
    },
    function () {
        $('body').append('<p>Failure2</p>')
    }
);
