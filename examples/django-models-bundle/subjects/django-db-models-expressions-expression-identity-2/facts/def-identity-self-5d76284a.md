# Fact 5d76284a

Store id: 4dc8902d-0d12-4201-9a21-65c973558720

## Text

```text
def identity(self)
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
- posted_at: `2026-11-09T22:39:41.5382670+00:00`

## Data

```json
{
  "end_line": 554,
  "entity_kind": "method",
  "parent": "Expression",
  "start_line": 540,
  "symbol": "Expression.identity"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":540,"selector":"L540-L554","symbol":"Expression.identity"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Expression.identity](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 554,
    "entity_kind": "method",
    "parent": "Expression",
    "start_line": 540,
    "symbol": "Expression.identity"
  },
  "id": "4dc8902d-0d12-4201-9a21-65c973558720",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5382670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 540,
        "selector": "L540-L554",
        "symbol": "Expression.identity"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "baa38849-9814-45be-968b-550b3fb946d2",
  "subject_name": "django/db/models/expressions::Expression.identity",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def identity(self)"
}
```
