// wwwroot/interactFunctions.js

// draggable.js
export function makeDraggable(id) {
    // Your code here...
}

// resizable.js
export function makeResizableAndDraggable(id) {
    // Your code here...
}

// square.js
export function addSquare() {
    // Your code here...
}

// alert.js
export function showAlert(message) {
    // Your code here...
}

// dragdrop.js
export function enableDragAndDrop() {
    // Your code here...
}


export function addSquare() {
    // Your JavaScript code to add a square
    Console.log("success.");
}

window.interactFunctions = {
    makeDraggable: function (id) {
        console.log("ID: " + el.dataset.id);

        interact('#' + id)
            .draggable({
                // enable inertial throwing
                inertia: true,
                // keep the element within the area of it's parent
                modifiers: [
                    interact.modifiers.restrictRect({
                        restriction: 'parent',
                        endOnly: true
                    })
                ],
                // enable autoScroll
                autoScroll: true,

                listeners: {
                    // call this function on every dragmove event
                    move: dragMoveListener,

                    // call this function on every dragend event
                    end(event) {
                        console.log('finished dragging');
                    }
                }
            })
            .resizable({
                // resize from all edges and corners
                edges: { left: true, right: true, bottom: true, top: true },

                listeners: {
                    move(event) {
                        var target = event.target;
                        var x = (parseFloat(target.getAttribute('data-x')) || 0);
                        var y = (parseFloat(target.getAttribute('data-y')) || 0);

                        // update the element's style
                        target.style.width = event.rect.width + 'px';
                        target.style.height = event.rect.height + 'px';

                        // translate when resizing from top or left edges
                        x += event.deltaRect.left;
                        y += event.deltaRect.top;

                        target.style.webkitTransform = target.style.transform =
                            'translate(' + x + 'px,' + y + 'px)';

                        target.setAttribute('data-x', x);
                        target.setAttribute('data-y', y);
                    }
                },

                modifiers: [
                    // keep the edges inside the parent
                    interact.modifiers.restrictEdges({
                        outer: 'parent',
                        endOnly: true,
                    }),

                    // minimum size
                    interact.modifiers.restrictSize({
                        min: { width: 100, height: 50 },
                    }),
                ],

                inertia: true
            });

        function dragMoveListener(event) {
            var target = event.target,
                // keep the dragged position in the data-x/data-y attributes
                x = (parseFloat(target.getAttribute('data-x')) || 0) + event.dx,
                y = (parseFloat(target.getAttribute('data-y')) || 0) + event.dy;

            // translate the element
            target.style.webkitTransform =
                target.style.transform =
                'translate(' + x + 'px, ' + y + 'px)';

            // update the position attributes
            target.setAttribute('data-x', x);
            target.setAttribute('data-y', y);
        }
    }
}
// wwwroot/interactFunctions.js
window.interactFunctions = {
    makeResizableAndDraggable: function (id) {
        $('#' + id).draggable().resizable();
    }
}

