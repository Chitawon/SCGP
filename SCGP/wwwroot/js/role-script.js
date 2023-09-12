//Check All AssignPC
$("#AssignPC input#checkallPC").on("click",
    function () {
        let checkbox = [];
        $("#AssignPC input").each((index, elem) => {
            checkbox.push(elem);
        });

        let mainAllCheck = this.checked;

        CheckAllBox(mainAllCheck, checkbox);
    }
)

//Check All AssignPDA
$("#AssignPDA input#checkallPDA").on("click",
    function () {
        let checkbox = [];
        $("#AssignPDA input").each((index, elem) => {
            checkbox.push(elem);
        });

        let mainAllCheck = this.checked;
        CheckAllBox(mainAllCheck, checkbox);
    }
)

function CheckAllBox(checked, checkbox)
{
    for (var i = 0; i < checkbox.length; i++) {

        if (checkbox[i].checked != checked) {
            checkbox[i].click();
        }
    }
}