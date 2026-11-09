# django/contrib/flatpages/forms

- Subject: django/contrib/flatpages/forms (id `577cee4c-723e-46c2-a0c9-0b7dd3396aee`)
- Kind: subject
- Budget: 1200 tokens
- Used: 569 tokens
- Facts shown: 10 of 10
- Conflicts: 0
- Gaps: 0

## Facts

- if sites and same_url.filter(sites__in=sites).exists(): for site in sites: if same_url.filter(sites=site).exists(): raise ValidationError( _("Flatpage with url %(url)s already exists for site %(site)s"), code="duplicate_url", params={"url": url, "site": site}, ) [893c0825]
- return super().clean() [ff8e16d8]
- same_url = FlatPage.objects.filter(url=url) if self.instance.pk: same_url = same_url.exclude(pk=self.instance.pk) [16bcdbd3]
- class Meta: model = FlatPage fields = "__all__" [d412fb12]
- def __init__(self, *args, **kwargs): super().__init__(*args, **kwargs) if not self._trailing_slash_required(): self.fields["url"].help_text = _( "Example: “/about/contact”. Make sure to have a leading slash." ) [aa691568]
- def _trailing_slash_required(self): return ( settings.APPEND_SLASH and "django.middleware.common.CommonMiddleware" in settings.MIDDLEWARE ) [abed294a]
- def clean(self): url = self.cleaned_data.get("url") sites = self.cleaned_data.get("sites") [1e5b3791]
- def clean_url(self): url = self.cleaned_data["url"] if not url.startswith("/"): raise ValidationError( gettext("URL is missing a leading slash."), code="missing_leading_slash", ) if self._trailing_slash_required() and not url.endswith("/"): raise ValidationError( gettext("URL is missing a trailing slash."), code="missing_trailing_slash", ) return url [61b45838]
- class FlatpageForm(forms.ModelForm): url = forms.RegexField( label=_("URL"), max_length=100, regex=r"^[-\w/.~]+$", help_text=_( "Example: “/about/contact/”. Make sure to have leading and trailing " "slashes." ), error_messages={ "invalid": _( "This value must contain only letters, numbers, dots, " "underscores, dashes, slashes or tildes." ), }, ) [470891fd]
- from django import forms from django.conf import settings from django.contrib.flatpages.models import FlatPage from django.core.exceptions import ValidationError from django.utils.translation import gettext from django.utils.translation import gettext_lazy as _ [ae405cc2]
