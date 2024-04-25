

export function startSignalRConnection() {
    connection = new signalR.HubConnectionBuilder()
        .withUrl("/updateHub")
        .build();

    connection.on("ReceiveMessage", function (message) {
        console.log('received', message);
    });

    connection.start().catch(function (err) {
        return console.error(err.toString());
    });
}

export function stopSignalR() {
    if (connection) {
        connection.stop();
    }
}

let currentEvent = null;
let isResizing = false;
let lastX = 0;  // Add this line
let lastY = 0;  // Add this line
let squares = {};
let connection;
export function createSquare(id) {
    try {
        console.log(`Creating square with ID: ${id}`);
        const square = document.createElement('div');
        square.id = id;
        square.style.width = '60px';
        square.style.height = '60px';
        square.style.background = 'blue';
        square.style.position = 'absolute';
        square.style.left = '0px';
        square.style.top = '0px';
        document.body.appendChild(square);
        squares[id] = square;

        const handle = document.createElement('div');
        handle.style.width = '10px';
        handle.style.height = '10px';
        handle.style.background = 'black';
        handle.style.position = 'absolute';
        handle.style.left = '0px';
        handle.style.top = '0px';
        square.appendChild(handle);


            // Attach a mousedown event to the handle for dragging
        handle.addEventListener('mousedown', function (event)
        {
            // Inside the handle's mousedown event listener
            event.stopPropagation();

                let shiftX = event.clientX - handle.getBoundingClientRect().left;
                let shiftY = event.clientY - handle.getBoundingClientRect().top;

                function moveAt(pageX, pageY) {
                    square.style.left = pageX - shiftX + 'px';
                    square.style.top = pageY - shiftY + 'px';
                }

                function onMouseMove(event) {
                    moveAt(event.pageX, event.pageY);
                }

                // move the square on mousemove
                document.addEventListener('mousemove', onMouseMove);

                // drop the square, remove unneeded handlers
                handle.onmouseup = function () {
                    document.removeEventListener('mousemove', onMouseMove);
                    handle.onmouseup = null;
                };
        });

            // disable default drag-and-drop
            handle.ondragstart = function () {
                return false;
            };
   
        addButtonsToSquare(square, id);

        return square;
    } catch (error) {
        console.error(`An error occurred while creating square: ${error.message}`);
    }
}
export function addButtonsToSquare(square, id) {
    if (!id) {
        console.error('ID is undefined');
        return;
    }
    console.log(`Adding buttons to square with ID: ${id}`);

    const inputButton = document.createElement('button');
    inputButton.innerText = 'Add Input';
    inputButton.addEventListener('click', () => {
        console.log(`Clicked 'Add Input' on square ${id}`);
        addInputToSquare(id);
    });

    const colorButton = document.createElement('button');
    colorButton.innerText = 'Change Color';
    colorButton.addEventListener('click', () => {
        console.log(`Clicked 'Change Color' on square ${id}`);
        changeSquareColor(id);
    });

    const resizeButton = document.createElement('button');
    resizeButton.innerText = 'Toggle Resize';
    resizeButton.addEventListener('click', () => {
        console.log(`Clicked 'Toggle Resize' on square ${id}`);
        toggleResize(id);
    });

    // Make buttons smaller
    inputButton.style.width = '50px';
    inputButton.style.height = '20px';
    colorButton.style.width = '50px';
    colorButton.style.height = '20px';
    resizeButton.style.width = '50px';
    resizeButton.style.height = '20px';

    if (typeof square.appendChild !== 'function') {
        console.error('square.appendChild is not a function', square);
        return;
    } else {
        square.appendChild(inputButton);
        square.appendChild(colorButton);
        square.appendChild(resizeButton);
    }
}

export function addInputToSquare(id) {
    if (!id) {
        console.error('ID is undefined');
        return;
    }
    const square = squares[id];
    const input = document.createElement('input');
    input.type = 'text';
    square.appendChild(input);
}



