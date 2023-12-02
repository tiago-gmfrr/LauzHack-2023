const SERVER_IP = "127.0.0.1";

const socket = io("http://127.0.0.1:30992", {
    autoConnect: false,
    transports: ['websocket']
});