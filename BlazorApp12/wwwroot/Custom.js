export function makeDraggable(elementId) {
    var selectedBlock = null;
    var offsetX = 0, offsetY = 0;
    var gridItemWidth = document.querySelector(".grid").offsetWidth / 30;
    var gridItemHeight = document.querySelector(".grid").offsetHeight / 10;

    function onMouseDown(event) {
        var block = event.target.closest("#" + elementId);
        if (block) {
            selectedBlock = block;
            offsetX = event.clientX - block.offsetLeft;
            offsetY = event.clientY - block.offsetTop;
            selectedBlock.classList.add("selected");

            document.addEventListener("mousemove", onMouseMove);
            document.addEventListener("mouseup", onMouseUp);
        }
    }

    function onMouseMove(event) {
        if (selectedBlock) {
            var newLeft = event.clientX - offsetX;
            var newTop = event.clientY - offsetY;

            offsetX = event.clientX;
            offsetY = event.clientY;

            var column = Math.round(newLeft / gridItemWidth);
            var row = Math.round(newTop / gridItemHeight);

            selectedBlock.style.gridColumnStart = column + 1;
            selectedBlock.style.gridRowStart = row + 1;
        }
    }

    function onMouseUp(event) {
        if (selectedBlock) {
            selectedBlock.classList.remove("selected");
            selectedBlock = null;

            document.removeEventListener("mousemove", onMouseMove);
            document.removeEventListener("mouseup", onMouseUp);
        }
    }

    document.addEventListener("mousedown", onMouseDown);
}

export function makeResizableAndDraggable(id) {
    $('.' + id).draggable().resizable();
}

export function enableDragAndDrop() {

    console.log(" called ");
    var container = document.querySelector("#myContainer");

    var active = false;
    var currentX;
    var currentY;
    var initialX;
    var initialY;
    var xOffset = 0;
    var yOffset = 0;
    var resize = false;
    var resizeElement;

    // UserCarEvent delegation
    container.addEventListener("mousedown", function (e) {
        var dragItem = e.target.closest(".myDraggableItem");

        if (dragItem) {
            dragStart(e, dragItem);
        }
    }, false);

    container.addEventListener("mouseup", function (e) {
        var dragItem = e.target.closest(".myDraggableItem");

        if (dragItem) {
            dragEnd(e, dragItem);
        }
    }, false);

    container.addEventListener("mousemove", function (e) {
        var dragItem = e.target.closest(".myDraggableItem");

        if (dragItem) {
            drag(e, dragItem);
        }
    }, false);

    container.addEventListener("touchstart", function (e) {
        var dragItem = e.target.closest(".myDraggableItem");

        if (dragItem) {
            dragStart(e, dragItem);
        }
    }, false);

    container.addEventListener("touchend", function (e) {
        var dragItem = e.target.closest(".myDraggableItem");

        if (dragItem) {
            dragEnd(e, dragItem);
        }
    }, false);

    container.addEventListener("touchmove", function (e) {
        var dragItem = e.target.closest(".myDraggableItem");

        if (dragItem) {
            drag(e, dragItem);
        }
    }, false);

    function dragStart(e, el) {
        active = true;

        if (e.type === "touchstart") {
            initialX = e.touches[0].clientX - xOffset;
            initialY = e.touches[0].clientY - yOffset;
        } else {
            initialX = e.clientX - xOffset;
            initialY = e.clientY - yOffset;
        }
    }

    function dragEnd(e, el) {
        initialX = currentX;
        initialY = currentY;

        console.log("ID: " + el.dataset.id);
        console.log("X: " + currentX);
        console.log("Y: " + currentY);

        DotNet.invokeMethodAsync('BlazorApp1', 'UpdateSquarePosition', el.dataset.id, currentX, currentY);

        active = false;
    }

    function drag(e, el) {
        if (active) {
            e.preventDefault();

            if (e.type === "touchmove") {
                currentX = e.touches[0].clientX - initialX;
                currentY = e.touches[0].clientY - initialY;
            } else {
                currentX = e.clientX - initialX;
                currentY = e.clientY - initialY;
            }

            xOffset = currentX;
            yOffset = currentY;

            setTranslate(currentX, currentY, el);
        }
    }




    function initDraggableItem(el) {
        el.style.transform = "translate3d(0px, 0px, 0)";
    }
    function setTranslate(xPos, yPos, el) {
        el.style.transform = "translate3d(" + xPos + "px, " + yPos + "px, 0)";
    }


    document.onmousedown = function (e) {
        if (e.target.classList.contains("resizeHandle")) {
            resize = true;
            resizeElement = e.target.parentElement;
        }
    }

    document.onmouseup = function () {
        resize = false;
    }

    document.onmousemove = function (e) {
        if (resize) {
            resizeElement.style.width = e.pageX - resizeElement.offsetLeft + "px";
            resizeElement.style.height = e.pageY - resizeElement.offsetTop + "px";
        }
    }


    container.addEventListener("click", function (e) {
        var deleteButton = e.target.closest(".deleteButton");

        if (deleteButton) {
            deleteItem(deleteButton.parentElement.parentElement);
        }
    }, false);

    function deleteItem(item) {
        item.remove();
    }

}