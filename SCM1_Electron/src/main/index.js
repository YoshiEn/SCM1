import { app, BrowserWindow, Menu, Tray } from 'electron'

/**
 * Set `__static` path to static files in production
 * https://simulatedgreg.gitbooks.io/electron-vue/content/en/using-static-assets.html
 */
if (process.env.NODE_ENV !== 'development') {
  global.__static = require('path').join(__dirname, '/static').replace(/\\/g, '\\\\')
}

let mainWindow
const winURL = process.env.NODE_ENV === 'development'
  ? `http://localhost:9080`
  : `file://${__dirname}/index.html`

function createWindow () {
  /**
   * Initial window options
   */
  if (mainWindow) {
    if (mainWindow.isMinimized())
        mainWindow.focus()
  } else {
    mainWindow = new BrowserWindow({
      height: 563,
      useContentSize: true,
      width: 1000
    })
  }

  mainWindow.loadURL(winURL)

  mainWindow.on('closed', () => {
    mainWindow = null
  })
}

app.on('ready', () => {
  createWindow()

  //タスクトレイに格納
  var appIcon = new Tray(__dirname + '/image/icon.png')
  const contextMenu = Menu.buildFromTemplate([
      {label: 'Open(O)', accelerator: 'Command+O', click: () => createWindow()}
      ,{label: 'Close(Q)', accelerator: 'Command+Q', click: () => app.quit()}
  ])
  appIcon.setToolTip('SekiPa : 座席管理システム')
  appIcon.setContextMenu(contextMenu)
})

app.on('window-all-closed', () => {
  //常駐させる為、後で外す
  app.quit()
})

app.on('activate', () => {
  if (mainWindow === null) {
    createWindow()
  }
})

/**
 * Auto Updater
 *
 * Uncomment the following code below and install `electron-updater` to
 * support auto updating. Code Signing with a valid certificate is required.
 * https://simulatedgreg.gitbooks.io/electron-vue/content/en/using-electron-builder.html#auto-updating
 */

/*
import { autoUpdater } from 'electron-updater'

autoUpdater.on('update-downloaded', () => {
  autoUpdater.quitAndInstall()
})

app.on('ready', () => {
  if (process.env.NODE_ENV === 'production') autoUpdater.checkForUpdates()
})
 */
