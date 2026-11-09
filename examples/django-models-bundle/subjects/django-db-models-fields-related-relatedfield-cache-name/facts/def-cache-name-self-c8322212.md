# Fact c8322212

Store id: ad805559-3c0c-46f9-bac1-f953d11687a5

## Text

```text
def cache_name(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:51.5087490+00:00`

## Data

```json
{
  "end_line": 541,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 539,
  "symbol": "RelatedField.cache_name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":539,"selector":"L539-L541","symbol":"RelatedField.cache_name"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.cache_name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 541,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 539,
    "symbol": "RelatedField.cache_name"
  },
  "id": "ad805559-3c0c-46f9-bac1-f953d11687a5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5087490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 539,
        "selector": "L539-L541",
        "symbol": "RelatedField.cache_name"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "51047ca3-77ce-4e8d-9ea1-0aa23e957999",
  "subject_name": "django/db/models/fields/related::RelatedField.cache_name",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def cache_name(self)"
}
```
