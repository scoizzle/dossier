# docs/ref/template-response

- Subject: docs/ref/template-response (id `d54b7aeb-61c6-40a4-b73d-97aaa67329f5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 21 of 85
- Conflicts: 0
- Gaps: 0

## Facts

- # Assigning content does change, no render() call required >>> t.content = t.rendered_content >>> print(t.content) New content [a257f3fc]
- # Re-rendering doesn't change content >>> t.template_name = "new.html" >>> t.render() >>> print(t.content) Original content [01d86ad4]
- # Set up a rendered TemplateResponse >>> from django.template.response import TemplateResponse >>> t = TemplateResponse(request, "original.html", {}) >>> t.render() >>> print(t.content) Original content [875ae432]
- A boolean indicating whether the response content has been rendered. [30e7cd21]
- Add a callback that will be invoked after rendering has taken place. This hook can be used to defer certain processing operations (such as caching) until after rendering has occurred. [49d8f6de]
- Example: ``['foo.html', 'path/to/bar.html']`` [360964eb]
- Example: ``{'foo': 123}`` [bd17af05]
- If the :class:`~django.template.response.SimpleTemplateResponse` has already been rendered, the callback will be invoked immediately. [d92519da]
- If the callback returns a value that is not ``None``, this will be used as the response instead of the original response object (and will be passed to the next post rendering callback etc.) [4f38e5c2]
- Instantiates a :class:`~django.template.response.SimpleTemplateResponse` object with the given template, context, content type, HTTP status, and charset. [cd29e7df]
- Override this method in order to customize template loading. [3ba636c8]
- Override this method in order to customize the context. [2e8f92c6]
- Preprocesses context data that will be used for rendering a template. Accepts a :class:`dict` of context data. By default, returns the same :class:`dict`. [d552c3ef]
- Resolves the template instance to use for rendering. Accepts a backend-dependent template object (such as those returned by :func:`~django.template.loader.get_template`), the name of a template, or a list of template names. [2c86dd16]
- Returns the backend-dependent template object instance to be rendered. [44918655]
- Sets ``response.content`` to the result obtained by :attr:`SimpleTemplateResponse.rendered_content`, runs all post-rendering callbacks, and returns the resulting response object. [c86f1729]
- The context data to be used when rendering the template. It must be a :class:`dict`. [be268336]
- The current rendered value of the response content, using the current template and context data. [bdb12898]
- The name of the template to be rendered. Accepts a backend-dependent template object (such as those returned by :func:`~django.template.loader.get_template`), the name of a template, or a list of template names. [f2a9dfbe]
- When called, callbacks will be passed a single argument -- the rendered :class:`~django.template.response.SimpleTemplateResponse` instance. [34977662]
- ``TemplateResponse`` is a subclass of :class:`~django.template.response.SimpleTemplateResponse` that knows about the current :class:`~django.http.HttpRequest`. [a2cd9ffb]

## Beyond the budget

55 more facts did not fit in the budget: [3286d326fe78ee1b] [1f2656517290407d] [7275f4d1c0f68aeb] [9df2acb40e4691bd] [065efea1] [dccf414a] [2f600077f2180b9f] [b7cc75c3c75f83d3] [60e85ba2b5411ec8] [88a2cf1e] [b0dab9fb] [7d5f58c6] [ac4cbee2e748370f] [db84992b] [3a0764aa] [b230c892] [0a0b5a13] [fa085a4b] [01806670] [1dcf176e] [02499ff5] [7ec2b636] [eaf050be34acb41d-582] [ec1f2ed5] [6d64f336] [57b5d622] [fd8fdcef] [4ae76b76] [b8c2beb6] [558dbbd3] [2a455d71] [0481c49d] [e282d0f3] [bb91fb20711fda29-8] [d83300b8] [033b4c87] [9a05ff6b] [d55ff75e] [4fe043c0] [db683de5] [d5edc39b] [d5882157dc780592-12] [d5882157dc780592-13] [88a89c1c] [238ee609] [093081dd] [eca74c95] [638223a9] [31bb6ed8] [62f6ebfc] [a2fad889] [2a568cef] [db5714bd] [1c03e1a4] [ab9ae75d]
