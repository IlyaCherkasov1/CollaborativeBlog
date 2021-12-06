if (localStorage.media != null) {
    $("#lightDarkScheme").attr("media", localStorage.media);
}
else {
    $("#lightDarkScheme").attr("media", "(prefers-color-scheme: light)");
}