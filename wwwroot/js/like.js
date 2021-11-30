function showlike() {
    var url = $("#myLikePost").attr("action");

    $.ajax({
        type: 'POST',
        url: url,
        processData: false,
        contentType: false
    }).done(function (response) {
        if (response.status === "success") {
            $("#like").html("" + response.postLikes);
            if (response.isLike) {
                $("#likeIcon").css('color', '#f7296a');
            }
            else {
                $("#likeIcon").css('color','');
            }
        }
    }); 
}