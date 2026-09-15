const API_URL = "http://localhost:3000/shoes";

const shoeList = document.querySelector("#shoe-list");
const loading = document.querySelector("#loading");
const errorMessage = document.querySelector("#error-message");


async function loadShoes() {
    try {
        const response = await fetch(API_URL);

        if (!response.ok) {
            throw new Error(`HTTP hiba: ${response.status}`);
        }

        const shoes = await response.json();

        renderShoes(shoes);

    } catch (error) {
        console.error("Hiba:", error);

        errorMessage.textContent =
            "Nem sikerült betölteni a termékeket. Ellenőrizd, hogy fut-e a JSON Server.";

        errorMessage.classList.remove("d-none");

    } finally {
        loading.classList.add("d-none");
    }
}


function renderShoes(shoes) {

    shoeList.innerHTML = "";

    shoes.forEach(shoe => {

        const oldPriceHtml = shoe.oldPrice
            ? `
                <p class="mb-1">
                    <del class="text-muted">
                        ${formatPrice(shoe.oldPrice)}
                    </del>
                </p>
              `
            : "";

        const card = `
            <div class="col-md-6 col-lg-4">

                <article class="card h-100 shadow-sm shoe-card">

                    <img
                        src="${shoe.image}"
                        class="card-img-top"
                        alt="${shoe.name}">

                    <div class="card-body d-flex flex-column">

                        <h3 class="card-title h5">
                            ${shoe.name}
                        </h3>

                        <p class="text-muted mb-2">
                            ${shoe.brand} • ${shoe.category} • ${shoe.gender}
                        </p>

                        <p class="card-text">
                            ${shoe.description}
                        </p>

                        <div class="mt-auto">

                            ${oldPriceHtml}

                            <p class="fw-bold text-success price">
                                ${formatPrice(shoe.price)}
                            </p>

                            <button
                                class="btn btn-success w-100"
                                type="button"
                                onclick="addToCart(${shoe.id})">
                                Kosárba
                            </button>

                        </div>

                    </div>

                </article>

            </div>
        `;

        shoeList.innerHTML += card;
    });
}


function formatPrice(price) {
    return new Intl.NumberFormat("hu-HU").format(price) + " Ft";
}


function addToCart(id) {
    alert(`A(z) ${id}. termék bekerült a kosárba.`);
}


loadShoes();
