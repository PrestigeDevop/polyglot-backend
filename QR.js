

let qr = require('qr-image');
var QRCode = require('qrcode')
const express = require('express');
const port = 3000;
const app = express();
const test = 'Hello from Node JS!'
const bodyParser = require('body-parser');

console.log("method is called")

app.get('/hi', async (req, res) => {

    res.send('hi from express')
})
app.use('/generateQR', async (req, res) => {
    console.log('API is called')
    try {
        const url = req.query.url || 'https://example.com';
        const qrCodeImage =  await QRCode.toDataURL(url);
        res.send(`<img src="${qrCodeImage}" alt="QR Code"/>`);
    } catch (err) {
        console.error('Error generating QR code:', err);
        res.status(500).send('Internal Server Error');
    }
});

app.listen(port, () => {
    console.log(`Example app listening on port ${port}`)
})
module.exports = function (callback, text) {

    express,port,app ,test

};