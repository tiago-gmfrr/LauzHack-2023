// import io from 'socket.io-client'

const { app, BrowserWindow } = require('electron', 'express');
// const io = require('socket.io')();


const createWindow = () => {
    const win = new BrowserWindow({
        width: 470,
        height: 170
    });

    win.setMenu(null);

    win.loadFile('index.html');

    const f = () => {

    }
};

app.whenReady().then(() => {
    createWindow();

    

})

app.on('window-all-closed', () => {
    if (process.platform !== 'darwin') app.quit();
});

// export {socket}


// require('./lobby.js');
