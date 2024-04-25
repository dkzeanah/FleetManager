/*import interact from './interactFunctions';

import { makeDraggable } from './draggable.js';
import { makeResizableAndDraggable } from './resizable.js';
import { addSquare } from './square.js';
import { showAlert } from './alert.js';
import { enableDragAndDrop } from './dragdrop.js';
*/
export function showPrompt(message) {
    return prompt(message, 'Type anything here');
}






export function addSquare() {
    // Your JavaScript code to add a square
    console.log(block.color)
    Console.log("success.");
}


export function showAlert(message) {
    alert(message);
}
/*export function makeDraggable(id) {
    console.log("ID: " + id);

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
}*/

// script.js
export function makeDraggable1(elementId) {
    var selectedBlock = null;
    var offsetX = 0, offsetY = 0;

    // Function to run when the mouse is pressed down
    function onMouseDown(event) {
        // Check if we clicked on a block
        var block = event.target.closest("#" + elementId);
        if (block) {
            // Select the block and record the current mouse position
            selectedBlock = block;
            offsetX = event.clientX - block.offsetLeft;
            offsetY = event.clientY - block.offsetTop;
        }
    }

    // Function to run when the mouse is moved
    function onMouseMove(event) {
        // If we have a block selected, move it to the new mouse position
        if (selectedBlock) {
            selectedBlock.style.left = (event.clientX - offsetX) + "px";
            selectedBlock.style.top = (event.clientY - offsetY) + "px";
        }
    }

    // Function to run when the mouse is released
    function onMouseUp(event) {
        // Deselect the block
        selectedBlock = null;
    }

    // Add our event listeners to the document
    document.addEventListener("mousedown", onMouseDown);
    document.addEventListener("mousemove", onMouseMove);
    document.addEventListener("mouseup", onMouseUp);
}
// script.js
export function makeDraggable2(elementId) {
    var selectedBlock = null;
    var offsetX = 0, offsetY = 0;

    // Function to run when the mouse is pressed down
    function onMouseDown(event) {
        // Check if we clicked on a block
        var block = event.target.closest("#" + elementId);
        if (block) {
            // Select the block and record the current mouse position
            selectedBlock = block;
            offsetX = event.clientX - block.offsetLeft;
            offsetY = event.clientY - block.offsetTop;

            // Change the border to indicate selection
            selectedBlock.style.border = "2px solid red";

            // Add mouse move and mouse up listeners only when a block is selected
            document.addEventListener("mousemove", onMouseMove);
            document.addEventListener("mouseup", onMouseUp);
        }
    }

    // Function to run when the mouse is moved
    function onMouseMove(event) {
        // If we have a block selected, move it to the new mouse position
        if (selectedBlock) {
            selectedBlock.style.left = (event.clientX - offsetX) + "px";
            selectedBlock.style.top = (event.clientY - offsetY) + "px";
        }
    }

    // Function to run when the mouse is released
    function onMouseUp(event) {
        // Restore the original border and deselect the block
        if (selectedBlock) {
            selectedBlock.style.border = "1px solid black";
            selectedBlock = null;

            // Remove mouse move and mouse up listeners when a block is deselected
            document.removeEventListener("mousemove", onMouseMove);
            document.removeEventListener("mouseup", onMouseUp);
        }
    }

    // Add mouse down listener to the document
    document.addEventListener("mousedown", onMouseDown);
}
// script.js
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

