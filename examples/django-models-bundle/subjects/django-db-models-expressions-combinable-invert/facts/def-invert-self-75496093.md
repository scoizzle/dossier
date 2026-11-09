# Fact 75496093

Store id: fbe7e9b7-dc2f-4927-b356-acf186c385ba

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
- posted_at: `2026-11-09T23:31:55.7544990+00:00`

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
  "id": "fbe7e9b7-dc2f-4927-b356-acf186c385ba",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7544990+00:00"
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
  "subject_id": "9a67993a-4464-41f1-89aa-57f0e9ffa3dd",
  "subject_name": "django/db/models/expressions::Combinable.__invert__",
  "tags": [
    "entity:method"
  ],
  "text": "def __invert__(self)"
}
```
