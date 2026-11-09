# Fact e6e0dca4

Store id: e9cee4bc-8af3-47e5-9bda-e421dc03656c

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
- posted_at: `2026-11-09T22:39:41.5709740+00:00`

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
  "id": "e9cee4bc-8af3-47e5-9bda-e421dc03656c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5709740+00:00"
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
  "subject_id": "65811365-4901-4df0-918d-c965d9b58fec",
  "subject_name": "django/db/models/expressions::OuterRef",
  "tags": [
    "entity:class"
  ],
  "text": "class OuterRef(F)"
}
```
