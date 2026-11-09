# docs/ref/class-based-views/generic-editing

- Subject: docs/ref/class-based-views/generic-editing (id `b9a99f6a-d1fa-4c26-9735-d174326014d9`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 20 of 109
- Conflicts: 0
- Gaps: 0

## Facts

- def form_valid(self, form): # This method is called when valid form data has been POSTed. # It should return an HttpResponse. form.send_email() return super().form_valid(form) [fe25abab]
- def get_absolute_url(self): return reverse("author-detail", kwargs={"pk": self.pk}) [68a8f952]
- def send_email(self): # send email using the self.cleaned_data dictionary pass [0197168a]
- <form method="post">{% csrf_token %} <p>Are you sure you want to delete "{{ object }}"?</p> {{ form }} <input type="submit" value="Confirm"> </form> [67a4669d]
- <form method="post">{% csrf_token %} {{ form.as_p }} <input type="submit" value="Save"> </form> [db6d5b2f]
- <form method="post">{% csrf_token %} {{ form.as_p }} <input type="submit" value="Send message"> </form> [bc06e3f6]
- <form method="post">{% csrf_token %} {{ form.as_p }} <input type="submit" value="Update"> </form> [37cb9088]
- By providing your own ``Form`` subclass, you can add additional requirements, such as a confirmation checkbox, for example. [bfe00089]
- Inherited from :class:`~django.views.generic.edit.BaseDeleteView`. The form class that will be used to confirm the request. By default :class:`django.forms.Form`, resulting in an empty form that is always valid. [c76afa40]
- Sets the current object instance (``self.object``) to ``None``. [95658cdbacab4a3c]
- Sets the current object instance (``self.object``). [3fb173e2d74c98e0]
- The ``CreateView`` page displayed to a ``GET`` request uses a ``template_name_suffix`` of ``'_form'``. For example, changing this attribute to ``'_create_form'`` for a view creating objects for the example ``Author`` model would cause the default ``template_name`` to be ``'myapp/author_create_form.html'``. [b46ff91c]
- The ``DeleteView`` page displayed to a ``GET`` request uses a ``template_name_suffix`` of ``'_confirm_delete'``. For example, changing this attribute to ``'_check_delete'`` for a view deleting objects for the example ``Author`` model would cause the default ``template_name`` to be ``'myapp/author_check_delete.html'``. [a44d4183]
- The ``UpdateView`` page displayed to a ``GET`` request uses a ``template_name_suffix`` of ``'_form'``. For example, changing this attribute to ``'_update_form'`` for a view updating objects for the example ``Author`` model would cause the default ``template_name`` to be ``'myapp/author_update_form.html'``. [fa5520f9]
- When using ``CreateView`` you have access to ``self.object``, which is the object being created. If the object hasn't been created yet, the value will be ``None``. [58475470]
- When using ``UpdateView`` you have access to ``self.object``, which is the object being updated. [b0933c1f]
- class Author(models.Model): name = models.CharField(max_length=200) [da8ea448]
- class AuthorCreateView(CreateView): model = Author fields = ["name"] [49906b58]
- class AuthorDeleteView(DeleteView): model = Author success_url = reverse_lazy("author-list") [d91baf12]
- from django import forms [9ee3a9405e27875c]

## Beyond the budget

68 more facts did not fit in the budget: [9275317c] [907e999a] [f2bc257f] [80b3b4640d5882cf-2] [3e32f49c] [698c78ea] [b69c2f45] [253dd0dd] [7c63e540] [5e5a87ad] [a67a0521] [364e31d7] [010055a8] [5a10f1dfc09c4903] [32590fb0e4b1f943-14] [32590fb0e4b1f943-15] [32590fb0e4b1f943-16] [32590fb0e4b1f943-17] [32590fb0e4b1f943-18] [32590fb0e4b1f943-19] [32590fb0e4b1f943-20] [32590fb0e4b1f943-21] [37f612b97e1bc71b-3] [37f612b97e1bc71b-4] [37f612b97e1bc71b-5] [ca7afe11] [391a4b6d] [bc858a29] [d500e7d3] [05e908cc] [c53bd2bbe44e70a1-7] [7407ef7dca9e98ce-21] [7407ef7dca9e98ce-22] [c1c3dd7a88acbfd9] [566bf7cac451caf9] [566bf7cac451caf9-2] [d458942f800a329c] [685d15dfb6eb2285-53] [3c13e900595e87cf-3] [cc72feb621724713] [ba77f847] [301ecc09] [76abfde2] [630da269] [097cbac6] [a515f714] [61abb517] [8bd87de9] [f7e0fe71] [4d2547a9] [470bc2847d96bfb8-6] [e6ab992d] [501914db] [24ddaf32] [31acfd5e] [4279c236] [73acc436] [383114bf] [02b6654b] [4124dc4d] [942ae6c11625c81c-26] [6b4a5e54e001d097-17] [e4d84589] [97a7ac89] [6d0ef329] [29e53225] [5010a877] [825cccef]