// interactFunctions.js
/*export const interactFunctions = {
    makeDraggable: function (id) {
        console.log("ID: " + id);

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
    },

    makeResizableAndDraggable: function (id) {
        $('#' + id).draggable().resizable();
    }
}
*/


    //"use strict";
    /*class ChartJsInterop {
        constructor() {
            this.BlazorCharts = new Map();
        }
        setupChart(config) {
            if (!this.BlazorCharts.has(config.canvasId)) {
                this.wireUpCallbacks(config);
                let chart = new Chart(config.canvasId, config);
                this.BlazorCharts.set(config.canvasId, chart);
                return true;
            }
            else {411
    
                return this.updateChart(config);
            }
        }
        updateChart(config) {
            if (!this.BlazorCharts.has(config.canvasId))
                throw `Could not find a chart with the given id. ${config.canvasId}`;
            let myChart = this.BlazorCharts.get(config.canvasId);
            this.mergeDatasets(myChart.config.data.datasets, config.data.datasets);
            this.mergeLabels(myChart.config.data, config.data);
            this.wireUpCallbacks(config);
            Chart.helpers.extend(myChart.config.options, config.options);
            myChart.update();
            return true;
        }
        mergeDatasets(oldDatasets, newDatasets) {
            for (let i = oldDatasets.length - 1; i >= 0; i--) {
                let sameDatasetInNewConfig = newDatasets.find(newD => newD.id === oldDatasets[i].id);
                if (sameDatasetInNewConfig === undefined) {
                    oldDatasets.splice(i, 1);
                }
                else {
                    Chart.helpers.extend(oldDatasets[i], sameDatasetInNewConfig);
                }
            }
            let currentIds = oldDatasets.map(dataset => dataset.id);
            newDatasets.filter(newDataset => !currentIds.includes(newDataset.id))
                .forEach(newDataset => oldDatasets.push(newDataset));
        }
        mergeLabels(oldChartData, newChartData) {
            const innerFunc = (oldLabels, newLabels) => {
                if (newLabels == null || newLabels.length === 0) {
                    if (oldLabels) {
                        oldLabels.length = 0;
                    }
                    return oldLabels;
                }
                if (oldLabels == null) {
                    return newLabels;
                }
                oldLabels.length = 0;
                for (var i = 0; i < newLabels.length; i++) {
                    oldLabels.push(newLabels[i]);
                }
                return oldLabels;
            };
            oldChartData.labels = innerFunc(oldChartData.labels, newChartData.labels);
            oldChartData.xLabels = innerFunc(oldChartData.xLabels, newChartData.xLabels);
            oldChartData.yLabels = innerFunc(oldChartData.yLabels, newChartData.yLabels);
        }
        wireUpCallbacks(config) {
            this.wireUpOptionsOnClick(config);
            this.wireUpOptionsOnHover(config);
            this.wireUpLegendOnClick(config);
            this.wireUpLegendOnHover(config);
            this.wireUpLegendItemFilter(config);
            this.wireUpGenerateLabels(config);
            this.wireUpTickCallback(config);
        }
        wireUpOptionsOnClick(config) {
            let getDefaultFunc = type => {
                let defaults = Chart.defaults[type] || Chart.defaults.global;
                return (defaults === null || defaults === void 0 ? void 0 : defaults.onClick) || Chart.defaults.global.onClick;
            };
            if (!config.options)
                return;
            config.options.onClick = this.getMethodHandler(config.options.onClick, getDefaultFunc(config.type));
        }
        wireUpOptionsOnHover(config) {
            let getDefaultFunc = type => {
                let defaults = Chart.defaults[type] || Chart.defaults.global;
                return (defaults === null || defaults === void 0 ? void 0 : defaults.onHover) || Chart.defaults.global.onHover;
            };
            if (!config.options)
                return;
            config.options.onHover = this.getMethodHandler(config.options.onHover, getDefaultFunc(config.type));
        }
        wireUpLegendOnClick(config) {
            var _a;
            let getDefaultHandler = type => {
                var _a;
                let chartDefaults = Chart.defaults[type] || Chart.defaults.global;
                return ((_a = chartDefaults === null || chartDefaults === void 0 ? void 0 : chartDefaults.legend) === null || _a === void 0 ? void 0 : _a.onClick) || Chart.defaults.global.legend.onClick;
            };
            if (!((_a = config.options) === null || _a === void 0 ? void 0 : _a.legend))
                return;
            config.options.legend.onClick = this.getMethodHandler(config.options.legend.onClick, getDefaultHandler(config.type));
        }
        wireUpLegendOnHover(config) {
            var _a;
            let getDefaultFunc = type => {
                var _a;
                let chartDefaults = Chart.defaults[type] || Chart.defaults.global;
                return ((_a = chartDefaults === null || chartDefaults === void 0 ? void 0 : chartDefaults.legend) === null || _a === void 0 ? void 0 : _a.onHover) || Chart.defaults.global.legend.onHover;
            };
            if (!((_a = config.options) === null || _a === void 0 ? void 0 : _a.legend))
                return;
            config.options.legend.onHover = this.getMethodHandler(config.options.legend.onHover, getDefaultFunc(config.type));
        }
        wireUpLegendItemFilter(config) {
            var _a, _b;
            let getDefaultFunc = type => {
                var _a, _b;
                let chartDefaults = Chart.defaults[type] || Chart.defaults.global;
                return ((_b = (_a = chartDefaults === null || chartDefaults === void 0 ? void 0 : chartDefaults.legend) === null || _a === void 0 ? void 0 : _a.labels) === null || _b === void 0 ? void 0 : _b.filter) || Chart.defaults.global.legend.labels.filter;
            };
            if (!((_b = (_a = config.options) === null || _a === void 0 ? void 0 : _a.legend) === null || _b === void 0 ? void 0 : _b.labels))
                return;
            config.options.legend.labels.filter = this.getMethodHandler(config.options.legend.labels.filter, getDefaultFunc(config.type));
        }
        wireUpGenerateLabels(config) {
            var _a, _b;
            let getDefaultFunc = type => {
                var _a, _b;
                let chartDefaults = Chart.defaults[type] || Chart.defaults.global;
                return ((_b = (_a = chartDefaults === null || chartDefaults === void 0 ? void 0 : chartDefaults.legend) === null || _a === void 0 ? void 0 : _a.labels) === null || _b === void 0 ? void 0 : _b.generateLabels) || Chart.defaults.global.legend.labels.generateLabels;
            };
            if (!((_b = (_a = config.options) === null || _a === void 0 ? void 0 : _a.legend) === null || _b === void 0 ? void 0 : _b.labels))
                return;
            config.options.legend.labels.generateLabels = this.getMethodHandler(config.options.legend.labels.generateLabels, getDefaultFunc(config.type));
        }
        wireUpTickCallback(config) {
            var _a, _b, _c;
            const assignCallbacks = axes => {
                if (axes) {
                    for (var i = 0; i < axes.length; i++) {
                        if (!axes[i].ticks)
                            continue;
                        axes[i].ticks.callback = this.getMethodHandler(axes[i].ticks.callback, undefined);
                        if (!axes[i].ticks.callback) {
                            delete axes[i].ticks.callback;
                        }
                    }
                }
            };
            if ((_a = config.options) === null || _a === void 0 ? void 0 : _a.scales) {
                assignCallbacks(config.options.scales.xAxes);
                assignCallbacks(config.options.scales.yAxes);
            }
            if ((_c = (_b = config.options) === null || _b === void 0 ? void 0 : _b.scale) === null || _c === void 0 ? void 0 : _c.ticks) {
                config.options.scale.ticks.callback = this.getMethodHandler(config.options.scale.ticks.callback, undefined);
                if (!config.options.scale.ticks.callback) {
                    delete config.options.scale.ticks.callback;
                }
            }
        }
        getMethodHandler(handler, defaultFunc) {
            if (handler == null) {
                return defaultFunc;
            }
            if (this.isDelegateHandler(handler)) {
                const stringifyArgs = (args) => {
                    for (var i = 0; i < args.length; i++) {
                        if (handler.ignoredIndices.includes(i)) {
                            args[i] = '';
                        }
                        else {
                            args[i] = this.stringifyObjectIgnoreCircular(args[i]);
                        }
                    }
                    return args;
                };
                if (!handler.returnsValue) {
                    return (...args) => handler.handlerReference.invokeMethodAsync(handler.methodName, stringifyArgs(args));
                }
                else {
                    if (window.hasOwnProperty('MONO')) {
                        return (...args) => handler.handlerReference.invokeMethod(handler.methodName, stringifyArgs(args));
                    }
                    else {
                        console.warn('Using C# delegates that return values in chart.js callbacks is not supported on ' +
                            "server side blazor because the server side dispatcher doesn't support synchronous interop calls. Falling back to default value.");
                        return defaultFunc;
                    }
                }
            }
            else {
                if (handler.methodName == null) {
                    return defaultFunc;
                }
                const namespaceAndFunc = handler.methodName.split('.');
                if (namespaceAndFunc.length !== 2) {
                    return defaultFunc;
                }
                const namespace = window[namespaceAndFunc[0]];
                if (namespace == null) {
                    return defaultFunc;
                }
                const func = namespace[namespaceAndFunc[1]];
                if (typeof func === 'function') {
                    return func;
                }
                else {
                    return defaultFunc;
                }
            }
        }
        isDelegateHandler(handler) {
            return 'handlerReference' in handler;
        }
        stringifyObjectIgnoreCircular(object) {
            const seen = new WeakSet();
            const replacer = (_name, value) => {
                if (typeof value === 'object' &&
                    value !== null &&
                    !(value instanceof Boolean) &&
                    !(value instanceof Date) &&
                    !(value instanceof Number) &&
                    !(value instanceof RegExp) &&
                    !(value instanceof String)) {
                    if (seen.has(value))
                        return undefined;
                    seen.add(value);
                }
                return value;
            };
            return JSON.stringify(object, replacer);
        }
    }*/
    /*window[ChartJsInterop.name] = new ChartJsInterop();
    */


// wwwroot/interactFunctions.js
/*window.interactFunctions = {
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
}*/
// wwwroot/interactFunctions.js
/*window.interactFunctions = {
    makeResizableAndDraggable: function (id) {
        $('#' + id).draggable().resizable();
    }
}*/

