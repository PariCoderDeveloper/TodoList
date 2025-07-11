const div_body = document.querySelector(".container .pb-3");
window.addEventListener("DOMContentLoaded", () => {
    fetch("/Index?handler=Data")
        .then(res => res.json())
        .then(data => {
            data.forEach(item => {
                const checkbok = document.createElement("input");
                const label = document.createElement("label");
                checkbok.type = "checkbox";
                checkbok.value = item.id;
                checkbok.id = `${item.title}-${item.id}`;
                label.textContent = item.title;
                label.htmlFor = checkbok.id;
                if (item.isCompleted) {
                    checkbok.checked = true;
                }
                div_body.appendChild(checkbok);
                div_body.appendChild(label);
                div_body.appendChild(document.createElement("br"));
            });
        });
});