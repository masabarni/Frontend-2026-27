# II. Adatvezérelt weboldal

## Technológiák

- HTML5
- CSS3
- Bootstrap 5
- JavaScript
- JSON Server

## 1. JSON Server indítása

A projekt mappájában:

```bash
npx json-server db.json
```

A szerver ezután a következő címen érhető el:

```text
http://localhost:3000
```

A termékek végpontja:

```text
http://localhost:3000/shoes
```

## 2. Frontend indítása

Az `index.html` fájlt érdemes VS Code Live Serverrel vagy más helyi fejlesztői szerverrel futtatni.

Például:

```text
http://127.0.0.1:5500
```

## 3. Működés

```text
db.json
   ↓
JSON Server
   ↓
GET /shoes
   ↓
fetch()
   ↓
app.js
   ↓
renderShoes()
   ↓
Bootstrap kártyák
```

## 4. Fájlok

- `index.html` – HTML szerkezet
- `style.css` – egyedi CSS
- `app.js` – adatok lekérése és megjelenítése
- `db.json` – JSON Server adatforrás

## 5. Továbbfejlesztési ötletek

- keresés
- márka szerinti szűrés
- ár szerinti rendezés
- akciós termékek szűrése
- részletes termékoldal
- valódi kosár
- POST / PUT / DELETE műveletek
- Vue.js + TypeScript változat
