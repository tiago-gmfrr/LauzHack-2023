// import "inc.js";

// import { socket } from "./main";


const socket = require('./socket.js');

socket.emit('message', 'Hello from another file!1');

function createRoom() {

    socket.emit('message', 'Hello from another file!2');
    // alert("asd");
    // socket.open(); 
    socket.open();
}

function joinRoom() {

}