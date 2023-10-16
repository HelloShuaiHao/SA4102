/*
tutorial
https://www.bilibili.com/video/BV1Kt411u7BV/?spm_id_from=333.880.my_history.page.click&vd_source=6787721b3e8c187b64329d734a67a5f7
*/

let elementA;

window.onload = function () {
    // 初始化
    let obj1 =  { a: 0 };
    let obj2 =  { b: 0 };
    let obj3 =  { c: 0 };


    elementA = document.getElementById("a");
    while (true) {

        Initialize(obj1, obj2, obj3);
        
        let flag = false;

        elementA.addEventListener("keydown", function (event) {
            if (event.key == "Enter") {
                let a = parseInt(elementA.innerHTML);
                let b = obj2.b;
                let c = obj3.c;

                if (a + b == c) {
                    alert("yes");
                    updateStatus(true);

                } else {
                    alert("no");
                    updateStatus(false);
                }

            }

        });

        break;
    }

    
    
}

function Initialize(obj1, obj2, obj3) {
    let xhr = new XMLHttpRequest();
    xhr.open("Get", "/Data/GetData");
    xhr.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {

            let datas = JSON.parse(this.responseText);
            obj1.a = datas.a;
            obj2.b = datas.b;
            obj3.c = datas.c;

            let bElement = document.getElementById("b");
            let cElement = document.getElementById("c");

            bElement.innerHTML = obj2.b;
            cElement.innerHTML = obj3.c;
        }
    }

    xhr.send();
}

function updateStatus(status) {
    let elementMsg = document.getElementById("output");

    if (status) {
        elementMsg.innerHTML = "Yes";
        elementMsg.classList.remove("red");
        elementMsg.classList.add("green"); // 添加class
    } else {
        elementMsg.innerHTML = "No";
        elementMsg.classList.remove("green");
        elementMsg.classList.add("red");
    }
}