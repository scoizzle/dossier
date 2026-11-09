# django/contrib/admin/actions

- Subject: django/contrib/admin/actions (id `26ec479a-b04a-44c9-acc8-20c0a12bff28`)
- Kind: subject
- Budget: 1200 tokens
- Used: 815 tokens
- Facts shown: 12 of 12
- Conflicts: 0
- Gaps: 0

## Facts

- # Display the confirmation page return TemplateResponse( request, modeladmin.delete_selected_confirmation_template or [ "admin/%s/%s/delete_selected_confirmation.html" % (app_label, opts.model_name), "admin/%s/delete_selected_confirmation.html" % app_label, "admin/delete_selected_confirmation.html", ], context, ) [2c996602]
- # Populate deletable_objects, a data structure of all related objects that # will also be deleted. ( deletable_objects, model_count, perms_needed, protected, ) = modeladmin.get_deleted_objects(queryset, request) [854740ee]
- # The user has already confirmed the deletion. # Do the deletion and return None to display the change list view again. if request.POST.get("post") and not protected: if perms_needed: raise PermissionDenied n = len(queryset) if n: modeladmin.log_deletions(request, queryset) modeladmin.delete_queryset(request, queryset) modeladmin.message_user( request, _("Successfully deleted %(count)d %(items)s.") % {"count": n, "items": model_ngettext(modeladmin.opts, n)}, messages.SUCCESS, ) # Return None to display the change list page again. return None [d72fe692]
- Next, it deletes all selected objects and redirects back to the change list. """ opts = modeladmin.model._meta app_label = opts.app_label [31c9b9c3]
- This action first displays a confirmation page which shows all the deletable objects, or, if the user has no permission one of the related children (foreignkeys), a "permission denied" message. [bcb4f091]
- context = { **modeladmin.admin_site.each_context(request), "title": title, "subtitle": None, "objects_name": str(objects_name), "deletable_objects": [deletable_objects], "delete_confirmation_max_display": modeladmin.delete_confirmation_max_display, "model_count": dict(model_count).items(), "queryset": queryset, "perms_lacking": perms_needed, "protected": protected, "opts": opts, "action_checkbox_name": helpers.ACTION_CHECKBOX_NAME, "media": modeladmin.media, } [79429079]
- if perms_needed or protected: title = _("Cannot delete %(name)s") % {"name": objects_name} else: title = _("Delete multiple objects") [cb7f8fd5]
- objects_name = model_ngettext(queryset) [8c5d6c21]
- request.current_app = modeladmin.admin_site.name [704f4cad]
- """ Built-in, globally-available admin actions. """ [8757ee02]
- @action( permissions=["delete"], description=gettext_lazy("Delete selected %(verbose_name_plural)s"), ) def delete_selected(modeladmin, request, queryset): """ Default action which deletes the selected objects. [2d01284c]
- from django.contrib import messages from django.contrib.admin import helpers from django.contrib.admin.decorators import action from django.contrib.admin.utils import model_ngettext from django.core.exceptions import PermissionDenied from django.template.response import TemplateResponse from django.utils.translation import gettext as _ from django.utils.translation import gettext_lazy [2de33204]
