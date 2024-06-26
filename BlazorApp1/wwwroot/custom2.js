function enableDragAndDrop() {

    console.log(" called ");
    var container = document.querySelector("#myContainer");

    var active = false;
    var currentX;
    var currentY;
    var initialX;
    var initialY;
    var xOffset = 0;
    var yOffset = 0;

    // Event delegation
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

    
}

function initDraggableItem(el) {
    el.style.transform = "translate3d(0px, 0px, 0)";
}
function setTranslate(xPos, yPos, el) {
        el.style.transform = "translate3d(" + xPos + "px, " + yPos + "px, 0)";
    }
var resize = false;
var resizeElement;

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
