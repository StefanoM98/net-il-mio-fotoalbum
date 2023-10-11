// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function getFoto() {

    axios.get("/api/Fotos/getFoto?filter=" + document.getElementById("cerca").value)
        .then(resp => {
            document.getElementById('card-container').innerHTML = "";
            resp.data.forEach((foto) => {
                document.getElementById('card-container').innerHTML +=
                    `
                        <div class="card p-2" style ="width:20%; min-width:200px">
                            <img class="card-image w-100" style= "height: 180px; object-fit:contain;" src="${foto.pathimg}">
                            <div class="card-header">${foto.title}</div>
                            <div class="card-header">${foto.description}</div>
                            <div class="card-body overflow-hidden px-1 pb-4">
                                <a class="btn btn-primary" href="/Foto/Dettagli/${foto.id}" 
                                    <i class="fa-solid fa-magnifying-glass">Dettagli</i> 
                                </a>
                        </div>
                    `
            });
        })
        .catch((error)=>alert(error))
}

