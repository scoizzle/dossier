# docs/internals/security

- Subject: docs/internals/security (id `f4314cac-b097-4e5f-85f6-251e1084bd81`)
- Kind: subject
- Budget: 1200 tokens
- Used: 892 tokens
- Facts shown: 20 of 152
- Conflicts: 0
- Gaps: 0

## Facts

- A failure to provide the required information in your initial contact will count against you when making the decision on whether or not to approve your request. [be3b0a81]
- As a policy, we do not add these types of entities to the notification list. [a77dddad]
- Django's built-in development server does not enforce these limits because it is not designed to be a production server. [e8c58590]
- If you want to send an encrypted email (*optional*), the public key ID for ``security@djangoproject.com`` is ``0xfcb84b8d1d17f80b``, and this public key is available from most commonly-used keyservers. [9b3ccc9c]
- class EmailForm(forms.Form): email = forms.EmailField() [a06f3660]
- def my_proof_of_concept(request): email = request.GET.get("email", "") send_mail("Email subject", "Email body", email, ["admin@example.com"]) return JsonResponse(status=200) [5d6eab96]
- def my_proof_of_concept(request): form = EmailForm(request.GET) if form.is_valid(): send_mail( "Email subject", "Email body", form.cleaned_data["email"], ["admin@example.com"], ) return JsonResponse(status=200) return JsonResponse(form.errors, status=400) [235c7d55]
- def my_proof_of_concept(request): query = request.GET.get("query", "") q = MyModel.objects.extra(select={"id": query}) return HttpResponse(q.values()) [66d2c090]
- from django import forms from django.core.mail import send_mail from django.http import JsonResponse [92801f7d]
- from django.shortcuts import HttpResponse from .models import MyModel [dfbadb70]
- * Cross site scripting (XSS) * Cross site request forgery (CSRF) * Broken authentication [c050242a]
- * Denial-of-service attacks * Sensitive data exposure * Broken session management * Unvalidated redirects/forwards * Issues requiring an uncommon configuration option [06ad5ca0]
- * Exploits that only affect local development, for example when using :djadmin:`runserver`. * Exploits which fail to follow security best practices, such as failure to sanitize user input. For other examples, see our :ref:`security documentation <cross-site-scripting>`. * Exploits in AI generated code that do not adhere to security best practices. [65279bc4]
- * Remote code execution * SQL injection [94b955a8]
- #. Apply the relevant patch(es) to Django's codebase. [8a481d40]
- #. Issue the relevant release(s), by placing new packages on the :pypi:`Python Package Index <Django>` and on the `djangoproject.com website <https://www.djangoproject.com/download/>`_, and tagging the new release(s) in Django's git repository. [6b5f1a16]
- #. Post a notice to the |django-announce| and oss-security@lists.openwall.com mailing lists that links to the blog post. [7e495a23]
- #. Post a public entry on `the official Django development blog`_, describing the issue and its resolution in detail, pointing to the relevant patches and new releases, and crediting the reporter of the issue (if the reporter wishes to be publicly identified). [34425afc]
- * **High** [fdc669e4]
- * **Low** [ad04f6fb]

## Beyond the budget

131 more facts did not fit in the budget: [e3bf64fa] [12a5d7cd] [8abde078] [e6d6ea19] [e69300bf] [232f8514] [e95ace55] [ea2a866c] [22dfddf1] [e8f7f088] [4a8f0d72] [63b9d338] [8301f97d] [ebac8cb9] [a08ca336] [7b542a05] [814c1764] [3a0210e3] [a3b97c82] [bbd9f1fd] [993a66ed] [0d775eb8] [e763de36] [6da08bb9] [c9bc9c6b] [4466b894] [9c218913] [58d662cc] [6e576405] [f9d5eaca] [8ec660ba] [0921bd00] [d7608f37] [e7a2e412] [7372f9dd] [dc6701eb] [e7cd70be] [fa50e512] [5f6fc8b2] [bf45b02c] [822f2e0c] [cfbe679b] [136ae960] [a2e22527] [5b658ca2] [45f9a281] [54b1ff6e] [98155d61] [ac797b85] [2e1a8219] [db4ebc1d] [09fca64c] [c461c0b7] [296ccf64] [9bc23f88] [d18eab18] [36731d91] [938aed9a] [c9301995] [63915a3a] [c61c26fa] [c02f0bca] [1160bab3] [d87ad479] [26cc9af7] [b6c700d4] [5bd291dd] [f7a26406] [bb478362] [3dc1a70e] [bbf18d28] [7da4b94b] [74e1fb63] [c1c13e92] [97b5fa50] [803d2d2f] [69044274] [d96456b5] [80b81ecf] [b4a06ae4] [27a7ebd8] [bb62eea1] [1c315506] [a71abf79] [c414205d] [8733ac3b] [f2bed6c2a49a4853-2] [6be7a0f5] [70983592] [4244da5e] [47d03cee] [eda912c9] [98466f7e] [3c123526] [d5f40a8d] [48369a09] [f512d04c] [4dd53868] [44c8d98d] [6589df06] [1cc63f4c] [d6fcc31f] [7b961b43] [05a32fb7] [6682651f] [662283bb] [bbbd2366] [10730a2c] [8e0bc1df] [c6494c2a] [4982c6af531ad1e9-2] [789988ec] [047351e1] [7f8fe4ab] [2a63cfba] [7a3bbfda] [f411ae8d] [ff94157a] [e6eacb57] [f13cd9a8] [1941488f] [b48acbdb] [6718d3ec] [d81c3a59] [7aa36efb] [9de36ef3] [cc4e868f] [00c52c83] [ee12493a] [3d7426c9] [f094a33d]
