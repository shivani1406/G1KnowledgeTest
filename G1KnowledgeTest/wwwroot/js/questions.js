var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {

    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/admin/questions/GetAll",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "question", "width": "30%" },
            { "data": "option1", "width": "15%" },
            { "data": "option2", "width": "15%" },
            { "data": "option3", "width": "15%" },
            { "data": "option4", "width": "15%" },
            { "data": "answer", "width": "10%" },
            { "data": "category.category", "width": "10%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                                <a href="/Admin/questions/Upsert/${data}" class='btn btn-success text-white' style='cursor:pointer; width:100px;'>
                                    <i class='far fa-edit'></i> Edit
                                </a>
                                &nbsp;
                                <a onclick=Delete("/Admin/questions/Delete/${data}") class='btn btn-danger text-white' style='cursor:pointer; width:100px;'>
                                    <i class='far fa-trash-alt'></i> Delete
                                </a>
                            </div>
                            `;
                }, "width": "30%"
            }
        ],
        "language": {
            "emptyTable": "No records found."
        },
        "width": "100%"
    });
}

function Delete(url) {
    swal({
        title: "Are you sure you want to delete?",
        text: "You will not be able to restore the content!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Yes, delete it!",
        closeOnconfirm: true
    }, function () {
        $.ajax({
            type: 'DELETE',
            url: url,
            success: function (data) {
                if (data.success) {
                    toastr.success(data.message);
                    dataTable.ajax.reload();
                }
                else {
                    toastr.error(data.message);
                }
            }
        });
    });
}