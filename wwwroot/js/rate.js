
function starmark(item) {
    count = item.id[0];
    sessionStorage.starRating = count;
    var subid = item.id.substring(1);
    for (var i = 0; i < 5; i++) {
        if (i < count) {
            $("#" + (i + 1) + subid).css("color", "orange");
        }
        else {
            $("#" + (i + 1) + subid).css("color", "black");
        }
    }
}

function showrating() {
    var url = $("#myRatePost").attr("action") + '&ratingNumber=' + count;

    $.ajax({
        type: 'POST',
        url: url,
        processData: false,
        contentType: false
    }).done(function (response) {
        if (response.status === "success") {
         
            $("#avverageUserRate").html(response.avverageRate);
        }
    });
}