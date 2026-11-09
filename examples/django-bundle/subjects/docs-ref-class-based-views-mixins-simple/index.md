# docs/ref/class-based-views/mixins-simple

- Subject: docs/ref/class-based-views/mixins-simple (id `74305f14-3fed-4f25-b2b7-cc2082b0fb00`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 21 of 36
- Conflicts: 0
- Gaps: 0

## Facts

- Note that having the view instance in the template context may expose potentially hazardous methods to template authors. To prevent methods like this from being called in the template, set ``alters_data=True`` on those methods. For more information, read the documentation on :ref:`rendering a template context <alters-data-description>`. [9658d96b]
- TemplateView.as_view(extra_context={"title": "Custom Title"}) [0f2fc964]
- def get_context_data(self, **kwargs): context = super().get_context_data(**kwargs) context["number"] = random.randrange(1, 100) return context [b2e512f9]
- from django.views.generic import TemplateView [6744a9a0]
- .. admonition:: Use ``alters_data`` where appropriate [89656354]
- A dictionary to include in the context. This is a convenient way of specifying some context in :meth:`~django.views.generic.base.View.as_view`. Example usage:: [115bf753]
- Calls :meth:`get_template_names` to obtain the list of template names that will be searched looking for an existent template. [e9479cd9]
- If any keyword arguments are provided, they will be passed to the constructor of the response class. [5e849cd9]
- If you need custom template loading or custom context object instantiation, create a ``TemplateResponse`` subclass and assign it to ``response_class``. [58fea042]
- Returns a ``self.response_class`` instance. [6fd01110]
- Returns a dictionary representing the template context. The keyword arguments provided will make up the returned context. Example usage:: [ed945027]
- Returns a list of template names to search for when rendering the template. The first template that is found will be used. [f12da7a4]
- The :setting:`NAME <TEMPLATES-NAME>` of a template engine to use for loading the template. ``template_engine`` is passed as the ``using`` keyword argument to ``response_class``. Default is ``None``, which tells Django to search for the template in all configured engines. [3b161a29]
- The content type to use for the response. ``content_type`` is passed as a keyword argument to ``response_class``. Default is ``None`` -- meaning that Django uses ``'text/html'``. [195ff613]
- The default implementation will return a list containing :attr:`template_name` (if it is specified). [fe5b4a72]
- The full name of a template to use as defined by a string. Not defining a ``template_name`` will raise a :class:`django.core.exceptions.ImproperlyConfigured` exception. [2b618967]
- The response class to be returned by ``render_to_response`` method. Default is :class:`TemplateResponse <django.template.response.TemplateResponse>`. The template and context of ``TemplateResponse`` instances can be altered later (e.g. in :ref:`template response middleware <template-response-middleware>`). [95e8ce8e]
- The template context of all class-based generic views include a ``view`` variable that points to the ``View`` instance. [447402df]
- **Attributes** [37f612b97e1bc71b-6]
- **Attributes** [37f612b97e1bc71b-7]
- **Methods** [7407ef7dca9e98ce-23]

## Beyond the budget

15 more facts did not fit in the budget: [7407ef7dca9e98ce-24] [6e5bab06425e4544] [c14425e2] [e56dd2bb] [82d228a6] [47ff310de933b083] [0e06ba1d6d133a88-3] [68e197214557455a-2] [168b9fd3] [9ff2c543] [da506e49] [6833ddd2] [d4b6f97e] [7ebe4ced] [a639e331]
