# Fact 886b048a

Store id: 6273b8f6-03c5-4c6f-97b2-ded0e8ae3b41

## Text

```text
class IntegerFieldExact(IntegerFieldOverflow, Exact)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:IntegerField.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.1373130+00:00`

## Data

```json
{
  "end_line": 477,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 475,
  "symbol": "IntegerFieldExact"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":475,"selector":"L475-L477","symbol":"IntegerFieldExact"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IntegerFieldExact](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 477,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 475,
    "symbol": "IntegerFieldExact"
  },
  "id": "6273b8f6-03c5-4c6f-97b2-ded0e8ae3b41",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1373130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 475,
        "selector": "L475-L477",
        "symbol": "IntegerFieldExact"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "06d4b457-6acd-4839-8bcc-3f4087965c92",
  "subject_name": "django/db/models/lookups::IntegerFieldExact",
  "tags": [
    "entity:class",
    "decorator:IntegerField.register_lookup"
  ],
  "text": "class IntegerFieldExact(IntegerFieldOverflow, Exact)"
}
```
