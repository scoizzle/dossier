# Fact 38b8e987

Store id: 40dd8553-c8cd-4986-862c-1e1a44dc6829

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
- posted_at: `2026-11-09T23:31:55.9774360+00:00`

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
  "id": "40dd8553-c8cd-4986-862c-1e1a44dc6829",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9774360+00:00"
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
  "subject_id": "ba8eeec6-641b-42e6-99b3-24ec37ed299d",
  "subject_name": "django/db/models/expressions::Exists",
  "tags": [
    "entity:class"
  ],
  "text": "class Exists(Subquery)"
}
```
