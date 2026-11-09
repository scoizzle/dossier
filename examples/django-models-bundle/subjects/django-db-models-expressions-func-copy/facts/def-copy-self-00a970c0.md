# Fact 00a970c0

Store id: 7528a879-9cf9-499e-a23c-184be84c6637

## Text

```text
def copy(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.5816040+00:00`

## Data

```json
{
  "end_line": 1140,
  "entity_kind": "method",
  "parent": "Func",
  "start_line": 1136,
  "symbol": "Func.copy"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1136,"selector":"L1136-L1140","symbol":"Func.copy"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Func.copy](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1140,
    "entity_kind": "method",
    "parent": "Func",
    "start_line": 1136,
    "symbol": "Func.copy"
  },
  "id": "7528a879-9cf9-499e-a23c-184be84c6637",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5816040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1136,
        "selector": "L1136-L1140",
        "symbol": "Func.copy"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "aba418dd-0013-4ac0-ad85-461557db6ed6",
  "subject_name": "django/db/models/expressions::Func.copy",
  "tags": [
    "entity:method"
  ],
  "text": "def copy(self)"
}
```
