# Fact 38b8e987

Store id: bedbdfcf-6de8-4d94-a923-86154762ba42

## Text

```text
class Exists(Subquery)
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
- posted_at: `2026-11-09T22:39:41.7336160+00:00`

## Data

```json
{
  "end_line": 1911,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1887,
  "symbol": "Exists"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1887,"selector":"L1887-L1911","symbol":"Exists"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Exists](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1911,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1887,
    "symbol": "Exists"
  },
  "id": "bedbdfcf-6de8-4d94-a923-86154762ba42",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7336160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1887,
        "selector": "L1887-L1911",
        "symbol": "Exists"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "e4522fae-1416-4b94-bb62-a909be0e7d91",
  "subject_name": "django/db/models/expressions::Exists",
  "tags": [
    "entity:class"
  ],
  "text": "class Exists(Subquery)"
}
```
