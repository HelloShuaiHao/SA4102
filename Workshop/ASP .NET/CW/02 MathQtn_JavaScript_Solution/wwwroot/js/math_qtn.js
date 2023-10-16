let lhs_elem, rhs_elem, ans_elem, msg_elem;
let rhs_val, ans_val;

window.onload = function () {

    lhs_elem = document.getElementById("lhs");   
    rhs_elem = document.getElementById("rhs");
    ans_elem = document.getElementById("ans");
    msg_elem = document.getElementById("msg");

    get_qtn();

    lhs.addEventListener("keypress", function (event) {
        if (event.key === "Enter") {
            // event.preventDefault();

            let lhs_val = parseInt(lhs_elem.value);
            if (lhs_val + rhs_val === ans_val) {
                update_status(true);
               
                // Load new question after 1 second
                setTimeout(function () {
                    lhs_elem.value = "";
                    msg_elem.innerHTML = "";
                    get_qtn();
                }, 2000);                
            } else {
                update_status(false);
            }
        }
    });
}

function get_qtn() {
    let xhr = new XMLHttpRequest();

    xhr.open("GET", "/Home/GetQtn");
    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            let qtn = JSON.parse(xhr.responseText);
            rhs_val = parseInt(qtn.rhs);
            ans_val = parseInt(qtn.ans);
            
            rhs_elem.innerHTML = rhs_val;
            ans_elem.innerHTML = ans_val;
        }
    }

    xhr.send();
}

function update_status(is_correct) {
    if (is_correct) {
        msg_elem.innerHTML = "Correct! Fetching new question...";
        msg_elem.classList.remove("incorrect");
        msg_elem.classList.add("correct");
    } else {
        msg_elem.innerHTML = "Incorrect! Try again.";
        msg_elem.classList.remove("correct");
        msg_elem.classList.add("incorrect");
    }
}
