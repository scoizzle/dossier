# Fact 03c53741

Store id: df253fc8-6b02-4c74-ab77-3ac3c6478b39

## Text

```text
def get_class_lookups(cls)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:functools.cache`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:56.6685500+00:00`

## Data

```json
{
  "end_line": 345,
  "entity_kind": "method",
  "parent": "RegisterLookupMixin",
  "start_line": 340,
  "symbol": "RegisterLookupMixin.get_class_lookups"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":340,"selector":"L340-L345","symbol":"RegisterLookupMixin.get_class_lookups"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::RegisterLookupMixin.get_class_lookups](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 345,
    "entity_kind": "method",
    "parent": "RegisterLookupMixin",
    "start_line": 340,
    "symbol": "RegisterLookupMixin.get_class_lookups"
  },
  "id": "df253fc8-6b02-4c74-ab77-3ac3c6478b39",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.6685500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 340,
        "selector": "L340-L345",
        "symbol": "RegisterLookupMixin.get_class_lookups"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "fe11b17d-d78e-4d06-904e-130541f0d01e",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin.get_class_lookups",
  "tags": [
    "entity:method",
    "decorator:functools.cache"
  ],
  "text": "def get_class_lookups(cls)"
}
```
