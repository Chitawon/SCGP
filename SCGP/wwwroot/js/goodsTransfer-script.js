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

    const itemText = document.querySelector(selectForm + " [data-value='item-text']").value;
    formData.append("ITEM_TEXT", itemText);

    const movPlant = document.querySelector(selectForm + " [data-value='mov-plant']");

    if (movPlant != null)
    {
        formData.append("MOV_PLANT", movPlant.value);
    }

    const receivingStorageLoc = document.querySelector(selectForm + " [data-value='mov-storage']");

    if (receivingStorageLoc != null)
    {
        formData.append("MOV_STORAGE", receivingStorageLoc.value);
    }

    const costCenter = document.querySelector(selectForm + " [data-value='cost-center']");

    if (costCenter != null)
    {
        formData.append("COSTCENTER", costCenter.value);
    }

    const contractNo = document.querySelector(selectForm + " [data-value='pi-no']");
    const eoNumber = document.querySelector(selectForm + " [data-value='eo-no']");
    const length = document.querySelector(selectForm + " [data-value='length']");
    const diameter = document.querySelector(selectForm + " [data-value='diameter']");
    const containerItem = document.querySelector(selectForm + " [data-value='container-item']");
    const rollBatch = document.querySelector(selectForm + " [data-value='roll-batch']");

    if (contractNo != null && eoNumber != null && length != null
        && diameter != null && containerItem != null && rollBatch != null)
    {
        formData.append("PI_NUMBER", contractNo.value);
        
        formData.append("EO_Number", eoNumber.value);

        formData.append("LENGTH", length.value);

        formData.append("DIAMETER", diameter.value);

        formData.append("CONTAINER_ITEM", containerItem.value);

        formData.append("ROLL_BATCH", rollBatch.value);
    }

    $.ajax(
        {
            url: '/GoodsTransfer/Create',
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