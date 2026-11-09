# Fact c8322212

Store id: 637a44ba-381b-4f30-bdad-e8de16c8ca89

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
- posted_at: `2026-11-09T22:39:44.3026200+00:00`

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
  "id": "637a44ba-381b-4f30-bdad-e8de16c8ca89",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3026200+00:00"
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
  "subject_id": "c696c456-bbee-4f9d-a52d-f266108c7a56",
  "subject_name": "django/db/models/fields/related::RelatedField.cache_name",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def cache_name(self)"
}
```
