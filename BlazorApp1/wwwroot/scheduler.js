// calendar.js

///*function enableDragAndResize2(overlayId) {
//    const overlay = document.getElementById(overlayId);
//    if (overlay !== null) {

//        overlay.draggable = true;
//        overlay.addEventListener('dragstart', function (e) {
//            e.dataTransfer.setData('text/plain', overlayId);
//        });
//    } else {
//        console.error("Element with id " + overlayId + " not found.");
//    }

console.log("scheduler.js loaded");

export function enableDragAndResize(overlayId) {
    console.log("JS enableandresize");
    const overlay = document.getElementById(overlayId);
    console.log("Attempting to enable drag and resize for element with id: " + overlayId);

    if (overlay !== null) {
        console.log("Element found. Enabling drag and resize.");

        overlay.draggable = true;
        overlay.addEventListener('dragstart', function (e) {
            e.dataTransfer.setData('text/plain', overlayId);
        });

        // Enable dragging
        overlay.addEventListener('mousedown', function (e) {
            let offsetX = e.clientX - overlay.getBoundingClientRect().left;
            let offsetY = e.clientY - overlay.getBoundingClientRect().top;

            document.addEventListener('mousemove', onMouseMove);
            document.addEventListener('mouseup', onMouseUp);

            function onMouseMove(e) {
                console.log("Dragging overlay");
                overlay.style.left = e.clientX - offsetX + 'px';
                overlay.style.top = e.clientY - offsetY + 'px';
            }

            function onMouseUp() {
                console.log("Stopped dragging overlay");
                document.removeEventListener('mousemove', onMouseMove);
                document.removeEventListener('mouseup', onMouseUp);
            }
        });

        // Enable resizing (you can expand this part for more advanced resizing features)
        overlay.addEventListener('dblclick', function () {
            console.log("Resizing overlay");
            overlay.style.width = "200px";
            overlay.style.height = "200px";
        });

    } else {
        console.error("Element with id " + overlayId + " not found.");
    }
}




//}*/
/*
console.log("calendar.js loaded");
window.function enableDragAndResize(overlayId) {
    console.log("JS enableandresize");
    const overlay = document.getElementById(overlayId);
    console.log("Attempting to enable drag and resize for element with id: " + overlayId);

    if (overlay !== null)
    {
        console.log("Element found. Enabling drag and resize.");

        overlay.draggable = true;
        overlay.addEventListener('dragstart', function (e) {
            e.dataTransfer.setData('text/plain', overlayId);
        });
        // Enable dragging
            overlay.addEventListener('mousedown', function (e) {
                let offsetX = e.clientX - overlay.getBoundingClientRect().left;
                let offsetY = e.clientY - overlay.getBoundingClientRect().top;

                document.addEventListener('mousemove', onMouseMove);
                document.addEventListener('mouseup', onMouseUp);

                function onMouseMove(e) {
                    console.log("Dragging overlay");
                    overlay.style.left = e.clientX - offsetX + 'px';
                    overlay.style.top = e.clientY - offsetY + 'px';
                }

                function onMouseUp() {
                    console.log("Stopped dragging overlay");
                    document.removeEventListener('mousemove', onMouseMove);
                    document.removeEventListener('mouseup', onMouseUp);
                }
            } else {
                console.error("Element with id " + overlayId + " not found.");
            }
    });

    // Enable resizing (you can expand this part for more advanced resizing features)
    overlay.addEventListener('dblclick', function () {
        console.log("Resizing overlay");
        overlay.style.width = "200px";
        overlay.style.height = "200px";
    });
}*/


/*window.schedulerInterop = {
    enableDragAndDrop: function (element) {
        if (element) {
            console.log("Element found");
            element.draggable = true;
        } else {
            console.log("Element not found");
        }
    },
    enableDrop: function (container) {
        if (container) {
            console.log("Container found");
            container.ondragover = function (event) {
                event.preventDefault();
            };
            container.ondrop = function (event) {
                event.preventDefault();
                var blockId = event.dataTransfer.getData("text/plain");
                DotNet.invokeMethodAsync('BlazorApp1', 'MoveBlock', blockId, container.id);
            };
        } else {
            console.log("Container not found");
        }
    },

     dragStart: function (event, blockId) {
        event.dataTransfer.setData("text/plain", blockId);
    },

    allowDrop: function (event) {
        event.preventDefault();
    },

    drop: function (event, containerId) {
        event.preventDefault();
        var blockId = event.dataTransfer.getData("text/plain");
        DotNet.invokeMethodAsync('BlazorApp1', 'MoveBlock', blockId, containerId);
    }
};*/
