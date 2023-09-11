//Send ID To PopUp
$("[data-tw-target='#delete-confirmation-modal']").on("click",
    function () {
        let row = $(this).closest("tr");
        let plantNO = row.find("#PlantNO").text();
        $("#delete-confirmation-modal").data("value", plantNO);
    }
)

//Confirmat Delete And Send ID To Controller
$("#delete-confirmation").on("click",
    function () {
        let url = $(this).data('request-url');
        let confime = $("#delete-confirmation-modal").data("value");
        window.location.href = url + confime;
    }
)

//Send Data To Viwe PopUp
$("[data-tw-target='#view-data-modal']").on("click",
    function () {
        let row = $(this).closest("tr");
        let plantNO = row.find("#PlantNO").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let storageLocation = row.find("#StorageLocation").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let description = row.find("#Description").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        $("#ViwePlantNO").val(plantNO);
        $("#ViweStorageLocation").val(storageLocation);
        $("#ViweDescription").val(description);
    }
)

//Send Data To Edit PopUp
$("[data-tw-target='#edit-data-modal']").on("click",
    function () {
        let row = $(this).closest("tr");
        let plantNO = row.find("#PlantNO").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let storageLocation = row.find("#StorageLocation").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let description = row.find("#Description").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        $("#EditPlantNO").val(plantNO);
        $("#EditStorageLocation").val(storageLocation);
        $("#EditDescription").val(description);
    }
)