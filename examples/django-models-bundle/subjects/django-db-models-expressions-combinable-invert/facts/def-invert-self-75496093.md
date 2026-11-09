# Fact 75496093

Store id: 9d55151b-6ae4-4f33-ac6d-e3f464e7d388

## Text

```text
def __invert__(self)
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
- posted_at: `2026-11-09T22:39:41.4954450+00:00`

## Data

```json
{
  "end_line": 167,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 166,
  "symbol": "Combinable.__invert__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":166,"selector":"L166-L167","symbol":"Combinable.__invert__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__invert__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 167,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 166,
    "symbol": "Combinable.__invert__"
  },
  "id": "9d55151b-6ae4-4f33-ac6d-e3f464e7d388",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4954450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 166,
        "selector": "L166-L167",
        "symbol": "Combinable.__invert__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "bc8557cd-a68f-40cd-afcc-82b177f95ffb",
  "subject_name": "django/db/models/expressions::Combinable.__invert__",
  "tags": [
    "entity:method"
  ],
  "text": "def __invert__(self)"
}
```
