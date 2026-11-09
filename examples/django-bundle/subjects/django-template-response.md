# django/template/response

- Subject: django/template/response (id `f2ffea07-2ee4-403d-b62e-7e53981963b5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 16 of 27
- Conflicts: 0
- Gaps: 0

## Facts

- # _is_rendered tracks whether the template and context has been baked # into a final response. # Super __init__ doesn't know any better than to set self.content to # the empty string we just gave it, which wrongly sets _is_rendered # True, so we initialize it to False after the call to super __init__. self._is_rendered = False [83ff507c]
- # _request stores the current request object in subclasses that know # about requests, like TemplateResponse. It's defined in the base class # to minimize code duplication. # It's called self._request because self.request gets overwritten by # django.test.client.Client. Unlike template_name and context_data, # _request should not be considered part of the public API. self._request = None [e21772dd]
- # content argument doesn't make sense here because it will be replaced # with rendered template so we always pass empty string in order to # prevent errors and provide shorter signature. super().__init__("", content_type, status, charset=charset, headers=headers) [75929873]
- If the content has already been rendered, this is a no-op. [542a5c50]
- If the response has already been rendered, invoke the callback immediately. """ if self._is_rendered: callback(self) else: self._post_render_callbacks.append(callback) [d7228cbe]
- Return the baked response instance. """ retval = self if not self._is_rendered: self.content = self.rendered_content for post_callback in self._post_render_callbacks: newretval = post_callback(retval) if newretval is not None: retval = newretval return retval [e8f27081]
- This *does not* set the final content of the response. To set the response content, you must either call render(), or set the content explicitly using the value of this property. """ template = self.resolve_template(self.template_name) context = self.resolve_context(self.context_data) return template.render(context, self._request) [41448d4b]
- return obj_dict [3109dba6]
- self._post_render_callbacks = [] [78012358]
- self.using = using [a9325871]
- @content.setter def content(self, value): """Set the content for the response.""" HttpResponse.content.fset(self, value) self._is_rendered = True [a54a1a14]
- @property def content(self): if not self._is_rendered: raise ContentNotRenderedError( "The response content must be rendered before it can be accessed." ) return super().content [3323d52d]
- @property def is_rendered(self): return self._is_rendered [cc76a0cb]
- @property def rendered_content(self): """Return the freshly rendered content for the template and context described by the TemplateResponse. [afcfd8b8]
- def __getstate__(self): """ Raise an exception if trying to pickle an unrendered response. Pickle only rendered data, not the data used to construct the response. """ obj_dict = self.__dict__.copy() if not self._is_rendered: raise ContentNotRenderedError( "The response content must be rendered before it can be pickled." ) for attr in self.rendering_attrs: if attr in obj_dict: del obj_dict[attr] [e59523ad]
- def add_post_render_callback(self, callback): """Add a new post-rendering callback. [e1738b43]

## Beyond the budget

11 more facts did not fit in the budget: [3aead48e] [73c8ced1] [d4333fe7] [994a5aa8] [e17769b8] [21907eef] [30caee79] [b35166de] [d6590bde] [5c917ea4] [a4bde282]
