# Fact c0734fb9

Store id: 195ff109-83d3-480d-9253-c54a5399b6b3

## Text

```text
def _combine(self, other, connector, reversed)
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
- posted_at: `2026-11-09T23:44:49.2399350+00:00`

## Data

```json
{
  "end_line": 70,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 63,
  "symbol": "Combinable._combine"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":63,"selector":"L63-L70","symbol":"Combinable._combine"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable._combine](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 70,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 63,
    "symbol": "Combinable._combine"
  },
  "id": "195ff109-83d3-480d-9253-c54a5399b6b3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2399350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 63,
        "selector": "L63-L70",
        "symbol": "Combinable._combine"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "3136158a-3e2c-4d5c-91c0-01e5611470c6",
  "subject_name": "django/db/models/expressions::Combinable._combine",
  "tags": [
    "entity:method"
  ],
  "text": "def _combine(self, other, connector, reversed)"
}
```
