//Crear una cookie
document.cookie = "usuario=Ana; max-age=3600; path=/";

//Con fecha de expiración
const fecha = new Date();
fecha.setDate(fecha.getDate() + 7); // 7 días
document.cookie = `tema=oscuro; expires=${fecha.toUTCString()}; path=/`;

//Leer cookies
console.log(document.cookie); // "usuario=Ana; tema=oscuro"

//Eliminar (expirando en el pasado)
document.cookie = "usuario=; max-age=0; path=/";

//Función helper para leer una cookie específica
function getCookie(nombre) {
  return document.cookie
    .split("; ")
    .find(r => r.startsWith(nombre + "="))
    ?.split("=")[1];
}
