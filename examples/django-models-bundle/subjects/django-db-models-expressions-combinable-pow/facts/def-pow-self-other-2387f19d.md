# Fact 2387f19d

Store id: 0a15fe69-6cee-4228-a598-0f33c02c0413

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
- posted_at: `2026-11-09T22:39:41.4764480+00:00`

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
  "id": "0a15fe69-6cee-4228-a598-0f33c02c0413",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4764480+00:00"
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
  "subject_id": "2fc18452-a1fe-44d6-b4e9-16c536c9427d",
  "subject_name": "django/db/models/expressions::Combinable.__pow__",
  "tags": [
    "entity:method"
  ],
  "text": "def __pow__(self, other)"
}
```
