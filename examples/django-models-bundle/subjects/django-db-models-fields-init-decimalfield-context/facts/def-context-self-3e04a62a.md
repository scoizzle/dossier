# Fact 3e04a62a

Store id: 6892513f-f8db-400f-bc58-94b28829b65e

## Text

```text
def context(self)
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
- posted_at: `2026-11-09T23:44:50.1186610+00:00`

## Data

```json
{
  "end_line": 1880,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1878,
  "symbol": "DecimalField.context"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1878,"selector":"L1878-L1880","symbol":"DecimalField.context"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField.context](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1880,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1878,
    "symbol": "DecimalField.context"
  },
  "id": "6892513f-f8db-400f-bc58-94b28829b65e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1186610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1878,
        "selector": "L1878-L1880",
        "symbol": "DecimalField.context"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "14544b7f-3ab0-410e-a4a6-554566060863",
  "subject_name": "django/db/models/fields/__init__::DecimalField.context",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def context(self)"
}
```
