# Fact e6e0dca4

Store id: 946ace9c-b877-4b7e-8a34-689b939ece90

## Text

```text
class OuterRef(F)
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
- posted_at: `2026-11-09T23:31:55.8451820+00:00`

## Data

```json
{
  "end_line": 993,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 983,
  "symbol": "OuterRef"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":983,"selector":"L983-L993","symbol":"OuterRef"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OuterRef](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 993,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 983,
    "symbol": "OuterRef"
  },
  "id": "946ace9c-b877-4b7e-8a34-689b939ece90",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8451820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 983,
        "selector": "L983-L993",
        "symbol": "OuterRef"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "073b44c2-2a51-4fc4-9865-b3e4df8d2bda",
  "subject_name": "django/db/models/expressions::OuterRef",
  "tags": [
    "entity:class"
  ],
  "text": "class OuterRef(F)"
}
```
