$.doit = function () {
    var dfd = $.Deferred();

    setTimeout(dfd.resolve, 1000);

    //promise() is a read-only version of the deferred object. It is always safer to return promise() than just returning dfd.
    return dfd.promise();
}

$.doit().done(function () {
    $('body').append('<p>Hello World</p>');
});

/*Here, two ajax requests have been made. I've to do like below if I want to do something upon completion of both the
 * ajax requests. If any of the ajax requests does not resolve correctly, then Error will be called.
 * 
*/
var ajax1 = $.ajax({
    url: '/gh/get/response.html/zalun/jsFiddleGithubDemo/tree/master/Demo/',
    context: document.body
});
var ajax1 = $.ajax({
    url: '/gh/get/response.html/zalun/jsFiddleGithubDemo/tree/master/Demo/',
    context: document.body
});
$.when(ajax1, ajax2).then(
    function () {
        $('body').append('<p>Success</p>')
    },
    function () {
        $('body').append('<p>Error</p>')
    }
);
