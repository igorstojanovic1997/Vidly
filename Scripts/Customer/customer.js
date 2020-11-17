(function () {
    // all your code here
// ...

    $("table#customersTable").DataTable();

    $("#customersTable").on("click", ".js-delete",
        function () {
            var button = $(this);
            if (confirm("Are you sure you want to delete this customer?")) {
                $.ajax({
                    url: "api/customers/" + $(this).attr("data-customer-id"),
                    method: "DELETE",
                    done: function () {
                        button.parents("tr").remove();
                    }
                });
            }
        });
})();