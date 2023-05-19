function setearFoto(event) {
    let imagenClickeada = event.target;
    let idImagen = imagenClickeada.id;
    document.creador.media.value = idImagen;
}