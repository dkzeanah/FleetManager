let squares = {};
let lastX = 0;
let lastY = 0;

/*export function createSquare(id, x, y) {
    if (squares[id]) {
        console.warn(`Square with ID ${id} already exists.`);
        return;
    }

    const square = document.createElement('div');
    square.id = id;
    square.style.width = '60px';
    square.style.height = '60px';
    square.style.background = 'blue';
    square.style.position = 'absolute';

    square.style.left = `${x}px`;
    square.style.top = `${y}px`;
    squares[id] = square;

    const handle = document.createElement('div');
    handle.style.width = '10px';
    handle.style.height = '10px';
    handle.style.background = 'black';
    handle.style.position = 'absolute';
    handle.style.left = '0px';
    handle.style.top = '0px';

    square.appendChild(handle);
    document.body.appendChild(square);

    attachDragAndDrop(handle, square, id);
    addButtonsToSquare(square, id);
}
export function createSquare(id) {
    if (squares[id]) {
        console.warn(`Square with ID ${id} already exists.`);
        return;
    }

    const square = document.createElement('div');
    square.id = id;
    square.style.width = '60px';
    square.style.height = '60px';
    square.style.background = 'blue';
    square.style.position = 'absolute';
    square.style.left = '0px';
    square.style.top = '0px';

    squares[id] = square;

    const handle = document.createElement('div');
    handle.style.width = '10px';
    handle.style.height = '10px';
    handle.style.background = 'black';
    handle.style.position = 'absolute';
    handle.style.left = '0px';
    handle.style.top = '0px';

    square.appendChild(handle);
    document.body.appendChild(square);

    attachDragAndDrop(handle, square, id);
    addButtonsToSquare(square, id);
}*/
window.getElementById = function (id) {
    return document.getElementById(id);
}
export function createSquare(id, x = 0, y = 0) {
    if (squares[id]) {
        console.warn(`Square with ID ${id} already exists.`);
        return;
    }

    const square = document.createElement('div');
    square.id = id;
    square.style.width = '60px';
    square.style.height = '60px';
    square.style.background = 'blue';
    square.style.position = 'absolute';
    square.style.left = `${x}px`;
    square.style.top = `${y}px`;

    squares[id] = square;

    const handle = document.createElement('div');
    handle.style.width = '10px';
    handle.style.height = '10px';
    handle.style.background = 'black';
    handle.style.position = 'absolute';
    handle.style.left = '0px';
    handle.style.top = '0px';

    square.appendChild(handle);
    document.body.appendChild(square);

    attachDragAndDrop(handle, square, id);
    addButtonsToSquare(square, id);
}


export function attachDragAndDrop(handle, square, id) {
    handle.addEventListener('mousedown', function (event) {
        if (event.ctrlKey) {
            lastX = event.clientX;
            lastY = event.clientY;
            document.addEventListener('mousemove', onMouseMove);
            document.addEventListener('mouseup', onMouseUp);
        } else {
            let shiftX = event.clientX - handle.getBoundingClientRect().left;
            let shiftY = event.clientY - handle.getBoundingClientRect().top;

            function onMouseMove(event) {
                square.style.left = event.pageX - shiftX + 'px';
                square.style.top = event.pageY - shiftY + 'px';
            }

            document.addEventListener('mousemove', onMouseMove);

            handle.onmouseup = function () {
                document.removeEventListener('mousemove', onMouseMove);
                handle.onmouseup = null;
            };
        }
    });

     function onMouseMove(event) {
        const dx = event.clientX - lastX;
        const dy = event.clientY - lastY;
        const newWidth = parseInt(square.style.width) + dx;
        const newHeight = parseInt(square.style.height) + dy;

        square.style.width = `${newWidth}px`;
        square.style.height = `${newHeight}px`;

        lastX = event.clientX;
        lastY = event.clientY;
    }

    function onMouseUp() {
        document.removeEventListener('mousemove', onMouseMove);
        document.removeEventListener('mouseup', onMouseUp);
    }


    handle.ondragstart = function () {
        return false;
    };
}

export function addButtonsToSquare(square, id) {
    const inputButton = createButton('Add Input', () => addInputToSquare(id), 'auto', '20px');
    const colorButton = createButton('Change Color', () => changeSquareColor(square), '50px', '20px');
    colorButton.style.background = 'green';
    colorButton.style.border = '1px solid black';

    square.appendChild(inputButton);
    square.appendChild(colorButton);
}

export function createButton(text, callback, width, height) {
    const button = document.createElement('button');
    button.innerText = text;
    button.style.width = width;
    button.style.height = height;
    button.addEventListener('click', callback);
    return button;
}

export function addInputToSquare(id) {
    const square = squares[id];
    const input = document.createElement('input');
    input.type = 'text';
    input.style.position = 'absolute';
    input.style.bottom = '0';
    square.appendChild(input);
}

export function changeSquareColor(square) {
    square.style.background = prompt("Enter a color:", "blue");
}

export function setupRightClick(dotnetReference) {
    window.addEventListener('contextmenu', event => {
        event.preventDefault();
        const xPos = event.clientX;
        const yPos = event.clientY;
        dotnetReference.invokeMethodAsync('ShowMenu', xPos, yPos);
    });
}