$(document).ready(function () {
    $('input[type="file"]').on("change", function () {
        let filenames = [];
        let files = this.files;
        if (files.length > 1) {
            filenames.push("Total Files (" + files.length + ")");
        } else {
            for (let i in files) {
                if (files.hasOwnProperty(i)) {
                    filenames.push(files[i].name);
                }
            }
        }
        $(this)
            .next(".custom-file-label")
            .html(filenames.join(","));
    });

    $("#imageFile").change(function () {
        var File = this.files;

        if (File && File[0])
            ReadImage(File[0]);
    });

    var ReadImage = function (file) {
        var reader = new FileReader;
        var image = new Image;

        reader.readAsDataURL(file);
        reader.onload = function (_file) {

            image.src = _file.target.result;
            image.onload = function () {
                var height = this.height;
                var width = this.width;
                var type = file.type;
                var size = ~~(file.size / 1024) + " КБ";

                $("#loadImage").attr('src', _file.target.result);
                $("#imageDescription").text("Өлшемі: " + size + "; " + "Биіктігі: " + height + "; " + "Ені: " + width + "; " + "Түрі: " + type);
                $("#imagePreview").show();
            }
        }
    }
});