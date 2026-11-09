# Fact d006a5b1

Store id: d6d231a9-e408-49e9-a841-01f8fab7ea9b

## Text

```text
def __and__(self, other)
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
- posted_at: `2026-11-09T23:44:49.2459490+00:00`

## Data

```json
{
  "end_line": 102,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 97,
  "symbol": "Combinable.__and__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":97,"selector":"L97-L102","symbol":"Combinable.__and__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__and__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 102,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 97,
    "symbol": "Combinable.__and__"
  },
  "id": "d6d231a9-e408-49e9-a841-01f8fab7ea9b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2459490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 97,
        "selector": "L97-L102",
        "symbol": "Combinable.__and__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ffeec1c2-9edb-4971-b903-12102272e6b8",
  "subject_name": "django/db/models/expressions::Combinable.__and__",
  "tags": [
    "entity:method"
  ],
  "text": "def __and__(self, other)"
}
```
