function myParamName() {
    return "images";
}

Dropzone.options.uploader = {
    paramName: myParamName,
    autoProcessQueue: false,
    uploadMultiple: true,
    parallelUploads: 3,
    maxFiles: 100,
    maxFilesize: 5,
    acceptedFiles: 'image/*',
    addRemoveLinks: true,

    init: function () {
        var myDropzone = this;
        document.getElementById("submit").addEventListener("click", function (e) {
            e.preventDefault();
            e.stopPropagation();
            myDropzone.processQueue();

        });

        //this.on("sendingmultiple", function () {

        //    for (instance in CKEDITOR.instances) {
        //        CKEDITOR.instances[instance].updateElement();
        //    }
        //});

        //this.on("success", function (file, response) {

        //    window.location = response.urllink;
        //});

        //dzClosure.on('complete', function () {
        //    window.location.href = base_url + 'admin/saveProject';
        //})
    }
}