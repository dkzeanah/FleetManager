window.toastrWrapper = {
    ShowToastrInfo: function (message, options) {
        toastr.options = options,
            toastr.info(message);

    }
}

export function showCustomMenu(elementId) {
    const element = document.getElementById(elementId);
    element.addEventListener('contextmenu', function (event) {
        event.preventDefault();
        // Logic to display your custom menu
        alert('Custom menu for ' + elementId);
    });
}

export function setupGlobalRightClick(handlerName) {
    window.addEventListener('contextmenu', function (event) {
        event.preventDefault();
        DotNet.invokeMethodAsync('YourAssemblyName', handlerName, { x: event.clientX, y: event.clientY });
    });
}
export function setupRightClick(dotnetReference) {
    window.addEventListener('contextmenu', event => {
        event.preventDefault();
        const xPos = event.clientX;
        const yPos = event.clientY;
        dotnetReference.invokeMethodAsync('ShowMenu', xPos, yPos);
    });
}