# Fact 2387f19d

Store id: ff0c043c-b7c1-4b53-92f2-660c8f07ae10

## Text

```text
def __pow__(self, other)
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
- posted_at: `2026-11-09T23:31:55.7305180+00:00`

## Data

```json
{
  "end_line": 95,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 94,
  "symbol": "Combinable.__pow__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":94,"selector":"L94-L95","symbol":"Combinable.__pow__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__pow__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 95,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 94,
    "symbol": "Combinable.__pow__"
  },
  "id": "ff0c043c-b7c1-4b53-92f2-660c8f07ae10",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7305180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 94,
        "selector": "L94-L95",
        "symbol": "Combinable.__pow__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "f2d3fe4c-1a65-43b2-bba0-ef6acb029046",
  "subject_name": "django/db/models/expressions::Combinable.__pow__",
  "tags": [
    "entity:method"
  ],
  "text": "def __pow__(self, other)"
}
```
