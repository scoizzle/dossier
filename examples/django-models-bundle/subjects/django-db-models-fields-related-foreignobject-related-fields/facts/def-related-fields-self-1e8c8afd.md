# Fact 1e8c8afd

Store id: 67aee408-54ee-44a4-9565-e04a3badee95

## Text

```text
def related_fields(self)
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
- posted_at: `2026-11-09T22:39:44.3245820+00:00`

## Data

```json
{
  "end_line": 808,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 806,
  "symbol": "ForeignObject.related_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":806,"selector":"L806-L808","symbol":"ForeignObject.related_fields"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.related_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 808,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 806,
    "symbol": "ForeignObject.related_fields"
  },
  "id": "67aee408-54ee-44a4-9565-e04a3badee95",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3245820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 806,
        "selector": "L806-L808",
        "symbol": "ForeignObject.related_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "d0170b28-7065-4b51-b566-fd019db237d2",
  "subject_name": "django/db/models/fields/related::ForeignObject.related_fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def related_fields(self)"
}
```