export function toggleResize(id) {
    if (!id) {
        console.error('ID is undefined');
        return;
    }
    console.log(`Toggling resize for square with ID: ${id}`);  // Debugging

    const square = squares[id];
    square.addEventListener('mousedown', onMouseDown);

    function onMouseDown(e) {
        if (e.ctrlKey) {
       
            isResizing = true;
            lastX = e.clientX;
            lastY = e.clientY;
            document.addEventListener('mousemove', onMouseMove);
            document.addEventListener('mouseup', onMouseUp);
            
        }
    }
    function onMouseMove(e) {
        if (isResizing) {
            const dx = e.clientX - lastX;
            const dy = e.clientY - lastY;
            const newWidth = parseInt(square.style.width) + dx;
            const newHeight = parseInt(square.style.height) + dy;

            square.style.width = `${newWidth}px`;
            square.style.height = `${newHeight}px`;

            lastX = e.clientX;
            lastY = e.clientY;
        }
    }

    function onMouseUp() {
        isResizing = false;
        document.removeEventListener('mousemove', onMouseMove);
        document.removeEventListener('mouseup', onMouseUp);
    }

}

export function changeSquareColor(id) {
    const square = squares[id];
    const colorPicker = document.createElement('input');
    colorPicker.type = 'color';
    colorPicker.addEventListener('change', (e) => {
        square.style.background = e.target.value;
    });
    square.appendChild(colorPicker);
    colorPicker.click();
}

//===================
export function createChart(element, data) {
    const chart = new ChartLibrary(element, data);
    return chart;
}

export function updateData(chart, newData) {
    chart.updateData(newData);
}

export function applyTransformation(chart, transformation) {
    chart.applyTransformation(transformation);
}

function onMouseDown(event) {
    let square = event.currentTarget;

    let shiftX = event.clientX - square.getBoundingClientRect().left;
    let shiftY = event.clientY - square.getBoundingClientRect().top;

    square.style.position = 'absolute';
    square.style.zIndex = 1000;
    document.body.append(square);

    moveAt(event.pageX, event.pageY);

    function moveAt(pageX, pageY) {
        square.style.left = pageX - shiftX + 'px';
        square.style.top = pageY - shiftY + 'px';
    }

    function onMouseMove(event) {
        moveAt(event.pageX, event.pageY);
    }

    document.addEventListener('mousemove', onMouseMove);

    square.onmouseup = function () {
        document.removeEventListener('mousemove', onMouseMove);
        square.onmouseup = null;
    };
}

export function changeColor(id, color) {
    if (squares[id]) {
        squares[id].style.background = color;
    }
}


export function showPrompt(message) {
    return prompt(message, 'Type anything here');
}
export function initializeEventListeners(elementId, onEventChangeCallback) {
    const calendarElement = document.getElementById(elementId);
    calendarElement.addEventListener('mousedown', (e) => {
        if (e.target.classList.contains('event')) {
            currentEvent = e.target;
            document.addEventListener('mousemove', onMove);
            document.addEventListener('mouseup', onEnd);
        }
    });

    function onMove(e) {
        if (currentEvent && !isResizing) {
            currentEvent.style.left = e.clientX + 'px';
            currentEvent.style.top = e.clientY + 'px';
        }
    }

    function onEnd(e) {
        if (currentEvent) {
            onEventChangeCallback.invokeMethodAsync('UpdateEventPosition', currentEvent.style.left, currentEvent.style.top);
            document.removeEventListener('mousemove', onMove);
            document.removeEventListener('mouseup', onEnd);
            currentEvent = null;
        }
    }
}

export function createEvent(elementId, left, top, color) {
    const calendarElement = document.getElementById(elementId);
    const eventElement = document.createElement('div');
    eventElement.className = 'event';
    eventElement.style.left = left;
    eventElement.style.top = top;
    eventElement.style.backgroundColor = color;
    calendarElement.appendChild(eventElement);
}
