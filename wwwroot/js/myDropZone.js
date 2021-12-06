function myParamName() {
    return "images";
}

Dropzone.options.uploader = {
    paramName: myParamName,
    autoProcessQueue: false,
    uploadMultiple: true,
    parallelUploads: 100,
    maxFiles: 100,
    maxFilesize: 10,
    acceptedFiles: 'image/*',
    addRemoveLinks: true,

    init: function () {
        var myDropzone = this;
        document.getElementById("submit").addEventListener("click", function (e) {
            e.preventDefault();
            e.stopPropagation();
            myDropzone.processQueue();

        });

        this.on("success", function (file, response) {
            window.location = "/Home/Index";
        });

    }
}