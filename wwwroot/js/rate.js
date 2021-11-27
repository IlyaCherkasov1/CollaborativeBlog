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
            $("#myRating").html("My rate: " + response.name);
            $("#avverageUserRate").html(response.avverageRate);
        }

        //var countStar = response.name;
        //sessionStorage.starRating = countStar;
        //var subid = item.id.substring(1);
        //for (var i = 0; i < 5; i++) {
        //    $("#" + (i + 1) + subid).off("onmouseover");
        //}
    });
}