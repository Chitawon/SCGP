//Send Data To View PopUp
$("[data-tw-target='#view-data-modal']").on("click",
    function () {
        let row = $(this).closest("tr");
        let serverName = row.find("#ServerName").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let dataBaseName = row.find("#DataBaseName").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let ip = row.find("#IPAddress").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let userName = row.find("#UserName").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let password = row.find("#Password").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        $("#ViewServerName").val(serverName);
        $("#ViewDataBaseName").val(dataBaseName);
        $("#ViewIPAddress").val(ip);
        $("#ViewUserName").val(userName);
        $("#ViewPassword").val(password);
    }
)

//Send Data To Edit PopUp
$("[data-tw-target='#edit-data-modal']").on("click",
    function () {
        let row = $(this).closest("tr");
        let serverName = row.find("#ServerName").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let dataBaseName = row.find("#DataBaseName").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let ip = row.find("#IPAddress").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let userName = row.find("#UserName").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        let password = row.find("#Password").text().replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
        $("#EditServerName").val(serverName);
        $("#EditDataBaseName").val(dataBaseName);
        $("#EditIPAddress").val(ip);
        $("#EditUserName").val(userName);
        $("#EditPassword").val(password);
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

/*//Confirmat Delete And Send ID To Controller
$("#delete-confirmation").on("click",
    function () {
        let url = $(this).data('request-url');
        let confime = $("#delete-confirmation-modal").data("value");
        window.location.href = url + confime;
    }
)*/