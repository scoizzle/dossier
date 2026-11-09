# Fact d326996e

Store id: 879b156a-2452-49ae-b911-9247fbc21577

## Text

```text
class BitAnd(BitAggregate)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.3998310+00:00`

## Data

```json
{
  "end_line": 282,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 280,
  "symbol": "BitAnd"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":280,"selector":"L280-L282","symbol":"BitAnd"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::BitAnd](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 282,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 280,
    "symbol": "BitAnd"
  },
  "id": "879b156a-2452-49ae-b911-9247fbc21577",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3998310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 280,
        "selector": "L280-L282",
        "symbol": "BitAnd"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "864f8369-167e-441d-955c-bd95807de327",
  "subject_name": "django/db/models/aggregates::BitAnd",
  "tags": [
    "entity:class"
  ],
  "text": "class BitAnd(BitAggregate)"
}
```
