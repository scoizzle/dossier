# docs/ref/contrib/admin/javascript

- Subject: docs/ref/contrib/admin/javascript (id `e37bfeea-4014-4de3-8bcb-fd1ac5debd3b`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 766 tokens
- Facts shown: 18 of 18
- Conflicts: 0
- Gaps: 0

## Facts

- $(document).on('formset:added', (event, $row, formsetName) => { if (event.detail && event.detail.formsetName) { // Django >= 4.1 handleFormsetAdded(event.target, event.detail.formsetName) } else { // Django < 4.1, use $row and formsetName handleFormsetAdded($row.get(0), formsetName) } }) [5715e47f]
- document.addEventListener('formset:added', (event) => { if (event.detail.formsetName == 'author_set') { // Do something } }); document.addEventListener('formset:removed', (event) => { // Row removed }); [3b94c074]
- function handleFormsetAdded(row, formsetName) { // Do something } [a9ad7af7]
- {% block admin_change_form_document_ready %} {{ block.super }} <script src="{% static 'app/formset_handlers.js' %}"></script> {% endblock %} [990e97ea]
- {% extends 'admin/change_form.html' %} {% load static %} [0de6651b]
- * The JavaScript code must go in a template block if you are inheriting ``admin/change_form.html`` or it won't be rendered in the final HTML. * ``{{ block.super }}`` is added because Django's ``admin_change_form_document_ready`` block contains JavaScript code to handle various operations in the change form and we need that to be rendered too. [6cc714c2]
- .. _admin-javascript-inline-form-events: [0cdf1420]
- .. code-block:: html+django [685d15dfb6eb2285-62]
- .. code-block:: javascript [3f90e06ebee94674-5]
- .. code-block:: javascript :caption: ``app/static/app/formset_handlers.js`` [a59ba2f3]
- ====================================== JavaScript customizations in the admin ====================================== [a6eeef0d]
- If your event listener still has to support older versions of Django you have to use jQuery to register your event listener. jQuery handles JavaScript events but the reverse isn't true. [fd90f5aa]
- In your custom ``change_form.html`` template, extend the ``admin_change_form_document_ready`` block and add the event listener code: [652b971b]
- Inline form events ================== [f0ea1b6d]
- Supporting versions of Django older than 4.1 -------------------------------------------- [30d4bc2b]
- Two points to keep in mind: [a445e161]
- You could check for the presence of ``event.detail.formsetName`` and fall back to the old listener signature as follows: [cd9843ed]
- You may want to execute some JavaScript when an inline form is added or removed in the admin change form. The ``formset:added`` and ``formset:removed`` events allow this. ``event.detail.formsetName`` is the formset the row belongs to. For the ``formset:added`` event, ``event.target`` is the newly added row. [a6087066]
