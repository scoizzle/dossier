# Fact 77fef6d6

Store id: e11be439-b040-4f30-8f2d-7c80dbcf811b

## Text

```text
def __neg__(self)
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
- posted_at: `2026-11-09T22:39:41.4719460+00:00`

## Data

```json
{
  "end_line": 77,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 76,
  "symbol": "Combinable.__neg__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":76,"selector":"L76-L77","symbol":"Combinable.__neg__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__neg__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 77,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 76,
    "symbol": "Combinable.__neg__"
  },
  "id": "e11be439-b040-4f30-8f2d-7c80dbcf811b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4719460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 76,
        "selector": "L76-L77",
        "symbol": "Combinable.__neg__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "a28832dc-7151-4450-81ad-3be6b11cd73a",
  "subject_name": "django/db/models/expressions::Combinable.__neg__",
  "tags": [
    "entity:method"
  ],
  "text": "def __neg__(self)"
}
```
