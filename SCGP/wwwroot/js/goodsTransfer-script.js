const movementSelectElm = document.querySelector("#movement-select");
const nonSelect = movementSelectElm.options[0].text;
// Function to handle form submission
function submitForm() {
    // Determine which form is currently visible
    const selector = movementSelectElm.value;
    const isSelect = nonSelect != selector;

    if (!isSelect)
    {
        alert("Select a Movement Type before submitting.");
        return;
    }

    const selectForm = "#" + CSS.escape(selector);
    
    var formData = new FormData();

    GetCommonData(formData, selectForm);

    if (selector == "101" || selector == "102")
    {
        const movementIndicator = document.querySelector(selectForm + " [data-value='movement-indicator']").value;
        formData.append("MOVE_INDICATOR", movementIndicator);

        const poNo = document.querySelector(selectForm + " [data-value='po-no']").value;
        formData.append("PO_NUMBER", poNo);

        const poItem = document.querySelector(selectForm + " [data-value='po-Item']").value;
        formData.append("PO_ITEM", poItem);
    }
    else
    {
        const itemText = document.querySelector(selectForm + " [data-value='item-text']").value;
        formData.append("ITEM_TEXT", itemText);
    }

    if (selector == "301" || selector == "302" || selector == "309" || selector == "310")
    {
        const receivingMatNo = document.querySelector(selectForm + " [data-value='receiving-material-no']").value;
        formData.append("MOV_MATERIAL", receivingMatNo);

        const receivingPlant = document.querySelector(selectForm + " [data-value='receiving-plant']").value;
        formData.append("MOV_PLANT", receivingPlant);
    }

    if (selector == "301" || selector == "302" || selector == "309" || selector == "310"
        || selector == "311" || selector == "312" || selector == "321" || selector == "322"
        || selector == "323" || selector == "324" || selector == "343" || selector == "344")
    {
        const receivingBatchNo = document.querySelector(selectForm + " [data-value='receiving-batch-no']").value;
        formData.append("MOV_BATCH", receivingBatchNo);

        const receivingStorageLoc = document.querySelector(selectForm + " [data-value='receiving-storage-location']").value;
        formData.append("MOV_STORAGE", receivingStorageLoc);
    }

    if (selector == "521" || selector == "522" || selector == "201" || selector == "202")
    {
        const costCenter = document.querySelector(selectForm + " [data-value='cost-center']").value;
        formData.append("COSTCENTER", costCenter);
    }

    if (selector == "909" || selector == "910")
    {
        const glNo = document.querySelector(selectForm + " [data-value='gl-no']").value;
        formData.append("GLACCOUNT", glNo);
    }

    if (selector == "521" || selector == "522")
    {
        const pdTime = document.querySelector(selectForm + " [data-value='date-batch']").value;
        formData.append("PD_TIME", pdTime);

        const sqm = document.querySelector(selectForm + " [data-value='sqm']").value;
        formData.append("CONVERSION_FACT_SQM", sqm);
    }

    if (selector == "101" || selector == "102" || selector == "521" || selector == "522"
        || selector == "201" || selector == "202" || selector == "909" || selector == "910"
        || selector == "309" || selector == "310")
    {
        const contractNo = document.querySelector(selectForm + " [data-value='contract-no']").value;
        formData.append("PI_NUMBER", contractNo);

        const eoNumber = document.querySelector(selectForm + " [data-value='export-order-no']").value;
        formData.append("EO_Number", eoNumber);

        const length = document.querySelector(selectForm + " [data-value='length']").value;
        formData.append("LENGTH", length);

        const diameter = document.querySelector(selectForm + " [data-value='diameter']").value;
        formData.append("DIAMETER", diameter);

        const containerItem = document.querySelector(selectForm + " [data-value='container-item']").value;
        formData.append("CONTAINER_ITEM", containerItem);

        const rollBatch = document.querySelector(selectForm + " [data-value='roll-batch']").value;
        formData.append("ROLL_BATCH", rollBatch);
    }

    /*for (var pair of formData.entries()) {
        console.log(pair[0] + ', ' + pair[1]);
    }*/

    $.ajax(
        {
            url: '/GoodsTransfer/Create', // Replace 'ControllerName' with your actual controller name
            type: 'POST',
            data: formData,
            dataType: 'json',
            processData: false,
            contentType: false,
            success: function (result) {
                // Handle the success response
                console.log(result.result);
                console.log(result.message);
            },
            error: function (error) {
                // Handle errors
                console.log("An error occurred:", error);
            }
        }
    );
}

function GetCommonData(formData, selectForm)
{
    const movmentType = document.querySelector(selectForm + " [data-value='movement-type']").value;
    formData.append("MOVEMENTTYPE", movmentType);

    const materialNo = document.querySelector(selectForm + " [data-value='material-no']").value;
    formData.append("MATERIAL_NUMBER", materialNo);

    const batchNo = document.querySelector(selectForm + " [data-value='batch-no']").value;
    formData.append("BATCH_NUMBER", batchNo);

    const plant = document.querySelector(selectForm + " [data-value='plant']").value;
    formData.append("PLANT", plant);

    const storage = document.querySelector(selectForm + " [data-value='storage']").value;
    formData.append("STORAGE", storage);

    const entryQnt = document.querySelector(selectForm + " [data-value='entry-Qnt']").value;
    formData.append("ENTRY_QNT", entryQnt);

    const entryUom = document.querySelector(selectForm + " [data-value='entry-Uom']").value;
    formData.append("ENTRY_UOM", entryUom);
}