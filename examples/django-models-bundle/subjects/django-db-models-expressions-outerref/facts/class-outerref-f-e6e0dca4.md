# Fact e6e0dca4

Store id: 54ddd1e0-1efe-4e18-ac3a-f5c99c32660d

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
- posted_at: `2026-11-09T23:44:49.4932140+00:00`

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
  "id": "54ddd1e0-1efe-4e18-ac3a-f5c99c32660d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4932140+00:00"
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
  "subject_id": "2450916f-7dc7-4aaa-ab8e-ba16211c1fb4",
  "subject_name": "django/db/models/expressions::OuterRef",
  "tags": [
    "entity:class"
  ],
  "text": "class OuterRef(F)"
}
```
