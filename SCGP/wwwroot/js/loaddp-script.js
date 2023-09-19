function Reset()
{
    const inputEle = document.querySelectorAll("input");
    inputEle.forEach((ele) => {
        ele.value = "";
    });
}

/*function ViewDP(ele) {
    const model = @Html.Raw(Json.Serialize(Model));
    const selectDisplay = model[ele];

    console.log(model[ele]);

    const displayRow = document.querySelectorAll("#display tbody tr");

    displayRow.forEach((row) => {
        row.remove();
    });

    const table = document.querySelector("#display");
    selectDisplay.forEach((data) => {
        const newRow = table.insertRow();

        const cell1 = newRow.insertCell(0);
        cell1.innerHTML = data.;

        const cell2 = newRow.insertCell(1);
        cell2.innerHTML = data.;

        const cell3 = newRow.insertCell(2);
        cell3.innerHTML = data.;

        const cell4 = newRow.insertCell(3);
        cell4.innerHTML = data.;

        const cell5 = newRow.insertCell(4);
        cell5.innerHTML = data.;

        const cell6 = newRow.insertCell(5);
        cell6.innerHTML = data.;

        const cell7 = newRow.insertCell(6);
        cell7.innerHTML = data.;

        const cell8 = newRow.insertCell(7);
        cell8.innerHTML = data.;

        const cell9 = newRow.insertCell(8);
        cell9.innerHTML = data.;
    });
}*/