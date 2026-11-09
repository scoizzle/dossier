# docs/intro/tutorial03

- Subject: docs/intro/tutorial03 (id `991df3df-3e74-43c2-9ad8-0ac2595ff08c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 16 of 129
- Conflicts: 0
- Gaps: 0

## Facts

- # ... def detail(request, question_id): question = get_object_or_404(Question, pk=question_id) return render(request, "polls/detail.html", {"question": question}) [c87332c1]
- # ... def detail(request, question_id): try: question = Question.objects.get(pk=question_id) except Question.DoesNotExist: raise Http404("Question does not exist") return render(request, "polls/detail.html", {"question": question}) [e2ea93ff]
- # Leave the rest of the views (detail, results, vote) unchanged [42842fa3]
- ... # added the word 'specifics' path("specifics/<int:question_id>/", views.detail, name="detail"), ... [fcfd0c0c]
- ... # the 'name' value as called by the {% url %} template tag path("<int:question_id>/", views.detail, name="detail"), ... [e2579a8c]
- <h1>{{ question.question_text }}</h1> <ul> {% for choice in question.choice_set.all %} <li>{{ choice.choice_text }}</li> {% endfor %} </ul> [1117b076]
- <li><a href="/polls/{{ question.id }}/">{{ question.question_text }}</a></li> [76d37ba5]
- <li><a href="{% url 'detail' question.id %}">{{ question.question_text }}</a></li> [d1381f60c6feec3e]
- Because that would couple the model layer to the view layer. One of the foremost design goals of Django is to maintain loose coupling. Some controlled coupling is introduced in the :mod:`django.shortcuts` module. [e714c5e2]
- If you're having trouble going through this tutorial, please head over to the :doc:`Getting Help</faq/help>` section of the FAQ. [eff105796d7d4d6a-3]
- Now we *might* be able to get away with putting our templates directly in ``polls/templates`` (rather than creating another ``polls`` subdirectory), but it would actually be a bad idea. Django will choose the first template it finds whose name matches, and if you had a template with the same name in a *different* application, Django would be unable to distinguish between them. We need to be able to point Django at the right one, and the best way to ensure this is by *namespacing* them. That is, by putting those templates inside *another* directory named for the application itself. [72ef00b6]
- To make the tutorial shorter, all template examples use incomplete HTML. In your own projects you should use `complete HTML documents`__. [1a90ec42]
- Why do we use a helper function :func:`~django.shortcuts.get_object_or_404` instead of automatically catching the :exc:`~django.core.exceptions.ObjectDoesNotExist` exceptions at a higher level, or having the model API raise :exc:`~django.http.Http404` instead of :exc:`~django.core.exceptions.ObjectDoesNotExist`? [3cd86f4c]
- app_name = "polls" urlpatterns = [ path("", views.index, name="index"), path("<int:question_id>/", views.detail, name="detail"), path("<int:question_id>/results/", views.results, name="results"), path("<int:question_id>/vote/", views.vote, name="vote"), ] [74d47d17]
- def detail(request, question_id): return HttpResponse("You're looking at question %s." % question_id) [7518eead]
- def index(request): latest_question_list = Question.objects.order_by("-pub_date")[:5] output = ", ".join([q.question_text for q in latest_question_list]) return HttpResponse(output) [b9d06d6b]

## Beyond the budget

96 more facts did not fit in the budget: [440670ec] [c704759c] [df81238d] [c25305d8] [9e49b008] [c00926fe3424edad-3] [c00926fe3424edad-4] [df692aec3f5cbbed-2] [6b52c258] [c672e2c6d47dd35c-2] [c5bda1b341cf97d4-2] [02eea688fdf57895] [f3bb80f2b2fd7f5d-3] [c537d1941a7e3025-3] [cd9175d1] [7a8f81fd] [c344d94b] [489a6683] [5c804fa7] [226f123c] [35c6aba1] [40ea7022] [e5e71672] [fc47f8b2] [2a8d4248] [59c9e7bf] [928b6cb1] [50bed6e0d454902f-4] [2dea0dea] [dbb2ef17dd903b2b-4] [685d15dfb6eb2285-42] [5a286ce802025afd] [a8588014402a8293] [eaf050be34acb41d-9] [5c9a4d2d821e33d5-2] [d59bf1960628576c-2] [942ae6c11625c81c-21] [4c9112b7] [34dbed0f] [d22e2fcb] [7234ad00] [07d29481] [2d16583a] [392a4273] [2e4b6e9e] [19f9a766] [860a6cab] [69e6a432] [d6c90bce] [c060b686] [ed779427] [c5baac50] [d122eb76] [2427e12a] [b14eefd5] [29490055] [a49d3001] [bddf656f] [e29d814d] [3853a249] [c6960d6b] [75696e16fcbb84ec-2] [1464c470] [251274ed] [fd4bf586] [17a9fefc] [2656c32a] [6410c898] [24c694e4] [dbd13b7f] [cadc0e1b] [5bf6cabb] [0411c2d8] [a7f4eff8] [940606f3] [01cb2323] [02702943] [a1040027] [a1a3c8b2] [4a67dd0f] [641eac89] [ded25a55] [a8a0686a] [31c97ea5] [f0b83ffb] [b7a218d9] [b8566d51] [ce790fe5] [1e184b67] [2e2e3e5a] [51484a25] [803e6e13] [fe3c6bf7] [2253d95d] [d8ac28e1] [e380af84]
