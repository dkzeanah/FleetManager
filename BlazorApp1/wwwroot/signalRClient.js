// signalRClient.js

import * as signalR from "@microsoft/signalr";

let connection;

export async function initializeSignalR() {
    connection = new signalR.HubConnectionBuilder()
        .withUrl("/updateHub")
        .build();

    connection.on("ReceiveMessage", function (message) {
        let messageElement = document.createElement("div");
        messageElement.innerHTML = message;
        document.body.appendChild(messageElement);
    });

    try {
        await connection.start();
    } catch (err) {
        console.error(err.toString());
    }
}

export async function stopConnection() {
    if (connection) {
        await connection.stop();
    }
}
