

let addButton = document.getElementById("add-button");
addButton.addEventListener("click", addToDoItem);


// function addToDoItem() {
//     alert("Button Added!");
// }

let toDoEntryBox = document.getElementById("todo-entry-box");
let toDoList = document.getElementById("todo-list");

function addToDoItem() {
    var itemText = toDoEntryBox.value;
    newToDoItem(itemText, false);
}

function newToDoItem(itemText, completed) {
    var toDoItem = document.createElement("li");
    var toDoText = document.createTextNode(itemText);
    toDoItem.appendChild(toDoText);

    if (completed) {
        toDoItem.classList.add("completed");
    }

    toDoList.appendChild(toDoItem);
    toDoItem.addEventListener("dblclick", toggleToDoItemState);
}

function toggleToDoItemState() {
    if(this.classList.contains("completed")){
        this.classList.remove("completed");
    }else{
        this.classList.add("completed");
    }
}

let clearComButton = document.getElementById("clear-button");
clearComButton.addEventListener("click", clearCompleatedToDoItems);

// function clearCompleatedToDoItems() {
//     alert("Clear Completed!");
// }

function clearCompleatedToDoItems(){
    var completedItems = toDoList.getElementsByClassName("completed")
    while (completedItems.length > 0) {
        completedItems.item(0).remove();
    }
}


let emptyButton = document.getElementById("empty-button");
emptyButton.addEventListener("click", emptyList);

// function emptyList() {
//     alert("Empty List!");
    
// }

function emptyList(){
    var toDoItems = toDoList.children;
    while (toDoItems.length>0){
    toDoItems.item(0).remove();
    }
}

let saveButton = document.getElementById("save-button");
saveButton.addEventListener("click", saveList);

// function saveList() {
//     alert("List Saved!");
// }

// var myArray = [];
// myArray.push("something to store");
// myArray.push("something else to store");
// alert(myArray[0]);
//This will alert "something to store"

function saveList() {
    var toDos = [];
    for (var i = 0; i < toDoList.children.length; i++) {
        var toDo = toDoList.children.item(i);
        var toDoInfo = {
            "task": toDo.innerText,
            "completed": toDo.classList.contains("completed")
        };
        toDos.push(toDoInfo);
    }
    localStorage.setItem("toDos", JSON.stringify(toDos));
}

function loadList() {
    if (localStorage.getItem("toDos") != null) {
        var toDos = JSON.parse(localStorage.getItem("toDos"));

        for (var i = 0; i < toDos.length; i++) {
            var toDo = toDos[i];
            newToDoItem(toDo.task, toDo.completed);
        }
    }
}

loadList();