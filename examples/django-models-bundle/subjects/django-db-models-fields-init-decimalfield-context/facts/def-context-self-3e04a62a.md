# Fact 3e04a62a

Store id: b49bcc24-8a6f-40dc-aa7f-78fc007e3eba

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
- posted_at: `2026-11-09T22:39:42.4560110+00:00`

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
  "id": "b49bcc24-8a6f-40dc-aa7f-78fc007e3eba",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4560110+00:00"
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
  "subject_id": "20e5082b-fdfe-436a-84e7-4c0c62a6fcd0",
  "subject_name": "django/db/models/fields/__init__::DecimalField.context",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def context(self)"
}
```
