$(function () {
    $('#btn_tinh').click(function (event) {
        event.preventDefault();

        let a = parseFloat($('#tb_nhapa').val());
        let b = parseFloat($('#tb_nhapb').val());
        let c = parseFloat($('#tb_nhapc').val());

        if (isNaN(a) || isNaN(b) || isNaN(c)) {
            alert("Vui lòng nhập đúng hệ số a, b, c.");
            return;
        }

        let data = JSON.stringify({ a: a, b: b, c: c });

        let result = giaiPTB2(a, b, c);
        $('#kq').text(result);
    });

    function giaiPTB2(a, b, c) {
        if (a === 0) {
            if (b === 0) {
                return "Phương trình vô nghiệm.";
            } else {
                return "Phương trình có 1 nghiệm x = " + (-c / b);
            }
        }

        let delta = b * b - 4 * a * c;
        if (delta > 0) {
            let x1 = (-b + Math.sqrt(delta)) / (2 * a);
            let x2 = (-b - Math.sqrt(delta)) / (2 * a);
            return "Phương trình có 2 nghiệm: x1 = " + x1 + ", x2 = " + x2;
        } else if (delta === 0) {
            let x = -b / (2 * a);
            return "Phương trình có 1 nghiệm kép: x1 = x2 = " + x;
        } else {
            return "Phương trình vô nghiệm.";
        }
    }
});
