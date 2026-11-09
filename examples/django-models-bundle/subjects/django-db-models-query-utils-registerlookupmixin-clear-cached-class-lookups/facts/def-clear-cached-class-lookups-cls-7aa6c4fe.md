# Fact 7aa6c4fe

Store id: a2a4e940-1c44-4e47-ae36-d0005d4986bd

## Text

```text
def _clear_cached_class_lookups(cls)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:56.6914150+00:00`

## Data

```json
{
  "end_line": 391,
  "entity_kind": "class_method",
  "parent": "RegisterLookupMixin",
  "start_line": 388,
  "symbol": "RegisterLookupMixin._clear_cached_class_lookups"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":388,"selector":"L388-L391","symbol":"RegisterLookupMixin._clear_cached_class_lookups"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::RegisterLookupMixin._clear_cached_class_lookups](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 391,
    "entity_kind": "class_method",
    "parent": "RegisterLookupMixin",
    "start_line": 388,
    "symbol": "RegisterLookupMixin._clear_cached_class_lookups"
  },
  "id": "a2a4e940-1c44-4e47-ae36-d0005d4986bd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.6914150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 388,
        "selector": "L388-L391",
        "symbol": "RegisterLookupMixin._clear_cached_class_lookups"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "e70e8de1-f9b1-4774-be03-4dcee5eb60bc",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin._clear_cached_class_lookups",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _clear_cached_class_lookups(cls)"
}
```
