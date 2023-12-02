import "inc.js"

const { app, BrowserWindow} = require('electron');

const createWindow = () => {
    const win = new BrowserWindow({
        width: 470,
        height: 170
    });

    win.setMenu(null);

    win.loadFile('index.html');
};

app.whenReady().then(()=>{
    createWindow();
})

app.on('window-all-closed', ()=>{
    if(process.platform !== 'darwin') app.quit();
});

