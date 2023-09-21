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

    const poNo = document.querySelector(selectForm + " [data-value='po-no']").value;
    formData.append("PO_NUMBER", poNo);

    const poItem = document.querySelector(selectForm + " [data-value='po-item']").value;
    formData.append("PO_ITEM", poItem);

    const entryQnt = document.querySelector(selectForm + " [data-value='entry-Qnt']").value;
    formData.append("ENTRY_QNT", entryQnt);

    const entryUom = document.querySelector(selectForm + " [data-value='entry-Uom']").value;
    formData.append("ENTRY_UOM", entryUom);

    const contractNo = document.querySelector(selectForm + " [data-value='pi-no']").value;
    formData.append("PI_NUMBER", contractNo);

    const eoNumber = document.querySelector(selectForm + " [data-value='eo-no']").value;
    formData.append("EO_Number", eoNumber);

    const length = document.querySelector(selectForm + " [data-value='length']").value;
    formData.append("LENGTH", length);

    const diameter = document.querySelector(selectForm + " [data-value='diameter']").value;
    formData.append("DIAMETER", diameter);

    const containerItem = document.querySelector(selectForm + " [data-value='container-item']").value;
    formData.append("CONTAINER_ITEM", containerItem);

    const rollBatch = document.querySelector(selectForm + " [data-value='roll-batch']").value;
    formData.append("ROLL_BATCH", rollBatch);

    $.ajax(
        {
            url: '/GoodsReceiptForPO/Create',
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