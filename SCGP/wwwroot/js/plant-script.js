//Send Data To View PopUp
$("[data-tw-target='#view-data-modal']").on("click",
    function () {
        let row = $(this).closest("tr");
        let serverName = row.find("#ServerName").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let plantNO = row.find("#PlantNO").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let location = row.find("#Location").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let plant_Description = row.find("#Plant_Description").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        $("#ViewServerName").val(serverName);
        $("#ViewPlantNO").val(plantNO);
        $("#ViewLocation").val(location);
        $("#ViewPlant_Description").val(plant_Description);
    }
)

//Send Data To Edit PopUp
$("[data-tw-target='#edit-data-modal']").on("click",
    function () {
        let row = $(this).closest("tr");
        let serverName = row.find("#ServerName").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let plantNO = row.find("#PlantNO").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let location = row.find("#Location").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let plant_Description = row.find("#Plant_Description").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        $("#EditServerName").val(serverName);
        $("#EditPlantNO").val(plantNO);
        $("#EditLocation").val(location);
        $("#EditPlant_Description").val(plant_Description);
    }
)

//Delete Is No Compelet
//Send ID To Delete PopUp
/*$("[data-tw-target='#delete-confirmation-modal']").on("click",
    function () {
        let row = $(this).closest("tr");
        let plantNO = row.find("#PlantNO").text();
        $("#delete-confirmation-modal").data("value", plantNO);
    }
)*/

//Confirmat Delete And Send ID To Controller
/*$("#delete-confirmation").on("click",
    function () {
        let url = $(this).data('request-url');
        let confime = $("#delete-confirmation-modal").data("value");
        window.location.href = url + confime;
    }
)*/