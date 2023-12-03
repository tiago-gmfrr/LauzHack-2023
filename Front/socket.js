// socket.js
const net = require('net');
const client = new net.Socket();

const socket = io.connect('http://127.0.0.1:11111');

socket.on('connect', () => {
  console.log('Connected to the server');
});

socket.on('message', (data) => {
  console.log('Received message:', data);
  // Handle the received message as needed
});

socket.on('disconnect', () => {
  console.log('Disconnected from the server');
  // Implement reconnection logic with a delay (e.g., 5 seconds)
  // setTimeout(() => {
  //   socket.connect();
  // }, 5000);
});

// Add more event listeners or emit events as needed

module.exports = socket;