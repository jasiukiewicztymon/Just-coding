// pupeteer
const puppeteer = require('puppeteer');
fs = require('fs');

function sleep(milliseconds) {
    const date = Date.now();
    let currentDate = null;
    do {
      currentDate = Date.now();
    } while (currentDate - date < milliseconds);
  }
  

(async () => {
    try {
        while (1) {
            const browser = await puppeteer.launch({ headless: true });
            const page = await browser.newPage();
            await page.setUserAgent('Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/73.0.3641.0 Safari/537.36');
            await page.goto('https://disboard.org/fr/server/939255949699473418'); 
            
            var name = './serverinfo.json';
            var m = JSON.parse(fs.readFileSync(name).toString());

            await page.waitForSelector('.online-member-count')
            let o = await page.$('.online-member-count b')
            let oe = await page.evaluate(el => el.textContent, o)
            await page.waitForSelector('.member-count')
            let t = await page.$('.member-count b')
            let te = await page.evaluate(el => el.textContent, t)

            m.online = parseInt(oe);
            m.total = parseInt(te);

            fs.writeFileSync(name, JSON.stringify(m));

            await page.close();
            sleep(60000);
        }
    }
    catch (err) {
        console.log(err);
    }
})();