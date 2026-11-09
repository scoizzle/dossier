# docs/ref/class-based-views/mixins-editing

- Subject: docs/ref/class-based-views/mixins-editing (id `9cd1709d-0eaf-4489-867e-79a5b00d3281`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 21 of 89
- Conflicts: 0
- Gaps: 0

## Facts

- A dictionary containing initial data for the form. [367b9adf]
- A list of names of fields. This is interpreted the same way as the ``Meta.fields`` attribute of :class:`~django.forms.ModelForm`. [12dcf2c7]
- A model class. Can be explicitly provided, otherwise will be determined by examining ``self.object`` or :attr:`~django.views.generic.detail.SingleObjectMixin.queryset`. [837c2575]
- Add the current instance (``self.object``) to the standard :meth:`~django.views.generic.edit.FormMixin.get_form_kwargs`. [7c921b54]
- Build the keyword arguments required to instantiate the form. [3577dd72]
- Calls :meth:`get_form` and adds the result to the context data with the name 'form'. [4495aa13]
- Constructs a form, checks the form for validity, and handles it accordingly. [5afdc98a]
- Determine the :attr:`~django.forms.Form.prefix` for the generated form. Returns :attr:`~django.views.generic.edit.FormMixin.prefix` by default. [cdec22ae]
- Determine the URL to redirect to when the form is successfully validated. Returns :attr:`django.views.generic.edit.ModelFormMixin.success_url` if it is provided; otherwise, attempts to use the ``get_absolute_url()`` of the object. [f46a3f2c]
- Determine the URL to redirect to when the form is successfully validated. Returns :attr:`~django.views.generic.edit.FormMixin.success_url` by default. [520b6671]
- Instantiate an instance of ``form_class`` using :meth:`~django.views.generic.edit.FormMixin.get_form_kwargs`. If ``form_class`` isn't provided :meth:`get_form_class` will be used. [ecef62ea]
- Redirects to :meth:`~django.views.generic.edit.FormMixin.get_success_url`. [e46c2aa1]
- Renders a response using a context created with :meth:`~django.views.generic.edit.FormMixin.get_context_data`. [17f011d3]
- Renders a response, providing the invalid form as context. [2437115d6439d353]
- Retrieve initial data for the form. By default, returns a copy of :attr:`~django.views.generic.edit.FormMixin.initial`. [746c6bc5]
- Retrieve the form class to instantiate. By default :attr:`~django.views.generic.edit.FormMixin.form_class`. [dd71a80b]
- Retrieve the form class to instantiate. If :attr:`~django.views.generic.edit.FormMixin.form_class` is provided, that class will be used. Otherwise, a ``ModelForm`` will be instantiated using the model associated with the :attr:`~django.views.generic.detail.SingleObjectMixin.queryset`, or with the :attr:`~django.views.generic.detail.SingleObjectMixin.model`, depending on which attribute is provided. [c43f962c]
- Retrieves the target object and calls its ``delete()`` method, then redirects to the success URL. [474f1446]
- Returns the url to redirect to when the nominated object has been successfully deleted. Returns :attr:`~django.views.generic.edit.DeletionMixin.success_url` by default. [3871c791]
- Saves the form instance, sets the current object for the view, and redirects to :meth:`~django.views.generic.edit.FormMixin.get_success_url`. [be64dfdf]
- **Extends** [f3c346391998d9e9]

## Beyond the budget

61 more facts did not fit in the budget: [42e9e7f4] [a04ae0aec67217fe] [a3b1e058] [2d8fdae1] [fbc0cda8] [77ac1e34] [19af86eb] [83b55070] [e230f903] [f9349e9ad1d5a49b] [b7741a2ef07f59a9-2] [4b3897c8] [83eda2cf63eef8ea-7] [83eda2cf63eef8ea-8] [83eda2cf63eef8ea-9] [83eda2cf63eef8ea-10] [77f7bed952734363-2] [77f7bed952734363-3] [4594547e83cf579d] [c1c3dd7a88acbfd9-2] [efc99b2f] [a598e6014e379321] [c8555890] [d948684d623396b8] [d948684d623396b8-2] [d948684d623396b8-3] [5b217977] [70328cbf1afacfb2] [70328cbf1afacfb2-2] [a8aff823457fbc46] [a8aff823457fbc46-2] [3c13e900595e87cf-5] [0e06ba1d6d133a88] [e62d2bac] [49f66c59b0adc462] [ece6b9e38d9cdfad] [8eb92c30] [1d04127c] [f18c4be0de7a5b22] [cc72feb621724713-3] [099bc8a8] [942ae6c11625c81c-28] [a292278a] [7ff2678e] [36b0f6b4] [ade185f8] [79f1a1e5] [15fbb44b] [e6126e42] [8620ca8f] [7c720ba4] [84c731b2] [498c5f59] [c0ece66d] [942ae6c11625c81c-29] [e3c97d2c] [9cf4e64e] [5d8af19e] [25f815d4] [bf61bfec] [8a19b7ee]
